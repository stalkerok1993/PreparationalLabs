using System;

namespace UnderstandingOop.Date {
    public interface IDateProvider {
        DateTime Now { get; }
    }
}
