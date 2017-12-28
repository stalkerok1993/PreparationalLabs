using System;
using System.Text;
using System.Threading;
using Mobile.Phone.Components;
using Mobile.Phone.Components.Screen;
using Mobile.Phone.Graphics;
using Mobile.Phone.Misc;
using Mobile.Phone.Components.Playback;
using Mobile.Phone.Components.Charger;
using Mobile.Output;
using Mobile.Phone.NetworkServices.SMS;
using Mobile.Threads;

namespace Mobile.Phone {
    public abstract class MobileBase {
        internal SMSProvider SMSProvider = new SMSProvider();
        protected IOutput output;

        public Battery Battery { get; set; }
        public Camera Cameras { get; set; }
        public Dynamic Dynamics { get; set; }
        public Keyboard Keyboards { get; set; }
        public Microphone Microphones { get; set; }
        public SIMCard SimCards { get; set; }
        public Size Size { get; set; }

        public abstract ScreenBase Screen { get; }

        public PlaybackBase PlaybackComponent { get; set; }

        public ChargerBase Charger { get; private set; }

        public readonly SMSMessenger SMSMessenger = new SMSMessenger();

        private ManageableAction managebleChargeAction;

        protected MobileBase(IOutput output) {
            this.output = output;

            SMSProvider.SMSReciever += SMSMessenger.AddMessage;

            Battery = new Battery();
            var discharge = new Thread(() => {
                while (true) {
                    Thread.Sleep(2500);
                    Battery.ChangeCharge(-Battery.CapacityWh / 100);
                }
            });
            discharge.IsBackground = true;
            discharge.Start();

            managebleChargeAction = new ManageableAction(new Action(() => {
                Thread.Sleep(1000);
                Battery.ChangeCharge(Charger == null ? 0f : (float)Math.Pow(Charger.ChargeCurrentMa, 2) * 0.00005f);
            }));
            managebleChargeAction.Suspend();
            var charge = new Thread(managebleChargeAction.ThreadStart);
            charge.IsBackground = true;
            charge.Start();
        }

        public void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public string Description {
            get {
                var descriptionBuilder = new StringBuilder();
                descriptionBuilder.AppendLine($"Screen: {Screen}");

                return descriptionBuilder.ToString();
            }
        }

        public void Play(object data) {
            PlaybackComponent?.Play(data);
        }

        public void Charge(ChargerBase charger) {
            Charger = charger;
            
            if (Charger != null) {
                if (Charger.Mobile == null || Charger.Mobile != this) {
                    Charger.Charge(this);
                }
                managebleChargeAction.Continue();
            }
        }

        public ChargerBase RemoveCharger() {
            managebleChargeAction.Suspend();

            ChargerBase temp = Charger;
            Charger = null;
            if (temp.Mobile != null) {
                temp.RemovePhone();
            }

            return temp;
        }

        public void ReceiveSMS(string text, string number) {
            SMSProvider.RaiseSMSRecieverEvent(new Message(text, number));
        }

        public void SendSMS(string text, string number) {
            if (number != null) {
                var message = new Message(text, number, false);
                SMSMessenger.AddMessage(message);
            }
        }
    }
}
