using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Threading;

namespace laharika_2
{
    public partial class main : Form
    {
        public static string key { get; set; }

        public string keyvalue()
        {
            return key;
        }
        public void ChangeKey(string val)
        {
            key = val;
        }
        static double cv;
        static int bv;
        static int k = 0;
        static int fileno = 1;
    
        string lastFolderName = null;
        OpenFileDialog openimgfile;
        List<string> listdata = new List<string>();
        List<int> problem = new List<int>(); 
        public main()
        {
            InitializeComponent();
            comboBox1.Text = "12x36";
            custombox.Visible = false;
            custombox2.Visible = false;
            X.Visible = false;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int chk = 0;
            k = 0;
            
            
            if(rename_txt.Text =="")
            {
                fileno = 1;
            }
            listdata.Clear();
            problem.Clear();
            progressBar1.Value = 0;
            openimgfile = new OpenFileDialog();
            openimgfile.Multiselect = true;
            openimgfile.Filter = "image files(*.bmp,*.jpg,*.png)|*.bmp; *.jpg; *.png";
            if (openimgfile.ShowDialog() == DialogResult.OK)
            {
                foreach (string temp in openimgfile.FileNames)
                {
                    listdata.Add(temp);
                    if (chk == 0)
                    {
                        string path = temp;

                        lastFolderName = Path.GetDirectoryName(temp);
                        //MessageBox.Show(lastFolderName);
                        chk++;
                    }
                    

                }

               
            }

            progressBar1.Maximum = listdata.Count;
            progressBar1.Minimum = 0;



        }


