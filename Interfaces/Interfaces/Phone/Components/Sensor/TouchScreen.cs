using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components.Sensor
{
    public class TouchScreen : Sensor
    {
        public TouchTechnology Technology { get; set; }
    }
}
