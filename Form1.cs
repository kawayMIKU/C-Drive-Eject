namespace 弹出C盘
{
    public partial class 弹出C盘 : Form
    {
        public 弹出C盘()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c mountvol c: /d";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
