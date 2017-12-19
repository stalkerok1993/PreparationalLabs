using Mobile.Output;
using Mobile.Phone;
using System.Windows.Forms;
using Mobile.Phone.Network;
using System.Threading;
using System.Collections.Generic;
using System;

namespace EventsDelegatesForm
{
    public partial class MessageFormatting : Form
    {
        private delegate string Formatter(string message);

        private IOutput output;
        private MobileBase mobile;

        private Formatter currentFormatter;
        private Dictionary<string, Formatter> formatters = new Dictionary<string, Formatter>()
        {
            {"Start with DateTime", FormatWithTime},
            {"End with DateTime", (message) => $"{message} [{DateTime.Now}]" },
            {"Custom", (message) => $"SMS: {message.Trim()}" },
            {"Lowercase", (message) => message.ToLower() },
            {"Uppercase", (message) => message.ToUpper() },
        };

        public MessageFormatting()
        {
            InitializeComponent();

            comboBoxFormatters.SelectedIndex = 0;
            foreach (string key in formatters.Keys)
            {
                comboBoxFormatters.Items.Add(key);
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
                    mobile.SMSProvider.RaiseSMSRecieverEvent($"SMS #{notMainThreadSmsCount++} NOT from Main thread.");
                }, null, 1000, 3000);
            }).Start();
        }

        private int smsCount = 1;
        private void timerInMainThread_Tick(object sender, System.EventArgs e)
        {
            mobile.SMSProvider.RaiseSMSRecieverEvent($"SMS #{smsCount++} from Main thread.");
        }

        private static string FormatWithTime(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        private void comboBoxFormatters_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = sender as ComboBox;
            string selectedKey = cbSender?.SelectedItem.ToString();

            if (formatters.ContainsKey(selectedKey))
            {
                currentFormatter = formatters[selectedKey];
            }
            else
            {
                currentFormatter = (message) => message;
            }
        }
    }
}
