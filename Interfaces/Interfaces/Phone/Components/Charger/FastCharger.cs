using Interfaces.Output;

namespace Interfaces.Phone.Components.Charger
{
    public class FastCharger : ICharger
    {
        public Mobile Mobile { get; protected set; }

        private IOutput output;

        public FastCharger(IOutput output)
        {
            this.output = output;
        }

        public void Charge(Mobile mobile)
        {
            Mobile = mobile;
            output.WriteLine($"{typeof(Mobile).Name} is charging with {nameof(FastCharger)}.");
        }
    }
}
