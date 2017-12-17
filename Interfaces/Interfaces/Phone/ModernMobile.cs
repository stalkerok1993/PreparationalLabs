using Interfaces.Phone.Components.Screen;
using Interfaces.Phone.Components.Sensor;
using UnderstandingOop.Output;

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
            Screen = new RetinaScreen(output);
        }
    }
}
