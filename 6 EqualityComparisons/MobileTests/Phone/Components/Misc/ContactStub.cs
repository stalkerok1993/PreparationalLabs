using Mobile.Phone.Components.PhoneBook;

namespace MobileTests.Phone.Components.Misc {
    class ContactStub : Contact {
        private const string NAME_PREFIX = "name";
        private const string PHONE_PREFIX = "phone";
        private static int count = 1;
        public ContactStub() : base(NAME_PREFIX + count, PHONE_PREFIX + count++) {}
    }
}
