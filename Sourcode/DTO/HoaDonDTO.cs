using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HoaDonDTO
    {

        private string m_mahoadon;
        private DateTime m_ngaythanhtoan;
        private decimal m_tongtien;
        private string m_maphieuthue;
        private string m_makhachhang;
        private string m_username;

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

        public DateTime Ngaythanhtoan
        {
            get
            {
                return m_ngaythanhtoan;
            }
            set
            {
                m_ngaythanhtoan = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return m_tongtien;
            }
            set
            {
                m_tongtien = value;
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

        public string Makhachhang
        {
            get
            {
                return m_makhachhang;
            }
            set
            {
                m_makhachhang = value;
            }
        }

        public string Username
        {
            get
            {
                return m_username;
            }
            set
            {
                m_username = value;
            }
        }
    }
}
