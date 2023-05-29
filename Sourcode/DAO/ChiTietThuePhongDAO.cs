using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Collections;
using System.Data.Linq.SqlClient;

namespace DAO
{
    public class ChiTietThuePhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListcttp()
        {
            var query = (from cttp in htDataContext.chitietthuephongs  select cttp).Count();
            return query;
        }


        //Lấy danh sách tất cả các chi tiết thuê phòng 
        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongAll()
        {
            var query = (from cttp in htDataContext.chitietthuephongs
                         orderby cttp.maphieuthue descending
                         select new ChiTietThuePhongDTO
                         {
                             Maphieuthue = cttp.maphieuthue,
                             Maphong = cttp.maphong,
                             Madichvu = cttp.madichvu,
                             Ngay = (DateTime)cttp.ngay,
                             Soluong = (int)cttp.soluong,
                         }).Distinct<ChiTietThuePhongDTO>();

            return query.ToList<ChiTietThuePhongDTO>();
        }

        //Lấy danh sách tất cả các chi tiết thuê phòng mỗi lần lấy 10 phần tử
        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongLMAll(int a)
        {
            var query = (from cttp in htDataContext.chitietthuephongs
                         orderby cttp.maphieuthue descending
                         select new ChiTietThuePhongDTO
                         {
                             Maphieuthue=cttp.maphieuthue,
                             Maphong=cttp.maphong,
                             Madichvu=cttp.madichvu,
                             Ngay=(DateTime)cttp.ngay,
                             Soluong=(int)cttp.soluong,
                         }).Distinct<ChiTietThuePhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<ChiTietThuePhongDTO>();
        }

        //Danh sách các chi tiết thuê phòng có mã chi tiết thuê phòng được nhập vào
        public IList<ChiTietThuePhongDTO> getChiTietThuePhongByID(string id)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphieuthue == id
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            return querry.ToList<ChiTietThuePhongDTO>();
        }

        //Lấy danh sách tất cả các chi tiết thuê phòng có tên được nhập vào
        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongByName(string name)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphong == name
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        //Danh sách gần đúng các chi tiết thuê phòng có mã chi tiết thuê phòng được nhập vào
        public IList<ChiTietThuePhongDTO> getLikeChiTietThuePhongByID(string id)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where SqlMethods.Like(cttp.maphieuthue, "%" + id + "%")
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các chi tiết thuê phòng có tên được nhập vào
        public IList<ChiTietThuePhongDTO> getListLikeChiTietThuePhongByName(string name)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where SqlMethods.Like(cttp.maphong, "%" + name + "%")
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        //Thêm chi tiết thuê phòng
        public void insertChiTietThuePhong(ChiTietThuePhongDTO cttpDTO)
        {
            chitietthuephong cttp = new chitietthuephong();
            cttp.maphieuthue = cttpDTO.Maphieuthue;
            cttp.maphong = cttpDTO.Maphong;
            cttp.ngay = (DateTime)cttpDTO.Ngay;
            cttp.madichvu = cttpDTO.Madichvu;
            cttp.soluong = (int)cttpDTO.Soluong;
            htDataContext.chitietthuephongs.InsertOnSubmit(cttp);
            htDataContext.SubmitChanges();
        }

        //Xóa chi tiết thuê phòng
        public void deleteChiTietThuePhong(string IDChiTietThuePhong, string maphong, DateTime ngay, string madichvu)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphieuthue == IDChiTietThuePhong && cttp.maphong==maphong &&
                          cttp.ngay==ngay && cttp.madichvu==madichvu
                          select cttp).FirstOrDefault<chitietthuephong>();
            htDataContext.chitietthuephongs.DeleteOnSubmit(querry);
            htDataContext.SubmitChanges();
        }

        //Sửa chi tiết thuê phòng
        public void updateChiTietThuePhong(ChiTietThuePhongDTO cttpDTO)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphieuthue == cttpDTO.Maphieuthue && cttp.maphong == cttpDTO.Maphong &&
                          cttp.ngay == cttpDTO.Ngay && cttp.madichvu == cttpDTO.Madichvu
                          select cttp).FirstOrDefault<chitietthuephong>();
            querry.soluong= cttpDTO.Soluong;
            htDataContext.SubmitChanges();
        }

    }
}
