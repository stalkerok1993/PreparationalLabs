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

            return messages.Where((m) => !Selector.IsUsed(data) || Selector.Predicate(m, data));
        }
    }
}
