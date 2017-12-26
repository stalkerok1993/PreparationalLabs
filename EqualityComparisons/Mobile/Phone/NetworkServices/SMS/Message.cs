using System;

namespace Mobile.Phone.NetworkServices.SMS {
    public class Message {
        public string Number { get; set; }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }

        public Message(string text, string number = null, string user = null, DateTime? receivingTime = null)
        {
            Text = text;
            Number = number;
            User = user;
            ReceivingTime = receivingTime ?? DateTime.Now;
        }
    }
}
