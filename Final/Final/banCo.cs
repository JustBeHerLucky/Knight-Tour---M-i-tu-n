using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class BanCo : Form
    {
        public int[,] vt = new int[3, 2501];
        private int kichThuoc;
        private int x, _x;
        private int y, _y;
        private Label[,] labelSo;
        private PictureBox[,] table;
        private int step = 1;
        private Group _group;
        private bool start = false;
        public string gray = "grayBackGround.jpg";
        public string red = "redBackGround.jpg";
        public string whiteKnight = "whiteKnight.png";
        public string blackKnight = "blackKnight.png";
        public BanCo(int size, int xStart, int yStart)
        {
            kichThuoc = size;
            x = xStart;
            y = yStart;
        }
        
        public BanCo()
        {
            InitializeComponent();
        }

        public void khoiTao()
        {
            timer1 = new Timer();
            timer2 = new Timer();
            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            //timer1.Enabled = false;
            //timer2.Enabled = false;
            this.Controls.Clear();
            Knight _knight = new Knight();
            labelSo = new Label[2, kichThuoc + 1];
            for (int i = 1; i <= kichThuoc; i++)
            {
                //Ngang
                labelSo[1, i] = new Label();
                labelSo[1, i].AutoSize = true;
                labelSo[1, i].Location = new System.Drawing.Point(30 * i - 5, 9);
                labelSo[1, i].Name = i.ToString();
                labelSo[1, i].Size = new System.Drawing.Size(19, 13);
                labelSo[1, i].TabIndex = 1;
                labelSo[1, i].Text = i.ToString();
                labelSo[1, i].ForeColor = Color.Red;
                this.Controls.Add(labelSo[1, i]);
                //Doc
                labelSo[0, i] = new Label();
                labelSo[0, i].AutoSize = true;
                labelSo[0, i].Location = new System.Drawing.Point(5, 30 * i - 5);
                labelSo[0, i].Name = i.ToString();
                labelSo[0, i].Size = new System.Drawing.Size(19, 13);
                labelSo[0, i].TabIndex = 1;
                labelSo[0, i].Text = i.ToString();
                labelSo[0, i].ForeColor = Color.Red;
                this.Controls.Add(labelSo[0, i]);
            }
            table = new PictureBox[kichThuoc+1, kichThuoc+1];
            for (int i = 1; i <= kichThuoc; i++)
            {
                for (int j = 1; j <= kichThuoc; j++)
                {
                    table[i, j] = new PictureBox();
                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)  table[i, j].BackgroundImage = Image.FromFile(gray);                         
                        else table[i, j].BackgroundImage = Image.FromFile(red);
                    }
                    else if (j % 2 != 0) table[i, j].BackgroundImage = Image.FromFile(red);
                    else table[i, j].BackgroundImage = Image.FromFile(gray);


                    table[i, j].Location = new System.Drawing.Point(25 + (j - 1) * 30, 25 + (i - 1) * 30);
                    table[i, j].Name = "pictureBox1";
                    table[i, j].Size = new System.Drawing.Size(30, 30);
                    table[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    table[i, j].TabIndex = 0;
                    table[i, j].TabStop = false;
                    this.Controls.Add(table[i, j]);
                }
            }
            table[x, y].Image = Image.FromFile(blackKnight);
            //Khởi tạo control điều khiển chương trình chính
            _group = new Group();
            _group.Top = 12;
            _group.Left = 25 + 12 + 30 * kichThuoc;
            _group.labKT.Text = "Kích thước bàn cờ: " + kichThuoc.ToString() + "x" + kichThuoc.ToString();
            _group.labX.Text = "Tọa độ X xuất phát: " + x.ToString();
            _group.labY.Text = "Tọa độ Y xuất phát: " + y.ToString();
            _knight.Set(kichThuoc, x, y);
            _knight._vt = vt;
            if (_knight.TimDuong() == true)
            {
                _group.labKQ.Text = "Trạng thái kết quả: Tìm thấy đường đi";
            }
            else
            {
                _group.labKQ.Text = "Trạng thái kết quả: Không có đường đi";
                _group.gpFinal.Enabled = false;
                _group.gpSave.Enabled = false;
            }
            _x = x;
            _y = y;
            _group.Start.Click += new EventHandler(btnVT_BatDau_Click);
            _group.Create.Click += new EventHandler(btnVT_thucThi_Click);
            _group.Save.Click += new EventHandler(btnVT_Luu_Click);
            
            this.Controls.Add(_group);
            //Khởi tạo tùy chọn
            step = 1;
            start = false;
            //Điều chỉnh độ rộng thích hợp cho form
            Width = 50 + 30 * kichThuoc + _group.Width;
            this.WindowState = FormWindowState.Normal;
            if (kichThuoc <= 14)
            {
                AutoScroll = false;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                MaximizeBox = false;
                _group.Height = 30 + 30 * 14;
                Height = 25 + 12 + 30 * 14 + 34;//34 là chiều cao của thanh tiêu đề
            }
            else
            {
                AutoScroll = true;
                FormBorderStyle = FormBorderStyle.Sizable;
                MaximizeBox = true;
                _group.Height = 30 + 30 * kichThuoc;
                Width += 20;//20 độ rộng của thanh trượt
                Height = 25 + 12 + 30 * kichThuoc + 34 + 20;//34 là chiều cao của thanh tiêu đề, 20 là chiều cao than trượt
            }
        }
        void get_Time()
        {     
                timer1.Interval =  (int)(float.Parse(_group.Time.Text) * 1000);
                timer2.Enabled = true;           
        }
        void btnVT_Luu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine("Kich thuoc ban co: " + kichThuoc.ToString() + "x" + kichThuoc.ToString());
                streamWriter.WriteLine("Toa do xuat phat: ( " + x.ToString() + " , " + y.ToString() + " )");
                streamWriter.WriteLine("Toa do cac diem di lan luot la:");
                for (int i = 1; i < kichThuoc * kichThuoc; i++)
                    streamWriter.WriteLine("( " + vt[1, i].ToString() + " , " + vt[2, i].ToString() + " )");
                streamWriter.WriteLine("Ket thuc...");
                streamWriter.Close();
                fileStream.Close();
            }
        }
        void btnVT_thucThi_Click(object sender, EventArgs e)
        {
            Hide();
            thucThi newInit = new thucThi();
            newInit.form = this;
            newInit.Show();
            newInit.Focus();
        }

        void btnVT_BatDau_Click(object sender, EventArgs e)
        {
            get_Time();
            if (start == false)//bắt đầu chạy tự động
            {
                start = true;
                _group.Start.Text =(String)"Ngừng";             
                timer1.Interval = (int)(float.Parse(_group.Time.Text) * 1000);
                timer1.Enabled = true;
                timer2.Enabled = true;                              
            }
            else
            {
                start = false;
                _group.Start.Text = "Tiếp tục";
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine("Kich thuoc ban co: " + kichThuoc.ToString() + "x" + kichThuoc.ToString());
                streamWriter.WriteLine("Toa do xuat phat: ( " + x.ToString() + " , " + y.ToString() + " )");
                streamWriter.WriteLine("Toa do cac diem di lan luot la:");
                for (int i = 1; i < kichThuoc * kichThuoc; i++)
                    streamWriter.WriteLine("( " + vt[1, i].ToString() + " , " + vt[2, i].ToString() + " )");
                streamWriter.WriteLine("Ket thuc...");
                streamWriter.Close();
                fileStream.Close();
            }
        }
        void btnthucThi_Click(object sender, EventArgs e)
        {
            thucThi form = new thucThi();
            form.form = this;
            form.Show();
            form.Focus();
        }
        public void xoaNgua()
        {
            for (int i = 1; i <= kichThuoc; i++)
            {
                for (int j = 1; j <= kichThuoc; j++)
                {
                    table[i, j].Image = null;
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step == 0)
            {
                step++;
                xoaNgua();
                table[x, y].Image = Image.FromFile(blackKnight);
                table[x, y].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                table[_x, _y].Image = Image.FromFile(whiteKnight);
                table[_x, _y].SizeMode = PictureBoxSizeMode.StretchImage;
                _x = vt[1, step];
                _y = vt[2, step];
                table[_x, _y].Image = Image.FromFile(blackKnight);
                table[_x, _y].SizeMode = PictureBoxSizeMode.StretchImage;
                step++;
                if (step == kichThuoc * kichThuoc)//đi hết bàn cờ
                {
                    _x = x;
                    _y = y;
                    step = 0;
                    start = false;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    _group.Start.Text = "Bắt đầu";
                }
            }
        }

        private void Main_Scroll(object sender, ScrollEventArgs e)
        {
            _group.Top = 12;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        bool doi1 = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (step != 0)
            {
                if (doi1)
                {
                    doi1 = false;
                    table[vt[1, step], vt[2, step]].Image = Image.FromFile(blackKnight);
                }
                else
                {
                    doi1 = true;
                    table[vt[1, step], vt[2, step]].Image = null;
                }
            }
        }
  
    private void banCo_Load(object sender, EventArgs e)
        {

        }
    }
}
