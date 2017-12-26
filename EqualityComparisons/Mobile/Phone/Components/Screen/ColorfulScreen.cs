using System;
using Mobile.Phone.Graphics;
using Mobile.Phone.Misc;
using Mobile.Output;

namespace Mobile.Phone.Components.Screen
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
