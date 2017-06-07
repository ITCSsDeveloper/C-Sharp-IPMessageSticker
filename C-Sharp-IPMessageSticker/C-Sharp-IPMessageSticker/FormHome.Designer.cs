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
            this.SuspendLayout();
            // 
            // listViewChild
            // 
            this.listViewChild.BackColor = System.Drawing.SystemColors.Control;
            this.listViewChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewChild.Location = new System.Drawing.Point(3, 43);
            this.listViewChild.Name = "listViewChild";
            this.listViewChild.Size = new System.Drawing.Size(293, 217);
            this.listViewChild.TabIndex = 0;
            this.listViewChild.UseCompatibleStateImageBehavior = false;
            this.listViewChild.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewChild_MouseClick);
            // 
            // listViewParent
            // 
            this.listViewParent.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewParent.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewParent.LabelWrap = false;
            this.listViewParent.Location = new System.Drawing.Point(1, 2);
            this.listViewParent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listViewParent.MultiSelect = false;
            this.listViewParent.Name = "listViewParent";
            this.listViewParent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewParent.Scrollable = false;
            this.listViewParent.ShowGroups = false;
            this.listViewParent.Size = new System.Drawing.Size(297, 40);
            this.listViewParent.TabIndex = 0;
            this.listViewParent.UseCompatibleStateImageBehavior = false;
            this.listViewParent.SelectedIndexChanged += new System.EventHandler(this.listViewParent_SelectedIndexChanged);
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(299, 262);
            this.Controls.Add(this.listViewChild);
            this.Controls.Add(this.listViewParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHome";
            this.Text = "Sticker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewChild;
        private System.Windows.Forms.ListView listViewParent;
        private System.Windows.Forms.ImageList imageListChild;
        private System.Windows.Forms.ImageList imageListParent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}

