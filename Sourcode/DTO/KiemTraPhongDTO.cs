using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class KiemTraPhongDTO
    {
        private string m_maphieudat;
        private string m_maphong;
        private DateTime m_ngayden;
        private DateTime m_ngaydi;
        private string m_tinhtrang;
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

        public DateTime Ngayden
        {
            get
            {
                return m_ngayden;
            }
            set
            {
                m_ngayden = value;
            }
        }

        public DateTime Ngaydi
        {
            get
            {
                return m_ngaydi;
            }
            set
            {
                m_ngaydi = value;
            }
        }
        public string Tinhtrang
        {
            get
            {
                return m_tinhtrang;
            }
            set
            {
                m_tinhtrang = value;
            }
        }
    }
}
