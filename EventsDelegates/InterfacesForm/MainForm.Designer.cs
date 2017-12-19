namespace InterfacesForm
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlaybacks = new System.Windows.Forms.TabPage();
            this.tabChargers = new System.Windows.Forms.TabPage();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.radioButtonPlaybackSpeaker = new System.Windows.Forms.RadioButton();
            this.radioButtonPlaybackIphone = new System.Windows.Forms.RadioButton();
            this.radioButtonPlaybackSamsung = new System.Windows.Forms.RadioButton();
            this.radioButtonPlaybackUnofficialIphone = new System.Windows.Forms.RadioButton();
            this.buttonPlaybackUnplug = new System.Windows.Forms.Button();
            this.buttonPlaybackPlug = new System.Windows.Forms.Button();
            this.radioButtonChargerFast = new System.Windows.Forms.RadioButton();
            this.radioButtonChargerUsb = new System.Windows.Forms.RadioButton();
            this.buttonChargerPlug = new System.Windows.Forms.Button();
            this.buttonChargerUnplug = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPlaybacks.SuspendLayout();
            this.tabChargers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPlaybacks);
            this.tabControl1.Controls.Add(this.tabChargers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 122);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlaybacks
            // 
            this.tabPlaybacks.Controls.Add(this.buttonPlaybackPlug);
            this.tabPlaybacks.Controls.Add(this.buttonPlaybackUnplug);
            this.tabPlaybacks.Controls.Add(this.radioButtonPlaybackUnofficialIphone);
            this.tabPlaybacks.Controls.Add(this.radioButtonPlaybackSamsung);
            this.tabPlaybacks.Controls.Add(this.radioButtonPlaybackIphone);
            this.tabPlaybacks.Controls.Add(this.radioButtonPlaybackSpeaker);
            this.tabPlaybacks.Location = new System.Drawing.Point(4, 22);
            this.tabPlaybacks.Name = "tabPlaybacks";
            this.tabPlaybacks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaybacks.Size = new System.Drawing.Size(252, 96);
            this.tabPlaybacks.TabIndex = 0;
            this.tabPlaybacks.Text = "Playbacks";
            this.tabPlaybacks.UseVisualStyleBackColor = true;
            // 
            // tabChargers
            // 
            this.tabChargers.Controls.Add(this.buttonChargerUnplug);
            this.tabChargers.Controls.Add(this.buttonChargerPlug);
            this.tabChargers.Controls.Add(this.radioButtonChargerUsb);
            this.tabChargers.Controls.Add(this.radioButtonChargerFast);
            this.tabChargers.Location = new System.Drawing.Point(4, 22);
            this.tabChargers.Name = "tabChargers";
            this.tabChargers.Padding = new System.Windows.Forms.Padding(3);
            this.tabChargers.Size = new System.Drawing.Size(202, 96);
            this.tabChargers.TabIndex = 1;
            this.tabChargers.Text = "Chargers";
            this.tabChargers.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 140);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(256, 209);
            this.textBoxOutput.TabIndex = 1;
            // 
            // radioButtonPlaybackSpeaker
            // 
            this.radioButtonPlaybackSpeaker.AutoSize = true;
            this.radioButtonPlaybackSpeaker.Checked = true;
            this.radioButtonPlaybackSpeaker.Location = new System.Drawing.Point(6, 6);
            this.radioButtonPlaybackSpeaker.Name = "radioButtonPlaybackSpeaker";
            this.radioButtonPlaybackSpeaker.Size = new System.Drawing.Size(104, 17);
            this.radioButtonPlaybackSpeaker.TabIndex = 0;
            this.radioButtonPlaybackSpeaker.TabStop = true;
            this.radioButtonPlaybackSpeaker.Text = "External speaker";
            this.radioButtonPlaybackSpeaker.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlaybackIphone
            // 
            this.radioButtonPlaybackIphone.AutoSize = true;
            this.radioButtonPlaybackIphone.Location = new System.Drawing.Point(6, 29);
            this.radioButtonPlaybackIphone.Name = "radioButtonPlaybackIphone";
            this.radioButtonPlaybackIphone.Size = new System.Drawing.Size(99, 17);
            this.radioButtonPlaybackIphone.TabIndex = 1;
            this.radioButtonPlaybackIphone.Text = "iPhone headset";
            this.radioButtonPlaybackIphone.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlaybackSamsung
            // 
            this.radioButtonPlaybackSamsung.AutoSize = true;
            this.radioButtonPlaybackSamsung.Location = new System.Drawing.Point(6, 52);
            this.radioButtonPlaybackSamsung.Name = "radioButtonPlaybackSamsung";
            this.radioButtonPlaybackSamsung.Size = new System.Drawing.Size(110, 17);
            this.radioButtonPlaybackSamsung.TabIndex = 2;
            this.radioButtonPlaybackSamsung.Text = "Samsung headset";
            this.radioButtonPlaybackSamsung.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlaybackUnofficialIphone
            // 
            this.radioButtonPlaybackUnofficialIphone.AutoSize = true;
            this.radioButtonPlaybackUnofficialIphone.Location = new System.Drawing.Point(6, 75);
            this.radioButtonPlaybackUnofficialIphone.Name = "radioButtonPlaybackUnofficialIphone";
            this.radioButtonPlaybackUnofficialIphone.Size = new System.Drawing.Size(146, 17);
            this.radioButtonPlaybackUnofficialIphone.TabIndex = 3;
            this.radioButtonPlaybackUnofficialIphone.Text = "Unofficial iPhone headset";
            this.radioButtonPlaybackUnofficialIphone.UseVisualStyleBackColor = true;
            // 
            // buttonPlaybackUnplug
            // 
            this.buttonPlaybackUnplug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaybackUnplug.Enabled = false;
            this.buttonPlaybackUnplug.Location = new System.Drawing.Point(171, 38);
            this.buttonPlaybackUnplug.Name = "buttonPlaybackUnplug";
            this.buttonPlaybackUnplug.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaybackUnplug.TabIndex = 4;
            this.buttonPlaybackUnplug.Text = "Unplug";
            this.buttonPlaybackUnplug.UseVisualStyleBackColor = true;
            this.buttonPlaybackUnplug.Click += new System.EventHandler(this.buttonPlaybackUnplug_Click);
            // 
            // buttonPlaybackPlug
            // 
            this.buttonPlaybackPlug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaybackPlug.Location = new System.Drawing.Point(171, 67);
            this.buttonPlaybackPlug.Name = "buttonPlaybackPlug";
            this.buttonPlaybackPlug.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaybackPlug.TabIndex = 5;
            this.buttonPlaybackPlug.Text = "Plug";
            this.buttonPlaybackPlug.UseVisualStyleBackColor = true;
            this.buttonPlaybackPlug.Click += new System.EventHandler(this.buttonPlaybackPlug_Click);
            // 
            // radioButtonChargerFast
            // 
            this.radioButtonChargerFast.AutoSize = true;
            this.radioButtonChargerFast.Checked = true;
            this.radioButtonChargerFast.Location = new System.Drawing.Point(6, 6);
            this.radioButtonChargerFast.Name = "radioButtonChargerFast";
            this.radioButtonChargerFast.Size = new System.Drawing.Size(84, 17);
            this.radioButtonChargerFast.TabIndex = 0;
            this.radioButtonChargerFast.TabStop = true;
            this.radioButtonChargerFast.Text = "Fast charger";
            this.radioButtonChargerFast.UseVisualStyleBackColor = true;
            // 
            // radioButtonChargerUsb
            // 
            this.radioButtonChargerUsb.AutoSize = true;
            this.radioButtonChargerUsb.Location = new System.Drawing.Point(6, 29);
            this.radioButtonChargerUsb.Name = "radioButtonChargerUsb";
            this.radioButtonChargerUsb.Size = new System.Drawing.Size(86, 17);
            this.radioButtonChargerUsb.TabIndex = 1;
            this.radioButtonChargerUsb.Text = "USB charger";
            this.radioButtonChargerUsb.UseVisualStyleBackColor = true;
            // 
            // buttonChargerPlug
            // 
            this.buttonChargerPlug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChargerPlug.Location = new System.Drawing.Point(121, 67);
            this.buttonChargerPlug.Name = "buttonChargerPlug";
            this.buttonChargerPlug.Size = new System.Drawing.Size(75, 23);
            this.buttonChargerPlug.TabIndex = 2;
            this.buttonChargerPlug.Text = "Plug";
            this.buttonChargerPlug.UseVisualStyleBackColor = true;
            this.buttonChargerPlug.Click += new System.EventHandler(this.buttonChargerPlug_Click);
            // 
            // buttonChargerUnplug
            // 
            this.buttonChargerUnplug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChargerUnplug.Enabled = false;
            this.buttonChargerUnplug.Location = new System.Drawing.Point(121, 38);
            this.buttonChargerUnplug.Name = "buttonChargerUnplug";
            this.buttonChargerUnplug.Size = new System.Drawing.Size(75, 23);
            this.buttonChargerUnplug.TabIndex = 3;
            this.buttonChargerUnplug.Text = "Unplug";
            this.buttonChargerUnplug.UseVisualStyleBackColor = true;
            this.buttonChargerUnplug.Click += new System.EventHandler(this.buttonChargerUnplug_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "MainForm";
            this.Text = "WinForms Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPlaybacks.ResumeLayout(false);
            this.tabPlaybacks.PerformLayout();
            this.tabChargers.ResumeLayout(false);
            this.tabChargers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlaybacks;
        private System.Windows.Forms.Button buttonPlaybackPlug;
        private System.Windows.Forms.Button buttonPlaybackUnplug;
        private System.Windows.Forms.RadioButton radioButtonPlaybackUnofficialIphone;
        private System.Windows.Forms.RadioButton radioButtonPlaybackSamsung;
        private System.Windows.Forms.RadioButton radioButtonPlaybackIphone;
        private System.Windows.Forms.RadioButton radioButtonPlaybackSpeaker;
        private System.Windows.Forms.TabPage tabChargers;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonChargerUnplug;
        private System.Windows.Forms.Button buttonChargerPlug;
        private System.Windows.Forms.RadioButton radioButtonChargerUsb;
        private System.Windows.Forms.RadioButton radioButtonChargerFast;
    }
}

