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
    public partial class TestPreview : Form
    {
        public string PathImage {
            set { pictureBox1.ImageLocation = value; } 
        }
        public TestPreview()
        {
            InitializeComponent();
        }
    }
}
