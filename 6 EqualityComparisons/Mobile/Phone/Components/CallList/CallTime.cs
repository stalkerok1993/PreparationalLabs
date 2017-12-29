using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Phone.Components.CallList {
    class CallTime {
        public DateTime Time { get; private set; }
        public long DurationMs { get; set; }

        public CallTime(DateTime time)
        {
            Time = time;
            DurationMs = 0;
        }
    }
}
