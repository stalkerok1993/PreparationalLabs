using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components
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
