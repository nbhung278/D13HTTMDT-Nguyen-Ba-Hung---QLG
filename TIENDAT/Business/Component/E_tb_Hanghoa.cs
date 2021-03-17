using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QL_GAME.Business.EntitiesClass;
using QL_GAME.DataAccess;
using System.Windows.Forms;

namespace QL_GAME.Business.Component
{
    class E_tb_Hanghoa
    {
        SQL_tb_Hanghoa spsql = new SQL_tb_Hanghoa();
        public void themoisp(EC_tb_Hanghoa sp)
        {
            if (!spsql.kiemtrasp(sp.MAHANG))
            {
                spsql.themmoisp(sp);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suasp(EC_tb_Hanghoa sp)
        {
            spsql.suasp(sp);
        }
        public void xoasp(EC_tb_Hanghoa sp)
        {
            spsql.xoasp(sp);
        }
        //load nhà phát hành
        public void loadmanh(ComboBox cbnh)
        {
            spsql.loadmanh(cbnh);
        }
        public string loadtennh(string Tennh, string Manh)
        {
            Tennh = spsql.Loadtennh(Tennh, Manh);
            return Tennh;
        }
        
        //load thể loại
        public void loadmatl(ComboBox cbtl)
        {
            spsql.loadmatl(cbtl);
        }
        public string loadtentl(string Tentl, string Matl)
        {
            Tentl = spsql.Loadtentl(Tentl, Matl);
            return Tentl;
        }
        
        
        //load sx
        public void loadmasx(ComboBox cbsx)
        {
            spsql.loadmansx(cbsx);
        }
        public string loadtensx(string Tensx, string Masx)
        {
            Tensx = spsql.Loadtensx(Tensx, Masx);
            return Tensx;
        }
    }
}
