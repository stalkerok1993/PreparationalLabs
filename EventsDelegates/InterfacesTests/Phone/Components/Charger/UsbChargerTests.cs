using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Charger.Tests
{
    [TestClass()]
    public class UsbChargerTests
    {
        [TestMethod()]
        public void ChargeTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var charger = new USBCharger(output);

            mobile.Charge(charger);

            Assert.IsTrue(output.Output.ToUpper().Contains("CHARGING"));
        }
    }
}