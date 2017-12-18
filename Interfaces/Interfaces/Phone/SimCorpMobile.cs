using Interfaces.Phone.Components.Screen;
using Interfaces.Output;

namespace Interfaces.Phone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OLEDScreen OledScreen;

        public SimCorpMobile(IOutput output) : base(output)
        {
             OledScreen = new OLEDScreen(output);
        }
    }
}
