using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.Phone.Components.CallList;
using Mobile.Phone.Components.PhoneBook;
using MobileTests.Phone.Components.Misc;

namespace MobileTests1.Phone.Components.CallList {
    [TestClass()]
    public class SortedListTests {
        [TestMethod()]
        public void SortedListAdd() {
            var sortedList = new SortedList<Call>();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call0 = new CallStub(date.Add(new TimeSpan(4, 0, 0, 0)), false);
            var call1 = new CallStub(date.Add(new TimeSpan(2, 0, 0, 0)), false);
            var call2 = new CallStub(date.Add(new TimeSpan(1, 0, 0, 0)), false);
            var call3 = new CallStub(date, true);

            sortedList.Add(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);

            Assert.IsTrue(sortedList.Count == 4);
            Assert.IsTrue(sortedList[0] == call0);
            Assert.IsTrue(sortedList[1] == call1);
            Assert.IsTrue(sortedList[2] == call2);
            Assert.IsTrue(sortedList[3] == call3);
        }

        [TestMethod()]
        public void SortedListRemove() {
            var sortedList = new SortedList<Call>();
            var date = new DateTime(1993, 03, 11, 2, 25, 35);
            var call0 = new CallStub(date.Add(new TimeSpan(4, 0, 0, 0)), false);
            var call1 = new CallStub(date.Add(new TimeSpan(2, 0, 0, 0)), false);
            var call2 = new CallStub(date.Add(new TimeSpan(1, 0, 0, 0)), false);
            var call3 = new CallStub(date, true);

            sortedList.Add(call2);
            sortedList.Remove(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);
            sortedList.Remove(call1);


            Assert.IsTrue(sortedList.Count == 2);
            Assert.IsTrue(sortedList[0] == call0);
            Assert.IsTrue(sortedList[1] == call3);
        }
    }
}
