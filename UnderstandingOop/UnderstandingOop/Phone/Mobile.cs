using System.Text;
using UnderstandingOop.Phone.Components;
using UnderstandingOop.Phone.Components.Screen;
using UnderstandingOop.Phone.Graphics;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone
{
    abstract class Mobile
    {
        public Battery Battery { get; set; }
        public Camera Cameras { get; set; }
        public Dynamic Dynamics { get; set; }
        public Keyboard Keyboards { get; set; }
        public Microphone Microphones { get; set; }
        public SIMCard SimCards { get; set; }
        public Size Size { get; set; }

        public abstract ScreenBase Screen { get; }

        public void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen: {Screen}");

            return descriptionBuilder.ToString();
        }
    }
}
