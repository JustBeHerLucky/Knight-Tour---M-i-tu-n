namespace Final
{
    partial class Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.labKT = new System.Windows.Forms.Label();
            this.labX = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.labKQ = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gpFinal = new System.Windows.Forms.GroupBox();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.gpSave = new System.Windows.Forms.GroupBox();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gpFinal.SuspendLayout();
            this.gpInfo.SuspendLayout();
            this.gpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // labKT
            // 
            this.labKT.AutoSize = true;
            this.labKT.Location = new System.Drawing.Point(23, 16);
            this.labKT.Name = "labKT";
            this.labKT.Size = new System.Drawing.Size(99, 13);
            this.labKT.TabIndex = 1;
            this.labKT.Text = "Kích thước bàn cờ:";
            this.labKT.Click += new System.EventHandler(this.label2_Click);
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Location = new System.Drawing.Point(23, 38);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(104, 13);
            this.labX.TabIndex = 2;
            this.labX.Text = "Vị trí x lúc xuất phát:";
            this.labX.Click += new System.EventHandler(this.labX_Click);
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.Location = new System.Drawing.Point(23, 61);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(104, 13);
            this.labY.TabIndex = 3;
            this.labY.Text = "Vị trí y lúc xuất phát:";
            // 
            // labKQ
            // 
            this.labKQ.AutoSize = true;
            this.labKQ.Location = new System.Drawing.Point(23, 84);
            this.labKQ.Name = "labKQ";
            this.labKQ.Size = new System.Drawing.Size(97, 13);
            this.labKQ.TabIndex = 4;
            this.labKQ.Text = "Trạng thái kết quả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vị trí mã đã đi qua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vị trí mã hiện tại";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thời  gian chờ (giây): ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(142, 101);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(74, 20);
            this.Time.TabIndex = 9;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(184, 99);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(88, 22);
            this.Create.TabIndex = 10;
            this.Create.Text = "Tạo mới";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Lưu file kết quả";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(184, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(88, 22);
            this.Save.TabIndex = 13;
            this.Save.Text = "Lưu file";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Vị trí mã sẽ đi tiếp theo";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(157, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(157, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // gpFinal
            // 
            this.gpFinal.Controls.Add(this.Start);
            this.gpFinal.Controls.Add(this.pictureBox3);
            this.gpFinal.Controls.Add(this.pictureBox2);
            this.gpFinal.Controls.Add(this.pictureBox1);
            this.gpFinal.Controls.Add(this.label11);
            this.gpFinal.Controls.Add(this.Time);
            this.gpFinal.Controls.Add(this.label9);
            this.gpFinal.Controls.Add(this.label8);
            this.gpFinal.Controls.Add(this.label7);
            this.gpFinal.ForeColor = System.Drawing.Color.Red;
            this.gpFinal.Location = new System.Drawing.Point(9, 156);
            this.gpFinal.Name = "gpFinal";
            this.gpFinal.Size = new System.Drawing.Size(296, 176);
            this.gpFinal.TabIndex = 18;
            this.gpFinal.TabStop = false;
            this.gpFinal.Text = "Kết quả";
            this.gpFinal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.labKQ);
            this.gpInfo.Controls.Add(this.labY);
            this.gpInfo.Controls.Add(this.labX);
            this.gpInfo.Controls.Add(this.labKT);
            this.gpInfo.Controls.Add(this.Create);
            this.gpInfo.ForeColor = System.Drawing.Color.Red;
            this.gpInfo.Location = new System.Drawing.Point(9, 12);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(296, 138);
            this.gpInfo.TabIndex = 19;
            this.gpInfo.TabStop = false;
            this.gpInfo.Text = "Thông tin bàn cờ";
            // 
            // gpSave
            // 
            this.gpSave.Controls.Add(this.Save);
            this.gpSave.Controls.Add(this.label10);
            this.gpSave.ForeColor = System.Drawing.Color.Red;
            this.gpSave.Location = new System.Drawing.Point(9, 332);
            this.gpSave.Name = "gpSave";
            this.gpSave.Size = new System.Drawing.Size(296, 37);
            this.gpSave.TabIndex = 20;
            this.gpSave.TabStop = false;
            this.gpSave.Text = "Lưu kết quả";
            this.gpSave.Enter += new System.EventHandler(this.gpSave_Enter);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(184, 137);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(88, 22);
            this.Start.TabIndex = 11;
            this.Start.Text = "Bắt đầu";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpSave);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.gpFinal);
            this.Name = "Group";
            this.Size = new System.Drawing.Size(308, 383);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gpFinal.ResumeLayout(false);
            this.gpFinal.PerformLayout();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.gpSave.ResumeLayout(false);
            this.gpSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label labKT;
        public System.Windows.Forms.Label labX;
        public System.Windows.Forms.Label labY;
        public System.Windows.Forms.Label labKQ;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox Time;
        public System.Windows.Forms.Button Create;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.GroupBox gpFinal;
        public System.Windows.Forms.GroupBox gpInfo;
        public System.Windows.Forms.GroupBox gpSave;
        public System.Windows.Forms.Button Start;
    }
}