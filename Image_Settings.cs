using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laharika_2
{
    public partial class Image_Settings : Form
    {
       static Image original;
        static Image modified;
       // static int skey;
        static int BV;
        static double CV;
        public Image_Settings()
        {
            InitializeComponent();
            textBox2.Text = "0";
            textBox1.Text = "0";
            BV = 0;
            CV = 0;
            progressBar1.Visible = false;
         
        }

        public static List<string> filenames = new List<string>();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            CV = (double)trackBar1.Value;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "")
            {
                textBox1.Text = "0";
            }
            try
            { trackBar1.Value = Convert.ToInt32(textBox1.Text.ToString()); }
            catch
            {
                MessageBox.Show("Value must be in between -20 and 20");
            }
            CV = (double)trackBar1.Value;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.ToString()=="")
            {
                textBox2.Text = "0";
            }
            try
            { trackBar2.Value = Convert.ToInt32(textBox2.Text.ToString()); }
            catch
            {
                MessageBox.Show("Value must be in between -20 and 20");
            }
           
            BV = trackBar2.Value;
          
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
            
            BV = trackBar2.Value;
         
        }

        private void savefiles(object sender, EventArgs e)
        {
            Static_Values temp = new Static_Values();
            temp.set_brigthness(BV);
            temp.set_contrast((int)CV);
            MessageBox.Show("settings saved");
            return;
            progressBar1.Visible = true; 
            progressBar1.Minimum = 0;
            progressBar1.Maximum = filenames.Count;
            progressBar1.Value = 0;
            string foldername = System.IO.Path.Combine(Path.GetDirectoryName(filenames[0]), "Edited images");
            System.IO.Directory.CreateDirectory(foldername);
            for (int i = 0; i < filenames.Count; i++)
            {
                Image original = Image.FromFile(filenames[i]);
                Bitmap modified = (Bitmap)original;
                modified = AdjustBrightness(modified, BV);
                modified = AdjustContrast(modified, (float)CV);
                ///////
                string path = foldername + @"\" + Path.GetFileName(filenames[i]);
             
                //Bitmap a = modified.Clone(new System.Drawing.Rectangle(0, 0, modified.Width, modified.Height), modified.PixelFormat);
                using (EncoderParameters encoderParameters = new EncoderParameters(1))
                using (EncoderParameter encoderParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L))
                {
                    ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders().First(codec => codec.FormatID == ImageFormat.Jpeg.Guid);
                    encoderParameters.Param[0] = encoderParameter;
                    try
                    {
                        modified.Save(path, codecInfo, encoderParameters);
                    }
                    catch
                    {
                        MessageBox.Show("ERROR SAVING IMAGES");
                    }
                }

                original.Dispose();
                modified.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                // temp = Convert.ToString((i+1) / filenames.Count * 100);
                // temp += "% completed";
                // progressbox.Text = temp;
                progressBar1.Value = i +1;
            }
            MessageBox.Show("completed");
            progressBar1.Visible = false;

        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image edited = modified;
            Form form = new Form();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "edited";
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = edited;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }

        

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (original == null)
            {
                MessageBox.Show("please select image");
                return;
            }
            Bitmap modified = (Bitmap)original;
            modified = AdjustBrightness(modified, BV);
             modified = AdjustContrast(modified, (float)CV);
            pictureBox2.Image = modified;

        }

        public static Bitmap AdjustBrightness(Bitmap Image, int Value)
        {
            
            Bitmap TempBitmap = Image;

            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float FinalValue = (float)Value / 255.0f;

            float[][] FloatColorMatrix ={

                    new float[] {1, 0, 0, 0, 0},

                    new float[] {0, 1, 0, 0, 0},

                    new float[] {0, 0, 1, 0, 0},

                    new float[] {0, 0, 0, 1, 0},

                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);

            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

            Attributes.Dispose();

            NewGraphics.Dispose();

            return NewBitmap;
        }

        public static Bitmap AdjustContrast(Bitmap Image, float Value)
        {
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(
                new Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height),
                ImageLockMode.ReadWrite,
                NewBitmap.PixelFormat);
            int Height = NewBitmap.Height;
            int Width = NewBitmap.Width;

            unsafe
            {
                for (int y = 0; y < Height; ++y)
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for (int x = 0; x < Width; ++x)
                    {
                        byte B = row[columnOffset];
                        byte G = row[columnOffset + 1];
                        byte R = row[columnOffset + 2];

                        float Red = R / 255.0f;
                        float Green = G / 255.0f;
                        float Blue = B / 255.0f;
                        Red = (((Red - 0.5f) * Value) + 0.5f) * 255.0f;
                        Green = (((Green - 0.5f) * Value) + 0.5f) * 255.0f;
                        Blue = (((Blue - 0.5f) * Value) + 0.5f) * 255.0f;

                        int iR = (int)Red;
                        iR = iR > 255 ? 255 : iR;
                        iR = iR < 0 ? 0 : iR;
                        int iG = (int)Green;
                        iG = iG > 255 ? 255 : iG;
                        iG = iG < 0 ? 0 : iG;
                        int iB = (int)Blue;
                        iB = iB > 255 ? 255 : iB;
                        iB = iB < 0 ? 0 : iB;

                        row[columnOffset] = (byte)iB;
                        row[columnOffset + 1] = (byte)iG;
                        row[columnOffset + 2] = (byte)iR;

                        columnOffset += 4;
                    }
                }
            }

            NewBitmap.UnlockBits(data);

            return NewBitmap;
        }

        // new contrast
       

        private void Image_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            main temp = new main();
            temp.ChangeKey("main");
        }

        private void openfiles(object sender, EventArgs e)
        {
            int key = 0;
                OpenFileDialog sample = new OpenFileDialog();
                sample.Filter = "image files(*.bmp,*.jpg,*.png)|*.bmp; *.jpg; *.png";
            sample.Multiselect = true;
                // new Thread(() => sample.ShowDialog()).Start();

                if (sample.ShowDialog() == DialogResult.OK)
                {
                foreach (string fname in sample.FileNames)
                {
                    if (key == 0)
                    {
                      pictureBox1.Image = Image.FromFile(fname);
                    original = Image.FromFile(fname);
                        key = 1;
                    }
                    filenames.Add(fname);
                }
                   

                }

            sample.Dispose();
        }

       
    }
    }
