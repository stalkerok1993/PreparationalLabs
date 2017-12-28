using System;
using Mobile.Phone.Graphics;
using Mobile.Phone.Misc;
using Mobile.Output;

namespace Mobile.Phone.Components.Screen
{
    public class OLEDScreen : ColorfulScreen
    {
        public OLEDScreen(IOutput output, CoordsFlat resolution, SizeFlat size, int colorsCount = 65536, bool hasHighlight = true) 
            : base(output, resolution, size, colorsCount, hasHighlight)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(OLEDScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            Console.WriteLine($"I am {nameof(OLEDScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}
