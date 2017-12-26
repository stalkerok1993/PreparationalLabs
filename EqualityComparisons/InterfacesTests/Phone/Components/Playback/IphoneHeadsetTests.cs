using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Playback.Tests
{
    [TestClass()]
    public class IphoneHeadsetTests
    {
        [TestMethod()]
        public void PlayTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var playback = new IphoneHeadset(output);

            mobile.PlaybackComponent = playback;
            mobile.Play(new object());

            string playbackOutput = output.Output.ToUpper();
            Assert.IsTrue(playbackOutput.Contains("SOUND"));
            Assert.IsTrue(playbackOutput.Contains("IPHONE"));
            Assert.IsTrue(!playbackOutput.Contains("UNOFFICIAL"));
        }
    }
}