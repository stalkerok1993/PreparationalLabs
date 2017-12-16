using UnderstandingOop.Phone.Misc;

namespace UnderstandingOop.Phone.Components
{
    class Camera
    {
        public CoordsFlat Resolution { get; set; }
        public SizeFlat SensorSize { get; set; }

        public override string ToString()
        {
            return "Camera";
        }
    }
}
