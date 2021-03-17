using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_GAME.Business.Component;
using QL_GAME.Business.EntitiesClass;
using QL_GAME.DataAccess;
using System.IO;

namespace QL_GAME.Presentation
{
    public partial class fr_Sanpham : Form
    {
        public fr_Sanpham()
        {
            InitializeComponent();
        }
        E_tb_Hanghoa thucthi = new E_tb_Hanghoa();
        ConnectDB cn = new ConnectDB();
        EC_tb_Hanghoa ck = new EC_tb_Hanghoa();
        bool themmoi;
        int dong = 0;

        


        public void setnull()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdgb.Text = "0";
            txtdgn.Text = "0";
            txtsl.Text = "0";
            txtghichu.Text = "";

            cbdvt.Text = "";
           
            cbn.Text = "";
            cbsx.Text = "";
            cbn.Text = "";
            //imghinhanh.Image = QuanLyCuaHangTivi.Properties.Resources.no;
        }
        public void locktext()
        {
            txtma.Enabled = false;
            txtten.Enabled = false;
            txtghichu.Enabled = false;
            cbdvt.Enabled = false;
            
            cbn.Enabled = false;
            cbsx.Enabled = false;
            cbn.Enabled = false;
            

            btmoi.Enabled = true;
            btluu.Enabled = false;
            btsua.Enabled = true;
            btxoa.Enabled = true;
        }
        public void un_locktext()
        {
            txtma.Enabled = true;
            txtten.Enabled = true;
            txtghichu.Enabled = true;
            cbdvt.Enabled = true;
            
            cbn.Enabled = true;
            cbsx.Enabled = true;
            cbn.Enabled = true;
            

            btmoi.Enabled = false;
            btluu.Enabled = true;
            btsua.Enabled = false;
            btxoa.Enabled = false;
        }
        public void khoitaoluoi()
        {
            //RepositoryItemPictureEdit image = msds.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            msds.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].HeaderText = "Mã Hàng";
            msds.Columns[0].Frozen = true;
            msds.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            msds.Columns[0].Width = 200;

            msds.Columns[1].HeaderText = "Tên Hàng";
            msds.Columns[1].Width = 200;

            msds.Columns[2].HeaderText = "Mã Thể Loại";
            msds.Columns[2].Width = 200;

           

            msds.Columns[3].HeaderText = "Mã Nhà Phát Hành";
            msds.Columns[3].Width = 200;

           

            msds.Columns[4].HeaderText = "Mã Nước";
            msds.Columns[4].Width = 200;

            msds.Columns[5].HeaderText = "Số Lượng";
            msds.Columns[5].Width = 200;

            msds.Columns[6].HeaderText = "Đơn Giá Nhập";
            msds.Columns[6].Width = 200;

            msds.Columns[7].HeaderText = "Đơn Giá Bán";
            msds.Columns[7].Width = 200;

            msds.Columns[8].HeaderText = "Thời Gian Xuát Bản";
            msds.Columns[8].Width = 100;

       

            msds.Columns[9].HeaderText = "Ghi Chú";
            msds.Columns[9].Width = 100;

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btmoi_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtma.Text != "")
            {
                if (cbn.Text != "")
                {
                   
                        if (cbdvt.Text != "")
                        {
                            if (themmoi == true)
                            {
                                try
                                {
                                   
                                    ck.MAHANG = txtma.Text;
                                    ck.TENHANG = txtten.Text;
                                    ck.MATHELOAI = cbn.Text;
                                  
                                    ck.MANHAPHATHANH = cbdvt.Text;
                                   
                                    ck.MANUOC = cbsx.Text;
                                    ck.SOLUONG = txtsl.Text;
                                    ck.DONGIANHAP = txtdgn.Text;
                                    ck.DONGIABAN = txtdgb.Text;
                                    ck.THOAIGIANRM = txtngay.Text;
                             
                                    ck.GHICHU = txtghichu.Text;

                                    thucthi.themoisp(ck);
                                    locktext();
                                    hienthi();
                                    MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                                try
                                {
                                    
                                    ck.MAHANG = txtma.Text;
                                    ck.TENHANG = txtten.Text;
                                    ck.MATHELOAI = cbn.Text;
                                  
                                    ck.MANHAPHATHANH = cbdvt.Text;
                                   
                                    ck.MANUOC = cbsx.Text;
                                    ck.SOLUONG = txtsl.Text;
                                    ck.DONGIANHAP = txtdgn.Text;
                                    ck.DONGIABAN = txtdgb.Text;
                                    ck.THOAIGIANRM = txtngay.Text;
                             
                                    ck.GHICHU = txtghichu.Text;

                                    thucthi.suasp(ck);
                                    MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            txtma.Enabled = true;
                            locktext();
                            hienthi();
                        
                        
                    }
                   
                }
                else
                {
                    MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cbn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtma.Focus();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtma.Enabled = false;
            txtten.Focus();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ck.MAHANG = txtma.Text;

                    thucthi.xoasp(ck);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hienthi();
                    setnull();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)//annham
        {

        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbn.Text = msds.Rows[dong].Cells[2].Value.ToString();
            
            cbdvt.Text = msds.Rows[dong].Cells[3].Value.ToString();
          
            cbsx.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[6].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[7].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[8].Value.ToString();
            txtghichu.Text = msds.Rows[dong].Cells[9].Value.ToString();
            locktext();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fr_Sanpham_Load(object sender, EventArgs e)
        {
            
            thucthi.loadmanh(cbdvt); 


            thucthi.loadmatl(cbn);
            thucthi.loadmasx(cbsx);
            locktext();
            hienthi();
            khoitaoluoi();
        }

        private void cbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbn.Text = thucthi.loadtentl(lbn.Text, cbn.Text);
        }

        private void cbdvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbdvt.Text = thucthi.loadtennh(lbdvt.Text, cbdvt.Text);
        }

        private void cbsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbsx.Text = thucthi.loadtensx(lbsx.Text, cbsx.Text);
        }

        private void msds_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong < 0) dong = 0;
            txtma.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtten.Text = msds.Rows[dong].Cells[1].Value.ToString();
            cbn.Text = msds.Rows[dong].Cells[2].Value.ToString();

            cbdvt.Text = msds.Rows[dong].Cells[3].Value.ToString();

            cbsx.Text = msds.Rows[dong].Cells[4].Value.ToString();
            txtsl.Text = msds.Rows[dong].Cells[5].Value.ToString();
            txtdgn.Text = msds.Rows[dong].Cells[6].Value.ToString();
            txtdgb.Text = msds.Rows[dong].Cells[7].Value.ToString();
            txtngay.Text = msds.Rows[dong].Cells[8].Value.ToString();
            txtghichu.Text = msds.Rows[dong].Cells[9].Value.ToString();
            locktext();
        }
    }
}
