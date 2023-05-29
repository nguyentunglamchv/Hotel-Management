using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietVatTuDTO
    {
        private string m_mavattu;
        private string m_maloaiphong;
        private int m_soluong;

        public string Mavattu
        {
            get
            {
                return m_mavattu;
            }
            set
            {
                m_mavattu = value;
            }
        }

        public string Maloaiphong
        {
            get
            {
                return m_maloaiphong;
            }
            set
            {
                m_maloaiphong = value;
            }
        }

        public int Soluong
        {
            get 
            { 
                return m_soluong;
            }
            set
            {
                m_soluong = value;
            }
        }
    }
}
