using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapListBox
{
    public partial class BT_ListBox : Form
    {
        public BT_ListBox()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in listBox1.Items)
            {
                tong += int.Parse((String)item);
            }
            MessageBox.Show(" Tong : " + tong);
        }

        private void btnXoaDauVaCuoi_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
        }

        private void btnXoaPTChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show(" Object not found ! ", " Error! ");
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int tmp = int.Parse((String)listBox1.Items[i]);
                tmp += 2;
                listBox1.Items[i] = tmp.ToString();

            }
        }

        private void btnThayBinh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int tmp = int.Parse((String)listBox1.Items[i]);
                tmp += tmp;
                listBox1.Items[i] = tmp.ToString();

            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse((String)listBox1.Items[i]);
                if (x % 2 != 0)
                {
                    listBox1.SelectedIndex = i;
                }

            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int x = int.Parse((String)listBox1.Items[i]);
                if (x % 2 == 0)
                {
                    listBox1.SelectedIndex = i;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
