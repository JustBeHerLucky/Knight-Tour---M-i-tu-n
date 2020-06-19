using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Group : UserControl
    {
        bool wait = false;
        public Group()
        {
            InitializeComponent();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (wait)
            {
                wait = false;
                pictureBox3.Image = Image.FromFile("D:\\HOC\\C#\\Final\\Final\\Final\\blackKnight.jpg");
            }
            else
            {
                wait = true;
                pictureBox3.Image = null;
            }
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

        }

        public void label11_Click(object sender, EventArgs e)
        {

        }

        public void label9_Click(object sender, EventArgs e)
        {

        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void labX_Click(object sender, EventArgs e)
        {

        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        public void gpSave_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
