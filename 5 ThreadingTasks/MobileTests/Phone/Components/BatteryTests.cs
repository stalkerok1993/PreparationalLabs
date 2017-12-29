using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Tests {
    [TestClass()]
    public class BatteryTests {
        [TestMethod()]
        public void ChangeChargeMinimumTest() {
            var battery = new Battery();

            battery.ChangeCharge(-10 * battery.CapacityWh);

            Assert.IsTrue(battery.ChargeWh == 0f);
        }

        [TestMethod()]
        public void ChangeChargeMaximumTest() {
            var battery = new Battery();

            battery.ChangeCharge(10 * battery.CapacityWh);

            Assert.IsTrue(battery.ChargeWh == battery.CapacityWh);
        }
    }
}