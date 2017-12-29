using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components
{
    class Battery
    {
        public static readonly Size DEFAULT_SIZE = new Size(100f, 50f, 5f);

        public float CapacityWh { get; set; }
        public Size Size { get; set; }

        public Battery() : this(new Size(100f, 50f, 5f))
        {
        }

        public Battery(Size size, float capacityWh = 5000)
        {
            Size = size;
            CapacityWh = capacityWh;
        }

        public override string ToString()
        {
            return "Battery";
        }
    }
}
