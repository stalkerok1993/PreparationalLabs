using System.Text;
using Mobile.Phone.Components;
using Mobile.Phone.Components.Screen;
using Mobile.Phone.Graphics;
using Mobile.Phone.Misc;
using Mobile.Phone.Components.Playback;
using Mobile.Phone.Components.Charger;
using Mobile.Output;
using Mobile.Phone.NetworkServices.SMS;

namespace Mobile.Phone
{
    public abstract class MobileBase
    {
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

        protected MobileBase(IOutput output)
        {
            this.output = output;

            SMSProvider.SMSReciever += SMSMessenger.AddMessage;
        }

        public void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        public string Description
        {
            get
            {
                var descriptionBuilder = new StringBuilder();
                descriptionBuilder.AppendLine($"Screen: {Screen}");

                return descriptionBuilder.ToString();
            }
        }

        public void Play(object data)
        {
            PlaybackComponent?.Play(data);
        }

        public void Charge(ChargerBase charger)
        {
            Charger = charger;
            Charger?.Charge(this);
        }

        public void ReceiveSMS(string text, string number)
        {
            SMSProvider.RaiseSMSRecieverEvent(new Message(text, number));
        }

        public void SendSMS(string text, string number) {
            if (number != null) {
                SMSMessenger.SendMessage(text, number);
            }
        }
    }
}
