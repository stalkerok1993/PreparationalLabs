namespace EqualityComparisons {
    partial class FormCallList {
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
            this.buttonToggleIncoming = new System.Windows.Forms.Button();
            this.listViewCalls = new System.Windows.Forms.ListView();
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.labelCalling = new System.Windows.Forms.Label();
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.buttonCall = new System.Windows.Forms.Button();
            this.timerIncomingCalls = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonToggleIncoming
            // 
            this.buttonToggleIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToggleIncoming.Location = new System.Drawing.Point(12, 12);
            this.buttonToggleIncoming.Name = "buttonToggleIncoming";
            this.buttonToggleIncoming.Size = new System.Drawing.Size(546, 23);
            this.buttonToggleIncoming.TabIndex = 0;
            this.buttonToggleIncoming.Text = "Stop incoming calls";
            this.buttonToggleIncoming.UseVisualStyleBackColor = true;
            this.buttonToggleIncoming.Click += new System.EventHandler(this.ButtonToggleIncoming_Click);
            // 
            // listViewCalls
            // 
            this.listViewCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderType,
            this.columnHeaderName,
            this.columnHeaderPhone,
            this.columnHeaderTime,
            this.columnHeaderDuration});
            this.listViewCalls.Location = new System.Drawing.Point(12, 132);
            this.listViewCalls.Name = "listViewCalls";
            this.listViewCalls.Size = new System.Drawing.Size(546, 283);
            this.listViewCalls.TabIndex = 1;
            this.listViewCalls.UseCompatibleStateImageBehavior = false;
            this.listViewCalls.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 80;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 80;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Phone";
            this.columnHeaderPhone.Width = 120;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 120;
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Duration";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(12, 76);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(463, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReject.Enabled = false;
            this.buttonReject.Location = new System.Drawing.Point(481, 76);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(77, 23);
            this.buttonReject.TabIndex = 3;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.ButtonReject_Click);
            // 
            // labelCalling
            // 
            this.labelCalling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCalling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalling.Location = new System.Drawing.Point(12, 38);
            this.labelCalling.Name = "labelCalling";
            this.labelCalling.Size = new System.Drawing.Size(546, 35);
            this.labelCalling.TabIndex = 4;
            this.labelCalling.Text = "-";
            this.labelCalling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumbers.FormattingEnabled = true;
            this.comboBoxNumbers.Location = new System.Drawing.Point(12, 105);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(463, 21);
            this.comboBoxNumbers.TabIndex = 5;
            // 
            // buttonCall
            // 
            this.buttonCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCall.Location = new System.Drawing.Point(481, 104);
            this.buttonCall.Name = "buttonCall";
            this.buttonCall.Size = new System.Drawing.Size(77, 22);
            this.buttonCall.TabIndex = 6;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new System.EventHandler(this.ButtonCall_Click);
            // 
            // timerIncomingCalls
            // 
            this.timerIncomingCalls.Enabled = true;
            this.timerIncomingCalls.Interval = 5000;
            this.timerIncomingCalls.Tick += new System.EventHandler(this.TimerIncomingCalls_Tick);
            // 
            // FormCallList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 427);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.comboBoxNumbers);
            this.Controls.Add(this.labelCalling);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.listViewCalls);
            this.Controls.Add(this.buttonToggleIncoming);
            this.Name = "FormCallList";
            this.Text = "Call List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToggleIncoming;
        private System.Windows.Forms.ListView listViewCalls;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Label labelCalling;
        private System.Windows.Forms.ComboBox comboBoxNumbers;
        private System.Windows.Forms.Button buttonCall;
        private System.Windows.Forms.Timer timerIncomingCalls;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
    }
}

