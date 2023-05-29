using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DTO;
using System.Data.Linq.SqlClient;

namespace DAO
{
    public class DichVuDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListdv()
        {
            var query = (from dv in htDataContext.dichvus select dv).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các dịch vụ 
        public IList<DichVuDTO> getListDichVuAll()
        {
            var query = (from dv in htDataContext.dichvus
                         orderby dv.madichvu descending
                         select new DichVuDTO
                         {
                             Madichvu = dv.madichvu,
                             Tendichvu = dv.tendichvu,
                             Donvitinh = dv.donvitinh,
                             Gia = (decimal)dv.gia,
                         }).Distinct<DichVuDTO>();

            return query.ToList<DichVuDTO>();
        }

        //Lấy danh sách tất cả các dịch vụ mỗi lần lấy 10 phần tử
        public IList<DichVuDTO> getListDichVuLMAll(int a)
        {
            var query = (from dv in htDataContext.dichvus
                         orderby dv.madichvu descending
                         select new DichVuDTO
                         {
                            Madichvu=dv.madichvu,
                            Tendichvu=dv.tendichvu,
                            Donvitinh=dv.donvitinh,
                            Gia=(decimal)dv.gia,
                         }).Distinct<DichVuDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<DichVuDTO>();
        }

        //Danh sách các dịch vụ có mã dịch vụ được nhập vào
        public DichVuDTO getDichVuByID(string id)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.madichvu == id
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<DichVuDTO>();
            }
        }

        //Lấy danh sách tất cả các dịch vụ có tên được nhập vào
        public IList<DichVuDTO> getListDichVuByName(string name)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.tendichvu == name
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }

        //Danh sách gần đúng các dịch vụ có mã dịch vụ được nhập vào
        public IList<DichVuDTO> getLikeDichVuByID(string id)
        {
            var querry = (from dv in htDataContext.dichvus
                          where SqlMethods.Like(dv.madichvu, "%" + id + "%")
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các dịch vụ có tên được nhập vào
        public IList<DichVuDTO> getListLikeDichVuByName(string name)
        {
            var querry = (from dv in htDataContext.dichvus
                          where SqlMethods.Like(dv.tendichvu, "%" + name + "%")
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }

        //Thêm dịch vụ
        public void insertDichVu(DichVuDTO dvDTO)
        {
            dichvu dv = new dichvu();
            dv.madichvu = dvDTO.Madichvu;
            dv.tendichvu = dvDTO.Tendichvu;
            dv.donvitinh = dvDTO.Donvitinh;
            dv.gia = (decimal)dvDTO.Gia;
            htDataContext.dichvus.InsertOnSubmit(dv);
            htDataContext.SubmitChanges();
        }

        //Xóa dịch vụ
        public void deleteDichVu(string IDDV)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.madichvu == IDDV
                          select dv).FirstOrDefault<dichvu>();
            htDataContext.dichvus.DeleteOnSubmit(querry);
            htDataContext.SubmitChanges();
        }

        //Sửa dịch vụ
        public void updateDichVu(DichVuDTO dvDTO)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.madichvu == dvDTO.Madichvu
                          select dv).FirstOrDefault<dichvu>();
            querry.tendichvu = dvDTO.Tendichvu;
            querry.donvitinh = dvDTO.Donvitinh;
            querry.gia = (decimal)dvDTO.Gia;
            htDataContext.SubmitChanges();
        }
    }
}
