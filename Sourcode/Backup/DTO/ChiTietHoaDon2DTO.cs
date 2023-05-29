using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietHoaDon2DTO
    {

        private string m_mahoadon;
        private string m_dichvu;
        private string m_phong;
        private DateTime m_ngayDV;
        private float m_giaDV;
        private int m_soluongDV;

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

        public string Dichvu
        {
            get
            {
                return m_dichvu;
            }
            set
            {
                m_dichvu = value;
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

        public DateTime NgayDV
        {
            get
            {
                return m_ngayDV;
            }
            set
            {
                m_ngayDV = value;
            }
        }

        public float GiaDV
        {
            get
            {
                return m_giaDV;
            }
            set
            {
                m_giaDV = value;
            }
        }

        public int SoluongDV
        {
            get
            {
                return m_soluongDV;
            }
            set
            {
                m_soluongDV = value;
            }
        }
    }
}
