﻿using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Charger.Tests
{
    [TestClass()]
    public class OrdinaryChargerTests
    {
        [TestMethod()]
        public void ChargeOrdinaryChargerTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var charger = new OrdinaryCharger(output);

            mobile.Charge(charger);

            string chargerOutput = output.Output.ToUpper();
            Assert.IsTrue(chargerOutput.Contains("CHARGING"));
            Assert.IsTrue(chargerOutput.Contains("ORDINARY"));
        }
    }
}