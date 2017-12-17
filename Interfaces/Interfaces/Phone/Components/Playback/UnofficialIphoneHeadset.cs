using System;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class UnofficialIphoneHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(UnofficialIphoneHeadset)} sound.");
        }
    }
}
