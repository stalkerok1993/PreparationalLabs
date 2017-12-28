using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.NetworkServices.SMS.Tests {
    [TestClass()]
    public class SMSMessengerTests {
        [TestMethod()]
        public void AddMessageTest() {
            var messenger = new SMSMessenger();
            var messageText = "asdf random text asdfqwerASDFASDFASDF";
            var messageNumber = "14071202";
            var isIncoming = true;
            var time = new DateTime(1993, 03, 11, 2, 25, 35);
            var message1 = new Message(messageText, messageNumber, isIncoming, time);
            var message2 = new Message(messageText, messageNumber, !isIncoming, time);

            Assert.AreEqual(messenger.MessageHistory.Count, 0);

            messenger.AddMessage(message1);

            Assert.AreEqual(messenger.MessageHistory.Count, 1);
            Assert.IsTrue(messenger.MessageHistory.Contains(message1));

            messenger.AddMessage(message2);

            Assert.AreEqual(messenger.MessageHistory.Count, 2);
            Assert.IsTrue(messenger.MessageHistory.Contains(message1));
            Assert.IsTrue(messenger.MessageHistory.Contains(message2));
        }

        [TestMethod()]
        public void RemoveMessageTest() {
            var messenger = new SMSMessenger();
            var messageText = "asdf random text asdfqwerASDFASDFASDF";
            var messageNumber = "14071202";
            var isIncoming = true;
            var time = new DateTime(1993, 03, 11, 2, 25, 35);
            var message1 = new Message(messageText, messageNumber, isIncoming, time);
            var message2 = new Message(messageText, messageNumber, !isIncoming, time);

            messenger.AddMessage(message1);
            messenger.AddMessage(message2);

            Assert.AreEqual(messenger.MessageHistory.Count, 2);

            messenger.RemoveMessage(message2);

            Assert.AreEqual(messenger.MessageHistory.Count, 1);
            Assert.IsTrue(messenger.MessageHistory.Contains(message1));
            Assert.IsTrue(!messenger.MessageHistory.Contains(message2));
        }

        [TestMethod()]
        public void RemoveRangeTest() {
            var messenger = new SMSMessenger();
            var messageText = "asdf random text asdfqwerASDFASDFASDF";
            var messageNumber = "14071202";
            var isIncoming = true;
            var time = new DateTime(1993, 03, 11, 2, 25, 35);
            var time3 = new DateTime(1993, 03, 11, 2, 25, 35);
            var message1 = new Message(messageText, messageNumber, isIncoming, time);
            var message2 = new Message(messageText, messageNumber, !isIncoming, time);
            var message3 = new Message(messageText, messageNumber, !isIncoming, time3);

            messenger.AddMessage(message1);
            messenger.AddMessage(message2);
            messenger.AddMessage(message3);
            messenger.AddMessage(message2);

            Assert.AreEqual(messenger.MessageHistory.Count, 4);

            messenger.RemoveRange(1, 2);

            Assert.AreEqual(messenger.MessageHistory.Count, 2);
            Assert.IsTrue(messenger.MessageHistory.Contains(message1));
            Assert.IsTrue(messenger.MessageHistory.Contains(message2));
        }
    }
}