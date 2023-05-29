using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KhachHangDTO
    {

        private string m_makhachhang;
        private string m_tenkhachhang;
        private Boolean m_gioitinh;
        private string m_cmnd_passport;
        private string m_diachi;
        private string m_coquan;
        private string m_sodienthoai;
        private string m_email;

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

        public string Tenkhachhang
        {
            get
            {
                return m_tenkhachhang;
            }
            set
            {
                m_tenkhachhang = value;
            }
        }

        public Boolean Gioitinh
        {
            get
            {
                return m_gioitinh;
            }
            set
            {
                m_gioitinh = value;
            }
        }

        public string CMND_PASSPORT
        {
            get
            {
                return m_cmnd_passport;
            }
            set
            {
                m_cmnd_passport = value;
            }
        }

        public string Diachi
        {
            get
            {
                return m_diachi;
            }
            set
            {
                m_diachi = value;
            }
        }

        public string Coquan
        {
            get
            {
                return m_coquan;
            }
            set
            {
                m_coquan = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return m_sodienthoai;
            }
            set
            {
                m_sodienthoai = value;
            }
        }

        public string Email
        {
            get
            {
                return m_email;
            }
            set
            {
                m_email = value;
            }
        }
    }
}
