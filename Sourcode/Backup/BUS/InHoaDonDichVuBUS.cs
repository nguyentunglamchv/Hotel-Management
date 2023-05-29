using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Collections;

namespace BUS
{
    public class InHoaDonDichVuBUS
    {
        InHoaDonDichVuDAO ihddv = new InHoaDonDichVuDAO();
        public ArrayList InHoaDonDivhVu(string mahoadon)
        {
            return ihddv.inhoadondv(mahoadon);
        }
    }
}
