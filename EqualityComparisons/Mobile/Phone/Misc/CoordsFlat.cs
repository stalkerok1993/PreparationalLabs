﻿namespace Mobile.Phone.Misc
{
    public class CoordsFlat
    {
        public int HorizontalPx { get; set; }
        public int VerticalPx { get; set; }

        public CoordsFlat()
        {
        }

        public CoordsFlat(int horizontalPx, int verticalPx)
        {
            HorizontalPx = horizontalPx;
            VerticalPx = verticalPx;
        }
    }
}
