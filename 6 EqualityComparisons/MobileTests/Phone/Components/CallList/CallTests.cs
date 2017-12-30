using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileTests.Phone.Components.Misc;
using System;
using System.Linq;

namespace Mobile.Phone.Components.CallList.Tests {
    [TestClass()]
    public class CallTests {
        [TestMethod()]
        public void EqualsTrivialTest() {
            var contact = new ContactStub();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call = new Call(contact, contact.Phones.First(), date, true);

            Assert.IsFalse(call.Equals(null));
        }

        [TestMethod()]
        public void EqualsDifferentClassTest() {
            var contact = new ContactStub();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call = new Call(contact, contact.Phones.First(), date, true);

            Assert.IsFalse(call.Equals(new object()));
        }

        [TestMethod()]
        public void EqualsDifferentDirectionTest() {
            var contact = new ContactStub();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call1 = new Call(contact, contact.Phones.First(), date, true);
            var call2 = new Call(contact, contact.Phones.First(), date, false);

            Assert.IsFalse(call1.Equals(call2));
        }

        [TestMethod()]
        public void EqualsDifferentContactTest() {
            var contact1 = new ContactStub();
            var contact2 = new ContactStub();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call1 = new Call(contact1, contact1.Phones.First(), date, true);
            var call2 = new Call(contact2, contact2.Phones.First(), date, true);

            Assert.IsFalse(call1.Equals(call2));
        }

        [TestMethod()]
        public void EqualsSameTest() {
            var contact = new ContactStub();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call1 = new Call(contact, contact.Phones.First(), date, true);
            var call2 = new Call(contact, contact.Phones.First(), date, true);

            Assert.IsTrue(call1.Equals(call2));
        }
    }
}