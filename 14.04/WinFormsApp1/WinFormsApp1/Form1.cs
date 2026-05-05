using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
namespace WinFormsApp1


{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isX = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (isX)
                {
                    button2.Text = "X";
                    isX = false;
                }
                else
                {
                    button2.Text = "O";
                    isX = true;
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (button3.Text == "")
            {
                if (isX)
                {
                    button3.Text = "X";
                    isX = false;
                }
                else
                {
                    button3.Text = "O";
                    isX = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (isX)
                {
                    button4.Text = "X";
                    isX = false;
                }
                else
                {
                    button4.Text = "O";
                    isX = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (isX)
                {
                    button5.Text = "X";
                    isX = false;
                }
                else
                {
                    button5.Text = "O";
                    isX = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (isX)
                {
                    button6.Text = "X";
                    isX = false;
                }
                else
                {
                    button6.Text = "O";
                    isX = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (isX)
                {
                    button7.Text = "X";
                    isX = false;
                }
                else
                {
                    button7.Text = "O";
                    isX = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (isX)
                {
                    button8.Text = "X";
                    isX = false;
                }
                else
                {
                    button8.Text = "O";
                    isX = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (isX)
                {
                    button9.Text = "X";
                    isX = false;
                }
                else
                {
                    button9.Text = "O";
                    isX = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                if (isX)
                {
                    button10.Text = "X";
                    isX = false;
                }
                else
                {
                    button10.Text = "O";
                    isX = true;
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Location = new Point(rnd.Next(0, this.ClientSize.Width - button1.Width), rnd.Next(0, this.ClientSize.Height - button1.Height));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }
    }
}

