using System;

namespace UnderstandingOop.Date {
    public class SystemDatePrivider : IDateProvider {
        DateTime IDateProvider.Now => DateTime.Now;
    }
}
