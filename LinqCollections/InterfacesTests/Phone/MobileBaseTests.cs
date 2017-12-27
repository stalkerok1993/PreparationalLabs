using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileTest.Phone.Components.Misc;

namespace Mobile.Phone.Tests {
    [TestClass()]
    public class MobileBaseTests {
        [TestMethod()]
        public void ReceiveSMSTrivialTest() {
            bool isRecieved = false;
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            mobile.SMSMessenger.MessageAdded += (message, isAdded) => isRecieved = true;

            mobile.ReceiveSMS(null, "");

            Assert.IsTrue(isRecieved);
        }

        [TestMethod()]
        public void ReceiveSMSTest() {
            string testSms = "Some random SMS asdf;ljkqweproijsdgkhbn";
            string recieved = null;
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            mobile.SMSMessenger.MessageAdded += (message, isAdded) => recieved = message.Text;

            mobile.ReceiveSMS(testSms, null);

            Assert.AreEqual(testSms, recieved);
        }

        [TestMethod()]
        public void SendSMSTest() {
            Assert.Fail();
        }
    }
}