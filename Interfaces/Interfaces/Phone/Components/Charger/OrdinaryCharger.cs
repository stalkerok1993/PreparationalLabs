using Interfaces.Output;

namespace Interfaces.Phone.Components.Charger
{
    public class OrdinaryCharger : ICharger
    {
        public Mobile Mobile { get; protected set; }

        protected IOutput output;

        public OrdinaryCharger(IOutput output)
        {
            this.output = output;
        }

        public override void Charge(Mobile mobile)
        {
            Mobile = mobile;
            output.WriteLine($"{typeof(Mobile).Name} is charging with {nameof(OrdinaryCharger)}.");
        }
    }
}
