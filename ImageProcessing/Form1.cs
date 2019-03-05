using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Stack<Bitmap> stack = new Stack<Bitmap>();
        public Form1()
        {
            InitializeComponent();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);

            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {

                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;

        }

        private void х3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new Mediana(3);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void х5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new Mediana(5);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " Image files|*.png; *.jpg; *.bmp| All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);

                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }


        }

        private void сохранитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPeg Image|.jpg|Bitmap Image|.bmp|Gif Image|*.gif";
            dialog.Title = "Save an Image File";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {

                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                switch (dialog.FilterIndex)
                {
                    case 1:
                        this.image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void назToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stack.Count == 0)
            {
                return;
            }
            else
            {
                image = stack.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }

        }

       
        private void обычнаяМатрицаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new Laplass1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void расширеннаяМатрицаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new Laplass2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрCобеляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрацияСПодъемомВысокихЧастотToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new FrequencyIncrease(Convert.ToDouble(textBox1.Text));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process myProcess = new Process();
            myProcess.StartInfo.FileName = "info.docx";
            myProcess.StartInfo.Verb = "Open";
            myProcess.StartInfo.CreateNoWindow = false;
            myProcess.Start();
        }

        private void обычнаяМатрицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new LinearSmoothing();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void маскаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new LinearSmoothing2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void х7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stack.Push(image);
            Filters filter = new Mediana(7);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
