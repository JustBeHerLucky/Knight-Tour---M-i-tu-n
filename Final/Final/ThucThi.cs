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
    public partial class thucThi : Form
    {
        public BanCo form = new BanCo();
        private int kichThuoc;
        private int x;
        private int y;
        
        public thucThi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void thucThi_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void khoiTao_Click(object sender, EventArgs e)
        {
            Boolean check = false;
            try {
                kichThuoc = Convert.ToInt32(size.Text);
                if (kichThuoc <= 0) { 
                    MessageBox.Show("Kích thước phải là số nguyên lớn hơn 0","Thông báo");
                    size.Focus();
                }
                try
                {
                    x = Convert.ToInt32(xStart.Text);
                    y = Convert.ToInt32(yStart.Text);
                    if (x <= 0 || x > kichThuoc)
                    {
                        MessageBox.Show("Toạ độ x phải lớn hơn 0 và bé hơn hoặc bằng kích thước bàn cờ", "Thông báo");
                        xStart.Focus();
                    }
                    else if (y <= 0 || y > kichThuoc)
                    {
                        MessageBox.Show("Toạ độ y phải lớn hơn 0 và bé hơn hoặc bằng kích thước bàn cờ", "Thông báo");
                        yStart.Focus();
                    }
                    else check = true;
                }
                catch
                {
                    MessageBox.Show("Vị trí ban đầu phải là số nguyên!", "Thông báo");
                }          
            }
            catch
            {
                MessageBox.Show("Kích thước phải là số nguyên!", "Thông báo");
            }
            if (check)
            {
                BanCo banCo = new BanCo(kichThuoc, x, y);
                banCo.Show();
                banCo.khoiTao();
                Hide();
            }
            
            
        }
    }
}
