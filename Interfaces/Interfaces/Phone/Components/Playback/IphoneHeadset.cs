using System;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class IphoneHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(IphoneHeadset)} sound.");
        }
    }
}
