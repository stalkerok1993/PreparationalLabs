using UnderstandingOop.Phone.Components.Screen;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone
{
    class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OledScreen OledScreen = new OledScreen(new CoordsFlat(720, 1280), new SizeFlat(50f, 100f));
    }
}
