using Mobile.Phone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileTest.Phone.Components.Misc;
using Mobile.Output;
using Mobile.Threading;
using System.Threading;
using Mobile.Phone.Components.Charger;

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

        [TestMethod()]
        public void ChargeThreadTest() {
            var mobile = new ModernMobile(new NullOutput(), new BackgroundWorkerFactoryMethod(BackgroundWorkerFactoryMethod.WorkerType.Thread));

            float initialCharge = mobile.Battery.ChargeWh;
            mobile.Charge(new OrdinaryCharger(new NullOutput()));

            Thread.Sleep(3000);

            Assert.IsTrue(initialCharge < mobile.Battery.ChargeWh);
        }

        [TestMethod()]
        public void NotChargeThreadTest() {
            var mobile = new ModernMobile(new NullOutput(), new BackgroundWorkerFactoryMethod(BackgroundWorkerFactoryMethod.WorkerType.Thread));

            float initialCharge = mobile.Battery.ChargeWh;

            Thread.Sleep(3000);

            Assert.IsTrue(initialCharge > mobile.Battery.ChargeWh);
        }

        [TestMethod()]
        public void ChargeTaskTest() {
            var mobile = new ModernMobile(new NullOutput(), new BackgroundWorkerFactoryMethod(BackgroundWorkerFactoryMethod.WorkerType.Task));

            float initialCharge = mobile.Battery.ChargeWh;
            mobile.Charge(new OrdinaryCharger(new NullOutput()));

            Thread.Sleep(3000);

            Assert.IsTrue(initialCharge < mobile.Battery.ChargeWh);
        }

        [TestMethod()]
        public void NotChargeTaskTest() {
            var mobile = new ModernMobile(new NullOutput(), new BackgroundWorkerFactoryMethod(BackgroundWorkerFactoryMethod.WorkerType.Task));

            float initialCharge = mobile.Battery.ChargeWh;

            Thread.Sleep(3000);

            Assert.IsTrue(initialCharge > mobile.Battery.ChargeWh);
        }
    }
}