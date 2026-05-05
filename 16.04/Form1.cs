

namespace _16._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; 
        }

        string[] images = { "1.jfif", "2.jfif", "3.jfif", "4.jfif", "5.jfif" };
        int index = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            SetPictureByIndex(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= images.Length)
                index = 0;

            SetPictureByIndex(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = images.Length - 1;

            SetPictureByIndex(index);
        }

        private void SetPictureByIndex(int idx)
        {
            var path = Path.Combine(AppContext.BaseDirectory, images[idx]);

            if (!File.Exists(path))
            {
                MessageBox.Show($"Image file not found: {path}", "Missing image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                using var fs = File.OpenRead(path);
                using var ms = new MemoryStream();
                fs.CopyTo(ms);
                ms.Position = 0;
                var newImage = Image.FromStream(ms);

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = newImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}