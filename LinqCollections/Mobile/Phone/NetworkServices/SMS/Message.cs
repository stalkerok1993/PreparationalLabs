using System;

namespace Mobile.Phone.NetworkServices.SMS {
    public class Message {
        public string Number { get; private set; }

        public string Text { get; set; }

        public DateTime ReceivingTime { get; set; }

        public bool IsIncoming { get; set; }

        public Message(string text, string number = null, bool isIncoming = true, DateTime? receivingTime = null)
        {
            Text = text ?? "";
            Number = number;
            IsIncoming = isIncoming;
            ReceivingTime = receivingTime ?? DateTime.Now;
        }
    }
}
