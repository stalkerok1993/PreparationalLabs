using System;

namespace Mobile.Phone.NetworkServices.SMS.Filter {
    public class SMSSelectorData {
        public string TextPart { get; set; }
        public string NumberPart { get; set; }
        public DateTime? ReceivedFrom { get; set; }
        public DateTime? ReceivedTo { get; set; }

        public SMSSelectorData(string text = null, string phone = null, DateTime? from = null, DateTime? to = null) {
            TextPart = text;
            NumberPart = phone;
            ReceivedFrom = from;
            ReceivedTo = to;
        }
    }
}
