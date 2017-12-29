using System;
using UnderstandingOop.Date;

namespace InterfacesTests.Phone.Components.Misc {
    class FixedDateProvider : IDateProvider
    {
        public FixedDateProvider(DateTime fixedDate)
        {
            Now = fixedDate;
        }

        public DateTime Now { get; private set; }
    }
}
