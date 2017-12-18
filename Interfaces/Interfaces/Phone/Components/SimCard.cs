using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components
{
    public class SIMCard
    {
        public SIMSizeFormat SizeFormat { get; set; }

        public override string ToString()
        {
            return "SIM Card";
        }
    }
}
