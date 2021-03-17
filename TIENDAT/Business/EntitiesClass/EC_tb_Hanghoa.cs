using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_GAME.Business.EntitiesClass
{
    class EC_tb_Hanghoa
    {
        private string mahang;
        private string tenhang;
        private string matheloai;
        
        private string manhaphathanh;
        
        private string manuoc;
        private string soluong;
        private string dongianhap;
        private string dongiaban;
        private string thoaigianrm;
      
        private string ghichu;

        public string MAHANG
        {
            get
            {
                return mahang;
            }
            set
            {
                mahang = value;
                if (mahang == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENHANG
        {
            get
            {
                return tenhang;
            }
            set
            {
                tenhang = value;
            }
        }
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
        
        public string MANUOC
        {
            get
            {
                return manuoc;
            }
            set
            {
                manuoc = value;
                if (manuoc == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string SOLUONG
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public string DONGIANHAP
        {
            get
            {
                return dongianhap;
            }
            set
            {
                dongianhap = value;
            }
        }
        public string DONGIABAN
        {
            get
            {
                return dongiaban;
            }
            set
            {
                dongiaban = value;
            }
        }
        public string THOAIGIANRM
        {
            get
            {
                return thoaigianrm;
            }
            set
            {
                thoaigianrm = value;
            }
        }
       
        public string GHICHU
        {
            get
            {
                return ghichu;
            }
            set
            {
                ghichu = value;
            }
        }
    }
}
