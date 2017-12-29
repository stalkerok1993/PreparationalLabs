using Interfaces.Output;

namespace Interfaces.Phone.Components.Playback
{
    public class IphoneHeadset : IPlayback
    {
        protected IOutput output;

        public IphoneHeadset(IOutput output)
        {
            this.output = output;
        }

        public void Play(object data)
        {
            output.WriteLine($"{nameof(IphoneHeadset)} sound.");
        }
    }
}
