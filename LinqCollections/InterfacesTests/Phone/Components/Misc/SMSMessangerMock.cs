using Mobile.Phone.NetworkServices.SMS;

namespace MobileTests.Phone.Components.Misc {
    class SMSMessangerMock : SMSMessenger {
        public Message PassedMessage { get; set; } = null;

        public override void AddMessage(Message message) {
            PassedMessage = message;
        }
    }
}
