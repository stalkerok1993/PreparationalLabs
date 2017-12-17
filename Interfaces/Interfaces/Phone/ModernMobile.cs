using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Components.Sensor;

namespace Interfaces.Phone
{
    public class ModernMobile : Mobile
    {
        public override ScreenBase Screen { get; } = new RetinaScreen();

        public TouchScreen TouchScreen { get; } = new MultiTouchScreen()
        {
            Technology = Misc.TouchTechnology.Capacitive,
            TouchCountMax = 10
        };
    }
}
