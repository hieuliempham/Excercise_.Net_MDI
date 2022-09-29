using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCheckedListBox
{
    public partial class BT_CheckedList : Form
    {
        public BT_CheckedList()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    checkedListBox2.Items.Add(checkedListBox1.Items[i]);
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.AddRange(checkedListBox1.Items);
            checkedListBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i) == true)
                {
                    checkedListBox1.Items.Add(checkedListBox2.Items[i]);
                    checkedListBox2.Items.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(checkedListBox2.Items);
            checkedListBox2.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(" Kiet ");
            checkedListBox1.Items.Add(" Liêm");
            checkedListBox1.Items.Add(" Kiet Clone ");
            checkedListBox1.Items.Add(" An Fake ");
            checkedListBox1.Items.Add(" Kiet Real ");
        }
    }
}
