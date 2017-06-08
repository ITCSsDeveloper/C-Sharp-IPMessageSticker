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
            GetListItemParent();
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
                AllSticker = cSticker.GetStickers();
                GetListItemParent();
            }
        }

        public void GetListItemParent()
        {
            imageListParent.Images.Clear();
            foreach (var stickerSet in AllSticker)
            {
                if (stickerSet.NameHeader != "Recent")
                {
                    imageListParent.Images.Add(stickerSet.NameHeader, Image.FromFile(stickerSet.IconHeader));
                }
            }

            listViewParent.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewParent.SelectedItems.Count > 0)
            {
                if (listViewParent.SelectedItems[0].ImageKey == @"Basic")
                {
                    MessageBox.Show(@"You can't delete basic sticker.",
              @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(@"Are you sure that you want to delete this sticker set?",
              @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.OK)
                    {
                        cSticker.DeleteSticker(listViewParent.SelectedItems[0].ImageKey);
                        AllSticker = cSticker.GetStickers();
                        GetListItemParent();
                    }
                }

            }
        }
    }
}
