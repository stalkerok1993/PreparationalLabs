using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components
{
    class Battery
    {
        public float CapacityWh { get; set; }
        public Size Size { get; set; }

        public override string ToString()
        {
            return "Battery";
        }
    }
}
