using Mobile.Phone.Components.CallList;
using System;

namespace MobileTests.Phone.Components.Misc {
    class CallStub : Call {
        public CallStub(DateTime time, bool isIncoming) : base(new ContactStub(), "", time, isIncoming) {}
    }
}
