﻿using Mobile.Phone.Components.Screen;
using Mobile.Phone.Components.Sensor;
using Mobile.Output;
using Mobile.Phone.Misc;

namespace Mobile.Phone
{
    public class ModernMobile : MobileBase
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
