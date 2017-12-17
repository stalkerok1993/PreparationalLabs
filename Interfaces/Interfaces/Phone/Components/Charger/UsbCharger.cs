﻿using Interfaces.Phone;
using UnderstandingOop.Output;

namespace UnderstandingOop.Phone.Components.Charger
{
    class UsbCharger : ChargerBase
    {
        public UsbCharger(IOutput output) : base(output)
        {
        }

        public override void Charge(Mobile mobile)
        {
            Mobile = mobile;
            output.WriteLine($"{typeof(Mobile).Name} is charging with {nameof(UsbCharger)}.");
        }
    }
}
