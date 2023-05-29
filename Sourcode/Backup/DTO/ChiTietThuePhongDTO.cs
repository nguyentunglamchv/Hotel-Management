using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietThuePhongDTO
    {
        private string m_maphieuthue;
        private string m_maphong;
        private DateTime m_ngay;
        private string m_madichvu;
        private int m_soluong;

        public string Maphieuthue
        {
            get
            {
                return m_maphieuthue;
            }
            set
            {
                m_maphieuthue = value;
            }
        }

        public string Maphong
        {
            get
            {
                return m_maphong;
            }
            set
            {
                m_maphong = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return m_ngay;
            }
            set
            {
                m_ngay = value;
            }
        }

        public string Madichvu
        {
            get
            {
                return m_madichvu;
            }
            set
            {
                m_madichvu = value;
            }
        }

        public int Soluong
        {
            get
            {
                return m_soluong;
            }
            set 
            { 
                m_soluong = value;
            }
        }
    }
}
