using Interfaces.Output;

namespace Interfaces.Phone.Components.Charger
{
    public class USBCharger : ChargerBase
    {
        public USBCharger(IOutput output) : base(output)
        {
        }

        public override void Charge(Mobile mobile)
        {
            Mobile = mobile;
            output.WriteLine($"{typeof(Mobile).Name} is charging with {nameof(USBCharger)}.");
        }
    }
}
