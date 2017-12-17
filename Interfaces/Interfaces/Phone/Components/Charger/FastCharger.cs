using Interfaces.Phone;
using System;

namespace UnderstandingOop.Phone.Components.Charger
{
    class FastCharger : ICharger
    {
        public Mobile Mobile { get; private set; }

        public void Charge(Mobile mobile)
        {
            Mobile = mobile;
            Console.WriteLine($"{typeof(Mobile).Name} is charging with {nameof(FastCharger)}.");
        }
    }
}
