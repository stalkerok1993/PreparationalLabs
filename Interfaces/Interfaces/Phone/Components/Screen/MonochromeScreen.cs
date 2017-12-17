using Interfaces.Output;
using Interfaces.Phone.Graphics;

namespace Interfaces.Phone.Components.Screen
{
    public class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(IOutput output) : base(output)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            output.WriteLine($"I am {nameof(MonochromeScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            output.WriteLine($"I am {nameof(MonochromeScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
