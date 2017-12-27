using System.Collections.Generic;
using System.Linq;

namespace Mobile.Phone.NetworkServices.SMS {
    public class SMSMessenger
    {
        public delegate void SMSHistoryChangedHandler(Message message, bool isAdded);

        protected readonly List<Message> messageHistory = new List<Message>();

        public event SMSHistoryChangedHandler MessageAdded;
        public event SMSHistoryChangedHandler MessageRemoved;

        public List<Message> MessageHistory => messageHistory.ToList();

        public void AddMessage(Message message)
        {
            messageHistory.Add(message);
            MessageAdded?.Invoke(message, true);
        }

        public void SendMessage(string text, string number)
        {
            if (number != null)
            {
                var message = new Message(text, number, false);
                AddMessage(message);
            }
        }

        public void RemoveMessage(Message message)
        {
            if (messageHistory.Remove(message))
            {
                MessageRemoved?.Invoke(message, false);
            }
        }

        public void RemoveRange(int start, int count) {
            messageHistory.RemoveRange(start, count);
        }
    }
}
