using Mobile.Output;

namespace Mobile.Phone.Components.Playback
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
