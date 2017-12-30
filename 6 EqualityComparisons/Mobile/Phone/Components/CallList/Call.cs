using System;
using System.Collections.Generic;
using System.Linq;
using Mobile.Phone.Components.PhoneBook;

namespace Mobile.Phone.Components.CallList {
    public class Call : IComparable
    {
        private readonly Contact contact;

        public Contact Contact => contact;
        
        public List<CallTime> CallTime { get; private set; } = new List<CallTime>();
        
        public bool IsIncoming { get; private set; }

        public Call(Contact contact, string number, DateTime time, bool isIncoming)
        {
            this.contact = contact;
            CallTime.Add(new CallTime(number, time));
            IsIncoming = isIncoming;
        }

        public override bool Equals(object obj)
        {
            Call anotherCall = obj as Call;
            return this == obj || Contact == anotherCall?.Contact && IsIncoming.Equals(anotherCall?.IsIncoming);
        }

        public override int GetHashCode()
        {
            return contact.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Call anotherCall = obj as Call;

            if (anotherCall == null) {
                throw new InvalidOperationException($"{nameof(anotherCall)} must not be null");
            }
            if (CallTime.Count == 0 || anotherCall?.CallTime.Count == 0) {
                throw new InvalidOperationException($"{nameof(CallTime)} must not be empty");
            }

            return CallTime.Last().Time.CompareTo(anotherCall.CallTime.Last().Time);
        }
    }
}
