using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinforms
{
    public partial class BT_Editor : Form
    {
        public BT_Editor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Red;
                textBox2.ForeColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.OliveDrab;
                textBox2.ForeColor = Color.OliveDrab;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.ForeColor = Color.MediumTurquoise;
                textBox2.ForeColor = Color.MediumTurquoise;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style | FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Bold);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style & ~FontStyle.Bold);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style | FontStyle.Italic);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Italic);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style & ~FontStyle.Italic);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style | FontStyle.Underline);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Underline);
                textBox2.Font = new Font(textBox2.Font, textBox2.Font.Style & ~FontStyle.Underline);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
