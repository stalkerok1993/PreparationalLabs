using UnderstandingOop.Phone.Components.Screen;

namespace UnderstandingOop.Phone
{
    class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OledScreen OledScreen = new OledScreen();
    }
}
