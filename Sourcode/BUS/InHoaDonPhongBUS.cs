using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Collections;
namespace BUS
{
    public class InHoaDonPhongBUS
    {
        InHoaDonPhongDAO hdDAO = new InHoaDonPhongDAO();
        public ArrayList InHoaDonPhong(string mahoadon)
        {
            return hdDAO.InHoaDonPhong(mahoadon);
        }
    }
}
