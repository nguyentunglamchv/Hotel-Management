using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DTO;
using System.Data.Linq.SqlClient;

namespace DAO
{
    public class PhieuDatPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListPDP()
        {
            var query = (from pdp in htDataContext.phieudatphongs select pdp).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các phiếu đặt phòng 
        public IList<PhieuDatPhongDTO> getListPhieuDatPhongAll()
        {
            var query = (from pdp in htDataContext.phieudatphongs
                         orderby pdp.maphieudat descending
                         select new PhieuDatPhongDTO
                         {
                             Maphieudat = pdp.maphieudat,
                             Makhachhang = pdp.makhachhang,
                             Ngayden = (DateTime)pdp.ngayden,
                             Ngaydi = (DateTime)pdp.ngaydi,
                             Sotiendatcoc = (decimal)pdp.sotiendatcoc,
                             Username = pdp.username,
                             Tinhtrang = pdp.tinhtrang,
                             Songuoi = (int)pdp.songuoi,
                         }).Distinct<PhieuDatPhongDTO>();

            return query.ToList<PhieuDatPhongDTO>();
        }


        //Lấy danh sách tất cả các phiếu đặt phòng mỗi lần lấy 10 phần tử
        public IList<PhieuDatPhongDTO> getListPhieuDatPhongLMAll(int a)
        {
            var query = (from pdp in htDataContext.phieudatphongs
                         orderby pdp.maphieudat descending
                         select new PhieuDatPhongDTO
                         {
                             Maphieudat=pdp.maphieudat,
                             Makhachhang=pdp.makhachhang,
                             Ngayden=(DateTime)pdp.ngayden,
                             Ngaydi=(DateTime)pdp.ngaydi,
                             Sotiendatcoc=(decimal)pdp.sotiendatcoc,
                             Username=pdp.username,
                             Tinhtrang=pdp.tinhtrang,
                             Songuoi=(int)pdp.songuoi,
                         }).Distinct<PhieuDatPhongDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<PhieuDatPhongDTO>();
        }

        //Danh sách các phiếu đặt phòng có mã phiếu đặt phòng được nhập vào
        public PhieuDatPhongDTO getPhieuDatPhongByID(string id)
        {
            var querry = (from pdp in htDataContext.phieudatphongs
                          where pdp.maphieudat == id
                          select new PhieuDatPhongDTO
                          {
                              Maphieudat = pdp.maphieudat,
                              Makhachhang = pdp.makhachhang,
                              Ngayden = (DateTime)pdp.ngayden,
                              Ngaydi = (DateTime)pdp.ngaydi,
                              Sotiendatcoc = (decimal)pdp.sotiendatcoc,
                              Username = pdp.username,
                              Tinhtrang = pdp.tinhtrang,
                              Songuoi = (int)pdp.songuoi,
                          }).Distinct<PhieuDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<PhieuDatPhongDTO>();
            }
        }

