using System;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class ExternalSpeaker : IPlayback
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(ExternalSpeaker)} sound.");
        }
    }
}
