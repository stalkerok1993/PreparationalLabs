using Mobile.Output;
using System.Text;

namespace MobileTest.Phone.Components.Misc
{
    public class OutputMock : IOutput
    {
        public string Output
        {
            get
            {
                return outputText.ToString();
            }
        }
        private StringBuilder outputText = new StringBuilder();

        public void Write(string message)
        {
            outputText.Append(message);
        }

        public void WriteLine(string message)
        {
            Write(message);
            outputText.AppendLine();
        }
    }
}
