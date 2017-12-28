using Mobile.Output;

namespace Mobile.Phone.Components.Charger {
    public class OrdinaryCharger : ChargerBase {
        public OrdinaryCharger(IOutput output) : base(output) {
            ChargeCurrentMa = 1000f;
        }

        public override void Charge(MobileBase mobile) {
            base.Charge(mobile);
            output.WriteLine($"{typeof(MobileBase).Name} is charging with {nameof(OrdinaryCharger)}.");
        }
    }
}
