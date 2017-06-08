using System.Drawing;
using System.Windows.Forms;

namespace C_Sharp_IPMessageSticker
{
    public partial class FormPreview : Form
    {

        public string PathImage
        {
            set
            {

                if (pictureBox1.ImageLocation != value)
                {
                    pictureBox1.ImageLocation = value;
                }
            }
        }


        public FormPreview(Point point)
        {
            InitializeComponent();
            Location = point;
        }



    }
}
