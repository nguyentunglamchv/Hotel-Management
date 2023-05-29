using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class InHoaDonPhongDTO
    {
        private string m_mahoadon;
        private string m_tenkhachhang;
        private string m_cmnd;
        private string m_diachi;
        private string m_coquan;
        private string m_sodienthoai;
        private string m_email;
        private DateTime m_ngayden;
        private DateTime m_ngaydi;
        private decimal m_sotiendatcoc;
        private decimal m_gia;
        private int m_songayo;
        private string m_maphong;
        private string m_tennhanvien;
        private decimal m_tongtien;

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

        public string Tenkhachhang
        {
            get { return m_tenkhachhang;  }
            set
            {
                m_tenkhachhang = value;
            }
        }

        public string CMND
        {
            get { return m_cmnd; }
            set { m_cmnd = value; }
        }

        public string Diachi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }

        public string Coquan
        {
            get { return m_coquan; }
            set { m_coquan = value; }
        }

        public string Sodienthoai
        {
            get { return m_sodienthoai; }
            set { m_sodienthoai = value; }
        }

        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }

        public DateTime Ngayden
        {
            get { return m_ngayden; }
            set { m_ngayden = value; }
        }

        public DateTime Ngaydi
        {
            get { return m_ngaydi; }
            set { m_ngaydi = value; }
        }

        public decimal Sotiendatcoc
        {
            get { return m_sotiendatcoc; }
            set { m_sotiendatcoc = value; }
        }

        public decimal Gia
        {
            get { return m_gia; }
            set { m_gia = value; }
        }

        public int Songayo
        {
            get { return m_songayo; }
            set
            {
                m_songayo = value;
            }
        }

        public string Maphong
        {
            get { return m_maphong; }
            set { m_maphong = value; }
        }

        public string Tennhanvien
        {
            get { return m_tennhanvien; }
            set { m_tennhanvien = value; }
        }

        public decimal Tongtien
        {
            get { return m_tongtien; }
            set { m_tongtien = value; }
        }
    }
}
