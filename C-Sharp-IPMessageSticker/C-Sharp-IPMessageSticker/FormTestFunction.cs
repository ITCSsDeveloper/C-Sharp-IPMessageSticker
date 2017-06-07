﻿using System;
using System.ComponentModel;
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

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);

        public FormTestFunction()
        {
            InitializeComponent();

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;


            cSticker.GetStickers();

            // Thread.Sleep(100);
            // this.Hide();
            //backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = cMain.LoadImageFormPath(@"D:\f1.gif");
            cMain.Clipbroad_AddImage(image);
            SwitchToThisWindow(cMain.GetProcessIPMSG().MainWindowHandle, true);

            Thread.Sleep(50);
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
    }
}