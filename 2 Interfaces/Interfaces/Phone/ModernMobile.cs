using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Components.Sensor;
using Interfaces.Output;
using Interfaces.Phone.Misc;

namespace Interfaces.Phone
{
    public class ModernMobile : Mobile
    {
        public override ScreenBase Screen { get; }

        public TouchScreen TouchScreen { get; } = new MultiTouchScreen()
        {
            Technology = Misc.TouchTechnology.Capacitive,
            TouchCountMax = 10
        };

        public ModernMobile(IOutput output) : base(output)
        {
            Screen = new RetinaScreen(output, new CoordsFlat(1080, 1920), new SizeFlat(50f, 100f));
        }
    }
}
