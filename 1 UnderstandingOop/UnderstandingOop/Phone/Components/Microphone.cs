﻿namespace UnderstandingOop.Phone.Components
{
    class Microphone
    {
        public float SensitivityMinDb { get; set; }

        public Microphone(float sensitivityMinDb = -6f)
        {
            SensitivityMinDb = sensitivityMinDb;
        }

        public override string ToString()
        {
            return "Microphone";
        }
    }
}
