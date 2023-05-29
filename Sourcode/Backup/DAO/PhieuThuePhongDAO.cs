using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DTO;
using System.Data.Linq.SqlClient;

namespace DAO
{
    public class PhieuThuePhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListPTP()
        {
            var query = (from ptp in htDataContext.phieuthuephongs select ptp).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các nhân viên 
        public IList<PhieuThuePhongDTO> getListPhieuThuePhongAll()
        {
            var query = (from ptp in htDataContext.phieuthuephongs
                         orderby ptp.maphieuthue descending
                         select new PhieuThuePhongDTO
                         {
                             Maphieuthue = ptp.maphieuthue,
                             Maphieudat = ptp.maphieudat,
                             Username = ptp.username,
                         }).Distinct<PhieuThuePhongDTO>();

            return query.ToList<PhieuThuePhongDTO>();
        }

        //Lấy danh sách tất cả các nhân viên mỗi lần lấy 10 phần tử
        public IList<PhieuThuePhongDTO> getListPhieuThuePhongLMAll(int a)
        {
            var query = (from ptp in htDataContext.phieuthuephongs
                         orderby ptp.maphieuthue descending
                         select new PhieuThuePhongDTO
                         {
                            Maphieuthue=ptp.maphieuthue,
                            Maphieudat=ptp.maphieudat,
                            Username=ptp.username,
                         }).Distinct<PhieuThuePhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<PhieuThuePhongDTO>();
        }

        //Danh sách các nhân viên có mã nhân viên được nhập vào
        public PhieuThuePhongDTO getPhieuThuePhongByID(string id)
        {
            var querry = (from ptp in htDataContext.phieuthuephongs
                          where ptp.maphieuthue == id
                          select new PhieuThuePhongDTO
                          {
                              Maphieuthue = ptp.maphieuthue,
                              Maphieudat = ptp.maphieudat,
                              Username = ptp.username,
                          }).Distinct<PhieuThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<PhieuThuePhongDTO>();
            }
        }

        //Lấy danh sách tất cả các nhân viên có tên được nhập vào
        public IList<PhieuThuePhongDTO> getListPhieuThuePhongByMaPhieuDat(string name)
        {
            var querry = (from ptp in htDataContext.phieuthuephongs
                          where ptp.maphieudat == name
                          select new PhieuThuePhongDTO
                          {
                              Maphieuthue = ptp.maphieuthue,
                              Maphieudat = ptp.maphieudat,
                              Username = ptp.username,
                          }).Distinct<PhieuThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuThuePhongDTO>();
            }
        }

        //Danh sách gần đúng các nhân viên có mã nhân viên được nhập vào
        public IList<PhieuThuePhongDTO> getLikePhieuThuePhongByID(string id)
        {
            var querry = (from ptp in htDataContext.phieuthuephongs
                          where SqlMethods.Like(ptp.maphieudat, "%" + id + "%")
                          select new PhieuThuePhongDTO
                          {
                              Maphieuthue = ptp.maphieuthue,
                              Maphieudat = ptp.maphieudat,
                              Username = ptp.username,
                          }).Distinct<PhieuThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuThuePhongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các nhân viên có tên được nhập vào
        public IList<PhieuThuePhongDTO> getListLikePhieuThuePhongByMaPhieuDat(string name)
        {
            var querry = (from ptp in htDataContext.phieuthuephongs
                          where SqlMethods.Like(ptp.maphieudat, "%" + name + "%")
                          select new PhieuThuePhongDTO
                          {
                              Maphieuthue = ptp.maphieuthue,
                              Maphieudat = ptp.maphieudat,
                              Username = ptp.username,
                          }).Distinct<PhieuThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuThuePhongDTO>();
            }
        }

        //Thêm nhân viên
        public void insertPhieuThuePhong(PhieuThuePhongDTO ptpDTO)
        {
            phieuthuephong ptp = new phieuthuephong();
            ptp.maphieuthue = ptpDTO.Maphieuthue;
            ptp.maphieudat = ptpDTO.Maphieudat;
            ptp.username = ptpDTO.Username;
            htDataContext.phieuthuephongs.InsertOnSubmit(ptp);
            htDataContext.SubmitChanges();
        }

        //Xóa nhân viên
        public void deletePhieuThuePhong(string IDPhieuThuePhong)
        {
            IEnumerable<phieuthuephong>list=from ptp in htDataContext.phieuthuephongs
                          where ptp.maphieuthue == IDPhieuThuePhong
                          select ptp;
            foreach (phieuthuephong querry in list)
            {
                htDataContext.phieuthuephongs.DeleteOnSubmit(querry);
            }
            htDataContext.SubmitChanges();
        }

        //Sửa nhân viên
        public void updatePhieuThuePhong(PhieuThuePhongDTO ptpDTO)
        {
            var querry = (from ptp in htDataContext.phieuthuephongs
                          where ptp.maphieuthue == ptpDTO.Maphieuthue
                          select ptp).FirstOrDefault<phieuthuephong>();
            querry.maphieudat = ptpDTO.Maphieudat;
            querry.username = ptpDTO.Username;
            htDataContext.SubmitChanges();
        }
    }
}
