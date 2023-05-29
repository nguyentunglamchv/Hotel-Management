using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        private string m_manhanvien;
        private string m_tennhanvien;
        private DateTime m_ngaysinh;
        private Boolean m_phai;
        private string m_diachi;
        private string m_phone;
        private string m_chucvu;

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

        public string Tennhanvien
        {
            get
            {
                return m_tennhanvien;
            }
            set
            {
                m_tennhanvien = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return m_ngaysinh;
            }
            set
            {
                m_ngaysinh = value;
            }
        }

        public Boolean Phai
        {
            get
            {
                return m_phai;
            }
            set
            {
                m_phai = value;
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

        public string Phone
        {
            get
            {
                return m_phone;
            }
            set
            {
                m_phone = value;
            }
        }

        public string Chucvu
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
