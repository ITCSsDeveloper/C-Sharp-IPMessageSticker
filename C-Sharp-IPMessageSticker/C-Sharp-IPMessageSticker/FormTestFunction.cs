using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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
            cMain.Clipbroad_AddImage(image);
            SwitchToThisWindow(cMain.GetProcessIPMSG().MainWindowHandle, true);

            Thread.Sleep(100);
            SendKeys.Send("^V");
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

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);

        private String ProcWindow = "itunes";
        //function which calls switchWindow() is here but not important

        //now we have switch window.
        private void switchWindow()
        {
            Process[] procs = Process.GetProcessesByName(ProcWindow);
            foreach (Process proc in procs)
            {
                //switch to process by name
                SwitchToThisWindow(proc.MainWindowHandle, false);
            }
        }
    }
}