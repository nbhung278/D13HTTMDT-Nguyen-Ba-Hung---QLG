using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_GAME.Business.EntitiesClass
{
    class EC_tb_Theloai
    {
        private string matheloai;
        private string tentheloai;

        public string MATHELOAI
        {
            get
            {
                return matheloai;
            }
            set
            {
                matheloai = value;
                if (matheloai == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENTHELOAI
        {
            get
            {
                return tentheloai;
            }
            set
            {
                tentheloai = value;
            }
        }
    }
}
