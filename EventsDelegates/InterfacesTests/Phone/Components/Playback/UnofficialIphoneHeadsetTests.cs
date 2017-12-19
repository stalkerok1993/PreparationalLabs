using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Playback.Tests
{
    [TestClass()]
    public class UnofficialIphoneHeadsetTests
    {
        [TestMethod()]
        public void PlayTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var playback = new UnofficialIphoneHeadset(output);

            mobile.PlaybackComponent = playback;
            mobile.Play(new object());

            Assert.IsTrue(output.Output.ToUpper().Contains("SOUND"));
        }
    }
}