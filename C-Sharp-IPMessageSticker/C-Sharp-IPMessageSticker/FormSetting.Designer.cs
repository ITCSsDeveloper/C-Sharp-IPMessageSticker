namespace C_Sharp_IPMessageSticker
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.txtStickerSetName = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Manage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearRecent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewChild = new System.Windows.Forms.ListView();
            this.listViewParent = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.TabPage();
            this.imageListChild = new System.Windows.Forms.ImageList(this.components);
            this.imageListParent = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.Manage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStickerSetName
            // 
            this.txtStickerSetName.Location = new System.Drawing.Point(111, 282);
            this.txtStickerSetName.Name = "txtStickerSetName";
            this.txtStickerSetName.Size = new System.Drawing.Size(182, 20);
            this.txtStickerSetName.TabIndex = 8;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(299, 250);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 78);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(218, 305);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(111, 308);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.ReadOnly = true;
            this.txtBrowse.Size = new System.Drawing.Size(101, 20);
            this.txtBrowse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(71, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(66, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sticker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(107, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add new sticker set";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Manage);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 374);
            this.tabControl1.TabIndex = 10;
            // 
            // Manage
            // 
            this.Manage.Controls.Add(this.panel3);
            this.Manage.Controls.Add(this.btnClearRecent);
            this.Manage.Controls.Add(this.panel2);
            this.Manage.Controls.Add(this.btnBrowse);
            this.Manage.Controls.Add(this.label2);
            this.Manage.Controls.Add(this.txtBrowse);
            this.Manage.Controls.Add(this.label3);
            this.Manage.Controls.Add(this.btnImport);
            this.Manage.Controls.Add(this.label1);
            this.Manage.Controls.Add(this.txtStickerSetName);
            this.Manage.Location = new System.Drawing.Point(4, 22);
            this.Manage.Name = "Manage";
            this.Manage.Padding = new System.Windows.Forms.Padding(3);
            this.Manage.Size = new System.Drawing.Size(603, 348);
            this.Manage.TabIndex = 0;
            this.Manage.Text = "Mange";
            this.Manage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(417, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 100);
            this.panel3.TabIndex = 1015;
            // 
            // btnClearRecent
            // 
            this.btnClearRecent.Location = new System.Drawing.Point(453, 249);
            this.btnClearRecent.Name = "btnClearRecent";
            this.btnClearRecent.Size = new System.Drawing.Size(123, 78);
            this.btnClearRecent.TabIndex = 1013;
            this.btnClearRecent.Text = "ClearRecent";
            this.btnClearRecent.UseVisualStyleBackColor = true;
            this.btnClearRecent.Click += new System.EventHandler(this.btnClearRecent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewChild);
            this.panel2.Controls.Add(this.listViewParent);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 221);
            this.panel2.TabIndex = 1012;
            // 
            // listViewChild
            // 
            this.listViewChild.BackColor = System.Drawing.SystemColors.Control;
            this.listViewChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewChild.Location = new System.Drawing.Point(12, 56);
            this.listViewChild.Name = "listViewChild";
            this.listViewChild.Size = new System.Drawing.Size(568, 132);
            this.listViewChild.TabIndex = 2;
            this.listViewChild.UseCompatibleStateImageBehavior = false;
            // 
            // listViewParent
            // 
            this.listViewParent.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewParent.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewParent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewParent.LabelWrap = false;
            this.listViewParent.Location = new System.Drawing.Point(12, 8);
            this.listViewParent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listViewParent.MultiSelect = false;
            this.listViewParent.Name = "listViewParent";
            this.listViewParent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViewParent.Scrollable = false;
            this.listViewParent.ShowGroups = false;
            this.listViewParent.Size = new System.Drawing.Size(568, 40);
            this.listViewParent.TabIndex = 1;
            this.listViewParent.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(603, 348);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
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
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Program is running in backgroud.";
            this.notifyIcon.BalloonTipTitle = "IPMessage Sticker";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "IPMessage Sticker";
            this.notifyIcon.Visible = true;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSetting";
            this.Text = "Setting";
            this.tabControl1.ResumeLayout(false);
            this.Manage.ResumeLayout(false);
            this.Manage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStickerSetName;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Manage;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearRecent;
        private System.Windows.Forms.ListView listViewParent;
        private System.Windows.Forms.ListView listViewChild;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imageListChild;
        private System.Windows.Forms.ImageList imageListParent;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}