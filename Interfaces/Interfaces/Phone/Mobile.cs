using System.Text;
using Interfaces.Phone.Components;
using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Graphics;
using Interfaces.Phone.Misc;
using UnderstandingOop.Phone.Components.Playback;
using UnderstandingOop.Phone.Components.Charger;
using UnderstandingOop.Output;

namespace Interfaces.Phone
{
    public abstract class Mobile
    {
        public Battery Battery { get; set; }
        public Camera Cameras { get; set; }
        public Dynamic Dynamics { get; set; }
        public Keyboard Keyboards { get; set; }
        public Microphone Microphones { get; set; }
        public SimCard SimCards { get; set; }
        public Size Size { get; set; }

        public abstract ScreenBase Screen { get; }

        public PlaybackBase PlaybackComponent { get; set; }

        public ChargerBase Charger { get; private set; }

        protected IOutput output;

        public Mobile(IOutput output)
        {
            this.output = output;
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
    }
}
