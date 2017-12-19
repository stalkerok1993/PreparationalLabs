namespace UnderstandingOop.Phone.Components
{
    class Dynamic
    {
        public float LoudnessDb { get; set; }

        public Dynamic(float loudnessDb = 20f)
        {
            LoudnessDb = loudnessDb;
        }

        public override string ToString()
        {
            return "Dynamic";
        }
    }
}
