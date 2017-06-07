using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormHome : Form
    {
        private bool isActive = false;

        private int screenWidth;
        private int screenHeight;
        private IEnumerable<StickerSet> AllSticker;


        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool turnon);


        public FormHome()
        {
            InitializeComponent();

            AllSticker = cSticker.GetStickers();
            GetListItemParent();
            GetListItemChild();

            Thread.Sleep(100);
            this.Hide();
            backgroundWorker1.RunWorkerAsync();
        }

        public void GetListItemParent()
        {
            foreach (var stickerSet in AllSticker)
            {
                imageListParent.Images.Add(stickerSet.NameHeader, Image.FromFile(stickerSet.IconHeader));
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
                                Location = new Point(screenWidth - (Width), screenHeight - (Height + 40));
                                Show();
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
            }

        }
    }
}



//
//foreach (var folder in dir.GetDirectories())
//{
//    imageListParent.Images.Add(Image.FromFile(folder.GetFiles()[0].FullName));
//}

//listViewParent.View = View.LargeIcon;
//imageListParent.ImageSize = new Size(25, 25);
//listViewParent.LargeImageList = imageListParent;

//for (int j = 0; j < imageListParent.Images.Count; j++)
//{
//    ListViewItem item = new ListViewItem();
//    item.ImageIndex = j;
//    listViewParent.Items.Add(item);
//}