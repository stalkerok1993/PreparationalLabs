using Mobile.Phone;
using Mobile.Output;

namespace Mobile.Phone.Components.Charger
{
    public abstract class ChargerBase {
        public float ChargeCurrentMa { get; protected set; }
        public MobileBase Mobile { get; protected set; }

        protected IOutput output;

        public ChargerBase(IOutput output)
        {
            this.output = output;
        }

        public abstract void Charge(MobileBase mobile);

        public void RemovePhone() {
            if (Mobile.Charger != null) {
                Mobile.RemoveCharger();
            }

            Mobile = null;
        }
    }
}
