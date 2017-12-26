using Mobile.Phone;
using Mobile.Output;

namespace Mobile.Phone.Components.Charger
{
    public abstract class ChargerBase
    {
        public MobileBase Mobile { get; protected set; }

        protected IOutput output;

        public ChargerBase(IOutput output)
        {
            this.output = output;
        }

        public abstract void Charge(MobileBase mobile);
    }
}
