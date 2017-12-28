using System;

namespace Mobile.Date {
    public interface IDateProvider {
        DateTime Now { get; }
    }
}
