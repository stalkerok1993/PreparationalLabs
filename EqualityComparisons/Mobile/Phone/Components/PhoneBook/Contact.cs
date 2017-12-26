using System.Collections.Generic;

namespace Mobile.Phone.Components.PhoneBook {
    class Contact
    {
        public readonly string name;

        public string Name => name;

        public List<string> Phones { get; private set; } = new List<string>();

        public Contact(string name, params string[] phones)
        {
            this.name = name;
            Phones.AddRange(phones);
        }

        public override bool Equals(object obj)
        {
            Contact anotherContact = obj as Contact;
            return this == anotherContact || anotherContact != null && name.Equals(anotherContact.name);
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
