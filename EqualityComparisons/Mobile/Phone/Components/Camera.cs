using Mobile.Phone.Misc;

namespace Mobile.Phone.Components
{
    public class Camera
    {
        public CoordsFlat Resolution { get; set; }
        public SizeFlat SensorSizeMm { get; set; }

        public Camera() : this(new CoordsFlat(600, 800))
        {
        }

        public Camera(CoordsFlat resolution) : this(resolution, new SizeFlat(1f, 1.3f))
        {
        }

        public Camera(CoordsFlat resolution, SizeFlat sensorSizeMm)
        {
            Resolution = resolution;
            SensorSizeMm = sensorSizeMm;
        }

        public override string ToString()
        {
            return "Camera";
        }
    }
}
