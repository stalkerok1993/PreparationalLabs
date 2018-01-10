using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile.Phone.Components.CallList;
using Mobile.Phone.Components.PhoneBook;
using MobileTests.Phone.Components.Misc;

namespace MobileTests1.Phone.Components.CallList {
    [TestClass()]
    public class SortedListTests {
        private static readonly DateTime date = new DateTime(1993, 03, 11, 2, 25, 35);
        private readonly Call call0 = new CallStub(date.Add(new TimeSpan(4, 0, 0, 0)), false);
        private readonly Call call1 = new CallStub(date.Add(new TimeSpan(2, 0, 0, 0)), false);
        private readonly Call call2 = new CallStub(date.Add(new TimeSpan(1, 0, 0, 0)), false);
        private readonly Call call3 = new CallStub(date, true);
        private SortedList<Call> sortedList;

        [TestInitialize()]
        public void Initialize() {
            sortedList = new SortedList<Call>();
        }

        [TestMethod()]
        public void SortedListAddProperChange() {
            sortedList.Add(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);

            Assert.IsTrue(sortedList.Count == 4);
        }

        [TestMethod()]
        public void SortedListAddProperOrder() {
            sortedList.Add(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);
            
            Assert.IsTrue(sortedList[0] == call0 && sortedList[1] == call1 && sortedList[2] == call2 && sortedList[3] == call3);
        }

        [TestMethod()]
        public void SortedListRemoveProperCount() {
            sortedList.Add(call2);
            sortedList.Remove(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);
            sortedList.Remove(call1);


            Assert.IsTrue(sortedList.Count == 2);
        }

        [TestMethod()]
        public void SortedListRemoveProperOrder() {
            sortedList.Add(call2);
            sortedList.Remove(call2);
            sortedList.Add(call0);
            sortedList.Add(call1);
            sortedList.Add(call3);
            sortedList.Remove(call1);
            
            Assert.IsTrue(sortedList[0] == call0 && sortedList[1] == call3);
        }
    }
}
