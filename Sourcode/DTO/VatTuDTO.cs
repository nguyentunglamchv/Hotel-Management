using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VatTuDTO
    {
        private string m_mavattu;
        private string m_tenvattu;

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

        public string Tenvattu
        {
            get
            {
                return m_tenvattu;
            }
            set
            {
                m_tenvattu = value;
            }
        }
    }
}
