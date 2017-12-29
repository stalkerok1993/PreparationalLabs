using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Graphics
{
    public class Image : IScreenImage
    {
        public CoordsFlat Size { get; set; } = new CoordsFlat(256, 256);
        public CoordsFlat DrawPoint { get; set; } = new CoordsFlat(0, 0);
    }
}
