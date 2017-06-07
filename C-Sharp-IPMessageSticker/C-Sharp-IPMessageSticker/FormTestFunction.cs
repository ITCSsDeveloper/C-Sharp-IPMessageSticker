using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormTestFunction : Form
    {
        private bool isActive = false;

        private int screenWidth;
        private int screenHeight;

        public FormTestFunction()
        {
            InitializeComponent();

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Hide();
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
                Thread.Sleep(200);

                var process = cMain.GetProcessIPMSG();
                if (process != null)
                {
                    if (process.MainWindowTitle.Contains("Send Message"))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (!isActive)
                            {
                                this.Location = new Point(screenWidth - this.Width + 10, screenHeight - (this.Height + 30));
                                this.Show();
                            }

                            isActive = true;
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (isActive)
                            {
                                this.Hide();
                            }

                            isActive = false;
                        });
                    }
                }
            }
        }
    }
}