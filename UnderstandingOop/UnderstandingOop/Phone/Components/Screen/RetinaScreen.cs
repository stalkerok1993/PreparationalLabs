using System;
using UnderstandingOop.Phone.Graphics;

namespace UnderstandingOop.Phone.Components.Screen
{
    class RetinaScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"I am {nameof(RetinaScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            Console.WriteLine($"I am {nameof(RetinaScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}
