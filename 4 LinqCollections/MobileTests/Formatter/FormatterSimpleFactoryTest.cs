using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.Phone.NetworkServices.SMS;
using System;
using System.Linq;

namespace Mobile.Formatter {
    [TestClass()]
    public class FormatterSimpleFactoryTests {
        //AvailableNames
        [TestMethod()]
        public void AvailableNamesTest() {
            var formatterFactory = new FormatterSimpleFactory(null);

            Assert.IsTrue(formatterFactory.AvailableNames.Contains("Start with DateTime"));
            Assert.IsTrue(formatterFactory.AvailableNames.Contains("End with DateTime"));
            Assert.IsTrue(formatterFactory.AvailableNames.Contains("Custom"));
            Assert.IsTrue(formatterFactory.AvailableNames.Contains("Lowercase"));
            Assert.IsTrue(formatterFactory.AvailableNames.Contains("Uppercase"));
        }


        [TestMethod()]
        public void CreateFormatterTrivialTest() {
            var formatterFactory = new FormatterSimpleFactory(null);

            FormatterSimpleFactory.Formatter formatterNull = formatterFactory.CreateFormatter(null);
            FormatterSimpleFactory.Formatter formatterNotExists = formatterFactory.CreateFormatter("not existing formatter name asdfasdf");

            Assert.IsTrue(formatterNull == formatterFactory.DefaultFormatter);
            Assert.IsTrue(formatterNotExists == formatterFactory.DefaultFormatter);
        }

        [TestMethod()]
        public void CreateFormatterDefaultTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.DefaultFormatter;

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, message);
        }

        [TestMethod()]
        public void CreateFormatterStartWithDateTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Start with DateTime");

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, "[03/11/1993 02:25:35] some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterEndWithDateTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("End with DateTime");

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, "some asdf random ;lkj message [03/11/1993 02:25:35]");
        }

        [TestMethod]
        public void CreateFormatterCustomTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Custom");

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, "SMS: some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterLowercaseTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Lowercase");

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, "some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterUppercaseTest() {
            string message = "some asdf random ;lkj message";
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var formatterFactory = new FormatterSimpleFactory();
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Uppercase");

            string formatted = formatter(new Message(message, null, true, date));

            Assert.AreEqual(formatted, "SOME ASDF RANDOM ;LKJ MESSAGE");
        }
    }
}
