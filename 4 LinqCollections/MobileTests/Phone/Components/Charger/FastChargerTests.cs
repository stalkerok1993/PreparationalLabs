using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Charger.Tests
{
    [TestClass()]
    public class FastChargerTests
    {
        [TestMethod()]
        public void ChargeFastChargeTest() {
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