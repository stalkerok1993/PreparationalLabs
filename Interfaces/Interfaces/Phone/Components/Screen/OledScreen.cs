using Interfaces.Output;
using Interfaces.Phone.Graphics;

namespace Interfaces.Phone.Components.Screen
{
    public class OledScreen : ColorfulScreen
    {
        public OledScreen(IOutput output) : base(output)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            output.WriteLine($"I am {nameof(OledScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            output.WriteLine($"I am {nameof(OledScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}
