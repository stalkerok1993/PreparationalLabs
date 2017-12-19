using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components.Sensor
{
    public class MultiTouchScreen : TouchScreen
    {
        public int TouchCountMax { get; set; }

        public MultiTouchScreen(int touchCountMax = 1, TouchTechnology touchTechnology = TouchTechnology.Capacitive) : base(touchTechnology)
        {
            TouchCountMax = touchCountMax;
        }

        public override string ToString()
        {
            return "Multitouch Screen";
        }
    }
}
