using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuThuePhongDTO
    {
        private string m_maphieuthue;
        private string m_maphieudat;
        private string m_username;

        public string Maphieuthue
        {
            get
            {
                return m_maphieuthue;
            }
            set
            {
                m_maphieuthue = value;
            }
        }

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
    }
}
