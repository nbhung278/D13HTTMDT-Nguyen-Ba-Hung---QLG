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
    public partial class fr_Timkiemsp : Form
    {
        public fr_Timkiemsp()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();

        private void txtthongtin_TextChanged(object sender, EventArgs e)
        {
            khoitaoluoi();
            if (txtthongtin.Text.Length == 0)
            {
                string sql = @"SELECT mahang, tenhang, matheloai, manhaphathanh, manuoc, soluong, dongianhap, dongiaban, thoigianrm, ghichu FROM tb_Hanghoa";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
            if (op1.Checked)
            {
                string sql = @"SELECT mahang, tenhang, matheloai, manhaphathanh, manuoc, soluong, dongianhap, dongiaban, thoigianrm, ghichu FROM tb_Hanghoa WHERE matheloai= '" + txtthongtin.Text + "'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
           
            if (op2.Checked)
            {
                string sql = @"SELECT mahang, tenhang, matheloai, manhaphathanh, manuoc, soluong, dongianhap, dongiaban, thoigianrm, ghichu FROM tb_Hanghoa where thoigianrm like N'%" + txtthongtin.Text + "%'";
                msds.DataSource = cn.taobang(sql);

                SqlConnection con = cn.getcon();
                con.Open();
            }
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Hàng";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 100;

            msds.Columns[1].HeaderText = "Tên Hàng";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Thể Loại";
            msds.Columns[2].Width = 100;

            msds.Columns[3].HeaderText = "Mã Nhà Phát Hành";
            msds.Columns[3].Width = 100;

         

            msds.Columns[4].HeaderText = "Mã Nước";
            msds.Columns[4].Width = 100;

            msds.Columns[5].HeaderText = "Số Lượng";
            msds.Columns[5].Width = 100;

            msds.Columns[6].HeaderText = "Đơn Giá Nhập";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Đơn Giá Bán";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Thời Gian Ra Mắt";
            msds.Columns[8].Width = 100;

     

            msds.Columns[9].HeaderText = "Ghi Chú";
            msds.Columns[9].Width = 300;

        }
        public void hienthi()
        {
            string sql = "SELECT mahang, tenhang, matheloai, manhaphathanh, manuoc, soluong, dongianhap, dongiaban, thoigianrm, ghichu FROM tb_Hanghoa";
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

        private void fr_Timkiemsp_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitaoluoi();
        }
    }
}
