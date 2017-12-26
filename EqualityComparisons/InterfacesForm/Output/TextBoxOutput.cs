using Mobile.Output;
using System;
using System.Windows.Forms;

namespace InterfacesForm.Output
{
    class TextBoxOutput : IOutput
    {
        private TextBox textBox;

        public TextBoxOutput(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public void Write(string message)
        {
            textBox.AppendText(message);
        }

        public void WriteLine(string message)
        {
            Write(message);
            textBox.AppendText(Environment.NewLine);
        }
    }
}
