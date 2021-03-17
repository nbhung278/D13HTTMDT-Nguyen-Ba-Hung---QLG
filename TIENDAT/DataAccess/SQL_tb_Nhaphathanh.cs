using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;

namespace QL_GAME.DataAccess
{
    class SQL_tb_Nhaphathanh
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Nhaphathanh] where manhaphathanh=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Nhaphathanh l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Nhaphathanh
                      (manhaphathanh, tennhaphathanh) VALUES   (N'" + l.MANHAPHATHANH + "',N'" + l.TENNHAPHATHANH + "')");
        }
        public void xoal(EC_tb_Nhaphathanh l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Nhaphathanh] WHERE [manhaphathanh] = N'" + l.MANHAPHATHANH + "'");
        }

        public void sual(EC_tb_Nhaphathanh l)
        {
            string sql = (@"UPDATE tb_Nhaphathanh
            SET tennhaphathanh =N'" + l.TENNHAPHATHANH + "' where  manhaphathanh =N'" + l.MANHAPHATHANH + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
