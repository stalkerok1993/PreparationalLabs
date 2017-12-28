using System;
using System.Threading;
using Mobile.Phone.Misc;

namespace Mobile.Phone.Components
{
    public class Battery {
        public static readonly Size DEFAULT_SIZE = new Size(100f, 50f, 5f);

        public float CapacityWh { get; set; }
        public Size Size { get; set; }

        protected volatile float chargeWh;

        public float ChargeWh {
            get { return chargeWh; }
            private set { chargeWh = value; }
        }

        public Battery() : this(new Size(100f, 50f, 5f)) {}

        public Battery(Size size, float capacityWh = 5000, float chargeWh = 4000) {
            Size = size;
            CapacityWh = capacityWh;
            ChargeWh = chargeWh;
        }

        public void ChangeCharge(float changeWh) {
            lock (this) {
                chargeWh = Math.Max(0, Math.Min(CapacityWh, chargeWh + changeWh));
            }
        }

    public override string ToString()
        {
            return "Battery";
        }
    }
}
