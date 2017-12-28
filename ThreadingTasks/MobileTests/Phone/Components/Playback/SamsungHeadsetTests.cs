using MobileTest.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mobile.Phone.Components.Playback.Tests
{
    [TestClass()]
    public class SamsungHeadsetTest
    {
        [TestMethod()]
        public void PlayTest()
        {
            var output = new OutputMock();
            var mobile = new PhoneStub(output);
            var playback = new SamsungHeadset(output);

            mobile.PlaybackComponent = playback;
            mobile.Play(new object());

            string playbackOutput = output.Output.ToUpper();
            Assert.IsTrue(playbackOutput.Contains("SOUND"));
            Assert.IsTrue(playbackOutput.Contains("SAMSUNG"));
        }
    }
}