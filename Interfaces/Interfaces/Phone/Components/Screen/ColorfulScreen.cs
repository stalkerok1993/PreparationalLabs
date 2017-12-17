using System;
using Interfaces.Phone.Graphics;
using UnderstandingOop.Output;

namespace Interfaces.Phone.Components.Screen
{
    public class ColorfulScreen : ScreenBase
    {
        public ColorfulScreen(IOutput output) : base(output)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            output.WriteLine($"I am {nameof(ColorfulScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            output.WriteLine($"I am {nameof(ColorfulScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Colorful Screen";
        }
    }
}
