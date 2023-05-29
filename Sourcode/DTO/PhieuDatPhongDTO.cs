using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuDatPhongDTO
    {

        private string m_maphieudat;
        private string m_makhachhang;
        private DateTime m_ngayden;
        private DateTime m_ngaydi;
        private decimal m_sotiendatcoc;
        private string m_username;
        private string m_tinhtrang;
        private int m_songuoi;

        public string Maphieudat
        {
            get
            {
                return m_maphieudat;
            }
            set
            {
                m_maphieudat = value;
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

        public DateTime Ngayden
        {
            get
            {
                return m_ngayden;
            }
            set
            {
                m_ngayden = value;
            }
        }

        public DateTime Ngaydi
        {
            get
            {
                return m_ngaydi;
            }
            set
            {
                m_ngaydi = value;
            }
        }

        public decimal Sotiendatcoc
        {
            get
            {
                return m_sotiendatcoc;
            }
            set
            {
                m_sotiendatcoc = value;
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

        public string Tinhtrang
        {
            get
            {
                return m_tinhtrang;
            }
            set
            {
                m_tinhtrang = value;
            }
        }

        public int Songuoi
        {
            get
            {
                return m_songuoi;
            }
            set
            {
                m_songuoi = value;
            }
        }
    }
}
