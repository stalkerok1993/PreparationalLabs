using System;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class SamsungHeadset : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound.");
        }
    }
}
