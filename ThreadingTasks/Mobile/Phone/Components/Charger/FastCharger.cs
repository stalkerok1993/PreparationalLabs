﻿using Mobile.Output;

namespace Mobile.Phone.Components.Charger {
    public class FastCharger : ChargerBase {
        public FastCharger(IOutput output) : base(output) {
            ChargeCurrentMa = 3000f;
        }

        public override void Charge(MobileBase mobile) {
            Mobile = mobile;
            if (Mobile.Charger == null) {
                Mobile.Charge(this);
            }
            output.WriteLine($"{typeof(MobileBase).Name} is charging with {nameof(FastCharger)}.");
        }
    }
}
