using Mobile.Phone.Components.CallList;
using Mobile.Phone.Components.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EqualityComparisons {
    public partial class FormCallList : Form {
        private readonly Random random = new Random(DateTime.Now.Millisecond);
        private readonly List<Contact> contacts = new List<Contact>() {
            new Contact("Contact1", "+380999999999"),
            new Contact("Contact2", "+380888888888"),
            new Contact("Contact3", "+380777777777", "+380666666666", "+380555555555"),
        };
        private readonly List<string> phoneNumbers = new List<string>();
        private readonly SortedList<Call> calls = new SortedList<Call>();
        private Call currentCall = null;
        private string calling = null;
        private bool isIncoming = false;

        public FormCallList() {
            InitializeComponent();

            foreach (Contact contact in contacts) {
                phoneNumbers.AddRange(contact.Phones);
            }
            comboBoxNumbers.Items.AddRange(phoneNumbers.ToArray());
            comboBoxNumbers.SelectedIndex = 0;
        }

        private void TimerIncomingCalls_Tick(object sender, EventArgs e) {
            if (GetCallState() == CallState.Ringing) {
                RejectCall();
                return;
            }

            calling = phoneNumbers[random.Next(0, phoneNumbers.Count)];

            UpdateControlsState();
        }

        private void UpdateControlsState() {
            buttonAccept.Enabled = calling != null && currentCall == null;
            buttonReject.Enabled = calling != null;
            buttonCall.Enabled = !buttonReject.Enabled;
            comboBoxNumbers.Enabled = buttonCall.Enabled;

            if (calling == null) {
                labelCalling.Text = "-";
                buttonReject.Text = "Reject";
                return;
            }
            if (currentCall == null) {
                Contact callingContact = FindContact(calling);
                labelCalling.Text = "Calling: " + callingContact?.Name ?? calling;
                buttonReject.Text = "Reject";
                comboBoxNumbers.Text = calling;
            }
            else {
                labelCalling.Text = (currentCall.IsIncoming ? "Incoming" : "Outgoing") + ": " + currentCall.Contact?.Name ?? calling;
                buttonReject.Text = "End";
                comboBoxNumbers.Text = calling ?? currentCall.CallTime.Last().Number ?? "";
            }
        }

        private void ButtonToggleIncoming_Click(object sender, EventArgs e) {
            timerIncomingCalls.Enabled = !timerIncomingCalls.Enabled;
            buttonToggleIncoming.Text = timerIncomingCalls.Enabled ? "Stop incoming calls" : "Start incoming calls";
        }

        private void ButtonAccept_Click(object sender, EventArgs e) {
            if (calling == null) {
                return;
            }

            currentCall = new Call(FindContact(calling, true), calling, DateTime.Now, true);

            UpdateControlsState();
        }

        public Contact FindContact(string number, bool createTemporary = false) {
            Contact saved = contacts.Where((c) => c.Phones.Contains(calling))?.First();
            if (saved == null && createTemporary) {
                return new Contact(null, number);
            }

            return saved;
        }

        private void ButtonReject_Click(object sender, EventArgs e) {
            RejectCall();
        }

        private void RejectCall() {
            DateTime now = DateTime.Now;
            if (calling != null) {
                if (currentCall == null) {
                    currentCall = new Call(FindContact(calling, true), calling, now, true);
                }
                CallTime callTime = currentCall.CallTime.Last();
                callTime.DurationMs = now.Subtract(callTime.Time).Milliseconds;

                if (calls.Count > 0 && currentCall.Equals(calls.First())) {
                    calls.First().CallTime.AddRange(currentCall.CallTime);
                }
                else {
                    calls.Add(currentCall);
                }

                currentCall = null;
                calling = null;
                isIncoming = false;

                UpdateControlsState();
                UpdateList();
            }
        }

        private CallState GetCallState() {
            if (calling == null) {
                return CallState.Empty;
            }
            if (currentCall == null) {
                if (isIncoming) {
                    return CallState.Ringing;
                }
                else {
                    return CallState.Calling;
                }
            }
            else {
                return CallState.Connected;
            }
        }

        private enum CallState {
            Empty,
            Ringing,
            Calling,
            Connected
        }

        private void ButtonCall_Click(object sender, EventArgs e) {
            isIncoming = false;
            calling = comboBoxNumbers.Text;
            currentCall = new Call(contacts.Where((c) => c.Phones.Contains(calling)).First(), calling, DateTime.Now, isIncoming);

            UpdateControlsState();
        }

        private void UpdateList() {
            listViewCalls.BeginUpdate();
            ListViewState state = GetListViewState(listViewCalls);

            listViewCalls.Items.Clear();
            foreach (Call call in calls) {
                listViewCalls.Items.Add(new ListViewItem(new[] { GetCallType(call), call.Contact?.Name ?? "",
                    call.CallTime.Last().Number, call.CallTime.Last().Time.ToString(),
                    ((float)call.CallTime.Last().DurationMs / 100).ToString("F2")}));
            }

            listViewCalls.EndUpdate();
            RestoreListViewState(listViewCalls, state);
        }

        private string GetCallType(Call call) {
            if (call.IsIncoming) {
                if (call.CallTime.Last().DurationMs > 0) {
                    return "Incoming";
                }
                else {
                    return "Missed";
                }
            }
            else {
                return "Outgoing";
            }
        }

        private ListViewState GetListViewState(ListView listView) {
            ListViewState state = new ListViewState {
                TopItemIndex = listView.TopItem?.Index ?? 0,
                SelectedRowIds = new List<int>()
            };
            foreach (ListViewItem item in listView.SelectedItems) {
                state.SelectedRowIds.Add(item.Index);
            }

            return state;
        }

        private void RestoreListViewState(ListView listView, ListViewState state) {
            try {
                listView.TopItem = listView.Items[state.TopItemIndex];
                foreach (int selectedIx in state.SelectedRowIds) {
                    listView.Items[selectedIx].Selected = true;
                }
            }
            catch { }
        }

        private class ListViewState {
            public int TopItemIndex { get; set; }
            public List<int> SelectedRowIds { get; set; }
        }
    }
}
