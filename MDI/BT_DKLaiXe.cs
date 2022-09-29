using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapDangKyLaiXe
{
    public partial class BT_DKLaiXe : Form
    {
        public BT_DKLaiXe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        bool check()
        {
            if (textBox1.Text == "")
            {
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                textBox2.Focus();
                return false;
            }
            if (int.Parse(textBox2.Text) < 18)
            {
                textBox2.Focus();
                return false;
            }
            DateTime dt = new DateTime();
            dt = dateTimePicker1.Value;
            if (dt.DayOfWeek.ToString() == "Sunday")
            {
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (check())
            {
                MessageBox.Show(" Dang ky thanh cong ", " thong bao");
            }
            else
            {
                MessageBox.Show(" dang ky that bai ", " thong bao ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
