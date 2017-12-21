using Interfaces.Output;

namespace Interfaces.Phone.Components.Playback
{
    public class SamsungHeadset : IPlayback
    {
        protected IOutput output;

        public SamsungHeadset(IOutput output)
        {
            this.output = output;
        }

        public override void Play(object data)
        {
            output.WriteLine($"{nameof(SamsungHeadset)} sound.");
        }
    }
}
