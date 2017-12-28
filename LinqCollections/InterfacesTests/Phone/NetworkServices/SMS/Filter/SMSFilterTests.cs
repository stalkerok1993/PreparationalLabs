using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.NetworkServices.SMS.Filter.Tests {
    [TestClass()]
    public class SMSFilterTests {
        [TestMethod()]
        public void FilterTrivialTest()
        {
            List<Message> messages = new List<Message>()
            {
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text_3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35)),
                new Message("text_6", "_num6", true, new DateTime(1996, 06, 16, 2, 26, 36)),
                new Message("text_7", "num7", true, new DateTime(1997, 07, 17, 2, 27, 37)),
                new Message("text8", "_num8", true, new DateTime(1998, 08, 18, 2, 28, 38)),
                new Message("text9", "num9", true, new DateTime(1999, 09, 19, 2, 29, 39))
            };
            var data = new SMSSelectorData("text_", "_num", 
                new DateTime(1993, 03, 13, 2, 23, 33),
                new DateTime(1997, 07, 17, 2, 27, 37));
            var filter = new SMSFilter(null);

            IEnumerable<Message> filtered = filter.Filter(messages, data);

            Assert.AreEqual(filtered.Count(), messages.Count);
            foreach (Message message in filtered)
            {
                Assert.IsTrue(messages.Contains(message));
            }
        }

        [TestMethod()]
        public void FilterTest() {
            List<Message> messages = new List<Message>()
            {
                new Message("text0", "num0", true, new DateTime(1990, 01, 11, 2, 21, 31)),
                new Message("text1", "num1", true, new DateTime(1991, 01, 11, 2, 21, 31)),
                new Message("text_2", "_num2", true, new DateTime(1992, 02, 12, 2, 22, 32)),
                new Message("text3", "num3", true, new DateTime(1993, 03, 13, 2, 23, 33)),
                new Message("text_4", "_num4", true, new DateTime(1994, 04, 14, 2, 24, 34)),
                new Message("text5", "num5", true, new DateTime(1995, 05, 15, 2, 25, 35)),
                new Message("text_6", "_num6", true, new DateTime(1996, 06, 16, 2, 26, 36)),
                new Message("text_7", "num7", true, new DateTime(1997, 07, 17, 2, 27, 37)),
                new Message("text8", "_num8", true, new DateTime(1998, 08, 18, 2, 28, 38)),
                new Message("text9", "num9", true, new DateTime(1999, 09, 19, 2, 29, 39))
            };
            var data = new SMSSelectorData("text_", "_num",
                new DateTime(1993, 03, 13, 2, 23, 33),
                new DateTime(1997, 07, 17, 2, 27, 37));
            var filter = new SMSFilter(new SMSSelectorSimpleFactory().CreateSelector("CompositeSelector"));

            IEnumerable<Message> filtered = filter.Filter(messages, data);

            Assert.AreEqual(filtered.Count(), 2);
            Assert.IsTrue(filtered.Contains(messages[4]));
            Assert.IsTrue(filtered.Contains(messages[6]));
        }
    }
}