namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt32(textBox1.Text);
            int b =Convert.ToInt32(textBox2.Text);
            label1.Text = "Сума: " + (a + b);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