        //Lấy danh sách tất cả các phiếu đặt phòng có mã khách hàng được nhập vào
        public IList<PhieuDatPhongDTO> getListPhieuDatPhongByMKH(string name)
        {
            var querry = (from pdp in htDataContext.phieudatphongs
                          where pdp.makhachhang == name
                          select new PhieuDatPhongDTO
                          {
                              Maphieudat = pdp.maphieudat,
                              Makhachhang = pdp.makhachhang,
                              Ngayden = (DateTime)pdp.ngayden,
                              Ngaydi = (DateTime)pdp.ngaydi,
                              Sotiendatcoc = (decimal)pdp.sotiendatcoc,
                              Username = pdp.username,
                              Tinhtrang = pdp.tinhtrang,
                              Songuoi = (int)pdp.songuoi,
                          }).Distinct<PhieuDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuDatPhongDTO>();
            }
        }

        //Danh sách gần đúng các phiếu đặt phòng có mã phiếu đặt phòng được nhập vào
        public IList<PhieuDatPhongDTO> getLikePhieuDatPhongByID(string id)
        {
            var querry = (from pdp in htDataContext.phieudatphongs
                          where SqlMethods.Like(pdp.maphieudat, "%" + id + "%")
                          select new PhieuDatPhongDTO
                          {
                              Maphieudat = pdp.maphieudat,
                              Makhachhang = pdp.makhachhang,
                              Ngayden = (DateTime)pdp.ngayden,
                              Ngaydi = (DateTime)pdp.ngaydi,
                              Sotiendatcoc = (decimal)pdp.sotiendatcoc,
                              Username = pdp.username,
                              Tinhtrang = pdp.tinhtrang,
                              Songuoi = (int)pdp.songuoi,
                          }).Distinct<PhieuDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuDatPhongDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các phiếu đặt phòng có mã khách hàng được nhập vào
        public IList<PhieuDatPhongDTO> getListLikePhieuDatPhongByMKH(string name)
        {
            var querry = (from pdp in htDataContext.phieudatphongs
                          where SqlMethods.Like(pdp.makhachhang, "%" + name + "%")
                          select new PhieuDatPhongDTO
                          {
                              Maphieudat = pdp.maphieudat,
                              Makhachhang = pdp.makhachhang,
                              Ngayden = (DateTime)pdp.ngayden,
                              Ngaydi = (DateTime)pdp.ngaydi,
                              Sotiendatcoc = (decimal)pdp.sotiendatcoc,
                              Username = pdp.username,
                              Tinhtrang = pdp.tinhtrang,
                              Songuoi = (int)pdp.songuoi,
                          }).Distinct<PhieuDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<PhieuDatPhongDTO>();
            }
        }

        //Thêm phiếu đặt phòng
        public void insertPhieuDatPhong(PhieuDatPhongDTO pdpDTO)
        {
            phieudatphong pdp = new phieudatphong();
            pdp.maphieudat = pdpDTO.Maphieudat;
            pdp.makhachhang = pdpDTO.Makhachhang;
            pdp.ngayden = (DateTime)pdpDTO.Ngayden;
            pdp.ngaydi = (DateTime)pdpDTO.Ngaydi;
            pdp.sotiendatcoc = (decimal)pdpDTO.Sotiendatcoc;
            pdp.username = pdpDTO.Username;
            pdp.tinhtrang = pdpDTO.Tinhtrang;
            pdp.songuoi = (int)pdpDTO.Songuoi;
            htDataContext.phieudatphongs.InsertOnSubmit(pdp);
            htDataContext.SubmitChanges();
        }

        //Xóa phiếu đặt phòng
        public void deletePhieuDatPhong(string IDPhieuDatPhong)
        {
            IEnumerable<phieudatphong> list=from pdp in htDataContext.phieudatphongs
                          where pdp.maphieudat == IDPhieuDatPhong
                          select pdp;
            foreach (phieudatphong querry in list)
            {
                htDataContext.phieudatphongs.DeleteOnSubmit(querry);
            }
               
            htDataContext.SubmitChanges();
        }

        //Sửa phiếu đặt phòng
        public void updatePhieuDatPhong(PhieuDatPhongDTO pdpDTO)
        {
            var querry = (from pdp in htDataContext.phieudatphongs
                          where pdp.maphieudat == pdpDTO.Maphieudat
                          select pdp).FirstOrDefault<phieudatphong>();
            querry.makhachhang = pdpDTO.Makhachhang;
            querry.ngayden = (DateTime)pdpDTO.Ngayden;
            querry.ngaydi = (DateTime)pdpDTO.Ngaydi;
            querry.sotiendatcoc= (decimal) pdpDTO.Sotiendatcoc;
            querry.username = pdpDTO.Username;
            querry.tinhtrang = pdpDTO.Tinhtrang;
            querry.songuoi =(int) pdpDTO.Songuoi;
            htDataContext.SubmitChanges();
        }
    }
}
