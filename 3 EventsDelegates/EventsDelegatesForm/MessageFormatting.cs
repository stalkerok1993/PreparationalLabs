using Mobile.Output;
using Mobile.Phone;
using System.Windows.Forms;
using Mobile.Phone.Network;
using System.Threading;
using System.Collections.Generic;
using System;
using System.Linq;
using UnderstandingOop.Date;
using UnderstandingOop.Formatter;

namespace EventsDelegatesForm
{
    public partial class MessageFormatting : Form
    {
        private IOutput output;
        private MobileBase mobile;

        private readonly FormatterSimpleFactory formatterFactory = new FormatterSimpleFactory(new SystemDatePrivider());
        private FormatterSimpleFactory.Formatter currentFormatter;

        public MessageFormatting()
        {
            InitializeComponent();

            comboBoxFormatters.SelectedIndex = 0;
            foreach (string formatterName in formatterFactory.AvailableNames)
            {
                comboBoxFormatters.Items.Add(formatterName);
            }

            output = new TextBoxOutput(richTextBoxOutput);
            mobile = new ModernMobile(output);
            mobile.SMSProvider = new SMSProvider();
            mobile.SMSProvider.SMSReciever += (message) => output.WriteLine(currentFormatter?.Invoke(message));

            new Thread(() =>
            {
                int notMainThreadSmsCount = 1;
                System.Threading.Timer notMainThreadTimer = new System.Threading.Timer((sender) => 
                {
                    mobile.ReceiveSMS($"SMS #{notMainThreadSmsCount++} NOT from Main thread.");
                }, null, 1000, 3000);
            }).Start();
        }

        private int smsCount = 1;
        private void timerInMainThread_Tick(object sender, System.EventArgs e)
        {
            mobile.ReceiveSMS($"SMS #{smsCount++} from Main thread.");
        }

        private static string FormatWithTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        private void comboBoxFormatters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = sender as ComboBox;
            string selectedFormatterName = cbSender?.SelectedItem.ToString();

            if (formatterFactory.AvailableNames.Contains(selectedFormatterName))
            {
                currentFormatter = formatterFactory.CreateFormatter(selectedFormatterName);
            }
            else
            {
                currentFormatter = formatterFactory.DefaultFormatter;
            }
        }
    }
}
