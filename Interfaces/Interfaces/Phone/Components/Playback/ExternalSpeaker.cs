using Interfaces.Output;

namespace Interfaces.Phone.Components.Playback
{
    public class ExternalSpeaker : IPlayback
    {
        protected IOutput output;

        public ExternalSpeaker(IOutput output)
        {
            this.output = output;
        }

        public void Play(object data)
        {
            output.WriteLine($"{nameof(ExternalSpeaker)} sound.");
        }
    }
}
