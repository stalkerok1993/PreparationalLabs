namespace Mobile.Phone.NetworkServices.SMS.Filter {
    public sealed class SMSSelectorComposite : SMSSelector {
        private readonly SMSSelector[] smsSelectors;

        public SelectorBoolFunc SelectorBooleanFunction { get; set; }

        public SMSSelectorComposite(SelectorBoolFunc selectorBooleanFunction, params SMSSelector[] selectors) {
            Predicate = CheckMessage;
            IsUsed = CheckUse;

            SelectorBooleanFunction = selectorBooleanFunction;
            smsSelectors = selectors;
        }

        private bool CheckMessage(Message message, SMSSelectorData data) {
            bool isSelected = SelectorBooleanFunction == SelectorBoolFunc.And;

            foreach (SMSSelector smsSelector in smsSelectors) {
                if (SelectorBooleanFunction == SelectorBoolFunc.And) {
                    isSelected &= !smsSelector.IsUsed(data) || smsSelector.Predicate(message, data);
                }
                else {
                    isSelected |= smsSelector.IsUsed(data) && smsSelector.Predicate(message, data);
                }
            }

            return isSelected;
        }

        private bool CheckUse(SMSSelectorData data) {
            foreach (SMSSelector smsSelector in smsSelectors) {
                if (smsSelector.IsUsed(data)) {
                    return true;
                }
            }

            return false;
        }

        public enum SelectorBoolFunc {
            And,
            Or
        }
    }
}
