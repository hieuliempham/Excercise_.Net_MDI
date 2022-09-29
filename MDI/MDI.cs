using BaiTapCheckedListBox;
using BaiTapDangKyLaiXe;
using BaiTapDataPicker;
using BaiTapListBox;
using BaiTapWinforms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void bàiTập1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BT_BongDen"))
            {
                BT_BongDen frmBongDen = new BT_BongDen();
                frmBongDen.MdiParent = this;
                frmBongDen.Show();
            }
            else
            {
                ActiveChildForm("BT_BongDen");
            }

            
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void bàiTập2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BT_CheckedList"))
            {
                BT_CheckedList frmCheckedList = new BT_CheckedList();
                frmCheckedList.MdiParent = this;
                frmCheckedList.Show();
            }
            else
            {
                ActiveChildForm("BT_CheckedList");
            }
         
        }

        private void bàiTập3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BT_DKLaiXe"))
            {
                BT_DKLaiXe bT_DKLaiXe = new BT_DKLaiXe();
                bT_DKLaiXe.MdiParent = this;
                bT_DKLaiXe.Show();
            }
            else
            {
                ActiveChildForm("BT_DKLaiXe");
            }
        }

        private void bàiTập4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BT_ListBox"))
            {
                BT_ListBox frmListBox = new BT_ListBox();
                frmListBox.MdiParent = this;
                frmListBox.Show();
            }
            else
            {
                ActiveChildForm("BT_ListBox");
            }
            
        }

        private void bàiTập5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("BT_Editor"))
            {
                BT_Editor frmBTEditor = new BT_Editor();
                frmBTEditor.MdiParent = this;
                frmBTEditor.Show();
            }
            else
            {
                ActiveChildForm("BT_Editor");
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void sXNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void sXDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form form in this.MdiChildren)
            {
                if(form.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form form in this.MdiChildren)
            {
                if(form.Name == name)
                {
                    form.Activate();
                    break;
                }
            }
        }

        private void bảiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bàiTậpDataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("DataGridView"))
            {
                DataGridView frmBTEditor = new DataGridView();
                frmBTEditor.MdiParent = this;
                frmBTEditor.Show();
            }
            else
            {
                ActiveChildForm("DataGridView");
            }
        }
    }
}
