using System;
using UnderstandingOop.Phone.Graphics;

namespace UnderstandingOop.Phone.Components.Screen
{
    class OledScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(OledScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            Console.WriteLine($"I am {nameof(OledScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "OLED Screen";
        }
    }
}
