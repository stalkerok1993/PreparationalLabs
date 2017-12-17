﻿using Interfaces.Output;
using Interfaces.Phone.Graphics;

namespace Interfaces.Phone.Components.Screen
{
    class RetinaScreen : ColorfulScreen
    {
        public RetinaScreen(IOutput output) : base(output)
        {
        }

        public override void Show(IScreenImage screenImage)
        {
            output.WriteLine($"I am {nameof(RetinaScreen)}");
        }

        public override void Show(IScreenImage screenImage, float brightness)
        {
            output.WriteLine($"I am {nameof(RetinaScreen)} and showing {screenImage} with brightness {brightness: N2}.");
        }

        public override string ToString()
        {
            return "Retina Screen";
        }
    }
}