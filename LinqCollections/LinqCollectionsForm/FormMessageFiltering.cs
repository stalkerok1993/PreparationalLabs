using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mobile.Date;
using Mobile.Formatter;

using Message = Mobile.Phone.NetworkServices.SMS.Message;
using Mobile.Output;
using Mobile.Phone;
using static Mobile.Formatter.FormatterSimpleFactory;
using Mobile.Phone.NetworkServices.SMS;
using System;
using System.Threading;

namespace LinqCollectionsForm {
    public partial class FormMessageFiltering : Form {
        private IOutput output;
        private MobileBase mobile;

        private FormatterSimpleFactory formatterFactory = new FormatterSimpleFactory(new SystemDatePrivider());
        private Formatter currentFormatter;

        private List<MessageCriteriaSelector> criteriaSelectors;

        private const int MAXIMUM_CACHED = 100;
        private List<Message> recievedMessages = new List<Message>();

        public FormMessageFiltering() {
            InitializeComponent();

            comboBoxFormatter.SelectedIndex = 0;
            comboBoxFormatter.Items.AddRange(formatterFactory.AvailableNames.ToArray());

            criteriaSelectors = new List<MessageCriteriaSelector>() {
                new MessageCriteriaSelector((m) => m.Number?.ToUpper().Contains(comboBoxPhone.Text.Trim().ToUpper()) ?? false,
                    () => comboBoxPhone.Text.Trim().Length > 0),
                new MessageCriteriaSelector((m) => m.Text?.ToUpper().Contains(textBoxMessageContains.Text.Trim().ToUpper()) ?? false,
                    () => textBoxMessageContains.Text.Trim().Length > 0),
                new MessageCriteriaSelector((m) => m.ReceivingTime.CompareTo(dateTimePickerReceivedAfter.Value) >= 0,
                    () => checkBoxReceivedAfter.Checked),
                new MessageCriteriaSelector((m) => m.ReceivingTime.CompareTo(dateTimePickerReceivedAfter.Value) < 0,
                    () => checkBoxReceivedBefore.Checked)
            };
            currentFormatter = formatterFactory.DefaultFormatter;

            output = new NullOutput();
            mobile = new ModernMobile(output);
            mobile.SMSProvider = new SMSProvider();
            mobile.SMSProvider.SMSReciever += (message) => {
                recievedMessages.Add(message);
                if (recievedMessages.Count > MAXIMUM_CACHED) {
                    recievedMessages.RemoveRange(0, recievedMessages.Count - MAXIMUM_CACHED);
                }

                try {
                    Invoke(new Action(() => ShowMessages(FilterMessages(recievedMessages).ToList())));
                }
                catch (ObjectDisposedException) {
                }
            };

            new Thread(() => {
                int notMainThreadSmsCount = 1;
                System.Threading.Timer notMainThreadTimer = new System.Threading.Timer((sender) => {
                    mobile.ReceiveSMS(new Message($"SMS #{notMainThreadSmsCount++} NOT from Main thread."));
                }, null, 1000, 3000);
            }).Start();
        }

        private int smsCount = 1;
        private void timerInMainThread_Tick(object sender, System.EventArgs e) {
            mobile.ReceiveSMS(new Message($"SMS #{smsCount++} from Main thread."));
        }

        private static string FormatWithTime(string message) {
            return $"[{DateTime.Now}] {message}";
        }

        private void comboBoxFormatters_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cbSender = sender as ComboBox;
            string selectedKey = cbSender?.SelectedItem.ToString();

            currentFormatter = formatterFactory.CreateFormatter(selectedKey);
        }

        private sealed class MessageCriteriaSelector {
            public Func<Message, bool> Predicate { get; private set; }
            private Func<bool> isUsed;

            public bool IsUsed => isUsed();

            public MessageCriteriaSelector(Func<Message, bool> predicate, Func<bool> isUsed) {
                Predicate = predicate;
                this.isUsed = isUsed;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            listViewMessages.BeginUpdate();

            listViewMessages.Items.Clear();
            ShowMessages(FilterMessages(recievedMessages).ToList());

            listViewMessages.EndUpdate();
        }

        private void ShowMessages(IEnumerable<Message> messages) {
            listViewMessages.Items.Clear();

            foreach (Message message in messages) {
                listViewMessages.Items.Add(new ListViewItem(new[] { currentFormatter(message.Text) }));
            }
        }

        private IEnumerable<Message> FilterMessages(IEnumerable<Message> messages) {
            return messages.Where((m) => {
                bool isUsed = false;
                bool isSelected = radioButtonAnd.Checked;

                foreach (MessageCriteriaSelector selector in criteriaSelectors) {
                    isUsed |= selector.IsUsed;

                    if (radioButtonAnd.Checked) {
                        isSelected &= selector.IsUsed ? selector.Predicate(m) : true;
                    }
                    else {
                        isSelected |= selector.IsUsed ? selector.Predicate(m) : false;
                    }
                }

                return !isUsed || isSelected;
            });
        }

        private int mainThreadSmsCount = 1;
    }
}
