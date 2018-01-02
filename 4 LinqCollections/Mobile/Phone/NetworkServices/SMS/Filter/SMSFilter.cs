using System.Collections.Generic;
using System.Linq;

namespace Mobile.Phone.NetworkServices.SMS.Filter {
    public class SMSFilter {
        public SMSSelector Selector { get; set; }

        public SMSFilter(SMSSelector selector) {
            Selector = selector;
        }

        public IEnumerable<Message> Filter(IEnumerable<Message> messages, SMSSelectorData data) {
            if (Selector == null || messages == null) {
                return messages;
            }

            IEnumerable<Message> filtered =
                from message in messages
                where !Selector.IsUsed(data) || Selector.Predicate(message, data)
                select message;

            return filtered;
        }
    }
}
