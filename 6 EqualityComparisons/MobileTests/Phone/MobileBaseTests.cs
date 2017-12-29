using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.Phone.NetworkServices.SMS;
using MobileTest.Phone.Components.Misc;

namespace Mobile.Phone.Tests {
    [TestClass()]
    public class MobileBaseTests {
        [TestMethod()]
        public void ReceiveSMSTrivialTest() {
            bool isRecieved = false;
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            mobile.SMSProvider = new SMSProvider();
            mobile.SMSProvider.SMSReciever += (message) => isRecieved = true;

            mobile.ReceiveSMS(null);

            Assert.IsTrue(isRecieved);
        }

        [TestMethod()]
        public void ReceiveSMSTest() {
            string testSms = "Some random SMS asdf;ljkqweproijsdgkhbn";
            string recieved = null;
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            mobile.SMSProvider = new SMSProvider();
            mobile.SMSProvider.SMSReciever += (message) => recieved = message.Text;

            mobile.ReceiveSMS(new Message(testSms));

            Assert.AreEqual(testSms, recieved);
        }
    }
}