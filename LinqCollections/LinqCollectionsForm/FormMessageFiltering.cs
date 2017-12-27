using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mobile.Date;
using Mobile.Formatter;
using Message = Mobile.Phone.NetworkServices.SMS.Message;
using Mobile.Output;
using Mobile.Phone;
using static Mobile.Formatter.FormatterSimpleFactory;
using System;
using System.Globalization;
using System.Threading;

namespace LinqCollectionsForm {
    public partial class FormMessageFiltering : Form {
        private readonly IOutput output = new NullOutput();
        private readonly MobileBase mobile;

        private readonly FormatterSimpleFactory formatterFactory = new FormatterSimpleFactory(new SystemDatePrivider());
        private Formatter currentFormatter;

        private readonly List<MessageCriteriaSelector> criteriaSelectors;

        private const int MAXIMUM_OUTPUT = 100;
        private List<Message> messageHistoryCopy;

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

            mobile = new ModernMobile(output);
            mobile.SMSMessenger.MessageAdded += (message, isAdded) => {
                messageHistoryCopy = mobile.SMSMessenger.MessageHistory;
                if (messageHistoryCopy.Count > MAXIMUM_OUTPUT) {
                    mobile.SMSMessenger.RemoveRange(0, messageHistoryCopy.Count - MAXIMUM_OUTPUT);
                }

                try {
                    Invoke(new Action(RefreshListView));
                }
                catch (ObjectDisposedException) {
                }
            };

            new Thread(() => {
                int notMainThreadSmsCount = 1;
                System.Threading.Timer notMainThreadTimer = new System.Threading.Timer((sender) => {
                    mobile.ReceiveSMS($"SMS #{notMainThreadSmsCount++} NOT from Main thread.", "700");
                }, null, 500, 2000);
            }).Start();
        }

        private int smsCount = 1;
        private void timerInMainThread_Tick(object sender, System.EventArgs e) {
            mobile.ReceiveSMS($"SMS #{smsCount++} from Main thread.", "800");
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
            private readonly Func<bool> isUsed;

            public bool IsUsed => isUsed();

            public MessageCriteriaSelector(Func<Message, bool> predicate, Func<bool> isUsed) {
                Predicate = predicate;
                this.isUsed = isUsed;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            RefreshListView();
        }

        private void RefreshListView() {
            ListViewState state = GetListViewState(listViewMessages);

            ShowMessages(FilterMessages(messageHistoryCopy.GetRange(0, Math.Min(messageHistoryCopy.Count, MAXIMUM_OUTPUT))).ToList());

            RestoreState(listViewMessages, state);
        }

        private ListViewState GetListViewState(ListView listView) {
            ListViewState state = new ListViewState();
            state.TopItemIndex = listView.TopItem?.Index ?? 0;
            state.SelectedRowIds = new List<int>();
            foreach (ListViewItem item in listView.SelectedItems) {
                state.SelectedRowIds.Add(item.Index);
            }

            return state;
        }

        private void RestoreState(ListView listView, ListViewState state)
        {
            try {
                listViewMessages.TopItem = listView.Items[state.TopItemIndex];
                foreach (int selectedIx in state.SelectedRowIds) {
                    listView.Items[selectedIx].Selected = true;
                }
            } catch { }
        }

        private void ShowMessages(IEnumerable<Message> messages) {
            listViewMessages.BeginUpdate();

            listViewMessages.Items.Clear();

            foreach (Message message in messages) {
                listViewMessages.Items.Add(new ListViewItem(new[] { currentFormatter(message.Text), message.Number, message.ReceivingTime.ToString(CultureInfo.InvariantCulture) }));
            }

            listViewMessages.EndUpdate();
        }

        private class ListViewState {
            public int TopItemIndex { get; set; }
            public List<int> SelectedRowIds { get; set; }
        }

        private IEnumerable<Message> FilterMessages(IEnumerable<Message> messages) {
            return messages.Where((m) => {
                bool isUsed = false;
                bool isSelected = radioButtonAnd.Checked;

                foreach (MessageCriteriaSelector selector in criteriaSelectors) {
                    isUsed |= selector.IsUsed;

                    if (radioButtonAnd.Checked) {
                        isSelected &= !selector.IsUsed || selector.Predicate(m);
                    }
                    else {
                        isSelected |= selector.IsUsed && selector.Predicate(m);
                    }
                }

                return !isUsed || isSelected;
            });
        }
    }
}
