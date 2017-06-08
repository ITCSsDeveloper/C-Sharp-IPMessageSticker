namespace C_Sharp_IPMessageSticker
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewChild = new System.Windows.Forms.ListView();
            this.listViewParent = new System.Windows.Forms.ListView();
            this.imageListChild = new System.Windows.Forms.ImageList(this.components);
            this.imageListParent = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHideShow = new System.Windows.Forms.Button();
            this.linkLabelSetting = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listViewChild
            // 
            this.listViewChild.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewChild.BackColor = System.Drawing.SystemColors.Control;
            this.listViewChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewChild.GridLines = true;
            this.listViewChild.Location = new System.Drawing.Point(29, 69);
            this.listViewChild.Name = "listViewChild";
            this.listViewChild.Size = new System.Drawing.Size(300, 220);
            this.listViewChild.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewChild.TabIndex = 0;
            this.listViewChild.UseCompatibleStateImageBehavior = false;
            this.listViewChild.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listViewChild_ItemMouseHover);
            this.listViewChild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewChild_MouseClick);
            this.listViewChild.MouseLeave += new System.EventHandler(this.listViewChild_MouseLeave);
            // 
            // listViewParent
            // 
            this.listViewParent.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewParent.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewParent.LabelWrap = false;
            this.listViewParent.Location = new System.Drawing.Point(29, 27);
            this.listViewParent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listViewParent.MultiSelect = false;
            this.listViewParent.Name = "listViewParent";
            this.listViewParent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewParent.Scrollable = false;
            this.listViewParent.Size = new System.Drawing.Size(300, 40);
            this.listViewParent.TabIndex = 0;
            this.listViewParent.UseCompatibleStateImageBehavior = false;
            this.listViewParent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewParent_MouseClick);
            // 
            // imageListChild
            // 
            this.imageListChild.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChild.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListChild.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListParent
            // 
            this.imageListParent.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListParent.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListParent.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnHideShow
            // 
            this.btnHideShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHideShow.Location = new System.Drawing.Point(3, 1);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(23, 288);
            this.btnHideShow.TabIndex = 2;
            this.btnHideShow.Text = ">";
            this.btnHideShow.UseVisualStyleBackColor = true;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // linkLabelSetting
            // 
            this.linkLabelSetting.AutoSize = true;
            this.linkLabelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.linkLabelSetting.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelSetting.Location = new System.Drawing.Point(274, 7);
            this.linkLabelSetting.Name = "linkLabelSetting";
            this.linkLabelSetting.Size = new System.Drawing.Size(52, 17);
            this.linkLabelSetting.TabIndex = 3;
            this.linkLabelSetting.TabStop = true;
            this.linkLabelSetting.Text = "Setting";
            this.linkLabelSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetting_LinkClicked);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 292);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelSetting);
            this.Controls.Add(this.btnHideShow);
            this.Controls.Add(this.listViewChild);
            this.Controls.Add(this.listViewParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewChild;
        private System.Windows.Forms.ListView listViewParent;
        private System.Windows.Forms.ImageList imageListChild;
        private System.Windows.Forms.ImageList imageListParent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHideShow;
        private System.Windows.Forms.LinkLabel linkLabelSetting;

    }
}

