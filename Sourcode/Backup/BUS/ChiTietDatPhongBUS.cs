using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietDatPhongBUS
    {
        ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongAll()
        {
            try
            {
                return ctdpDAO.getListChiTietDatPhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongLMAll(int a)
        {
            try
            {
                return ctdpDAO.getListChiTietDatPhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietDatPhongDTO> getChiTietDatPhongByID(string ID)
        {
            try
            {
                return ctdpDAO.getChiTietDatPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongByName(string name)
        {
            try
            {
                return ctdpDAO.getListChiTietDatPhongByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietDatPhongDTO> getLikeChiTietDatPhongByID(string ID)
        {
            try
            {
                return ctdpDAO.getLikeChiTietDatPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<ChiTietDatPhongDTO> getListLikeChiTietDatPhongByName(string name)
        {
            try
            {
                return ctdpDAO.getListLikeChiTietDatPhongByName(name);
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
                return ctdpDAO.CountListctdp();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertChiTietDatPhong(ChiTietDatPhongDTO htDTO)
        {
            try
            {
                ctdpDAO.insertChiTietDatPhong(htDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteChiTietDatPhong(string idChiTietDatPhong)
        {
            try
            {
                ctdpDAO.deleteChiTietDatPhong(idChiTietDatPhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateChiTietDatPhong(ChiTietDatPhongDTO htDTO)
        {
            try
            {
                ctdpDAO.updateChiTietDatPhong(htDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
