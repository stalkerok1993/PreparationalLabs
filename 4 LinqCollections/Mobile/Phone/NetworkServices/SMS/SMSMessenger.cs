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

        public virtual void AddMessage(Message message)
        {
            messageHistory.Add(message);
            MessageAdded?.Invoke(message, true);
        }

        public virtual void RemoveMessage(Message message)
        {
            if (messageHistory.Remove(message))
            {
                MessageRemoved?.Invoke(message, false);
            }
        }

        public virtual void RemoveRange(int start, int count) {
            messageHistory.RemoveRange(start, count);
        }
    }
}
