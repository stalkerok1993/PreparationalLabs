﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileTests.Phone.Components.Misc;

namespace Mobile.Formatter.Test {
    [TestClass()]
    public class FormatterSimpleFactoryTests {
        [TestMethod()]
        public void CreateFormatterTrivial() {
            var formatterFactory = new FormatterSimpleFactory(null);

            FormatterSimpleFactory.Formatter formatterNull = formatterFactory.CreateFormatter(null);
            FormatterSimpleFactory.Formatter formatterNotExists = formatterFactory.CreateFormatter("not existing formatter name asdfasdf");

            Assert.IsTrue(formatterNull == formatterFactory.DefaultFormatter);
            Assert.IsTrue(formatterNotExists == formatterFactory.DefaultFormatter);
        }

        [TestMethod()]
        public void CreateFormatterDefault() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.DefaultFormatter;

            string formatted = formatter(message);

            Assert.AreEqual(formatted, message);
        }

        [TestMethod()]
        public void CreateFormatterStartWithDate() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Continue with DateTime");

            string formatted = formatter(message);

            Assert.AreEqual(formatted, "[11.03.1993 2:25:35] some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterEndWithDate() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("End with DateTime");

            string formatted = formatter(message);

            Assert.AreEqual(formatted, "some asdf random ;lkj message [11.03.1993 2:25:35]");
        }

        [TestMethod]
        public void CreateFormatterCustom() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Custom");

            string formatted = formatter(message);

            Assert.AreEqual(formatted, "SMS: some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterLowercase() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Lowercase");

            string formatted = formatter(message);

            Assert.AreEqual(formatted, "some asdf random ;lkj message");
        }

        [TestMethod()]
        public void CreateFormatterUppercase() {
            string message = "some asdf random ;lkj message";
            var dateProvider = new FixedDateProvider(new DateTime(1993, 03, 11, 2, 25, 35));
            var formatterFactory = new FormatterSimpleFactory(dateProvider);
            FormatterSimpleFactory.Formatter formatter = formatterFactory.CreateFormatter("Uppercase");

            string formatted = formatter(message);

            Assert.AreEqual(formatted, "SOME ASDF RANDOM ;LKJ MESSAGE");
        }
    }
}
