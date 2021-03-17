using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_GAME.Presentation
{
    public partial class fr_Main : Form
    {
        public fr_Main()
        {
            InitializeComponent();
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new fr_NhaPH();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Theloai();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Nuocsx();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Sanpham();
            frm.ShowDialog();
            hideSubMenu();
        }
        #endregion
        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(paneltimkiem);
        }
        #region timkiem
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Timkiemsp();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new fr_TimkiemHDB();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form frm = new fr_TimkiemHDN();
            frm.ShowDialog();
            hideSubMenu();
        }
        #endregion
        private void fr_Main_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        #region PlaylistSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Calam();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Congviec();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Nhanvien();
            frm.ShowDialog();
            hideSubMenu();
        }


        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            Form frm = new fr_Khachhang();
            frm.ShowDialog();
            hideSubMenu();
        }
        
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            Form frm = new fr_HDB();
            frm.ShowDialog();
            hideSubMenu();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Form frm = new fr_HDN();
            frm.ShowDialog();
            hideSubMenu();
        }




        #endregion

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm = new fr_NCC();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm = new fr_thongke();
            frm.ShowDialog();
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
