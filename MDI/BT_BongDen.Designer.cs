namespace BaiTapDataPicker
{
    partial class BT_BongDen
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
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelDES = new System.Windows.Forms.Label();
            this.Thoatbut = new System.Windows.Forms.Button();
            this.textshow = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designed by";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(76, 40);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(343, 22);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDES
            // 
            this.labelDES.AutoSize = true;
            this.labelDES.Location = new System.Drawing.Point(150, 391);
            this.labelDES.Name = "labelDES";
            this.labelDES.Size = new System.Drawing.Size(31, 16);
            this.labelDES.TabIndex = 3;
            this.labelDES.Text = "Tên";
            // 
            // Thoatbut
            // 
            this.Thoatbut.Location = new System.Drawing.Point(344, 391);
            this.Thoatbut.Name = "Thoatbut";
            this.Thoatbut.Size = new System.Drawing.Size(75, 23);
            this.Thoatbut.TabIndex = 4;
            this.Thoatbut.Text = "Exit";
            this.Thoatbut.UseVisualStyleBackColor = true;
            this.Thoatbut.Click += new System.EventHandler(this.Thoatbut_Click);
            // 
            // textshow
            // 
            this.textshow.Location = new System.Drawing.Point(115, 363);
            this.textshow.Name = "textshow";
            this.textshow.Size = new System.Drawing.Size(292, 22);
            this.textshow.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MDI.Properties.Resources.z3758873795313_d3a426d5204bbfa17075efb7c6f46f3e;
            this.pictureBox2.InitialImage = global::MDI.Properties.Resources.tải_xuống;
            this.pictureBox2.Location = new System.Drawing.Point(102, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 284);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MDI.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(102, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 284);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BT_BongDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 460);
            this.Controls.Add(this.textshow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Thoatbut);
            this.Controls.Add(this.labelDES);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BT_BongDen";
            this.Text = "BÓNG ĐÈN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelDES;
        private System.Windows.Forms.Button Thoatbut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textshow;
    }
}