        private void savefile(int x, int y)
        {


            string folderName = lastFolderName;
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            try
            {
                System.IO.Directory.CreateDirectory(pathString);
            }
            catch
            {
                MessageBox.Show("ERROR CREATING FOLDER");
                return;
            }



            Bitmap s = null;
            try
            {
                s = new Bitmap(listdata[k]);
            }
            catch
            {
                MessageBox.Show("ERROR OPENING FILE or FILE CORRUPTED\n File Name: -  " + Path.GetFileName(listdata[k]));
                return;
            }
            if (s.Width < s.Height)
            {
                s.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            ////////////////
            ///

            Static_Values temp = new Static_Values();
            bv = temp.get_brightness();
            cv = temp.get_contrast();
            if (bv != 0)
            { s = temp.AdjustBrightness(s); }
            if (cv != 0)
            {s = AdjustContrast(s,(float)cv); }
            ///////////////
            ///

            Bitmap a = s.Clone(new System.Drawing.Rectangle(0, 0, s.Width / 2, s.Height), s.PixelFormat);
            Bitmap b = s.Clone(new System.Drawing.Rectangle(s.Width / 2, 0, s.Width / 2, s.Height), s.PixelFormat);
            string number = "";
            if(fileno<10)
            {
                number = "0" + fileno.ToString();
            }
            else
            {
                number = fileno.ToString();
            }
            string tmp = lastFolderName + @"\SubFolder\" + number+"a" + ".jpg";
            
           // MessageBox.Show(a.Width + " " + a.VerticalResolution + " " + a.Height + " " + a.HorizontalResolution);
           
            
            if (a.Width != x || a.Height != y)
            {   a = new Bitmap(a, new Size(x, y));
            a.SetResolution(300, 300);
                b = new Bitmap(b, new Size(x, y));
                b.SetResolution(300, 300);
                problem.Add((k+1));
               
            }
           // MessageBox.Show(a.Width + " " + a.VerticalResolution + " " + a.Height + " " + a.HorizontalResolution);
           // MessageBox.Show(c.Width +" "+ c.VerticalResolution+" " + c.Height +" "+c.HorizontalResolution);
            //a.SetResolution(100,100);
            // a.Save(tmp);
            using (EncoderParameters encoderParameters = new EncoderParameters(1))
            using (EncoderParameter encoderParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L))
            {
                ImageCodecInfo codecInfo = ImageCodecInfo.GetImageDecoders().First(codec => codec.FormatID == ImageFormat.Jpeg.Guid);
                encoderParameters.Param[0] = encoderParameter;
                try
                {
                    a.Save(tmp, codecInfo, encoderParameters);
                    tmp = lastFolderName + @"\SubFolder\" + number + "b" + ".jpg";
                    fileno++;
                    b.Save(tmp, codecInfo, encoderParameters);
                }
                catch
                {
                    MessageBox.Show("ERROR SAVING CROPPED IMAGES");
                    
                }
            }
            a.Dispose();
            b.Dispose();
            s.Dispose();
            // GC.Collect();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void btn_resize_Click(object sender, EventArgs e)
        {
            
            btn_resizes();
        }
        private void btn_resizes()
        {
           
            int x = 0, y = 0;
            string boxdata = "";
            boxdata = comboBox1.Text;
            progressBar1.Value = 0;
            // var listdata;

            if (boxdata == "12x36")
            {
                x = 5400;
                y = 3600;
            }
            else if (boxdata == "11x33")
            {
                x = 4950;
                y = 3300;
            }
            else
            {try
                {
                    x = Convert.ToInt32(custombox2.Text) * 150;
                    y = Convert.ToInt32(custombox.Text) * 300;
                }
                catch
                {
                    MessageBox.Show("Enter only numbers");
                    return;
                }
            }
            for (int i = 0; i < listdata.Count; i++)
            {
                savefile(x, y);
                k++;

               // this.Invoke(new MethodInvoker(delegate () { progressBar1.Value = i+1; }));
               
               // worker.ReportProgress(i);
              // backgroundWorker1.ReportProgress(i);
                
               progressBar1.Value = i + 1;
            }
            if (problem.Count > 0)
            {
                string error = "";
                for (int i = 0; i < problem.Count; i++)
                {
                    error += "\n" + problem[i].ToString();

                }

                MessageBox.Show("THESE ARE AUTO RESIZED " + error);
            }
            MessageBox.Show("FILES SAVED");
            rename_txt.Text = "";
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            
            //listdata.Clear();
            Document doc = null;
            System.IO.Stream st;
            PdfWriter writer=null;

            progressBar1.Maximum = openimgfile.FileNames.Length;
            progressBar1.Minimum = 0;
           lastFolderName +=  @"\" + "print.pdf";
            Bitmap bimg = null;
            try
            {
                bimg = new Bitmap(openimgfile.FileName);
            }
            catch
            {
                MessageBox.Show("ERROR OPENING IMAGE FOR PDF CONVERTION");
                return;
            }

            iTextSharp.text.Rectangle pagesize = new iTextSharp.text.Rectangle(0, 0, bimg.Width*72/300, bimg.Height*72/300);
            MessageBox.Show(lastFolderName);
           
            bimg.Dispose();
            doc = new Document(pagesize, 0, 0, 0, 0);
            
              st = new FileStream(lastFolderName, FileMode.Create, FileAccess.Write);
               writer = PdfWriter.GetInstance(doc, st);
              doc.Open();
              writer.Open();
           
            for (int i=0;i<listdata.Count;i++)
            {

                iTextSharp.text.Image img = null;
                    try
                {
                    img = iTextSharp.text.Image.GetInstance(listdata[i]);
                    img.ScaleToFit(pagesize);
                    doc.Add(img);
                }
                catch
                {
                    MessageBox.Show("ERROR OPENING IMAGE FOR PDF CONVERTION\n File Name:- " + Path.GetFileName(listdata[i]));
                    doc.Close();
                    writer.Close();
                    progressBar1.Value = 0;
                    return;
                    
                }
                //////////
               
                
                //////////
                progressBar1.Value = i+1;
          
            }

            doc.Close();
            writer.Close();
           
            MessageBox.Show("PDF COMPLETED");
           
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Thread.CurrentThread.Join();
            //    new Thread(() => Application.Run(new Image_Settings())).Start();
           
            key = "page2";
            this.Close();
            //  Application.Run(new Image_Settings());

        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (key != "page2")
            { key = "close";}
        }

        private void Rename_btn_Click(object sender, EventArgs e)
        {
            rename_txt.Visible = true;
            ok_btn.Visible = true;
            
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (rename_txt.Text.ToString() != "")
            {
                fileno = Convert.ToInt32(rename_txt.Text.ToString());
            }
            else
                fileno = 1;

            MessageBox.Show("renamed saved");
            rename_txt.Visible = false;
            ok_btn.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 2)
            {
                custombox.Visible = true;
                custombox2.Visible = true;
                X.Visible = true;
            }
            else
            {
                custombox.Visible = false;
                custombox2.Visible = false;
                X.Visible =false;
            }
        }

        public static Bitmap AdjustContrast(Bitmap Image,float Value)
        {
            
            Value = (100.0f + Value) / 100.0f;
            Value *= Value;
            Bitmap NewBitmap = (Bitmap)Image.Clone();
            BitmapData data = NewBitmap.LockBits(
                new System.Drawing.Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height),
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
    }
}
