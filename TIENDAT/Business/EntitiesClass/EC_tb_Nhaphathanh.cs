using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_GAME.Business.EntitiesClass
{
    class EC_tb_Nhaphathanh
    {
        private string manhaphathanh;
        private string tennhaphathanh;

        public string MANHAPHATHANH
        {
            get
            {
                return manhaphathanh;
            }
            set
            {
                manhaphathanh = value;
                if (manhaphathanh == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENNHAPHATHANH
        {
            get
            {
                return tennhaphathanh;
            }
            set
            {
                tennhaphathanh = value;
            }
        }
    }
}
