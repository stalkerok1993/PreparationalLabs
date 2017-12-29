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

        public virtual void Charge(MobileBase mobile) {
            Mobile = mobile;
            if (mobile.Charger == null || mobile.Charger != this) {
                mobile.Charge(this);
            }
        }

        public void RemovePhone() {
            MobileBase temp = Mobile;
            Mobile = null;
            if (temp.Charger != null) {
                temp.RemoveCharger();
            }
        }
    }
}
