using System;
using UnderstandingOop.Phone.Graphics;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components.Screen
{
    class ColorfulScreen : ScreenBase
    {
        public ColorfulScreen(CoordsFlat resolution, SizeFlat size, int colorsCount = 2, bool hasHighlight = false) : base(resolution, size, colorsCount, hasHighlight)
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
