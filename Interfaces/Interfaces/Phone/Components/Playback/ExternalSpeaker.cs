using UnderstandingOop.Output;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class ExternalSpeaker : PlaybackBase
    {
        public ExternalSpeaker(IOutput output) : base(output)
        {
        }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(ExternalSpeaker)} sound.");
        }
    }
}
