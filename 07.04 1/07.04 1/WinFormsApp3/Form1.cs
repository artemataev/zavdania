namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Привіт, " + textBox1.Text + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
