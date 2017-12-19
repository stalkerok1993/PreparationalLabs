namespace Mobile.Phone.Network
{
    public class SMSProvider
    {
        public delegate void SMSRecieverDelegate(string message);

        public event SMSRecieverDelegate SMSReciever;

        public void RaiseSMSRecieverEvent(string message)
        {
            SMSReciever?.Invoke(message);
        }
    }
}
