using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QL_GAME.DataAccess;
using System.Data.SqlClient;

namespace QL_GAME.Presentation
{
    public partial class fr_TimkiemHDB : Form
    {
        public fr_TimkiemHDB()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT     tb_HDB.sohdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien
FROM         tb_HDB INNER JOIN
                      tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT     tb_HDB.sohdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien
FROM         tb_HDB INNER JOIN
                      tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb WHERE tb_CTHDB.mahang= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op2.Checked)
            {
                string sql = @"SELECT     tb_HDB.sohdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien
FROM         tb_HDB INNER JOIN
                      tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb WHERE tb_HDB.ngayban  like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op3.Checked)
            {
                string sql = @"SELECT     tb_HDB.sohdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien
FROM         tb_HDB INNER JOIN
                      tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb WHERE tb_HDB.makh= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
        }
        public void khoitaoluoi()
        {
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Số HDB";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 80;
            msds.Columns[1].HeaderText = "Nhân Viên";
            msds.Columns[1].Width = 80;
            msds.Columns[2].HeaderText = "Ngày Bán";
            msds.Columns[2].Width = 100;
            msds.Columns[3].HeaderText = "Khách Hàng";
            msds.Columns[3].Width = 80;
            msds.Columns[4].HeaderText = "Tổng Tiền";
            msds.Columns[4].Width = 160;

        }
        public void hienthi()
        {
            string sql = @"SELECT tb_HDB.sohdb, tb_HDB.manv, tb_HDB.ngayban, tb_HDB.makh, tb_HDB.tongtien
FROM         tb_HDB INNER JOIN
                      tb_CTHDB ON tb_HDB.sohdb = tb_CTHDB.sohdb";
            msds.DataSource = cn.taobang(sql);
            SqlConnection con = cn.getcon();
            con.Open();
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void fr_TimkiemHDB_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
