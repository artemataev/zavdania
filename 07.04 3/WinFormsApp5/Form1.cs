namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            if (age < 18)
            {
                MessageBox.Show("неповнолітній");
            }
            else
            {
                MessageBox.Show("повнолітній");
            }
        }
    }
}
