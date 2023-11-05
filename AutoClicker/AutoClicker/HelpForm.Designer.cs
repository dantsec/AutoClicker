namespace AutoClicker
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            helpTabControl = new TabControl();
            descriptionTabPage = new TabPage();
            descriptionTextBox = new TextBox();
            aboutTabPage = new TabPage();
            aboutTextBox = new TextBox();
            licenseTabPage = new TabPage();
            licenseTextBox = new TextBox();
            helpTabControl.SuspendLayout();
            descriptionTabPage.SuspendLayout();
            aboutTabPage.SuspendLayout();
            licenseTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // helpTabControl
            // 
            helpTabControl.Controls.Add(descriptionTabPage);
            helpTabControl.Controls.Add(aboutTabPage);
            helpTabControl.Controls.Add(licenseTabPage);
            helpTabControl.Location = new Point(12, 12);
            helpTabControl.Name = "helpTabControl";
            helpTabControl.SelectedIndex = 0;
            helpTabControl.Size = new Size(382, 288);
            helpTabControl.TabIndex = 0;
            // 
            // descriptionTabPage
            // 
            descriptionTabPage.Controls.Add(descriptionTextBox);
            descriptionTabPage.Location = new Point(4, 24);
            descriptionTabPage.Name = "descriptionTabPage";
            descriptionTabPage.Padding = new Padding(3);
            descriptionTabPage.Size = new Size(374, 260);
            descriptionTabPage.TabIndex = 0;
            descriptionTabPage.Text = "Description";
            descriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(6, 6);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(362, 248);
            descriptionTextBox.TabIndex = 0;
            descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            // 
            // aboutTabPage
            // 
            aboutTabPage.Controls.Add(aboutTextBox);
            aboutTabPage.Location = new Point(4, 24);
            aboutTabPage.Name = "aboutTabPage";
            aboutTabPage.Padding = new Padding(3);
            aboutTabPage.Size = new Size(374, 260);
            aboutTabPage.TabIndex = 1;
            aboutTabPage.Text = "About";
            aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutTextBox
            // 
            aboutTextBox.Location = new Point(6, 6);
            aboutTextBox.Multiline = true;
            aboutTextBox.Name = "aboutTextBox";
            aboutTextBox.ReadOnly = true;
            aboutTextBox.ScrollBars = ScrollBars.Vertical;
            aboutTextBox.Size = new Size(362, 248);
            aboutTextBox.TabIndex = 0;
            aboutTextBox.Text = "[ DEV ]\r\n    dantsec\r\n\r\n[ GITHUB PROFILE ]\r\n    https://github.com/dantsec\r\n\r\n[ CONTACT ]\r\n    dantsec@proton.me";
            // 
            // licenseTabPage
            // 
            licenseTabPage.Controls.Add(licenseTextBox);
            licenseTabPage.Location = new Point(4, 24);
            licenseTabPage.Name = "licenseTabPage";
            licenseTabPage.Size = new Size(374, 260);
            licenseTabPage.TabIndex = 2;
            licenseTabPage.Text = "License";
            licenseTabPage.UseVisualStyleBackColor = true;
            // 
            // licenseTextBox
            // 
            licenseTextBox.Location = new Point(3, 3);
            licenseTextBox.Multiline = true;
            licenseTextBox.Name = "licenseTextBox";
            licenseTextBox.ReadOnly = true;
            licenseTextBox.ScrollBars = ScrollBars.Vertical;
            licenseTextBox.Size = new Size(368, 254);
            licenseTextBox.TabIndex = 0;
            licenseTextBox.Text = resources.GetString("licenseTextBox.Text");
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 312);
            Controls.Add(helpTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(422, 351);
            MinimumSize = new Size(422, 351);
            Name = "HelpForm";
            Text = "Auto Clicker - Help";
            helpTabControl.ResumeLayout(false);
            descriptionTabPage.ResumeLayout(false);
            descriptionTabPage.PerformLayout();
            aboutTabPage.ResumeLayout(false);
            aboutTabPage.PerformLayout();
            licenseTabPage.ResumeLayout(false);
            licenseTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl helpTabControl;
        private TabPage descriptionTabPage;
        private TabPage aboutTabPage;
        private TabPage licenseTabPage;
        private TextBox descriptionTextBox;
        private TextBox aboutTextBox;
        private TextBox licenseTextBox;
    }
}