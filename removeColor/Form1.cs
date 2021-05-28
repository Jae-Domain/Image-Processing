using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace removeColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }

        private Color isDarker(Color a, Color b)
        {
           if (a.GetBrightness() > b.GetBrightness())
            {
                return b;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open file
            //file upload code cited from https://stackoverflow.com/questions/12968138/how-to-upload-a-file-in-window-forms
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.jpg"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                Bitmap pic = new Bitmap(dialog.FileName);
                Color dark = pic.GetPixel(0, 0);

                progressBar1.Value = 0;
                progressBar1.Maximum = pic.Width * pic.Height;

                //loop through every pixel, identify darkest color
                for (int x = 0; x < pic.Width; x++)
                {
                    for (int y = 0; y < pic.Height; y++)
                    {
                        dark = isDarker(pic.GetPixel(x, y), dark); //set dark to be darkest pixel
                    }
                }

                //eliminate all brighter pixels
                for (int x = 0; x < pic.Width; x++)
                {
                    for (int y = 0; y < pic.Height; y++)
                    {
                        progressBar1.Value++; //increment progress bar

                        if (pic.GetPixel(x, y).GetBrightness() > dark.GetBrightness() + .25)
                        {
                            pic.SetPixel(x, y, Color.White);
                        }
                    }
                }

                //save new image/ preview image
                Bitmap newPic = new Bitmap(pic);
                picCanvas.Image = newPic;
                picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
                picCanvas.Update();

                newPic.Save("lineArt.jpg", ImageFormat.Jpeg);
            }

        }
    }
}
