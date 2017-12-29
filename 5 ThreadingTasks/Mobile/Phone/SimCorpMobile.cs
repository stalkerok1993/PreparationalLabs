using Mobile.Phone.Components.Screen;
using Mobile.Output;
using Mobile.Phone.Misc;
using Mobile.Threading;

namespace Mobile.Phone
{
    public class SimCorpMobile : MobileBase
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OLEDScreen OledScreen;

        public SimCorpMobile(IOutput output, BackgroundWorkerFactoryMethod backgroundWorkerFactory = null) : base(output, backgroundWorkerFactory)
        {
             OledScreen = new OLEDScreen(output, new CoordsFlat(720, 1280), new SizeFlat(50f, 100f));
        }
    }
}
