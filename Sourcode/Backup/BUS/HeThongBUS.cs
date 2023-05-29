using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HeThongBUS
    {
        HeThongDAO htDAO = new HeThongDAO();

        public IList<HeThongDTO> getListHeThongAll()
        {
            try
            {
                return htDAO.getListHethongAll();
            }
            catch
            {
                throw new Exception("Không lấy được danh sách người dùng!");
            }
        }

        public IList<HeThongDTO> getListHeThongLMAll(int a)
        {
            try
            {
                return htDAO.getListHethongLMAll(a);
            }
            catch
            {
                throw new Exception("Không lấy được danh sách người dùng!");
            }
        }

        public HeThongDTO getHeThongByUserName(string ID)
        {
            try
            {
                return htDAO.getHeThongByUserName(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public HeThongDTO getListHeThongByID(string id)
        {
            try
            {
                return htDAO.getListHeThongByID(id);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<HeThongDTO> getLikeHeThongByUserName(string ID)
        {
            try
            {
                return htDAO.getLikeHeThongByUserName(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<HeThongDTO> getListLikeHeThongByMaNV(string name)
        {
            try
            {
                return htDAO.getListLikeHeThongByMaNV(name);
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
                return htDAO.CountListHT();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertHeThong(HeThongDTO htDTO)
        {
            try
            {
                htDAO.insertHeThong(htDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteHeThong(string idHeThong)
        {
            try
            {
                htDAO.deleteHeThong(idHeThong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateHeThong(HeThongDTO htDTO)
        {
            try
            {
                htDAO.updateHeThong(htDTO);
                return 1;
            }catch{
                return 0;
            }
        }
    }
}
