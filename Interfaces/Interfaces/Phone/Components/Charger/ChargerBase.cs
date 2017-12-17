using Interfaces.Phone;
using Interfaces.Output;

namespace Interfaces.Phone.Components.Charger
{
    public abstract class ChargerBase
    {
        public Mobile Mobile { get; protected set; }

        protected IOutput output;

        public ChargerBase(IOutput output)
        {
            this.output = output;
        }

        public abstract void Charge(Mobile mobile);
    }
}
