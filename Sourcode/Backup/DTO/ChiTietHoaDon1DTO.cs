using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDon1DTO
    {

        private string m_mahoadon;
        private string m_phong;
        private float m_giaphong;
        private DateTime m_ngayden;
        private DateTime m_ngaydi;
        private int m_songayo;
        private float m_thanhtien;
        private string m_nhanvien;
        private string m_khachhang;
        private float m_tiendatcoc;
        private float m_tiendichvu;

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

        public string Phong
        {
            get
            {
                return m_phong;
            }
            set
            {
                m_phong = value;
            }
        }

        public float Giaphong
        {
            get
            {
                return m_giaphong;
            }
            set
            {
                m_giaphong = value;
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

        public int Songayo
        {
            get
            {
                return m_songayo;
            }
            set
            {
                m_songayo = value;
            }
        }

        public float Thanhtien
        {
            get
            {
                return m_thanhtien;
            }
            set
            {
                m_thanhtien = value;
            }
        }

        public string Tennhanvien
        {
            get
            {
                return m_nhanvien;
            }
            set
            {
                m_nhanvien = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return m_khachhang;
            }
            set
            {
                m_khachhang = value;
            }
        }

        public float Tiendatcoc
        {
            get
            {
                return m_tiendatcoc;
            }
            set
            {
                m_tiendatcoc = value;
            }
        }

        public float Tiendichvu
        {
            get
            {
                return m_tiendichvu;
            }
            set
            {
                m_tiendichvu = value;
            }
        }
    }
}
