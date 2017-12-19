using UnderstandingOop.Phone.Graphics;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components.Screen
{
    public abstract class ScreenBase
    {
        public CoordsFlat Resolution { get; set; }
        public SizeFlat SizeMm { get; set; }
        public int ColorsCount { get; set; }
        public bool HasHighlight { get; set; }

        public ScreenBase()
        {
            Resolution = new CoordsFlat(16, 16);
            SizeMm = new SizeFlat(10, 10);
        }

        public ScreenBase(CoordsFlat resolution, SizeFlat sizeMm, int colorsCount = 2, bool hasHighlight = false)
        {
            Resolution = resolution;
            SizeMm = sizeMm;
            ColorsCount = colorsCount;
            HasHighlight = hasHighlight;
        }

        public abstract void Show(IScreenImage screenImage);

        /// <param name="brightness">0.0 - minimal brightness, 1.0 - maximum brightness.</param>
        public abstract void Show(IScreenImage screenImage, float brightness);
    }
}
