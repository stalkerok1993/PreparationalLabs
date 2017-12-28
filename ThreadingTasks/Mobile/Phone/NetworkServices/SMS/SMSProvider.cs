namespace Mobile.Phone.NetworkServices.SMS
{
    internal class SMSProvider
    {
        public delegate void SMSRecieverDelegate(Message message);

        public event SMSRecieverDelegate SMSReciever;

        public void RaiseSMSRecieverEvent(Message message)
        {
            SMSReciever?.Invoke(message);
        }
    }
}
