using Mobile.Output;

namespace Mobile.Phone.Components.Playback
{
    public class UnofficialIphoneHeadset : PlaybackBase
    {
        public UnofficialIphoneHeadset(IOutput output) : base(output)
        {
        }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(UnofficialIphoneHeadset)} sound.");
        }
    }
}
