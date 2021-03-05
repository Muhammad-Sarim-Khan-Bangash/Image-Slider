using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSlider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imageno = 1;

        private void loadimage()
        {
            if(imageno == 17)
            {
                imageno = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", imageno);
            imageno++;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            loadimage();
        }
    }
}
