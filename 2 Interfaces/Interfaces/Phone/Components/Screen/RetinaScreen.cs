using System;
using Interfaces.Phone.Graphics;
using Interfaces.Phone.Misc;
using Interfaces.Output;

namespace Interfaces.Phone.Components.Screen
{
    class RetinaScreen : ColorfulScreen
    {
        public RetinaScreen(IOutput output, CoordsFlat resolution, SizeFlat size, int colorsCount = 65536, bool hasHighlight = true) 
            : base(output, resolution, size, colorsCount, hasHighlight)
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
