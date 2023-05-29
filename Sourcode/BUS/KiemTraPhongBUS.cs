using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Collections;


namespace BUS
{
    public class KiemTraPhongBUS
    {
        KiemTraPhongDAO ktpDAO = new KiemTraPhongDAO();
        public ArrayList KiemTraPhong(DateTime ngayden, DateTime ngaydi)
        {
            return ktpDAO.KiemTraPhong(ngayden,ngaydi);
        }
    }
}
