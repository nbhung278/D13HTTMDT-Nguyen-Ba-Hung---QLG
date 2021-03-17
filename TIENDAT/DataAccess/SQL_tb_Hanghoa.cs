using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_GAME.DataAccess
{
	class SQL_tb_Hanghoa
	{
		ConnectDB cn = new ConnectDB();
		public bool kiemtrasp(string masp)
		{
			return cn.kiemtra("select count(*) from [tb_Hanghoa] where mahang=N'" + masp + "'");
		}
		public void themmoisp(EC_tb_Hanghoa sp)
		{
			SqlConnection con = cn.getcon();
			try
			{

				con.Open();
				string sql = @"INSERT INTO tb_Hanghoa
					  (mahang, tenhang, matheloai, manhaphathanh,  manuoc, soluong, dongianhap, dongiaban, thoigianrm, ghichu)
							 VALUES (N'" + sp.MAHANG + "',N'" + sp.TENHANG + "',N'" + sp.MATHELOAI + "',N'" + sp.MANHAPHATHANH + "',N'" + sp.MANUOC + "',N'" + sp.SOLUONG + "',N'" + sp.DONGIANHAP + "',N'" + sp.DONGIABAN + "',N'" + sp.THOAIGIANRM + "',N'" + sp.GHICHU + "')";
				SqlCommand cmd = new SqlCommand(sql, con);
			
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
		public void xoasp(EC_tb_Hanghoa sp)
		{
			cn.ExcuteNonQuery("DELETE FROM [tb_Hanghoa] WHERE  mahang=N'" + sp.MAHANG + "'");
		}

		public void suasp(EC_tb_Hanghoa sp)
		{
			SqlConnection con = cn.getcon();
			try
			{
				con.Open();
				string sql = @"UPDATE    tb_Hanghoa
				SET tenhang =N'" + sp.TENHANG + "', matheloai =N'" + sp.MATHELOAI + "', manhaphathanh =N'" + sp.MANHAPHATHANH + "', manuoc =N'" + sp.MANUOC + "', soluong =N'" + sp.SOLUONG + "', dongianhap =N'" + sp.DONGIANHAP + "', dongiaban =N'" + sp.DONGIABAN + "', thoigianrm =N'" + sp.THOAIGIANRM + "', ghichu =N'" + sp.GHICHU + "' where mahang=N'" + sp.MAHANG + "'";
				SqlCommand cmd = new SqlCommand(sql, con);
			
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
		//load thể loại
		public void loadmatl(ComboBox Matl)
		{
			cn.LoadLenCombobox(Matl, "SELECT     matheloai FROM tb_Theloai", 0);
		}
		public string Loadtentl(string tennh, string Matl)
		{
			tennh = cn.LoadLable("SELECT [tentheloai] From [tb_Theloai] where matheloai= N'" + Matl + "'");
			return tennh;
		}
		
		

		//load nhà ph
		public void loadmanh(ComboBox manh)
		{
			cn.LoadLenCombobox(manh, "SELECT     manhaphathanh FROM tb_Nhaphathanh", 0);
		}
		public string Loadtennh(string tennh, string manh)
		{
			tennh = cn.LoadLable("SELECT [tennhaphathanh] From [tb_Nhaphathanh] where manhaphathanh= N'" + manh + "'");
			return tennh;
		}
		
		//load nsx
		public void loadmansx(ComboBox mansx)
		{
			cn.LoadLenCombobox(mansx, "SELECT     manuoc FROM tb_Nuocsx", 0);
		}
		public string Loadtensx(string tennsx, string mansx)
		{
			tennsx = cn.LoadLable("SELECT [tennuoc] From [tb_Nuocsx] where manuoc= N'" + mansx + "'");
			return tennsx;
		}
	}
}
