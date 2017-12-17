using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components
{
    public class Battery
    {
        public float CapacityWh { get; set; }
        public Size Size { get; set; }

        public override string ToString()
        {
            return "Battery";
        }
    }
}
