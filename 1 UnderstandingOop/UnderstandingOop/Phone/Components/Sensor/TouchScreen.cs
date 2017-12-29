using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components.Sensor
{
    public class TouchScreen : Sensor
    {
        public TouchTechnology Technology { get; set; }

        public TouchScreen(TouchTechnology technology = TouchTechnology.Capacitive)
        {
            Technology = technology;
        }
    }
}
