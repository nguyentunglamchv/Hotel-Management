using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class InHoaDonDichVuDTO
    {
        protected string m_mahoadon;
        protected string m_maphieuthue;
        protected string m_tendichvu;
        protected Decimal m_gia;
        protected string m_donvitinh;
        protected int m_soluong;
        private string m_maphong;
        private DateTime m_ngay;

        
        public string Mahoadon
        {
            get
            {
                return m_mahoadon;
            }
            set
            {
                m_mahoadon = value;
            }
        }

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

        public string Tendichvu
        {
            get
            {
                return m_tendichvu;
            }
            set
            {
                m_tendichvu = value;
            }
        }

        public Decimal Gia
        {
            get
            {
                return m_gia;
            }
            set
            {
                m_gia = value;
            }
        }

        public string Donvitinh
        {
            get
            {
                return m_donvitinh;
            }
            set
            {
                m_donvitinh = value;
            }
        }

        public int Soluong
        {
            get{
                return m_soluong;
            }set{
                m_soluong=value;
            }
        }

        public string MaPhong
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
    }
}
