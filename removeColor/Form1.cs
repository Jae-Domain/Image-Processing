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

        Bitmap pic;
        Bitmap original;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pic == null)
            {
                loadFile_Click(sender, e);
            }
        }

        private void Colorize(Color a)
        {
            pic = new Bitmap(original);
            progressBar1.Value = 0;

            for (int x = 0; x < pic.Width; x++)
            {
                for (int y = 0; y < pic.Height; y++)
                {
                    progressBar1.Value++;
                    pic.SetPixel(x, y, combine(pic.GetPixel(x, y), a)); //hue shift pixel
                }
            }    
        }

        public static Color combine (Color a, Color b)
        {
            Color n = new Color();
            int r = a.R + b.R;
            int g = a.G + b.G;
            int blue = a.B + b.B;

            if (r > 255)
            {
                r = 255;
            }
            if (g > 255)
            {
                g = 255;
            }
            if (blue > 255)
            {
                blue = 255;
            }

            n = Color.FromArgb(r, g, blue);
            return n;
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
            pic = new Bitmap(original);
            Color dark = pic.GetPixel(0, 0);
            progressBar1.Value = 0;

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

            saveImage("lineArt.jpg");

        }

        private void saveImage(string name)
        {
            //save new image/ preview image
            Bitmap newPic = new Bitmap(pic);
            picCanvas.Image = newPic;
            picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            picCanvas.Update();

            newPic.Save(name, ImageFormat.Jpeg);
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            //open file
            //file upload code cited from https://stackoverflow.com/questions/12968138/how-to-upload-a-file-in-window-forms
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images | *.jpg"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                pic = new Bitmap(dialog.FileName);
            }

            progressBar1.Maximum = pic.Width * pic.Height;
            original = new Bitmap(pic);
            originalPreview.Image = original;
            originalPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            originalPreview.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Colorize(Color.FromArgb(redIntensity.Value,0,0));
            //Colorize(Color.Red);
            saveImage("redArt.jpg");
        }

        private void saturateBlue_Click(object sender, EventArgs e)
        {
            Colorize(Color.FromArgb(0,0,blueIntensity.Value));
            //Colorize(Color.Blue);
            saveImage("blueArt.jpg");
        }

        private void saturateGreen_Click(object sender, EventArgs e)
        {
            Colorize(Color.FromArgb(0, greenIntensity.Value, 0));
            //Colorize(Color.Green);
            saveImage("greenArt.jpg");
        }

        private void grayscaleButton_Click(object sender, EventArgs e)
        {
            pic = new Bitmap(original);
            progressBar1.Value = 0;

            //eliminate all brighter pixels
            for (int x = 0; x < pic.Width; x++)
            {
                for (int y = 0; y < pic.Height; y++)
                {
                    progressBar1.Value++; //increment progress bar

                    //cited from https://stackoverflow.com/questions/2265910/convert-an-image-to-grayscale
                    Color oc = pic.GetPixel(x, y);
                    int grayScale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayScale, grayScale, grayScale);
                    pic.SetPixel(x, y, nc);

                }
            }

            saveImage("grayscale.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Colorize(Color.FromArgb(redIntensity.Value, greenIntensity.Value, blueIntensity.Value));
            //Colorize(Color.Green);
            saveImage("customArt.jpg");
        }
    }
}
