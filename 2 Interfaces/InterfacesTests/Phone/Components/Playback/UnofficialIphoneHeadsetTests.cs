using InterfacesTests.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.Phone.Components.Playback.Tests
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

            string playbackOutput = output.Output.ToUpper();
            Assert.IsTrue(playbackOutput.Contains("SOUND"));
            Assert.IsTrue(playbackOutput.Contains("IPHONE"));
            Assert.IsTrue(playbackOutput.Contains("UNOFFICIAL"));
        }
    }
}