using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormSetting : Form
    {
        private IEnumerable<StickerSet> AllSticker;

        public FormSetting()
        {
            InitializeComponent();
            AllSticker = cSticker.GetStickers();
        }

        private void btnClearRecent_Click(object sender, EventArgs e)
        {
            cSticker.ClearRecent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = null;

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBrowse.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStickerSetName.Text.Trim()) || string.IsNullOrEmpty(txtBrowse.Text.Trim()))
            {
                MessageBox.Show(this, @"กรุณาระบุชื่อ Sticker และ Browse ไฟล์ที่ต้องการ Import", @"Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cSticker.ImportStickers(txtStickerSetName.Text.Trim(), txtBrowse.Text.Trim());
            }
        }

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
    }
}
