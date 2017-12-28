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
        public void ReceiveSMSHistoryTest() {
            string testMessage1 = "Some random SMS asdf;ljkqweproijsdgkhbn";
            string testNumber1 = "num1";
            string testMessage2 = "Some random SMS2 asdf;ljkqweproijsdgkhbn";
            string testNumber2 = "num2";
            string testMessage3 = "Some random SMS3 asdf;ljkqweproijsdgkhbn";
            string testNumber3 = "num3";
            var output = new OutputMock();
            var mobile = new PhoneStub(output);

            mobile.ReceiveSMS(testMessage1, testNumber1);
            mobile.ReceiveSMS(testMessage2, testNumber2);
            mobile.ReceiveSMS(testMessage3, testNumber3);

            Assert.AreEqual(mobile.SMSMessenger.MessageHistory.Count, 3);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[0].Text, testMessage1);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[0].Number, testNumber1);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[1].Text, testMessage2);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[1].Number, testNumber2);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[2].Text, testMessage3);
            Assert.AreEqual(mobile.SMSMessenger.MessageHistory[2].Number, testNumber3);
        }
    }
}