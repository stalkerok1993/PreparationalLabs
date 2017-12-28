using System.Collections.Generic;
using System.Linq;

namespace Mobile.Phone.NetworkServices.SMS.Filter {
    public class SMSSelectorSimpleFactory {
        private static Dictionary<string, SMSSelector> criteriaSelectors = new Dictionary<string, SMSSelector> {
            {"NumberSelector", new SMSSelector(
                (m, d) => m.Number?.ToUpper().Contains(d.NumberPart?.Trim().ToUpper()) ?? false,
                (d) => (d.NumberPart?.Trim().Length ?? -1) > 0) },
            {"TextSelector", new SMSSelector(
                (m, d) => m.Text?.ToUpper().Contains(d.TextPart?.Trim().ToUpper()) ?? false,
                (d) => (d.TextPart?.Trim().Length ?? -1) > 0) },
            {"RecievedAfterSelector", new SMSSelector(
                (m, d) => m.ReceivedTime.CompareTo(d.ReceivedFrom) >= 0,
                (d) => d.ReceivedFrom != null) },
            {"RecievedBeforeSelector", new SMSSelector(
                (m, d) => m.ReceivedTime.CompareTo(d.ReceivedTo) < 0,
                (d) => d.ReceivedTo != null) }
        };

        static SMSSelectorSimpleFactory() {
            SMSSelector[] selectors = criteriaSelectors.Values.ToArray();
            SMSSelectorComposite composite = new SMSSelectorComposite(SMSSelectorComposite.SelectorBoolFunc.And, selectors);
            criteriaSelectors.Add("CompositeSelector", composite);
        }

        public IEnumerable<string> AvailableNames => criteriaSelectors.Keys;

        public SMSSelector CreateSelector(string selectorName) {
            if (selectorName == null || !criteriaSelectors.ContainsKey(selectorName)) {
                return null;
            }

            return criteriaSelectors[selectorName];
        }
    }
}
