using System;
using Mobile.Phone.Graphics;
using Mobile.Phone.Misc;
using Mobile.Output;

namespace Mobile.Phone.Components.Screen
{
    public class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(IOutput output, CoordsFlat resolution, SizeFlat size, bool hasHighlight = false) 
            : base(output, resolution, size, 2, hasHighlight)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(MonochromeScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            Console.WriteLine($"I am {nameof(MonochromeScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
