namespace Final
{
    partial class thucThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thucThi));
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yStart = new System.Windows.Forms.TextBox();
            this.xStart = new System.Windows.Forms.TextBox();
            this.khoiTao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(142, 16);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(99, 20);
            this.size.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập kích thước bàn cờ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(142, 69);
            this.label2.MaximumSize = new System.Drawing.Size(0, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 2);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập toạ độ xuất phát";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 2);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "X: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Y:";
            // 
            // yStart
            // 
            this.yStart.Location = new System.Drawing.Point(159, 91);
            this.yStart.Name = "yStart";
            this.yStart.Size = new System.Drawing.Size(82, 20);
            this.yStart.TabIndex = 7;
            this.yStart.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // xStart
            // 
            this.xStart.Location = new System.Drawing.Point(48, 91);
            this.xStart.Name = "xStart";
            this.xStart.Size = new System.Drawing.Size(82, 20);
            this.xStart.TabIndex = 9;
            // 
            // khoiTao
            // 
            this.khoiTao.Location = new System.Drawing.Point(15, 141);
            this.khoiTao.Name = "khoiTao";
            this.khoiTao.Size = new System.Drawing.Size(225, 22);
            this.khoiTao.TabIndex = 10;
            this.khoiTao.Text = "Khởi tạo bàn cờ";
            this.khoiTao.UseVisualStyleBackColor = true;
            this.khoiTao.Click += new System.EventHandler(this.khoiTao_Click);
            // 
            // thucThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 181);
            this.Controls.Add(this.khoiTao);
            this.Controls.Add(this.xStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "thucThi";
            this.Text = "Mã đi dạo";
            this.Load += new System.EventHandler(this.thucThi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox yStart;
        private System.Windows.Forms.TextBox xStart;
        private System.Windows.Forms.Button khoiTao;
    }
}

