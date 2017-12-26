namespace LinqCollectionsForm {
    partial class FormMessageFiltering {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBoxFormatter = new System.Windows.Forms.ComboBox();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.textBoxMessageContains = new System.Windows.Forms.TextBox();
            this.dateTimePickerReceivedAfter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReceivedBefore = new System.Windows.Forms.DateTimePicker();
            this.labelReceivedAfter = new System.Windows.Forms.Label();
            this.labelReceivedBefore = new System.Windows.Forms.Label();
            this.labelMessageContains = new System.Windows.Forms.Label();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFormatter
            // 
            this.comboBoxFormatter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFormatter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormatter.FormattingEnabled = true;
            this.comboBoxFormatter.Items.AddRange(new object[] {
            "None"});
            this.comboBoxFormatter.Location = new System.Drawing.Point(114, 12);
            this.comboBoxFormatter.Name = "comboBoxFormatter";
            this.comboBoxFormatter.Size = new System.Drawing.Size(179, 21);
            this.comboBoxFormatter.TabIndex = 0;
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Location = new System.Drawing.Point(114, 39);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(179, 21);
            this.comboBoxPhone.TabIndex = 1;
            // 
            // textBoxMessageContains
            // 
            this.textBoxMessageContains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageContains.Location = new System.Drawing.Point(114, 66);
            this.textBoxMessageContains.Name = "textBoxMessageContains";
            this.textBoxMessageContains.Size = new System.Drawing.Size(179, 20);
            this.textBoxMessageContains.TabIndex = 2;
            // 
            // dateTimePickerReceivedAfter
            // 
            this.dateTimePickerReceivedAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReceivedAfter.Location = new System.Drawing.Point(114, 92);
            this.dateTimePickerReceivedAfter.Name = "dateTimePickerReceivedAfter";
            this.dateTimePickerReceivedAfter.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerReceivedAfter.TabIndex = 3;
            // 
            // dateTimePickerReceivedBefore
            // 
            this.dateTimePickerReceivedBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReceivedBefore.Location = new System.Drawing.Point(114, 118);
            this.dateTimePickerReceivedBefore.Name = "dateTimePickerReceivedBefore";
            this.dateTimePickerReceivedBefore.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerReceivedBefore.TabIndex = 4;
            // 
            // labelReceivedAfter
            // 
            this.labelReceivedAfter.AutoSize = true;
            this.labelReceivedAfter.Location = new System.Drawing.Point(12, 94);
            this.labelReceivedAfter.Name = "labelReceivedAfter";
            this.labelReceivedAfter.Size = new System.Drawing.Size(80, 13);
            this.labelReceivedAfter.TabIndex = 5;
            this.labelReceivedAfter.Text = "Received after:";
            // 
            // labelReceivedBefore
            // 
            this.labelReceivedBefore.AutoSize = true;
            this.labelReceivedBefore.Location = new System.Drawing.Point(12, 123);
            this.labelReceivedBefore.Name = "labelReceivedBefore";
            this.labelReceivedBefore.Size = new System.Drawing.Size(89, 13);
            this.labelReceivedBefore.TabIndex = 6;
            this.labelReceivedBefore.Text = "Received before:";
            // 
            // labelMessageContains
            // 
            this.labelMessageContains.AutoSize = true;
            this.labelMessageContains.Location = new System.Drawing.Point(12, 69);
            this.labelMessageContains.Name = "labelMessageContains";
            this.labelMessageContains.Size = new System.Drawing.Size(96, 13);
            this.labelMessageContains.TabIndex = 7;
            this.labelMessageContains.Text = "Message contains:";
            // 
            // listViewMessages
            // 
            this.listViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMessages.Location = new System.Drawing.Point(12, 144);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(281, 182);
            this.listViewMessages.TabIndex = 8;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Formatter:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 42);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Phone number:";
            // 
            // FormMessageFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 338);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.labelMessageContains);
            this.Controls.Add(this.labelReceivedBefore);
            this.Controls.Add(this.labelReceivedAfter);
            this.Controls.Add(this.dateTimePickerReceivedBefore);
            this.Controls.Add(this.dateTimePickerReceivedAfter);
            this.Controls.Add(this.textBoxMessageContains);
            this.Controls.Add(this.comboBoxPhone);
            this.Controls.Add(this.comboBoxFormatter);
            this.Name = "FormMessageFiltering";
            this.Text = "Message Filtering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormatter;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.TextBox textBoxMessageContains;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivedAfter;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivedBefore;
        private System.Windows.Forms.Label labelReceivedAfter;
        private System.Windows.Forms.Label labelReceivedBefore;
        private System.Windows.Forms.Label labelMessageContains;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPhoneNumber;
    }
}

