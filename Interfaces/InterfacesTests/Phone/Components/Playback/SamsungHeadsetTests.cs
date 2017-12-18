﻿using InterfacesTests.Phone.Components.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces.Phone.Components.Playback.Tests
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

            Assert.IsTrue(output.Output.ToUpper().Contains("SOUND"));
        }
    }
}