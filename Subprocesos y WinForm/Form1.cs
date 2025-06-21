namespace Subprocesos_y_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var thread2 = new System.Threading.Thread(WriteTextUnsafe);
            thread2.Start();
        }

        private void WriteTextUnsafe() =>
            textBox1.Text = "This text was set unsafely.";
    }
}
