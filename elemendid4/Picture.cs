using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elemendid_vormis_TARpv23
{
    public partial class Picture : Form
    {
        public Picture(int width, int height)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = height;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Picture_Load(object sender, EventArgs e)
        {

        }

        private void rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = image;
            }
        }

        private void Zoom_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                int newWidth = (int)(originalImage.Width * 1.2);
                int newHeight = (int)(originalImage.Height * 1.2);

                Bitmap resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                pictureBox1.Image = resizedImage;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != null && openFileDialog1.FileName != "")
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void ShowButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog5.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Load(openFileDialog5.FileName);
            }
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null)
            {
                // Сохраняем текущее изображение в переменной временного хранения
                Image tempImage = pictureBox1.Image;

                // Меняем изображения местами
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = tempImage;
            }
        }
    }
}
