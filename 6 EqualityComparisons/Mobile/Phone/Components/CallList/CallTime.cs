using System;

namespace Mobile.Phone.Components.CallList {
    public class CallTime {
        public string Number { get; private set; }
        public DateTime Time { get; private set; }
        public long DurationMs { get; set; }

        public CallTime(string number, DateTime time)
        {
            Number = number;
            Time = time;
            DurationMs = 0;
        }
    }
}
