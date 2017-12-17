namespace Interfaces.Phone.Components.Sensor
{
    public class MultiTouchScreen : TouchScreen
    {
        public int TouchCountMax { get; set; }

        public override string ToString()
        {
            return "Multitouch Screen";
        }
    }
}
