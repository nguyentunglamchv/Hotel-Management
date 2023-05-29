using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LoaiPhongDTO
    {
        private string m_maloai;
        private decimal m_gia;
        private int m_songuoi;

        public string Maloai
        {
            get
            {
                return m_maloai;
            }
            set
            {
                m_maloai = value;
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
