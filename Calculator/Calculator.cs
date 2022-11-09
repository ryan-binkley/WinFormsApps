using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Calculator : Form
    {
        // Helper methods to make the form draggable by the top panel
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessge(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        public Calculator()
        {
            InitializeComponent(); 
        }

        // This method allows the panel to be draggable, along with the DllImports
        private void ControlBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessge(this.Handle, 0x112, 0xf012, 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "0";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "2";
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "3";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "6";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "7";
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "8";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += "9";
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            this.NumberOutputTextBox.Text += ".";
        }
    }
}