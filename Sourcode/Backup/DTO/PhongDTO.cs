using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhongDTO
    {
        private string m_maphong;
        private string m_maloai;
        private Boolean m_dadat;
        private Boolean m_danhan;

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

        public Boolean Dadat
        {
            get
            {
                return m_dadat;
            }
            set
            {
                m_dadat = value;
            }
        }

        public Boolean Danhan
        {
            get
            {
                return m_danhan;
            }
            set
            {
                m_danhan = value;
            }
        }
    }
}
