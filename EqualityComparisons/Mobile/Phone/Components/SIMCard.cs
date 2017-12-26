using Mobile.Phone.Misc;

namespace Mobile.Phone.Components
{
    public class SIMCard
    {
        public SIMSizeFormat SizeFormat { get; set; }

        public SIMCard(SIMSizeFormat sizeFormat = SIMSizeFormat.SIM)
        {
            SizeFormat = sizeFormat;
        }

        public override string ToString()
        {
            return "SIM Card";
        }
    }
}
