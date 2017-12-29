using System;

namespace Mobile.Phone.Components.CallList {
    public class CallTime {
        public DateTime Time { get; private set; }
        public long DurationMs { get; set; }

        public CallTime(DateTime time)
        {
            Time = time;
            DurationMs = 0;
        }
    }
}
