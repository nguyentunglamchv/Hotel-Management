using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoginDTO
    {
        private string m_username;
        private string m_tenNV;
        private string m_chucvu;
        private string m_maNV;

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

        public string TenNV
        {
            get
            {
                return m_tenNV;
            }
            set
            {
                m_tenNV = value;
            }
        }

        public string MaNV
        {
            get
            {
                return m_maNV;
            }
            set
            {
                m_maNV = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return m_chucvu;
            }
            set
            {
                m_chucvu = value;
            }
        }
    }
}
