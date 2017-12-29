namespace Mobile.Phone.Misc
{
    public class SizeFlat
    {
        public float WidthMm { get; set; }
        public float HeightMm { get; set; }

        public SizeFlat()
        {
        }

        public SizeFlat(float widthMm, float heightMm) : this() {
            WidthMm = widthMm;
            HeightMm = heightMm;
        }
    }
}
