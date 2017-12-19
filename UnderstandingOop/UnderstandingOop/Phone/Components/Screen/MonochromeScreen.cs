using System;
using UnderstandingOop.Phone.Graphics;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components.Screen
{
    public class MonochromeScreen : ScreenBase
    {
        public MonochromeScreen(CoordsFlat resolution, SizeFlat size, bool hasHighlight = false) : base(resolution, size, 2, hasHighlight)
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
