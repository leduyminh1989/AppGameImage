using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIma1.Text = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Images\Ima1.png");
            lblIma2.Text = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), @"Images\Ima2.png");
            progressBar1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            string img1_ref, img2_ref;
            var img1 = new Bitmap(lblIma1.Text);
            var img2 = new Bitmap(lblIma2.Text);
            var img3 = GrayScaleFilter(img1);

            progressBar1.Maximum = img1.Width;
            bool flag = true;
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();

                        if (img1_ref != img2_ref)
                        {
                            flag = false;
                            img3.SetPixel(i, j, Color.Red);
                        }
                    }
                    progressBar1.Value++;
                }
                if (flag == false)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Width = img3.Width;
                    pictureBox1.Height = img3.Height;
                    pictureBox1.Image = img3;
                }
                else
                    MessageBox.Show("Images are same !");
            }
            else
                MessageBox.Show("Can not compare this images");
        }

        public Bitmap GrayScaleFilter(Bitmap image)
        {
            Bitmap grayScale = new Bitmap(image.Width, image.Height);

            for (Int32 y = 0; y < grayScale.Height; y++)
                for (Int32 x = 0; x < grayScale.Width; x++)
                {
                    Color c = image.GetPixel(x, y);

                    Int32 gs = (Int32)(c.R * 0.3 + c.G * 0.59 + c.B * 0.11);

                    grayScale.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return grayScale;
        }

        private void linkImage1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "All Images|*.jpg; *.bmp; *.png";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                lblIma1.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void linkImage2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.Title = "Images";
            openFileDialog2.Filter = "All Images|*.jpg; *.bmp; *.png";
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName.ToString() != "")
            {
                lblIma2.Text = openFileDialog2.FileName.ToString();
            }
        }
    }
}
