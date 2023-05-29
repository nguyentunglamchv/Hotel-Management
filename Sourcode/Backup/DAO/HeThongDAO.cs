using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Collections;
using System.Data.Linq.SqlClient;


namespace DAO
{
    public class HeThongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListHT()
        {
            var query = (from ht in htDataContext.hethongs orderby ht.manhanvien where ht.manhanvien != "admin" select ht).Count();
            return query;
        }

        //Lấy danh sách tất cả các hệ thống 
        public IList<HeThongDTO> getListHethongAll()
        {
            var query = (from ht in htDataContext.hethongs
                         orderby ht.manhanvien descending
                         where ht.manhanvien != "admin"
                         select new HeThongDTO
                         {
                             Username = ht.username,
                             Manhanvien = ht.manhanvien,
                             Password = ht.password,
                         }).Distinct<HeThongDTO>();

            return query.ToList<HeThongDTO>();
        }

        //Lấy danh sách tất cả các hệ thống mỗi lần lấy 10 phần tử
        public IList<HeThongDTO> getListHethongLMAll(int a)
        {
            var query = (from ht in htDataContext.hethongs
                         orderby ht.manhanvien descending
                         where ht.manhanvien != "admin"
                         select new HeThongDTO
                         {
                             Username=ht.username,
                             Manhanvien=ht.manhanvien,
                             Password=ht.password,
                         }).Distinct<HeThongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<HeThongDTO>();
        }

        //Danh sách các hệ thống có mã hệ thống được nhập vào
        public HeThongDTO getHeThongByUserName(string id)
        {
            var querry = (from ht in htDataContext.hethongs
                          where ht.username == id
                          select new HeThongDTO
                          {
                              Username=ht.username,
                              Manhanvien=ht.manhanvien,
                              Password=ht.password,
                          }).Distinct<HeThongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<HeThongDTO>();
            }
        }

        //Lấy danh sách tất cả các hệ thống có tên được nhập vào
        public HeThongDTO getListHeThongByID(string id)
        {
            var querry = (from ht in htDataContext.hethongs
                          where ht.manhanvien==id
                          select new HeThongDTO
                          {
                              Username=ht.username,
                              Manhanvien=ht.manhanvien,
                              Password=ht.password,
                          }).Distinct<HeThongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<HeThongDTO>();
            }
        }
       
        //Danh sách gần đúng các hệ thống có mã hệ thống được nhập vào
        public IList<HeThongDTO> getLikeHeThongByUserName(string id)
        {
            var querry = (from ht in htDataContext.hethongs
                          where SqlMethods.Like(ht.username, "%" + id + "%")
                          select new HeThongDTO
                          {
                              Username=ht.username,
                              Manhanvien=ht.manhanvien,
                              Password=ht.password,
                          }).Distinct<HeThongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<HeThongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các hệ thống có tên được nhập vào
        public IList<HeThongDTO> getListLikeHeThongByMaNV(string name)
        {
            var querry = (from ht in htDataContext.hethongs
                          where SqlMethods.Like(ht.manhanvien, "%" + name + "%")
                          select new HeThongDTO
                          {
                              Username=ht.username,
                              Manhanvien=ht.manhanvien,
                              Password=ht.password,
                          }).Distinct<HeThongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<HeThongDTO>();
            }
        }

        //Thêm hệ thống
        public void insertHeThong(HeThongDTO htDTO)
        {
            hethong ht = new hethong();
            ht.username = htDTO.Username;
            ht.manhanvien = htDTO.Manhanvien;
            ht.password = htDTO.Password;
            htDataContext.hethongs.InsertOnSubmit(ht);
            htDataContext.SubmitChanges();
        }

        //Xóa hệ thống
        public void deleteHeThong(string IDHethong)
        {
            var querry = (from ht in htDataContext.hethongs
                          where ht.manhanvien == IDHethong
                          select ht).FirstOrDefault<hethong>();
            htDataContext.hethongs.DeleteOnSubmit(querry);
            htDataContext.SubmitChanges();
        }

        //Sửa hệ thống
        public void updateHeThong(HeThongDTO htDTO)
        {
            var querry = (from ht in htDataContext.hethongs
                          where ht.manhanvien == htDTO.Manhanvien
                          select ht).FirstOrDefault<hethong>();
            //querry.username = htDTO.Username;
            querry.password = htDTO.Password;
            htDataContext.SubmitChanges();

           /* try
            {
                htDataContext.Connection.Open();
                System.Data.Common.DbTransaction transaction = htDataContext.Connection.BeginTransaction();
                htDataContext.Transaction = transaction;

                deleteHeThong(htDTO.Manhanvien);
                insertHeThong(htDTO);

               htDataContext.Transaction.Commit();
                return 1;
           }
           catch(Exception)
           {
                htDataContext.Transaction.Rollback();
                return 0;
           }*/
        }
    }
}
