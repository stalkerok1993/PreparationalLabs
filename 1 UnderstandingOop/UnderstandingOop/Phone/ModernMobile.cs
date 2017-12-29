using UnderstandingOop.Phone.Components.Screen;
using UnderstandingOop.Phone.Components.Sensor;
using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone
{
    class ModernMobile : Mobile
    {
        public override ScreenBase Screen { get; } = new RetinaScreen(new CoordsFlat(1080, 1920), new SizeFlat(50f, 100f));

        public TouchScreen TouchScreen { get; } = new MultiTouchScreen()
        {
            Technology = Misc.TouchTechnology.Capacitive,
            TouchCountMax = 10
        };
    }
}
