using Interfaces.Phone.Components.Screen;

namespace Interfaces.Phone
{
    public class SimCorpMobile : Mobile
    {
        public override ScreenBase Screen => OledScreen;

        public readonly OledScreen OledScreen = new OledScreen();
    }
}
