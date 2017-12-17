using Interfaces.Phone.Components.Screen;
using UnderstandingOop.Output;

namespace Interfaces.Phone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OledScreen OledScreen;

        public SimCorpMobile(IOutput output) : base(output)
        {
             OledScreen = new OledScreen(output);
        }
    }
}
