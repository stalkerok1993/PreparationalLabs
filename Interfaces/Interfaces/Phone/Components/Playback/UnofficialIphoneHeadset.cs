using Interfaces.Output;

namespace Interfaces.Phone.Components.Playback
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
