using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HeThongDTO
    {
        private string m_username;
        private string m_manhanvien;
        private string m_password;

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

        public string Manhanvien
        {
            get
            {
                return m_manhanvien;
            }
            set
            {
                m_manhanvien = value;
            }
        }

        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
            }
        }
    }
}
