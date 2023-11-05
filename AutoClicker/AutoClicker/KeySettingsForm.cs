namespace AutoClicker
{
    public partial class KeySettingsForm : Form
    {
        public string selectedHotkey_keyCode = "";
        public int selectedHotkey_keyValue = 0;

        public KeySettingsForm()
        {
            InitializeComponent();
        }

        private void KeySettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeyLabel.Text = e.KeyCode.ToString();
            pressedKeyValueLabel.Text = e.KeyValue.ToString();
        }

        private void saveLabel_Click(object sender, EventArgs e)
        {
            selectedHotkey_keyCode = pressedKeyLabel.Text;
            selectedHotkey_keyValue = int.Parse(pressedKeyValueLabel.Text);
            MessageBox.Show("Key [ " + selectedHotkey_keyCode + " ] - [ " + selectedHotkey_keyValue.ToString() + " ] Saved!", "[Info]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
