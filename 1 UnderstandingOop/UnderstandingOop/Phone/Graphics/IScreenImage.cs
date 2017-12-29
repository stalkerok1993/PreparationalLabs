﻿using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Graphics
{
    public class IScreenImage
    {
        CoordsFlat Size { get; set; }
        CoordsFlat DrawPoint { get; set; }

        public IScreenImage()
        {
        }

        public IScreenImage(CoordsFlat size, CoordsFlat drawPoint)
        {
            Size = size;
            DrawPoint = drawPoint;
        }
    }
}
