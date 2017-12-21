using Interfaces.Output;

namespace Interfaces.Phone.Components.Playback
{
    public class UnofficialIphoneHeadset : IPlayback
    {
        protected IOutput output;

        public UnofficialIphoneHeadset(IOutput output)
        {
            this.output = output;
        }

        public void Play(object data)
        {
            output.WriteLine($"{nameof(UnofficialIphoneHeadset)} sound.");
        }
    }
}
