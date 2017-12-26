﻿using Mobile.Output;

namespace Mobile.Phone.Components.Charger
{
    public class FastCharger : ChargerBase
    {
        public FastCharger(IOutput output) : base(output)
        {
        }

        public override void Charge(MobileBase mobile)
        {
            Mobile = mobile;
            output.WriteLine($"{typeof(MobileBase).Name} is charging with {nameof(FastCharger)}.");
        }
    }
}
