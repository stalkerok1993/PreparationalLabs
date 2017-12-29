namespace Mobile.Phone.Misc
{
    public class Size : SizeFlat
    {
        public float DepthMm { get; set; }

        public Size()
        {
        }

        public Size(float widthMm, float heightMm, float depthMm) : base(widthMm, heightMm)
        {
            DepthMm = depthMm;
        }
    }
}
