namespace AutoClicker
{
    partial class KeySettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeySettingsForm));
            pressedKeyLabel = new Label();
            saveLabel = new Label();
            cancelLabel = new Label();
            titleLabel = new Label();
            pressedKeyValueLabel = new Label();
            SuspendLayout();
            // 
            // pressedKeyLabel
            // 
            pressedKeyLabel.AutoSize = true;
            pressedKeyLabel.BorderStyle = BorderStyle.Fixed3D;
            pressedKeyLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pressedKeyLabel.ForeColor = Color.Red;
            pressedKeyLabel.Location = new Point(207, 14);
            pressedKeyLabel.Name = "pressedKeyLabel";
            pressedKeyLabel.Size = new Size(35, 30);
            pressedKeyLabel.TabIndex = 0;
            pressedKeyLabel.Text = "F6";
            // 
            // saveLabel
            // 
            saveLabel.AutoSize = true;
            saveLabel.BackColor = SystemColors.ControlDark;
            saveLabel.BorderStyle = BorderStyle.FixedSingle;
            saveLabel.Location = new Point(96, 69);
            saveLabel.Name = "saveLabel";
            saveLabel.Size = new Size(33, 17);
            saveLabel.TabIndex = 1;
            saveLabel.Text = "Save";
            saveLabel.Click += saveLabel_Click;
            // 
            // cancelLabel
            // 
            cancelLabel.AutoSize = true;
            cancelLabel.BackColor = SystemColors.ControlDark;
            cancelLabel.BorderStyle = BorderStyle.FixedSingle;
            cancelLabel.Location = new Point(184, 69);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(45, 17);
            cancelLabel.TabIndex = 2;
            cancelLabel.Text = "Cancel";
            cancelLabel.Click += cancelLabel_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(32, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(71, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Pressed key:";
            // 
            // pressedKeyValueLabel
            // 
            pressedKeyValueLabel.AutoSize = true;
            pressedKeyValueLabel.BorderStyle = BorderStyle.Fixed3D;
            pressedKeyValueLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pressedKeyValueLabel.ForeColor = Color.Red;
            pressedKeyValueLabel.Location = new Point(127, 14);
            pressedKeyValueLabel.Name = "pressedKeyValueLabel";
            pressedKeyValueLabel.Size = new Size(47, 30);
            pressedKeyValueLabel.TabIndex = 4;
            pressedKeyValueLabel.Text = "117";
            // 
            // KeySettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 101);
            Controls.Add(pressedKeyValueLabel);
            Controls.Add(titleLabel);
            Controls.Add(cancelLabel);
            Controls.Add(saveLabel);
            Controls.Add(pressedKeyLabel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(336, 140);
            MinimumSize = new Size(336, 140);
            Name = "KeySettingsForm";
            Text = "Auto Clicker - Settings";
            KeyDown += KeySettingsForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pressedKeyLabel;
        private Label saveLabel;
        private Label cancelLabel;
        private Label titleLabel;
        private Label pressedKeyValueLabel;
    }
}