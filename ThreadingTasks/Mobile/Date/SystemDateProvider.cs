using System;

namespace Mobile.Date {
    public class SystemDatePrivider : IDateProvider {
        DateTime IDateProvider.Now => DateTime.Now;
    }
}
