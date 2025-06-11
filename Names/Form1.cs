namespace Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !lstNames.Items.Contains(txtName.Text)){
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }
    }
}
