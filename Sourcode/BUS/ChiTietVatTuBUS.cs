using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietVatTuBUS
    {
        ChiTietVatTuDAO ctvtDAO = new ChiTietVatTuDAO();

        public IList<ChiTietVatTuDTO> getListChiTietVatTuAll()
        {
            try
            {
                return ctvtDAO.getListChiTietVatTuAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietVatTuDTO> getListChiTietVatTuLMAll(int a)
        {
            try
            {
                return ctvtDAO.getListChiTietVatTuLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public ChiTietVatTuDTO getChiTietVatTuByID(string ID)
        {
            try
            {
                return ctvtDAO.getChiTietVatTuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietVatTuDTO> getListChiTietVatTuByMaLP(string name)
        {
            try
            {
                return ctvtDAO.getListChiTietVatTuByMaLP(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietVatTuDTO> getLikeChiTietVatTuByID(string ID)
        {
            try
            {
                return ctvtDAO.getLikeChiTietVatTuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietVatTuDTO> getListLikeChiTietVatTuByMaLP(string name)
        {
            try
            {
                return ctvtDAO.getListLikeChiTietVatTuByMaLP(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int Count()
        {
            try
            {
                return ctvtDAO.CountListctvt();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertChiTietVatTu(ChiTietVatTuDTO htDTO)
        {
            try
            {
                ctvtDAO.insertChiTietVatTu(htDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteChiTietVatTu(string idChiTietVatTu,string idPhong)
        {
            try
            {
                ctvtDAO.deleteChiTietVatTu(idChiTietVatTu,idPhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateChiTietVatTu(ChiTietVatTuDTO htDTO)
        {
            try
            {
                ctvtDAO.updateChiTietVatTu(htDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
