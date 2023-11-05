// PROCESS MODULE
using System.Diagnostics;
// DLL IMPORTS
using System.Runtime.InteropServices;
// MOUSE & KEYBOARD SIMULATOR
using WindowsInput;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {
        // ---------------------- VARIABLES ------------------------
        int selectedHotKey_keyValue = 117;
        decimal? time = 0, iterations = 0, cordX = 0, cordY = 0;
        string? mouse_btn = "", click_type = "", selectedHotkey_keyCode = "F6";
        bool repeat_until_stop = false, isAutoClicking = false;
        CancellationTokenSource? cancellationTokenSource = null;
        // SIMULATE I/O DEVICES
        InputSimulator simulator = new InputSimulator();
        // IDENTIFY X/Y USER CLICK
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out Point lpPoint);
        // HOOK KEY OBJECT
        private GlobalKeyboardHook globalKeyboardHook = new GlobalKeyboardHook();
        // ---------------------------------------------------------

        // CLASS CONSTRUCTOR
        public AutoClicker()
        {
            InitializeComponent();
            globalKeyboardHook.KeyDown += GlobalKeyDown;
        }

        // HOOK KEYBOARD KEY CLASS
        public class GlobalKeyboardHook
        {
            private const int WH_KEYBOARD_LL = 13;
            private const int WM_KEYDOWN = 0x0100;

            private LowLevelKeyboardProc keyboardProc;
            private IntPtr hookID = IntPtr.Zero;

            public event KeyEventHandler KeyDown;

            public GlobalKeyboardHook()
            {
                keyboardProc = HookCallback;
                hookID = SetHook(keyboardProc);
            }

            ~GlobalKeyboardHook()
            {
                UnhookWindowsHookEx(hookID);
            }

            private IntPtr SetHook(LowLevelKeyboardProc proc)
            {
                using (ProcessModule curModule = Process.GetCurrentProcess().MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
                }
            }

            private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    KeyEventArgs kea = new KeyEventArgs((Keys)vkCode);
                    KeyDown?.Invoke(this, kea);
                    if (kea.Handled)
                        return (IntPtr)1;
                }
                return CallNextHookEx(hookID, nCode, wParam, lParam);
            }

            #region P/Invoke
            private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);
            #endregion
        }

        // DEFAULT OPTIONS TO DONT BUG
        private void AutoClicker_Load(object sender, EventArgs e)
        {
            mouseBtnComboBox.SelectedItem = "Left";
            clickTypeComboBox.SelectedItem = "Single";
        }

        // SET VARIABLES METHOD
        private void SetVariables()
        {
            // CLICK INTERVAL
            time = (hoursUpDown.Value * 3600000) + (minsUpDown.Value * 60000) + (secsUpDown.Value * 1000) + millisecsUpDown.Value;
            // CLICK OPTIONS
            mouse_btn = mouseBtnComboBox.Text;
            click_type = clickTypeComboBox.Text;
            // CURSOR POSITION
            cordX = coordinateXupDown.Value;
            cordY = coordinateYupDown.Value;
            // REPEATER
            repeat_until_stop = repeatUntilRadioBtn.Checked;

            if (repeatTimesRadioBtn.Checked)
            {
                iterations = repeatUpDown.Value;
            }
        }

        // OPEN HELP MENU
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        // REPEAT UNTIL STOPPED == TRUE
        private void RepeatUntilRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            repeat_until_stop = true;
            repeatUpDown.Enabled = false;
        }

        // REPEAT UNTIL STOPPED == FALSE -> WILL REPEAT X TIMES
        private void RepeatTimesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            repeat_until_stop = false;
            repeatUpDown.Enabled = true;

            // CLICK REPEAT TIMES
            iterations = repeatUpDown.Value;
        }

        // PICK LOCATION BUTTON CLICKED == TRUE (USE W/ ENTER)
        private void PickLocationBtn_Click(object sender, EventArgs e)
        {
            if (GetCursorPos(out Point cursorPos))
            {
                coordinateXupDown.Value = cursorPos.X;
                coordinateYupDown.Value = cursorPos.Y;
            }
        }

        // HOOK KEY IN SETTINGS FORM AND SAVE
        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            using (KeySettingsForm configForm = new KeySettingsForm())
            {
                configForm.ShowDialog();

                if (configForm.selectedHotkey_keyCode != "" && configForm.selectedHotkey_keyValue != 0)
                {
                    selectedHotkey_keyCode = configForm.selectedHotkey_keyCode;
                    selectedHotKey_keyValue = configForm.selectedHotkey_keyValue;
                }
            }

            startBtn.Text = "Start (" + selectedHotkey_keyCode + ")";
            stopBtn.Text = "Stop (" + selectedHotkey_keyCode + ")";
        }

        // --------------------- MAIN PROCESS ----------------------
        // HOOK KEY LISTENER
        private void GlobalKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == selectedHotkey_keyCode)
            {
                if (isAutoClicking)
                {
                    // PROCESS RUNNING -> STOP EXECUTION
                    cancellationTokenSource?.Cancel();
                    isAutoClicking = false;
                    iterations = 0;
                }
                else
                {
                    SetVariables();
                    // PROCESS DONT RUNNING -> START EXECUTION
                    isAutoClicking = true;
                    StartAutoClicking();
                }
            }
        }

        // UPDATE COUNTER (timesCounterLabel.Text)
        private void UpdateTimesCounterLabel(string text)
        {
            if (timesCounterLabel.InvokeRequired)
            {
                timesCounterLabel.Invoke(new Action(() => timesCounterLabel.Text = text));
            }
            else
            {
                timesCounterLabel.Text = text;
            }
        }

        // METHOD TO MANIPULATE THREADS (ASYNC, AWAIT)
        private async void StartAutoClicking()
        {
            cancellationTokenSource = new CancellationTokenSource();

            await Task.Run(() =>
            {
                int counter = 0;

                UpdateTimesCounterLabel("0");

                while (true)
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        // STOP KEY PRESSED -> EXIT LOOP
                        break;
                    }

                    // MAX - 1
                    if (repeat_until_stop == false && counter == ((int)iterations - 1))
                    {
                        // RESET PROGRAM
                        simulator.Keyboard.KeyPress((WindowsInput.Native.VirtualKeyCode)selectedHotKey_keyValue);
                    }

                    PerformClick();

                    // INCREMENT COUNTER
                    UpdateTimesCounterLabel((counter + 1).ToString());

                    counter++;

                    // TOTAL TIME = HOURS + MINUTES + SECS + MILLISECS
                    Thread.Sleep((int)time);
                }
            });
        }

        // 'CLICK' ACTION
        private void PerformClick()
        {
            // SET CURSOR POSITION
            Cursor.Position = new Point((int)cordX, (int)cordY);

            // SIMULATE CLICK
            if (mouse_btn == "Left")
            {
                if (click_type == "Single")
                {
                    simulator.Mouse.LeftButtonClick();
                }

                else if (click_type == "Double")
                {
                    simulator.Mouse.LeftButtonDoubleClick();
                }
            }

            else if (mouse_btn == "Right")
            {
                if (click_type == "Single")
                {
                    simulator.Mouse.RightButtonClick();
                }

                else if (click_type == "Double")
                {
                    simulator.Mouse.RightButtonDoubleClick();
                }
            }
        }
        // ---------------------------------------------------------
    }
}