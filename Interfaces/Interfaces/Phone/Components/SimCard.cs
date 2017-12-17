using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components
{
    public class SimCard
    {
        public SimSizeFormat SizeFormat { get; set; }

        public override string ToString()
        {
            return "SIM Card";
        }
    }
}
