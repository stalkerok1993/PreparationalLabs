using Interfaces.Phone;
using Interfaces.Output;

namespace Interfaces.Phone.Components.Charger
{
    public abstract class ICharger
    {
        public abstract void Charge(Mobile mobile);
    }
}
