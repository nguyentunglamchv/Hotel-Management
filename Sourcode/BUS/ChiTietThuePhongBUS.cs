using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietThuePhongBUS
    {
        ChiTietThuePhongDAO cttpDAO = new ChiTietThuePhongDAO();

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongAll()
        {
            try
            {
                return cttpDAO.getListChiTietThuePhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongLMAll(int a)
        {
            try
            {
                return cttpDAO.getListChiTietThuePhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietThuePhongDTO> getChiTietThuePhongByID(string ID)
        {
            try
            {
                return cttpDAO.getChiTietThuePhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongByName(string name)
        {
            try
            {
                return cttpDAO.getListChiTietThuePhongByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietThuePhongDTO> getLikeChiTietThuePhongByID(string ID)
        {
            try
            {
                return cttpDAO.getLikeChiTietThuePhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietThuePhongDTO> getListLikeChiTietThuePhongByName(string name)
        {
            try
            {
                return cttpDAO.getListLikeChiTietThuePhongByName(name);
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
                return cttpDAO.CountListcttp();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertChiTietThuePhong(ChiTietThuePhongDTO htDTO)
        {
            try
            {
                cttpDAO.insertChiTietThuePhong(htDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteChiTietThuePhong(string idChiTietThuePhong,string maphong,DateTime ngay,string madichvu)
        {
            try
            {
                cttpDAO.deleteChiTietThuePhong(idChiTietThuePhong,maphong,ngay,madichvu);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateChiTietThuePhong(ChiTietThuePhongDTO htDTO)
        {
            try
            {
                cttpDAO.updateChiTietThuePhong(htDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
