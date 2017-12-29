using Interfaces.Phone.Components.Screen;
using Interfaces.Output;
using Interfaces.Phone.Misc;

namespace Interfaces.Phone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OLEDScreen OledScreen;

        public SimCorpMobile(IOutput output) : base(output)
        {
             OledScreen = new OLEDScreen(output, new CoordsFlat(720, 1280), new SizeFlat(50f, 100f));
        }
    }
}
