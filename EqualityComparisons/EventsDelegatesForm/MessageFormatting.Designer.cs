namespace EventsDelegatesForm
{
    partial class MessageFormatting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxFormatters = new System.Windows.Forms.ComboBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.timerInMainThread = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBoxFormatters
            // 
            this.comboBoxFormatters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormatters.FormattingEnabled = true;
            this.comboBoxFormatters.Items.AddRange(new object[] {
            "None"});
            this.comboBoxFormatters.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFormatters.Name = "comboBoxFormatters";
            this.comboBoxFormatters.Size = new System.Drawing.Size(221, 21);
            this.comboBoxFormatters.TabIndex = 0;
            this.comboBoxFormatters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormatters_SelectedIndexChanged);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 39);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(374, 396);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // timerInMainThread
            // 
            this.timerInMainThread.Enabled = true;
            this.timerInMainThread.Interval = 5000;
            this.timerInMainThread.Tick += new System.EventHandler(this.timerInMainThread_Tick);
            // 
            // MessageFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 447);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.comboBoxFormatters);
            this.Name = "MessageFormatting";
            this.Text = "Message Formatting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormatters;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Timer timerInMainThread;
    }
}

