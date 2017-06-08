using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormHome : Form
    {
        private bool isActive = false;
        private bool isShow = false;
        private bool isHideByUser = false;

        private string Root = @"Stickers/";
        private string Recent = @"Recent/";

        private string _last = "Recent";


        private int screenWidth;
        private int screenHeight;
        
        private IEnumerable<StickerSet> AllSticker;


        public FormHome()
        {
            InitializeComponent();

            screenWidth = Screen.PrimaryScreen.Bounds.Width;
            screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(screenWidth - (Width), screenHeight - (Height + 40));
            AllSticker = cSticker.GetStickers();

            GetListItemParent();
            GetListItemChild("Recent");

            backgroundWorker1.RunWorkerAsync();
        }

        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);



        public void GetListItemParent()
        {
            imageListParent.Images.Add("Recent", Image.FromFile(@"Image\Recent.png"));

            foreach (var stickerSet in AllSticker)
            {
                if (stickerSet.NameHeader != "Recent")
                {
                    imageListParent.Images.Add(stickerSet.NameHeader, Image.FromFile(stickerSet.IconHeader));
                }
            }

            listViewParent.View = View.LargeIcon;
            imageListParent.ImageSize = new Size(25, 25);
            listViewParent.LargeImageList = imageListParent;

            for (int j = 0; j < imageListParent.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.ImageKey = imageListParent.Images.Keys[j];
                listViewParent.Items.Add(item);
            }
        }

        public void GetListItemChild(string stickerSetName = "Basic")
        {
            imageListChild.Images.Clear();

            foreach (var sticker in AllSticker.FirstOrDefault(x => x.NameHeader == stickerSetName).Stickers)
            {
                try
                {
                    imageListChild.Images.Add(sticker.Path, Image.FromFile(sticker.Path));
                }
                catch
                {
                    Console.WriteLine(@"This is not an image file");
                }
            }


            listViewChild.View = View.LargeIcon;
            imageListChild.ImageSize = new Size(40, 40);
            listViewChild.LargeImageList = imageListChild;
            listViewChild.Items.Clear();
            for (int j = 0; j < imageListChild.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                item.ImageKey = imageListChild.Images.Keys[j];
                listViewChild.Items.Add(item);
            }
        }

        private void listViewParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = listViewParent.SelectedItems[0].ImageKey;

            GetListItemChild(key);
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
                        screenWidth = Screen.PrimaryScreen.Bounds.Width;
                        screenHeight = Screen.PrimaryScreen.Bounds.Height;
                        Invoke((MethodInvoker)delegate
                        {
                            if (!isActive)
                            {
                                SetShow();
                            }
                        });
                    }
                    else
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            if (isActive)
                            {
                                this.Hide();
                                isActive = false;
                            }
                        });
                    }
                }
            }
        }

        private void SetShow()
        {
            listViewParent.Visible = true;
            listViewChild.Visible = true;
            Size = new Size(334, 292);
            Location = new Point(screenWidth - (Width), screenHeight - (Height + 40));
            btnHideShow.Text = @">";
            isActive = true;
            Show();
        }


        private void linkLabelSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (isActive == true && isShow == false)
            {
                Location = new Point(screenWidth - (20), screenHeight - (Height + 40));
                listViewParent.Visible = false;
                listViewChild.Visible = false;
                Size = new Size(23, 292);
                btnHideShow.Text = @"<";
                isShow = true;
            }
            else if (isActive == true && isShow == true)
            {
                listViewParent.Visible = true;
                listViewChild.Visible = true;
                Size = new Size(334, 292);
                Location = new Point(screenWidth - (Width), screenHeight - (Height + 40));
                btnHideShow.Text = @">";
                isShow = false;
                Show();
            }
            else
            {
                Hide();
            }
        }



        private void listViewParent_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewParent.SelectedItems.Count > 0)
            {
                string key = listViewParent.SelectedItems[0].ImageKey;
                _last = key;

                GetListItemChild(key);
            }
        }

        private void listViewChild_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewChild.SelectedItems.Count > 0)
            {
                string path = listViewChild.SelectedItems[0].ImageKey;
                Image image = cMain.LoadImageFormPath(path);
                cMain.Clipbroad_AddImage(image);
                SwitchToThisWindow(cMain.GetProcessIPMSG().MainWindowHandle, true);

                Thread.Sleep(50);
                SendKeys.Send("^V");
                var firstOrDefault = AllSticker.FirstOrDefault(x => x.NameHeader == _last);
                if (firstOrDefault != null)
                {
                    Sticker item = firstOrDefault.Stickers.FirstOrDefault(y => y.Path == path);
                    cSticker.AddToRecent(item);
                }
            }
        }

    }
}
