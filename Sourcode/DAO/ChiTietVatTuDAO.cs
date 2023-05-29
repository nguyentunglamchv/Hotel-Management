using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.Linq.SqlClient;
using System.Collections;

namespace DAO
{
    public class ChiTietVatTuDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();

        //Đếm tất cả các phần tử có trong bảng
        public int CountListctvt()
        {
            var query = (from ctvt in htDataContext.chitietvattus select ctvt).Distinct().Count();
            return query;
        }

        //Lấy danh sách tất cả các vật tư 
        public IList<ChiTietVatTuDTO> getListChiTietVatTuAll()
        {
            var query = (from ctvt in htDataContext.chitietvattus
                         orderby ctvt.mavattu descending
                         select new ChiTietVatTuDTO
                         {
                             Mavattu = ctvt.mavattu,
                             Maloaiphong = ctvt.maloaiphong,
                             Soluong = (int)ctvt.soluong,
                         }).Distinct<ChiTietVatTuDTO>();

            return query.ToList<ChiTietVatTuDTO>();
        }


        //Lấy danh sách tất cả các vật tư mỗi lần lấy 10 phần tử
        public IList<ChiTietVatTuDTO> getListChiTietVatTuLMAll(int a)
        {
            var query = (from ctvt in htDataContext.chitietvattus
                         orderby ctvt.mavattu descending
                         select new ChiTietVatTuDTO
                         {
                             Mavattu=ctvt.mavattu,
                             Maloaiphong=ctvt.maloaiphong,
                             Soluong=(int)ctvt.soluong,
                         }).Distinct<ChiTietVatTuDTO>();

            query = query.Skip(a).Take(LoginDAO.limitList);
            return query.ToList<ChiTietVatTuDTO>();
        }

        //Danh sách các vật tư có mã vật tư được nhập vào
        public ChiTietVatTuDTO getChiTietVatTuByID(string id)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where ctvt.mavattu == id
                          select new ChiTietVatTuDTO
                          {
                              Mavattu = ctvt.mavattu,
                              Maloaiphong = ctvt.maloaiphong,
                              Soluong = (int)ctvt.soluong,
                          }).Distinct<ChiTietVatTuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<ChiTietVatTuDTO>();
            }
        }

        //Lấy danh sách tất cả các vật tư có tên được nhập vào
        public IList<ChiTietVatTuDTO> getListChiTietVatTuByMaLP(string name)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where ctvt.maloaiphong == name
                          select new ChiTietVatTuDTO
                          {
                              Mavattu = ctvt.mavattu,
                              Maloaiphong = ctvt.maloaiphong,
                              Soluong = (int)ctvt.soluong,
                          }).Distinct<ChiTietVatTuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietVatTuDTO>();
            }
        }

        //Danh sách gần đúng các vật tư có mã vật tư được nhập vào
        public IList<ChiTietVatTuDTO> getLikeChiTietVatTuByID(string id)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where SqlMethods.Like(ctvt.mavattu, "%" + id + "%")
                          select new ChiTietVatTuDTO
                          {
                              Mavattu = ctvt.mavattu,
                              Maloaiphong = ctvt.maloaiphong,
                              Soluong = (int)ctvt.soluong,
                          }).Distinct<ChiTietVatTuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietVatTuDTO>();
            }
        }

        //Lấy danh sách gần đúng tất cả các vật tư có tên được nhập vào
        public IList<ChiTietVatTuDTO> getListLikeChiTietVatTuByMaLP(string name)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where SqlMethods.Like(ctvt.maloaiphong, "%" + name + "%")
                          select new ChiTietVatTuDTO
                          {
                              Mavattu = ctvt.mavattu,
                              Maloaiphong = ctvt.maloaiphong,
                              Soluong = (int)ctvt.soluong,
                          }).Distinct<ChiTietVatTuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietVatTuDTO>();
            }
        }

        //Thêm vật tư
        public void insertChiTietVatTu(ChiTietVatTuDTO ctvtDTO)
        {
            chitietvattu ctvt = new chitietvattu();
            ctvt.mavattu = ctvtDTO.Mavattu;
            ctvt.maloaiphong = ctvtDTO.Maloaiphong;
            ctvt.soluong = (int)ctvtDTO.Soluong;
            htDataContext.chitietvattus.InsertOnSubmit(ctvt);
            htDataContext.SubmitChanges();
        }

        //Xóa vật tư
        public void deleteChiTietVatTu(string IDNhactvtien, string idPhong)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where ctvt.mavattu == IDNhactvtien && ctvt.maloaiphong==idPhong
                          select ctvt).FirstOrDefault<chitietvattu>();
            htDataContext.chitietvattus.DeleteOnSubmit(querry);
            htDataContext.SubmitChanges();
        }

        //Sửa vật tư
        public void updateChiTietVatTu(ChiTietVatTuDTO ctvtDTO)
        {
            var querry = (from ctvt in htDataContext.chitietvattus
                          where ctvt.mavattu == ctvtDTO.Mavattu && ctvt.maloaiphong==ctvtDTO.Maloaiphong
                          select ctvt).FirstOrDefault<chitietvattu>();
            querry.soluong = (int)ctvtDTO.Soluong;
            htDataContext.SubmitChanges();
        }
    }
}
