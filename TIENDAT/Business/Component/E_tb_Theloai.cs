using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;
using QL_GAME.DataAccess;
using System.Windows.Forms;

namespace QL_GAME.Business.Component
{
    class E_tb_Theloai
    {
        SQL_tb_Theloai Lsql = new SQL_tb_Theloai();
        public void themoil(EC_tb_Theloai l)
        {
            if (!Lsql.kiemtral(l.MATHELOAI))
            {
                Lsql.themmoil(l);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_tb_Theloai l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_tb_Theloai l)
        {
            Lsql.xoal(l);
        }
    }
}
