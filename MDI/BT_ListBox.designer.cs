namespace BaiTapListBox
{
    partial class BT_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoaDauVaCuoi = new System.Windows.Forms.Button();
            this.btnXoaPTChon = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnThayBinh = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(401, 18);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 52);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(250, 120);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(247, 23);
            this.btnTong.TabIndex = 3;
            this.btnTong.Text = "Tổng Các Phần Tử";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoaDauVaCuoi
            // 
            this.btnXoaDauVaCuoi.Location = new System.Drawing.Point(250, 149);
            this.btnXoaDauVaCuoi.Name = "btnXoaDauVaCuoi";
            this.btnXoaDauVaCuoi.Size = new System.Drawing.Size(247, 23);
            this.btnXoaDauVaCuoi.TabIndex = 4;
            this.btnXoaDauVaCuoi.Text = "Xóa Phần Tử Đầu Và Cuối";
            this.btnXoaDauVaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauVaCuoi.Click += new System.EventHandler(this.btnXoaDauVaCuoi_Click);
            // 
            // btnXoaPTChon
            // 
            this.btnXoaPTChon.Location = new System.Drawing.Point(250, 178);
            this.btnXoaPTChon.Name = "btnXoaPTChon";
            this.btnXoaPTChon.Size = new System.Drawing.Size(247, 23);
            this.btnXoaPTChon.TabIndex = 5;
            this.btnXoaPTChon.Text = "Xóa Phần Tử Đang Chọn";
            this.btnXoaPTChon.UseVisualStyleBackColor = true;
            this.btnXoaPTChon.Click += new System.EventHandler(this.btnXoaPTChon_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(250, 207);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(247, 23);
            this.btnTang2.TabIndex = 6;
            this.btnTang2.Text = "Tăng Mỗi Phần Tử 2 Giá Trị";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnThayBinh
            // 
            this.btnThayBinh.Location = new System.Drawing.Point(250, 236);
            this.btnThayBinh.Name = "btnThayBinh";
            this.btnThayBinh.Size = new System.Drawing.Size(247, 23);
            this.btnThayBinh.TabIndex = 7;
            this.btnThayBinh.Text = "Thay Bằng Bình Phương";
            this.btnThayBinh.UseVisualStyleBackColor = true;
            this.btnThayBinh.Click += new System.EventHandler(this.btnThayBinh_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(250, 265);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(247, 23);
            this.btnLe.TabIndex = 8;
            this.btnLe.Text = "Chọn Số Lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(250, 294);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(247, 23);
            this.btnChan.TabIndex = 9;
            this.btnChan.Text = "Chọn Số Chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 196);
            this.listBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(40, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 226);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phần Tử";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(250, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 226);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // BT_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 437);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnLe);
            this.Controls.Add(this.btnThayBinh);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnXoaPTChon);
            this.Controls.Add(this.btnXoaDauVaCuoi);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BT_ListBox";
            this.Text = "LIST BOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnXoaDauVaCuoi;
        private System.Windows.Forms.Button btnXoaPTChon;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnThayBinh;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

