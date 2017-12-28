using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.NetworkServices.SMS.Filter.Tests
{
    [TestClass()]
    public class SMSSelectorSimpleFactoryTests {
        [TestMethod()]
        public void CreateTrivialTest()
        {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var factory = new SMSSelectorSimpleFactory();
            SMSSelector selector = factory.CreateSelector(null);

            Assert.IsNull(selector);
        }

        [TestMethod()]
        public void CreateTextSelectorTest()
        {
            List<Message> messages = new List<Message>() {
                new Message("text0", "num0", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_1", "_num1", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_2", "num2", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text3", "_num3", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text4", "num4", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1992, 01, 11, 2, 21, 31),
                new DateTime(1994, 07, 17, 2, 27, 37));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelector selector = factory.CreateSelector("TextSelector");

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsFalse(selector.Predicate(messages[0], data));
            Assert.IsTrue(selector.Predicate(messages[1], data));
            Assert.IsTrue(selector.Predicate(messages[2], data));
            Assert.IsFalse(selector.Predicate(messages[3], data));
            Assert.IsFalse(selector.Predicate(messages[4], data));
        }

        [TestMethod()]
        public void CreateNumberSelectorTest() {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1993, 03, 13, 2, 23, 33),
                new DateTime(1994, 07, 17, 2, 27, 37));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelector selector = factory.CreateSelector("NumberSelector");

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsFalse(selector.Predicate(messages[0], data));
            Assert.IsTrue(selector.Predicate(messages[1], data));
            Assert.IsFalse(selector.Predicate(messages[2], data));
            Assert.IsTrue(selector.Predicate(messages[3], data));
            Assert.IsFalse(selector.Predicate(messages[4], data));
        }

        [TestMethod()]
        public void CreateFromDateSelectorTest() {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1993, 03, 13, 2, 23, 33),
                new DateTime(1994, 07, 17, 2, 27, 37));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelector selector = factory.CreateSelector("RecievedAfterSelector");

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsFalse(selector.Predicate(messages[0], data));
            Assert.IsFalse(selector.Predicate(messages[1], data));
            Assert.IsTrue(selector.Predicate(messages[2], data));
            Assert.IsTrue(selector.Predicate(messages[3], data));
            Assert.IsTrue(selector.Predicate(messages[4], data));
        }

        [TestMethod()]
        public void CreateToDateSelectorTest() {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1993, 03, 13, 2, 23, 33),
                new DateTime(1994, 07, 17, 2, 27, 37));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelector selector = factory.CreateSelector("RecievedBeforeSelector");

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsTrue(selector.Predicate(messages[0], data));
            Assert.IsTrue(selector.Predicate(messages[1], data));
            Assert.IsTrue(selector.Predicate(messages[2], data));
            Assert.IsTrue(selector.Predicate(messages[3], data));
            Assert.IsFalse(selector.Predicate(messages[4], data));
        }

        [TestMethod()]
        public void CreateCompositeAndSelectorTest() {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1991, 02, 12, 2, 22, 32),
                new DateTime(1994, 07, 17, 2, 27, 37));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelectorComposite selector = (SMSSelectorComposite)factory.CreateSelector("CompositeSelector");
            selector.SelectorBooleanFunction = SMSSelectorComposite.SelectorBoolFunc.And;

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsFalse(selector.Predicate(messages[0], data));
            Assert.IsTrue(selector.Predicate(messages[1], data));
            Assert.IsFalse(selector.Predicate(messages[2], data));
            Assert.IsFalse(selector.Predicate(messages[3], data));
            Assert.IsFalse(selector.Predicate(messages[4], data));
        }

        [TestMethod()]
        public void CreateCompositeOrSelectorTest() {
            List<Message> messages = new List<Message>() {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1991, 02, 12, 2, 22, 32));
            var factory = new SMSSelectorSimpleFactory();
            SMSSelectorComposite selector = (SMSSelectorComposite)factory.CreateSelector("CompositeSelector");
            selector.SelectorBooleanFunction = SMSSelectorComposite.SelectorBoolFunc.Or;

            Assert.IsTrue(selector.IsUsed(data));
            Assert.IsFalse(selector.Predicate(messages[0], data));
            Assert.IsTrue(selector.Predicate(messages[1], data));
            Assert.IsTrue(selector.Predicate(messages[2], data));
            Assert.IsTrue(selector.Predicate(messages[3], data));
            Assert.IsTrue(selector.Predicate(messages[4], data));
        }
    }
}