using cxapi;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Enumeration;

namespace Executor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void Inject_Click_1(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
            if (CoreFunctions.IsInjected() == false) { pnlStatus.BackColor = Color.DarkRed; };
            if (CoreFunctions.IsInjected() == true) { pnlStatus.BackColor = Color.DarkGreen; };
        }

        private void Execute_Click_1(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(scriptTextBox.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            scriptTextBox.Text = "";
        }
        private void brnKillRoblox_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimise_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            scriptTextBox.Text += Clipboard.GetText();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (FileInfo fileInfo in new DirectoryInfo("./Scripts").GetFiles("*.txt"))
            { this.lbScripts.Items.Add(fileInfo.Name); }
            foreach (FileInfo fileInfo2 in new DirectoryInfo("./Scripts").GetFiles("*.lua"))
            { this.lbScripts.Items.Add(fileInfo2.Name); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbScripts.Items.Clear();
            foreach (FileInfo fileInfo in new DirectoryInfo("./Scripts").GetFiles("*.txt"))
            {
                this.lbScripts.Items.Add(fileInfo.Name);
            }
            foreach (FileInfo fileInfo2 in new DirectoryInfo("./Scripts").GetFiles("*.lua"))
            {
                this.lbScripts.Items.Add(fileInfo2.Name);
            }
        }

        private void lbScripts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbScripts.SelectedItem != null)
            {
                string selectedFileName = lbScripts.SelectedItem.ToString();
                string filePath = Path.Combine("./Scripts", selectedFileName);

                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    scriptTextBox.Text += fileContent;
                }
                else
                {
                    MessageBox.Show("Файл не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
