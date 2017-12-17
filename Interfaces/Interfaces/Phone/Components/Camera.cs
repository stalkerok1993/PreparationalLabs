using Interfaces.Phone.Misc;

namespace Interfaces.Phone.Components
{
    public class Camera
    {
        public CoordsFlat Resolution { get; set; }
        public SizeFlat SensorSize { get; set; }

        public override string ToString()
        {
            return "Camera";
        }
    }
}
