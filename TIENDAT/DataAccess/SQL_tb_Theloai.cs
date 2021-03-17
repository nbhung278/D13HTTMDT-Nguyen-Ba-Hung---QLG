using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;

namespace QL_GAME.DataAccess
{
    class SQL_tb_Theloai
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtral(string loai)
        {
            return cn.kiemtra("select count(*) from [tb_Theloai] where matheloai=N'" + loai + "'");
        }
        public void themmoil(EC_tb_Theloai l)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Theloai
                      (matheloai, tentheloai) VALUES   (N'" + l.MATHELOAI + "',N'" + l.TENTHELOAI + "')");
        }
        public void xoal(EC_tb_Theloai l)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Theloai] WHERE [matheloai] = N'" + l.MATHELOAI + "'");
        }

        public void sual(EC_tb_Theloai l)
        {
            string sql = (@"UPDATE tb_Theloai
            SET tentheloai =N'" + l.TENTHELOAI + "' where  matheloai =N'" + l.MATHELOAI + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
