using System;

namespace Mobile.Phone.NetworkServices.SMS.Filter {
    public class SMSSelector {
        public Func<Message, SMSSelectorData, bool> Predicate { get; protected set; }
        public Func<SMSSelectorData, bool> IsUsed { get; protected set; }

        public SMSSelector() { }

        public SMSSelector(Func<Message, SMSSelectorData, bool> predicate, Func<SMSSelectorData, bool> isUsed) {
            Predicate = predicate;
            IsUsed = isUsed;
        }
    }
}
