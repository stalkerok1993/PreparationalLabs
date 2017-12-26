using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mobile.Date;
using Mobile.Formatter;

using Message = Mobile.Phone.NetworkServices.SMS.Message;

namespace LinqCollectionsForm {
    public partial class FormMessageFiltering : Form {
        public FormMessageFiltering() {
            InitializeComponent();

            comboBoxFormatter.SelectedIndex = 0;
            var formatterFactory = new FormatterSimpleFactory(new SystemDatePrivider());
            comboBoxFormatter.Items.AddRange(formatterFactory.AvailableNames.ToArray());
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
