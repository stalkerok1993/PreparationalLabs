using System.IO;

namespace Interfaces.Output
{
    class FileOutput : IOutput
    {
        private StreamWriter streamWriter;

        public FileOutput(StreamWriter streamWriter)
        {
            this.streamWriter = streamWriter;
        }

        public void Write(string message)
        {
            streamWriter.Write(message);
            streamWriter.Flush();
        }

        public void WriteLine(string message)
        {
            streamWriter.WriteLine(message);
            streamWriter.Flush();
        }
    }
}
