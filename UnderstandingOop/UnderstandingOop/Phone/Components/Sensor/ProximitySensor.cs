namespace UnderstandingOop.Phone.Components.Sensor
{
    class ProximitySensor : Sensor
    {
        public float MaxDistanceMm { get; set; }

        public ProximitySensor(float maxDistanceMm = 100)
        {
            MaxDistanceMm = maxDistanceMm;
        }
    }
}
