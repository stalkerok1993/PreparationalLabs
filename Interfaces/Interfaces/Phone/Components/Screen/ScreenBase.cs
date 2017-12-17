using Interfaces.Phone.Graphics;
using Interfaces.Phone.Misc;
using Interfaces.Output;

namespace Interfaces.Phone.Components.Screen
{
    public abstract class ScreenBase
    {
        public CoordsFlat CoordsFlatPx { get; set; }
        public SizeFlat Size { get; set; }
        public int ColoursCount { get; set; }
        public bool HasHighlight { get; set; }

        protected IOutput output;

        public ScreenBase(IOutput output)
        {
            this.output = output;
        }

        public abstract void Show(IScreenImage screenImage);

        /// <param name="brightness">0.0 - minimal brightness, 1.0 - maximum brightness.</param>
        public abstract void Show(IScreenImage screenImage, float brightness);
    }
}
