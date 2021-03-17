using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;
using QL_GAME.DataAccess;
using System.Windows.Forms;

namespace QL_GAME.Business.Component
{
    class E_tb_Nhaphathanh
    {
        SQL_tb_Nhaphathanh Lsql = new SQL_tb_Nhaphathanh();
        public void themoil(EC_tb_Nhaphathanh l)
        {
            if (!Lsql.kiemtral(l.MANHAPHATHANH))
            {
                Lsql.themmoil(l);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sual(EC_tb_Nhaphathanh l)
        {
            Lsql.sual(l);
        }
        public void xoal(EC_tb_Nhaphathanh l)
        {
            Lsql.xoal(l);
        }
    }
}
