using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietDatPhongDTO
    {
        private string m_maphieudat;
        private string m_maphong;

        public string Maphieudat
        {
            get
            {
                return m_maphieudat;
            }
            set
            {
                m_maphieudat = value;
            }
        }

        public string Maphong
        {
            get
            {
                return m_maphong;
            }
            set
            {
                m_maphong = value;
            }
        }
    }
}
