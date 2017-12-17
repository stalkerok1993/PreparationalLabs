using InterfacesTests.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.Phone.Components.Charger.Tests
{
    [TestClass()]
    public class UsbChargerTests
    {
        [TestMethod()]
        public void ChargeTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var charger = new UsbCharger(output);

            mobile.Charge(charger);

            Assert.IsTrue(output.Output.ToUpper().Contains("CHARGING"));
        }
    }
}