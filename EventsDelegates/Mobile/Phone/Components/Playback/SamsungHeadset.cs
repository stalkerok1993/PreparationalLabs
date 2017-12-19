using Mobile.Output;

namespace Mobile.Phone.Components.Playback
{
    public class SamsungHeadset : PlaybackBase
    {
        public SamsungHeadset(IOutput output) : base(output)
        {
        }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(SamsungHeadset)} sound.");
        }
    }
}
