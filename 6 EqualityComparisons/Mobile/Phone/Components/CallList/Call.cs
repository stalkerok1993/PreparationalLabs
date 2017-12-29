using System;
using System.Collections.Generic;
using System.Linq;
using Mobile.Phone.Components.PhoneBook;

namespace Mobile.Phone.Components.CallList {
    class Call : IComparable
    {
        private readonly Contact contact;

        public Contact Contact => contact;

        public List<CallTime> CallTime { get; private set; } = new List<CallTime>();
        
        public bool IsIncoming { get; private set; }

        public Call(Contact contact, DateTime time, bool isIncoming)
        {
            this.contact = contact;
            CallTime.Add(new CallTime(time));
            IsIncoming = isIncoming;
        }

        public override bool Equals(object obj)
        {
            Call anotherCall = obj as Call;
            return this == obj || contact.Equals(anotherCall?.contact) && IsIncoming.Equals(anotherCall?.IsIncoming);
        }

        public override int GetHashCode()
        {
            return contact.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Call anotherCall = obj as Call;
            return CallTime.Last().Time.CompareTo(anotherCall?.CallTime.Last());
        }
    }
}
