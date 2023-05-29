using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DTO;
using System.Data.Linq.SqlClient;

namespace DAO
{
    public class PhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListP()
        {
            var query = (from p in htDataContext.phongs select p).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các phòng 
        public IList<PhongDTO> getListPhongAll()
        {
            var query = (from p in htDataContext.phongs
                         orderby p.maphong descending
                         select new PhongDTO
                         {
                             Maphong = p.maphong,
                             Maloai = p.maloai,
                             Dadat = (bool)p.dadat,
                             Danhan = (bool)p.danhan,
                         }).Distinct<PhongDTO>();

            return query.ToList<PhongDTO>();
        }


        //Lấy danh sách tất cả các phòng mỗi lần lấy 10 phần tử
        public IList<PhongDTO> getListPhongLMAll(int a)
        {
            var query = (from p in htDataContext.phongs
                         orderby p.maphong descending
                         select new PhongDTO
                         {
                            Maphong=p.maphong,
                            Maloai=p.maloai,
                            Dadat=(bool)p.dadat,
                            Danhan = (bool)p.danhan,
                         }).Distinct<PhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<PhongDTO>();
        }

        //Danh sách các phòng có mã phòng được nhập vào
        public PhongDTO getPhongByID(string id)
        {
            var querry = (from p in htDataContext.phongs
                          where p.maphong == id
                          select new PhongDTO
                          {
                              Maphong = p.maphong,
                              Maloai = p.maloai,
                              Dadat = (bool)p.dadat,
                              Danhan = (bool)p.danhan,
                          }).Distinct<PhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<PhongDTO>();
            }
        }

        //Lấy danh sách tất cả các phòng có tên được nhập vào
        public IList<PhongDTO> getListPhongByLoai(string name)
        {
            var querry = (from p in htDataContext.phongs
                          where p.maloai == name
                          select new PhongDTO
                          {
                              Maphong = p.maphong,
                              Maloai = p.maloai,
                              Dadat = (bool)p.dadat,
                              Danhan = (bool)p.danhan,
                          }).Distinct<PhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhongDTO>();
            }
        }

        //Danh sách gần đúng các phòng có mã phòng được nhập vào
        public IList<PhongDTO> getLikePhongByID(string id)
        {
            var querry = (from p in htDataContext.phongs
                          where SqlMethods.Like(p.maphong, "%" + id + "%")
                          select new PhongDTO
                          {
                              Maphong = p.maphong,
                              Maloai = p.maloai,
                              Dadat = (bool)p.dadat,
                              Danhan = (bool)p.danhan,
                          }).Distinct<PhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các phòng có tên được nhập vào
        public IList<PhongDTO> getListLikePhongByLoai(string name)
        {
            var querry = (from p in htDataContext.phongs
                          where SqlMethods.Like(p.maloai, "%" + name + "%")
                          select new PhongDTO
                          {
                              Maphong = p.maphong,
                              Maloai = p.maloai,
                              Dadat = (bool)p.dadat,
                              Danhan = (bool)p.danhan,
                          }).Distinct<PhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhongDTO>();
            }
        }

        //Thêm phòng
        public void insertPhong(PhongDTO pDTO)
        {
            phong p = new phong();
            p.maphong = pDTO.Maphong;
            p.maloai = pDTO.Maloai;
            p.dadat = (bool)pDTO.Dadat;
            p.danhan = (bool)pDTO.Danhan;
            htDataContext.phongs.InsertOnSubmit(p);
            htDataContext.SubmitChanges();
        }

        //Xóa phòng
        public void deletePhong(string IDPhong)
        {
            IEnumerable<phong>list=from p in htDataContext.phongs
                          where p.maphong == IDPhong
                          select p;
            foreach (phong querry in list)
            {
                htDataContext.phongs.DeleteOnSubmit(querry);
            }
            htDataContext.SubmitChanges();
        }

        //Sửa phòng
        public void updatePhong(PhongDTO pDTO)
        {
            var querry = (from p in htDataContext.phongs
                          where p.maphong == pDTO.Maphong
                          select p).FirstOrDefault<phong>();
            querry.maloai = pDTO.Maloai;
            querry.dadat = pDTO.Dadat;
            querry.danhan = pDTO.Danhan;
            htDataContext.SubmitChanges();
        }
    }
}
