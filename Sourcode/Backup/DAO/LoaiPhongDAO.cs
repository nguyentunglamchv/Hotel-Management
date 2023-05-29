using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DTO;
using System.Data.Linq.SqlClient;


namespace DAO
{
    public class LoaiPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListLP()
        {
            var query = (from lp in htDataContext.loaiphongs select lp).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các loại phòng 
        public IList<LoaiPhongDTO> getListLoaiPhongAll()
        {
            var query = (from lp in htDataContext.loaiphongs
                         orderby lp.maloai descending
                         select new LoaiPhongDTO
                         {
                             Maloai = lp.maloai,
                             Gia = (decimal)lp.gia,
                             Songuoi = (int)lp.songuoi,
                         }).Distinct<LoaiPhongDTO>();

          
            return query.ToList<LoaiPhongDTO>();
        }

        //Lấy danh sách tất cả các loại phòng mỗi lần lấy 10 phần tử
        public IList<LoaiPhongDTO> getListLoaiPhongLMAll(int a)
        {
            var query = (from lp in htDataContext.loaiphongs
                         orderby lp.maloai descending
                         select new LoaiPhongDTO
                         {
                             Maloai=lp.maloai,
                             Gia=(decimal) lp.gia,
                             Songuoi=(int)lp.songuoi,
                         }).Distinct<LoaiPhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<LoaiPhongDTO>();
        }

        //Danh sách các loại phòng có mã loại phòng được nhập vào
        public LoaiPhongDTO getLoaiPhongByID(string id)
        {
            var querry = (from lp in htDataContext.loaiphongs
                          where lp.maloai == id
                          select new LoaiPhongDTO
                          {
                              Maloai = lp.maloai,
                              Gia = (decimal)lp.gia,
                              Songuoi = (int)lp.songuoi,
                          }).Distinct<LoaiPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<LoaiPhongDTO>();
            }
        }

       /* //Lấy danh sách tất cả các loại phòng có tên được nhập vào
        public IList<LoaiPhongDTO> getListLoaiPhongByName(string name)
        {
            var querry = (from lp in htDataContext.LoaiPhongs
                          where lp.tenLoaiPhong == name
                          select new LoaiPhongDTO
                          {
                              MaLoaiPhong = lp.maLoaiPhong,
                              TenLoaiPhong = lp.tenLoaiPhong,
                              Phai = (Boolean)lp.phai,
                              Ngaysinh = (DateTime)lp.ngaysinh,
                              Phone = lp.phone,
                              Diachi = lp.diachi,
                              Chucvu = lp.chucvu,
                          }).Distinct<LoaiPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<LoaiPhongDTO>();
            }
        }*/

        //Danh sách gần đúng các loại phòng có mã loại phòng được nhập vào
        public IList<LoaiPhongDTO> getLikeLoaiPhongByID(string id)
        {
            var querry = (from lp in htDataContext.loaiphongs
                          where SqlMethods.Like(lp.maloai, "%" + id + "%")
                          select new LoaiPhongDTO
                          {
                              Maloai = lp.maloai,
                              Gia = (decimal)lp.gia,
                              Songuoi = (int)lp.songuoi,
                          }).Distinct<LoaiPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<LoaiPhongDTO>();
            }
        }

        /*//Lấy danh sách gần đúng tất cả các loại phòng có tên được nhập vào
        public IList<LoaiPhongDTO> getListLikeLoaiPhongByName(string name)
        {
            var querry = (from lp in htDataContext.LoaiPhongs
                          where SqlMethods.Like(lp.tenLoaiPhong, "%" + name + "%")
                          select new LoaiPhongDTO
                          {
                              MaLoaiPhong = lp.maLoaiPhong,
                              TenLoaiPhong = lp.tenLoaiPhong,
                              Phai = (Boolean)lp.phai,
                              Ngaysinh = (DateTime)lp.ngaysinh,
                              Phone = lp.phone,
                              Diachi = lp.diachi,
                              Chucvu = lp.chucvu,
                          }).Distinct<LoaiPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<LoaiPhongDTO>();
            }
        }*/

        //Thêm loại phòng
        public void insertLoaiPhong(LoaiPhongDTO lpDTO)
        {
            loaiphong lp = new loaiphong();
            lp.maloai = lpDTO.Maloai;
            lp.gia = (decimal) lpDTO.Gia;
            lp.songuoi = (int)lpDTO.Songuoi;
            
            htDataContext.loaiphongs.InsertOnSubmit(lp);
            htDataContext.SubmitChanges();
        }

        //Xóa loại phòng
        public void deleteLoaiPhong(string IDLoaiPhong)
        {
            var querry = (from lp in htDataContext.loaiphongs
                          where lp.maloai == IDLoaiPhong
                          select lp).FirstOrDefault<loaiphong>();
            htDataContext.loaiphongs.DeleteOnSubmit(querry);
            htDataContext.SubmitChanges();
        }

        //Sửa loại phòng
        public void updateLoaiPhong(LoaiPhongDTO lpDTO)
        {
            var querry = (from lp in htDataContext.loaiphongs
                          where lp.maloai == lpDTO.Maloai
                          select lp).FirstOrDefault<loaiphong>();
            querry.gia= (decimal) lpDTO.Gia;
            querry.songuoi = (int)lpDTO.Songuoi;
            htDataContext.SubmitChanges();
        }
    }
}
