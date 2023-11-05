namespace AutoClicker
{
    partial class AutoClicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClicker));
            accessMenuStrip = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            clickIntervalBox = new GroupBox();
            millisecsLabel = new Label();
            millisecsUpDown = new NumericUpDown();
            hoursUpDown = new NumericUpDown();
            secsLabel = new Label();
            hoursLabel = new Label();
            secsUpDown = new NumericUpDown();
            minsUpDown = new NumericUpDown();
            minsLabel = new Label();
            clickOptionsBox = new GroupBox();
            clickTypeComboBox = new ComboBox();
            mouseBtnComboBox = new ComboBox();
            clickTypeLabel = new Label();
            mouseBtnLabel = new Label();
            clickRepeatBox = new GroupBox();
            repeatTimesLabel = new Label();
            repeatUntilRadioBtn = new RadioButton();
            repeatTimesRadioBtn = new RadioButton();
            timesCounterLabel = new Label();
            counterLabel = new Label();
            repeatUpDown = new NumericUpDown();
            cursorPositionBox = new GroupBox();
            coordinateYupDown = new NumericUpDown();
            coordinateXupDown = new NumericUpDown();
            coordinateYlabel = new Label();
            coordinateXlabel = new Label();
            pickLocationBtn = new Button();
            startBtn = new Button();
            stopBtn = new Button();
            settingsBtn = new Button();
            accessMenuStrip.SuspendLayout();
            clickIntervalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)millisecsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minsUpDown).BeginInit();
            clickOptionsBox.SuspendLayout();
            clickRepeatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repeatUpDown).BeginInit();
            cursorPositionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coordinateYupDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coordinateXupDown).BeginInit();
            SuspendLayout();
            // 
            // accessMenuStrip
            // 
            accessMenuStrip.BackColor = Color.FromArgb(224, 224, 224);
            accessMenuStrip.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            accessMenuStrip.Location = new Point(0, 0);
            accessMenuStrip.Name = "accessMenuStrip";
            accessMenuStrip.Size = new Size(487, 24);
            accessMenuStrip.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // clickIntervalBox
            // 
            clickIntervalBox.Controls.Add(millisecsLabel);
            clickIntervalBox.Controls.Add(millisecsUpDown);
            clickIntervalBox.Controls.Add(hoursUpDown);
            clickIntervalBox.Controls.Add(secsLabel);
            clickIntervalBox.Controls.Add(hoursLabel);
            clickIntervalBox.Controls.Add(secsUpDown);
            clickIntervalBox.Controls.Add(minsUpDown);
            clickIntervalBox.Controls.Add(minsLabel);
            clickIntervalBox.Location = new Point(12, 27);
            clickIntervalBox.Name = "clickIntervalBox";
            clickIntervalBox.Size = new Size(463, 55);
            clickIntervalBox.TabIndex = 1;
            clickIntervalBox.TabStop = false;
            clickIntervalBox.Text = "Click Interval";
            // 
            // millisecsLabel
            // 
            millisecsLabel.AutoSize = true;
            millisecsLabel.Location = new Point(387, 24);
            millisecsLabel.Name = "millisecsLabel";
            millisecsLabel.Size = new Size(52, 15);
            millisecsLabel.TabIndex = 9;
            millisecsLabel.Text = "millisecs";
            // 
            // millisecsUpDown
            // 
            millisecsUpDown.Location = new Point(332, 22);
            millisecsUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            millisecsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            millisecsUpDown.Name = "millisecsUpDown";
            millisecsUpDown.Size = new Size(49, 23);
            millisecsUpDown.TabIndex = 8;
            millisecsUpDown.TextAlign = HorizontalAlignment.Center;
            millisecsUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // hoursUpDown
            // 
            hoursUpDown.Location = new Point(25, 22);
            hoursUpDown.Name = "hoursUpDown";
            hoursUpDown.Size = new Size(49, 23);
            hoursUpDown.TabIndex = 2;
            hoursUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // secsLabel
            // 
            secsLabel.AutoSize = true;
            secsLabel.Location = new Point(288, 24);
            secsLabel.Name = "secsLabel";
            secsLabel.Size = new Size(29, 15);
            secsLabel.TabIndex = 7;
            secsLabel.Text = "secs";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(80, 24);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(37, 15);
            hoursLabel.TabIndex = 3;
            hoursLabel.Text = "hours";
            // 
            // secsUpDown
            // 
            secsUpDown.Location = new Point(233, 22);
            secsUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secsUpDown.Name = "secsUpDown";
            secsUpDown.Size = new Size(49, 23);
            secsUpDown.TabIndex = 6;
            secsUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // minsUpDown
            // 
            minsUpDown.Location = new Point(134, 22);
            minsUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minsUpDown.Name = "minsUpDown";
            minsUpDown.Size = new Size(49, 23);
            minsUpDown.TabIndex = 4;
            minsUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // minsLabel
            // 
            minsLabel.AutoSize = true;
            minsLabel.Location = new Point(189, 24);
            minsLabel.Name = "minsLabel";
            minsLabel.Size = new Size(33, 15);
            minsLabel.TabIndex = 5;
            minsLabel.Text = "mins";
            // 
            // clickOptionsBox
            // 
            clickOptionsBox.Controls.Add(clickTypeComboBox);
            clickOptionsBox.Controls.Add(mouseBtnComboBox);
            clickOptionsBox.Controls.Add(clickTypeLabel);
            clickOptionsBox.Controls.Add(mouseBtnLabel);
            clickOptionsBox.Location = new Point(12, 88);
            clickOptionsBox.Name = "clickOptionsBox";
            clickOptionsBox.Size = new Size(200, 100);
            clickOptionsBox.TabIndex = 2;
            clickOptionsBox.TabStop = false;
            clickOptionsBox.Text = "Click Options";
            // 
            // clickTypeComboBox
            // 
            clickTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            clickTypeComboBox.FormattingEnabled = true;
            clickTypeComboBox.Items.AddRange(new object[] { "Single", "Double" });
            clickTypeComboBox.Location = new Point(112, 60);
            clickTypeComboBox.Name = "clickTypeComboBox";
            clickTypeComboBox.Size = new Size(74, 23);
            clickTypeComboBox.TabIndex = 13;
            // 
            // mouseBtnComboBox
            // 
            mouseBtnComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            mouseBtnComboBox.FormattingEnabled = true;
            mouseBtnComboBox.Items.AddRange(new object[] { "Left", "Right" });
            mouseBtnComboBox.Location = new Point(112, 27);
            mouseBtnComboBox.Name = "mouseBtnComboBox";
            mouseBtnComboBox.Size = new Size(74, 23);
            mouseBtnComboBox.TabIndex = 12;
            // 
            // clickTypeLabel
            // 
            clickTypeLabel.AutoSize = true;
            clickTypeLabel.Location = new Point(21, 63);
            clickTypeLabel.Name = "clickTypeLabel";
            clickTypeLabel.Size = new Size(63, 15);
            clickTypeLabel.TabIndex = 11;
            clickTypeLabel.Text = "Click Type:";
            // 
            // mouseBtnLabel
            // 
            mouseBtnLabel.AutoSize = true;
            mouseBtnLabel.Location = new Point(21, 30);
            mouseBtnLabel.Name = "mouseBtnLabel";
            mouseBtnLabel.Size = new Size(85, 15);
            mouseBtnLabel.TabIndex = 10;
            mouseBtnLabel.Text = "Mouse Button:";
            // 
            // clickRepeatBox
            // 
            clickRepeatBox.Controls.Add(repeatTimesLabel);
            clickRepeatBox.Controls.Add(repeatUntilRadioBtn);
            clickRepeatBox.Controls.Add(repeatTimesRadioBtn);
            clickRepeatBox.Controls.Add(timesCounterLabel);
            clickRepeatBox.Controls.Add(counterLabel);
            clickRepeatBox.Controls.Add(repeatUpDown);
            clickRepeatBox.Location = new Point(218, 88);
            clickRepeatBox.Name = "clickRepeatBox";
            clickRepeatBox.Size = new Size(257, 100);
            clickRepeatBox.TabIndex = 3;
            clickRepeatBox.TabStop = false;
            clickRepeatBox.Text = "Click Repeat";
            // 
            // repeatTimesLabel
            // 
            repeatTimesLabel.AutoSize = true;
            repeatTimesLabel.Location = new Point(188, 22);
            repeatTimesLabel.Name = "repeatTimesLabel";
            repeatTimesLabel.Size = new Size(36, 15);
            repeatTimesLabel.TabIndex = 10;
            repeatTimesLabel.Text = "times";
            // 
            // repeatUntilRadioBtn
            // 
            repeatUntilRadioBtn.AutoSize = true;
            repeatUntilRadioBtn.Checked = true;
            repeatUntilRadioBtn.Location = new Point(23, 47);
            repeatUntilRadioBtn.Name = "repeatUntilRadioBtn";
            repeatUntilRadioBtn.Size = new Size(134, 19);
            repeatUntilRadioBtn.TabIndex = 15;
            repeatUntilRadioBtn.TabStop = true;
            repeatUntilRadioBtn.Text = "Repeat until stopped";
            repeatUntilRadioBtn.UseVisualStyleBackColor = true;
            repeatUntilRadioBtn.CheckedChanged += RepeatUntilRadioBtn_CheckedChanged;
            // 
            // repeatTimesRadioBtn
            // 
            repeatTimesRadioBtn.AutoSize = true;
            repeatTimesRadioBtn.Location = new Point(23, 22);
            repeatTimesRadioBtn.Name = "repeatTimesRadioBtn";
            repeatTimesRadioBtn.Size = new Size(61, 19);
            repeatTimesRadioBtn.TabIndex = 14;
            repeatTimesRadioBtn.Text = "Repeat";
            repeatTimesRadioBtn.UseVisualStyleBackColor = true;
            repeatTimesRadioBtn.CheckedChanged += RepeatTimesRadioBtn_CheckedChanged;
            // 
            // timesCounterLabel
            // 
            timesCounterLabel.AutoSize = true;
            timesCounterLabel.Location = new Point(64, 71);
            timesCounterLabel.Name = "timesCounterLabel";
            timesCounterLabel.Size = new Size(13, 15);
            timesCounterLabel.TabIndex = 13;
            timesCounterLabel.Text = "0";
            // 
            // counterLabel
            // 
            counterLabel.AutoSize = true;
            counterLabel.Location = new Point(23, 71);
            counterLabel.Name = "counterLabel";
            counterLabel.Size = new Size(41, 15);
            counterLabel.TabIndex = 12;
            counterLabel.Text = "Clicks:";
            // 
            // repeatUpDown
            // 
            repeatUpDown.Enabled = false;
            repeatUpDown.Location = new Point(108, 20);
            repeatUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            repeatUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            repeatUpDown.Name = "repeatUpDown";
            repeatUpDown.Size = new Size(74, 23);
            repeatUpDown.TabIndex = 10;
            repeatUpDown.TextAlign = HorizontalAlignment.Center;
            repeatUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cursorPositionBox
            // 
            cursorPositionBox.Controls.Add(coordinateYupDown);
            cursorPositionBox.Controls.Add(coordinateXupDown);
            cursorPositionBox.Controls.Add(coordinateYlabel);
            cursorPositionBox.Controls.Add(coordinateXlabel);
            cursorPositionBox.Controls.Add(pickLocationBtn);
            cursorPositionBox.Location = new Point(12, 194);
            cursorPositionBox.Name = "cursorPositionBox";
            cursorPositionBox.Size = new Size(463, 83);
            cursorPositionBox.TabIndex = 4;
            cursorPositionBox.TabStop = false;
            cursorPositionBox.Text = "Cursor Position";
            // 
            // coordinateYupDown
            // 
            coordinateYupDown.Location = new Point(383, 50);
            coordinateYupDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            coordinateYupDown.Minimum = new decimal(new int[] { 5000, 0, 0, int.MinValue });
            coordinateYupDown.Name = "coordinateYupDown";
            coordinateYupDown.Size = new Size(74, 23);
            coordinateYupDown.TabIndex = 16;
            coordinateYupDown.TextAlign = HorizontalAlignment.Center;
            // 
            // coordinateXupDown
            // 
            coordinateXupDown.Location = new Point(383, 18);
            coordinateXupDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            coordinateXupDown.Minimum = new decimal(new int[] { 5000, 0, 0, int.MinValue });
            coordinateXupDown.Name = "coordinateXupDown";
            coordinateXupDown.Size = new Size(74, 23);
            coordinateXupDown.TabIndex = 10;
            coordinateXupDown.TextAlign = HorizontalAlignment.Center;
            // 
            // coordinateYlabel
            // 
            coordinateYlabel.AutoSize = true;
            coordinateYlabel.Location = new Point(360, 56);
            coordinateYlabel.Name = "coordinateYlabel";
            coordinateYlabel.Size = new Size(17, 15);
            coordinateYlabel.TabIndex = 15;
            coordinateYlabel.Text = "Y:";
            // 
            // coordinateXlabel
            // 
            coordinateXlabel.AutoSize = true;
            coordinateXlabel.Location = new Point(360, 20);
            coordinateXlabel.Name = "coordinateXlabel";
            coordinateXlabel.Size = new Size(17, 15);
            coordinateXlabel.TabIndex = 14;
            coordinateXlabel.Text = "X:";
            // 
            // pickLocationBtn
            // 
            pickLocationBtn.Location = new Point(6, 19);
            pickLocationBtn.Name = "pickLocationBtn";
            pickLocationBtn.Size = new Size(333, 52);
            pickLocationBtn.TabIndex = 5;
            pickLocationBtn.Text = "Pick Location";
            pickLocationBtn.UseVisualStyleBackColor = true;
            pickLocationBtn.Click += PickLocationBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Enabled = false;
            startBtn.Location = new Point(12, 283);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(157, 58);
            startBtn.TabIndex = 6;
            startBtn.Text = "Start (F6)";
            startBtn.UseVisualStyleBackColor = true;
            // 
            // stopBtn
            // 
            stopBtn.Enabled = false;
            stopBtn.Location = new Point(175, 283);
            stopBtn.Name = "stopBtn";
            stopBtn.Size = new Size(145, 58);
            stopBtn.TabIndex = 7;
            stopBtn.Text = "Stop (F6)";
            stopBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.Location = new Point(326, 283);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(149, 58);
            settingsBtn.TabIndex = 8;
            settingsBtn.Text = "Hotkey Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += SettingsBtn_Click;
            // 
            // AutoClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 353);
            Controls.Add(settingsBtn);
            Controls.Add(stopBtn);
            Controls.Add(startBtn);
            Controls.Add(cursorPositionBox);
            Controls.Add(clickRepeatBox);
            Controls.Add(clickOptionsBox);
            Controls.Add(clickIntervalBox);
            Controls.Add(accessMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = accessMenuStrip;
            MaximumSize = new Size(503, 392);
            MinimumSize = new Size(503, 392);
            Name = "AutoClicker";
            Text = "Auto Clicker - Menu";
            Load += AutoClicker_Load;
            accessMenuStrip.ResumeLayout(false);
            accessMenuStrip.PerformLayout();
            clickIntervalBox.ResumeLayout(false);
            clickIntervalBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)millisecsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)secsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minsUpDown).EndInit();
            clickOptionsBox.ResumeLayout(false);
            clickOptionsBox.PerformLayout();
            clickRepeatBox.ResumeLayout(false);
            clickRepeatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)repeatUpDown).EndInit();
            cursorPositionBox.ResumeLayout(false);
            cursorPositionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coordinateYupDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)coordinateXupDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip accessMenuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox clickIntervalBox;
        private Label millisecsLabel;
        private NumericUpDown millisecsUpDown;
        private NumericUpDown hoursUpDown;
        private Label secsLabel;
        private Label hoursLabel;
        private NumericUpDown secsUpDown;
        private NumericUpDown minsUpDown;
        private Label minsLabel;
        private GroupBox clickOptionsBox;
        private GroupBox clickRepeatBox;
        private GroupBox cursorPositionBox;
        private Button pickLocationBtn;
        private Button startBtn;
        private Button stopBtn;
        private Button settingsBtn;
        private ComboBox clickTypeComboBox;
        private ComboBox mouseBtnComboBox;
        private Label clickTypeLabel;
        private Label mouseBtnLabel;
        private RadioButton repeatUntilRadioBtn;
        private RadioButton repeatTimesRadioBtn;
        private Label timesCounterLabel;
        private Label counterLabel;
        private NumericUpDown repeatUpDown;
        private NumericUpDown coordinateYupDown;
        private NumericUpDown coordinateXupDown;
        private Label coordinateYlabel;
        private Label coordinateXlabel;
        private Label repeatTimesLabel;
    }
}