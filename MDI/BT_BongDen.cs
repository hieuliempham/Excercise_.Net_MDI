using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiTapDataPicker
{
    public partial class BT_BongDen : Form
    {
        public BT_BongDen()
        {
            InitializeComponent();
        }
        public void Check()
        {
            if (pictureBox1.Visible == true)
            {
                textshow.Text = textName.Text + " The Light is OFF ";
            }
            else
            {
                textshow.Text = textName.Text + " The Light is ON ";
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = true;
            Check();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelDES.Text = textName.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = false;
            this.pictureBox1.Visible = true;
            Check();
        }

        private void Thoatbut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
