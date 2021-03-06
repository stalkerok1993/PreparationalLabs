﻿using InterfacesTests.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.Phone.Components.Charger.Tests
{
    [TestClass()]
    public class FastChargerTests
    {
        [TestMethod()]
        public void ChargeTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var charger = new FastCharger(output);

            mobile.Charge(charger);

            string chargerOutput = output.Output.ToUpper();
            Assert.IsTrue(chargerOutput.Contains("CHARGING"));
            Assert.IsTrue(chargerOutput.Contains("FAST"));
        }
    }
}