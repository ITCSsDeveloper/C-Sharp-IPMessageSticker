using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetListItemParent();

            GetListItemChild();
        }

        public void GetListItemParent()
        {

            //DirectoryInfo dir = new DirectoryInfo("Image");
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
        }




        public void GetListItemChild(int dirName = 0)
        {
            DirectoryInfo dir = new DirectoryInfo("Image/" + dirName);
            imageListChild.Images.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    imageListChild.Images.Add(Image.FromFile(file.FullName));
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
                listViewChild.Items.Add(item);
            }
        }

        private void listViewParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewParent.FocusedItem.Index;

            GetListItemChild(index);
        }
    }
}
