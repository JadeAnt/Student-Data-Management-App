using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDM_Ui_Design
{
    public partial class secondUserCustomControl1 : UserControl
    {
        public secondUserCustomControl1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;

            }
            SlidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
