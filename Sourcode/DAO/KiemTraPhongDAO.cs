using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.Linq.SqlClient;
using System.Data.Linq;
using System.Collections;

namespace DAO
{
    public class KiemTraPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();
        ArrayList a=new ArrayList();
        public ArrayList KiemTraPhong(DateTime ngayden, DateTime ngaydi)
        {
           var listd = htDataContext.kiemtraphong(ngayden, ngaydi);
           a.Clear();
           foreach (kiemtraphongResult kt in listd)
           {

               KiemTraPhongDTO ktp = new KiemTraPhongDTO();
               ktp.Maphieudat = kt.maphieudat;
               ktp.Maphong = kt.maphong;
               ktp.Ngayden = kt.ngayden.Value;
               ktp.Ngaydi = kt.ngaydi.Value;
               ktp.Tinhtrang = kt.tinhtrang;
               a.Add(ktp);
           }           
            return a;
        }
    }
}
