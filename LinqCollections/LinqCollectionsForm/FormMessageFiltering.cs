using Mobile.Formatter;
using Mobile.Output;
using Mobile.Phone;
using Mobile.Phone.NetworkServices.SMS.Filter;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static Mobile.Formatter.FormatterSimpleFactory;
using Message = Mobile.Phone.NetworkServices.SMS.Message;

namespace LinqCollectionsForm {
    public partial class FormMessageFiltering : Form {
        private readonly IOutput output = new NullOutput();
        private readonly MobileBase mobile;

        private readonly FormatterSimpleFactory formatterFactory = new FormatterSimpleFactory();
        private Formatter currentFormatter;

        private static SMSSelectorComposite compositeSelector = (SMSSelectorComposite)new SMSSelectorSimpleFactory().CreateSelector("CompositeSelector");
        private readonly SMSFilter filter = new SMSFilter(compositeSelector);

        private const int MAXIMUM_OUTPUT = 100;
        private List<Message> messageHistoryCopy;

        private readonly HashSet<string> phonesSet = new HashSet<string>();

        public FormMessageFiltering() {
            InitializeComponent();

            comboBoxFormatter.SelectedIndex = 0;
            comboBoxFormatter.Items.AddRange(formatterFactory.AvailableNames.ToArray());
            
            currentFormatter = formatterFactory.DefaultFormatter;

            mobile = new ModernMobile(output);
            mobile.SMSMessenger.MessageAdded += (message, isAdded) => {
                if (!phonesSet.Contains(message.Number)) {
                    phonesSet.Add(message.Number);
                    Invoke(new Action(() => comboBoxPhone.Items.Add(message.Number)));
                }

                if (mobile.SMSMessenger.MessageHistory.Count > MAXIMUM_OUTPUT) {
                    List<Message> temp = mobile.SMSMessenger.MessageHistory;
                    temp.RemoveRange(0, messageHistoryCopy.Count - MAXIMUM_OUTPUT);
                    messageHistoryCopy = temp;
                }
                else {
                    messageHistoryCopy = mobile.SMSMessenger.MessageHistory;
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

        private void buttonFilter_Click(object sender, EventArgs e) {
            RefreshListView();
        }

        private void RefreshListView() {
            ListViewState state = GetListViewState(listViewMessages);

            SMSSelectorData data = new SMSSelectorData(textBoxMessageContains.Text, comboBoxPhone.Text);
            data.ReceivedFrom = checkBoxReceivedAfter.Checked ? (DateTime?)dateTimePickerReceivedAfter.Value : null;
            data.ReceivedTo = checkBoxReceivedBefore.Checked ? (DateTime?)dateTimePickerReceivedBefore.Value : null;

            if (radioButtonAnd.Checked) {
                compositeSelector.SelectorBooleanFunction = SMSSelectorComposite.SelectorBoolFunc.And;
            }
            else {
                compositeSelector.SelectorBooleanFunction = SMSSelectorComposite.SelectorBoolFunc.Or;
            }

            List<Message> filtered = filter.Filter(messageHistoryCopy, data).ToList();
            IEnumerable<Message> displayed = filtered.GetRange(0, Math.Min(filtered.Count, MAXIMUM_OUTPUT));
            ShowMessages(displayed);

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
                listViewMessages.Items.Add(new ListViewItem(new[] {
                    currentFormatter(message),
                    message.Number,
                    message.ReceivedTime.ToString(CultureInfo.InvariantCulture) }));
            }

            listViewMessages.EndUpdate();
        }

        private class ListViewState {
            public int TopItemIndex { get; set; }
            public List<int> SelectedRowIds { get; set; }
        }
    }
}
