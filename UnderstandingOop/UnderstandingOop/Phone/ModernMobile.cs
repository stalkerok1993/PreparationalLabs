using UnderstandingOop.Phone.Components.Screen;
using UnderstandingOop.Phone.Components.Sensor;

namespace UnderstandingOop.Phone
{
    class ModernMobile : Mobile
    {
        public override ScreenBase Screen { get; } = new RetinaScreen();

        public TouchScreen TouchScreen { get; } = new MultiTouchScreen()
        {
            Technology = Misc.TouchTechnology.Capacitive,
            TouchCountMax = 10
        };
    }
}
