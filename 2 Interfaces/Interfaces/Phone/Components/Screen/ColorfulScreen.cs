using System;
using Interfaces.Phone.Graphics;
using Interfaces.Phone.Misc;
using Interfaces.Output;

namespace Interfaces.Phone.Components.Screen
{
    public class ColorfulScreen : ScreenBase
    {
        public ColorfulScreen(IOutput output, CoordsFlat resolution, SizeFlat size, int colorsCount = 2, bool hasHighlight = false) 
            : base(output, resolution, size, colorsCount, hasHighlight)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(ColorfulScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            Console.WriteLine($"I am {nameof(ColorfulScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Colorful Screen";
        }
    }
}
