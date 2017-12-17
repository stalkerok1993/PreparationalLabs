using UnderstandingOop.Output;

namespace UnderstandingOop.Phone.Components.Playback
{
    public class IphoneHeadset : PlaybackBase
    {
        public IphoneHeadset(IOutput output) : base(output)
        {
        }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(IphoneHeadset)} sound.");
        }
    }
}
