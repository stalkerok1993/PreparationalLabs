using System;
using Mobile.Date;

namespace MobileTests.Phone.Components.Misc {
    class FixedDateProvider : IDateProvider {
        public FixedDateProvider(DateTime fixedDate) {
            Now = fixedDate;
        }

        public DateTime Now { get; private set; }
    }
}
