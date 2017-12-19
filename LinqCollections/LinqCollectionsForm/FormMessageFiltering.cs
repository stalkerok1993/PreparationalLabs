using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mobile.Formatter;

using Message = Mobile.Phone.NetworkServices.SMS.Message;

namespace LinqCollectionsForm {
    public partial class FormMessageFiltering : Form {
        public FormMessageFiltering() {
            InitializeComponent();

            comboBoxFormatter.SelectedIndex = 0;
            comboBoxFormatter.Items.AddRange(FormatterSimpleFactory.AvailableNames.ToArray());
        }

        public void ShowMessages(List<Message> messages)
        {
            listViewMessages.Items.Clear();
            foreach (Message message in messages)
            {
                listViewMessages.Items.Add(new ListViewItem(new[] {message.User, message.Text}));
            }
        }
    }
}
