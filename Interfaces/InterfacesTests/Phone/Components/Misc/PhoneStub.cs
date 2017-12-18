using Interfaces.Output;
using Interfaces.Phone;
using Interfaces.Phone.Components.Screen;

namespace InterfacesTests.Phone.Components.Misc
{
    public class PhoneStub : Mobile
    {
        public override ScreenBase Screen { get; }

        public PhoneStub(IOutput output) : base(output)
        {
            Screen = new OLEDScreen(output);
        }
    }
}
