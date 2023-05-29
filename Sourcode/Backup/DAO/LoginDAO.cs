using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Collections;

namespace DAO
{
    public class LoginDAO
    {
        public const int limitList = 5;

        HotelDataContext htDataContext = new HotelDataContext();

        public IList<LoginDTO> Login(string user, string pass)
        {
            var querry = (from ht in htDataContext.hethongs
                          from nv in htDataContext.nhanviens
                          where ht.username == user &&
                          ht.password == pass && ht.manhanvien == nv.manhanvien
                          select new LoginDTO
                          {
                              Username=ht.username,
                              TenNV=nv.tennhanvien,
                              ChucVu=nv.chucvu,
                              MaNV=nv.manhanvien,
                          }).Distinct<LoginDTO>();
            return querry.ToList<LoginDTO>();
        }
    }
}
