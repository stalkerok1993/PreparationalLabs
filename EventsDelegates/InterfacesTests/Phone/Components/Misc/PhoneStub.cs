using Mobile.Output;
using Mobile.Phone;
using Mobile.Phone.Components.Screen;
using Mobile.Phone.Misc;

namespace MobileTest.Phone.Components.Misc
{
    public class PhoneStub : MobileBase
    {
        public override ScreenBase Screen { get; }

        public PhoneStub(IOutput output) : base(output)
        {
            Screen = new OLEDScreen(output, new CoordsFlat(720, 1280), new SizeFlat(50f, 100f));
        }
    }
}
