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
            this.components = new System.ComponentModel.Container();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.radioButtonOr = new System.Windows.Forms.RadioButton();
            this.radioButtonAnd = new System.Windows.Forms.RadioButton();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.checkBoxReceivedBefore = new System.Windows.Forms.CheckBox();
            this.checkBoxReceivedAfter = new System.Windows.Forms.CheckBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeaderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMessageContains = new System.Windows.Forms.Label();
            this.labelReceivedBefore = new System.Windows.Forms.Label();
            this.labelReceivedAfter = new System.Windows.Forms.Label();
            this.dateTimePickerReceivedBefore = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReceivedAfter = new System.Windows.Forms.DateTimePicker();
            this.textBoxMessageContains = new System.Windows.Forms.TextBox();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.comboBoxFormatter = new System.Windows.Forms.ComboBox();
            this.timerInMainThread = new System.Windows.Forms.Timer(this.components);
            this.groupBoxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFunctions.Controls.Add(this.radioButtonOr);
            this.groupBoxFunctions.Controls.Add(this.radioButtonAnd);
            this.groupBoxFunctions.Location = new System.Drawing.Point(275, 12);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(118, 70);
            this.groupBoxFunctions.TabIndex = 30;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Between conditions";
            // 
            // radioButtonOr
            // 
            this.radioButtonOr.AutoSize = true;
            this.radioButtonOr.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOr.Name = "radioButtonOr";
            this.radioButtonOr.Size = new System.Drawing.Size(104, 17);
            this.radioButtonOr.TabIndex = 14;
            this.radioButtonOr.Text = "Use OR function";
            this.radioButtonOr.UseVisualStyleBackColor = true;
            this.radioButtonOr.CheckedChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // radioButtonAnd
            // 
            this.radioButtonAnd.AutoSize = true;
            this.radioButtonAnd.Checked = true;
            this.radioButtonAnd.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAnd.Name = "radioButtonAnd";
            this.radioButtonAnd.Size = new System.Drawing.Size(111, 17);
            this.radioButtonAnd.TabIndex = 13;
            this.radioButtonAnd.TabStop = true;
            this.radioButtonAnd.Text = "Use AND function";
            this.radioButtonAnd.UseVisualStyleBackColor = true;
            this.radioButtonAnd.CheckedChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Location = new System.Drawing.Point(15, 139);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(377, 23);
            this.buttonFilter.TabIndex = 31;
            this.buttonFilter.Text = "Apply filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // checkBoxReceivedBefore
            // 
            this.checkBoxReceivedBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceivedBefore.AutoSize = true;
            this.checkBoxReceivedBefore.Location = new System.Drawing.Point(378, 122);
            this.checkBoxReceivedBefore.Name = "checkBoxReceivedBefore";
            this.checkBoxReceivedBefore.Size = new System.Drawing.Size(15, 14);
            this.checkBoxReceivedBefore.TabIndex = 29;
            this.checkBoxReceivedBefore.UseVisualStyleBackColor = true;
            this.checkBoxReceivedBefore.CheckedChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // checkBoxReceivedAfter
            // 
            this.checkBoxReceivedAfter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxReceivedAfter.AutoSize = true;
            this.checkBoxReceivedAfter.Location = new System.Drawing.Point(378, 94);
            this.checkBoxReceivedAfter.Name = "checkBoxReceivedAfter";
            this.checkBoxReceivedAfter.Size = new System.Drawing.Size(15, 14);
            this.checkBoxReceivedAfter.TabIndex = 28;
            this.checkBoxReceivedAfter.UseVisualStyleBackColor = true;
            this.checkBoxReceivedAfter.CheckedChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(12, 42);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.labelPhoneNumber.TabIndex = 27;
            this.labelPhoneNumber.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Formatter:";
            // 
            // columnHeaderText
            // 
            this.columnHeaderText.Text = "Text";
            this.columnHeaderText.Width = 180;
            // 
            // listViewMessages
            // 
            this.listViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderText,
            this.columnHeaderNumber,
            this.columnHeaderTime});
            this.listViewMessages.FullRowSelect = true;
            this.listViewMessages.Location = new System.Drawing.Point(12, 168);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(381, 158);
            this.listViewMessages.TabIndex = 25;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Number";
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 120;
            // 
            // labelMessageContains
            // 
            this.labelMessageContains.AutoSize = true;
            this.labelMessageContains.Location = new System.Drawing.Point(12, 69);
            this.labelMessageContains.Name = "labelMessageContains";
            this.labelMessageContains.Size = new System.Drawing.Size(96, 13);
            this.labelMessageContains.TabIndex = 24;
            this.labelMessageContains.Text = "Message contains:";
            // 
            // labelReceivedBefore
            // 
            this.labelReceivedBefore.AutoSize = true;
            this.labelReceivedBefore.Location = new System.Drawing.Point(12, 123);
            this.labelReceivedBefore.Name = "labelReceivedBefore";
            this.labelReceivedBefore.Size = new System.Drawing.Size(89, 13);
            this.labelReceivedBefore.TabIndex = 23;
            this.labelReceivedBefore.Text = "Received before:";
            // 
            // labelReceivedAfter
            // 
            this.labelReceivedAfter.AutoSize = true;
            this.labelReceivedAfter.Location = new System.Drawing.Point(12, 94);
            this.labelReceivedAfter.Name = "labelReceivedAfter";
            this.labelReceivedAfter.Size = new System.Drawing.Size(80, 13);
            this.labelReceivedAfter.TabIndex = 22;
            this.labelReceivedAfter.Text = "Received after:";
            // 
            // dateTimePickerReceivedBefore
            // 
            this.dateTimePickerReceivedBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReceivedBefore.Location = new System.Drawing.Point(114, 118);
            this.dateTimePickerReceivedBefore.Name = "dateTimePickerReceivedBefore";
            this.dateTimePickerReceivedBefore.Size = new System.Drawing.Size(258, 20);
            this.dateTimePickerReceivedBefore.TabIndex = 21;
            this.dateTimePickerReceivedBefore.ValueChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // dateTimePickerReceivedAfter
            // 
            this.dateTimePickerReceivedAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReceivedAfter.Location = new System.Drawing.Point(114, 92);
            this.dateTimePickerReceivedAfter.Name = "dateTimePickerReceivedAfter";
            this.dateTimePickerReceivedAfter.Size = new System.Drawing.Size(258, 20);
            this.dateTimePickerReceivedAfter.TabIndex = 20;
            this.dateTimePickerReceivedAfter.ValueChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxMessageContains
            // 
            this.textBoxMessageContains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageContains.Location = new System.Drawing.Point(114, 66);
            this.textBoxMessageContains.Name = "textBoxMessageContains";
            this.textBoxMessageContains.Size = new System.Drawing.Size(155, 20);
            this.textBoxMessageContains.TabIndex = 19;
            this.textBoxMessageContains.TextChanged += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Location = new System.Drawing.Point(114, 39);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(155, 21);
            this.comboBoxPhone.TabIndex = 18;
            this.comboBoxPhone.TextChanged += new System.EventHandler(this.buttonFilter_Click);
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
            this.comboBoxFormatter.Size = new System.Drawing.Size(155, 21);
            this.comboBoxFormatter.TabIndex = 17;
            this.comboBoxFormatter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormatters_SelectedIndexChanged);
            // 
            // timerInMainThread
            // 
            this.timerInMainThread.Enabled = true;
            this.timerInMainThread.Interval = 3000;
            this.timerInMainThread.Tick += new System.EventHandler(this.timerInMainThread_Tick);
            // 
            // FormMessageFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 338);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.checkBoxReceivedBefore);
            this.Controls.Add(this.checkBoxReceivedAfter);
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
            this.groupBoxFunctions.ResumeLayout(false);
            this.groupBoxFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.RadioButton radioButtonOr;
        private System.Windows.Forms.RadioButton radioButtonAnd;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxReceivedBefore;
        private System.Windows.Forms.CheckBox checkBoxReceivedAfter;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeaderText;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.Label labelMessageContains;
        private System.Windows.Forms.Label labelReceivedBefore;
        private System.Windows.Forms.Label labelReceivedAfter;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivedBefore;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivedAfter;
        private System.Windows.Forms.TextBox textBoxMessageContains;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxFormatter;
        private System.Windows.Forms.Timer timerInMainThread;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
    }
}

