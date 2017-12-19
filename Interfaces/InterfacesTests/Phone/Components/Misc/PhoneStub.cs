using Interfaces.Output;
using Interfaces.Phone;
using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Misc;

namespace InterfacesTests.Phone.Components.Misc
{
    public class PhoneStub : Mobile
    {
        public override ScreenBase Screen { get; }

        public PhoneStub(IOutput output) : base(output)
        {
            Screen = new OLEDScreen(output, new CoordsFlat(720, 1280), new SizeFlat(50f, 100f));
        }
    }
}
