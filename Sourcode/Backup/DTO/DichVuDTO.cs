using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DichVuDTO
    {
        private string m_madichvu;
        private string m_tendichvu;
        private decimal m_gia;
        private string m_donvitinh;

        public string Madichvu
        {
            get
            {
                return m_madichvu;
            }
            set
            {
                m_madichvu = value;
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

        public decimal Gia
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
    }
}
