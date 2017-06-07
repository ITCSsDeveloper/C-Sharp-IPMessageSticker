using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormTestFunction : Form
    {
        public FormTestFunction()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = cMain.LoadImageFormPath(@"D:\bokeh6.jpg");
            cMain.AddImage(image);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (cMain.CheckProcess())
                {
                    this.Show();
                }
            }
        }
    }
}