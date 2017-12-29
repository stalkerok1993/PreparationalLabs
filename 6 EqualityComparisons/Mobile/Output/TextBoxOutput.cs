using System;
using System.Windows.Forms;

namespace Mobile.Output
{
    public class TextBoxOutput : IOutput
    {
        private delegate void AppnedText(TextBoxBase textBox, string message);

        private static readonly AppnedText appendText = new AppnedText(AppendTextBox);

        private TextBoxBase textBox;

        public TextBoxOutput(TextBoxBase textBox)
        {
            this.textBox = textBox;
        }

        public void Write(string message)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(appendText, textBox, message);
            }
            else
            {
                AppendTextBox(textBox, message);
            }
        }

        public void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }

        private static void AppendTextBox(TextBoxBase textBox, string message)
        {
            textBox.AppendText(message);
        }
    }
}
