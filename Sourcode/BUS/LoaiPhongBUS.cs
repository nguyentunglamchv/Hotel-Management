using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiPhongBUS
    {
        LoaiPhongDAO lpDAO = new LoaiPhongDAO();

        public IList<LoaiPhongDTO> getListLoaiPhongAll()
        {
            try
            {
                return lpDAO.getListLoaiPhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<LoaiPhongDTO> getListLoaiPhongLMAll(int a)
        {
            try
            {
                return lpDAO.getListLoaiPhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public LoaiPhongDTO getLoaiPhongByID(string ID)
        {
            try
            {
                return lpDAO.getLoaiPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<LoaiPhongDTO> getLikeLoaiPhongByID(string ID)
        {
            try
            {
                return lpDAO.getLikeLoaiPhongByID(ID);
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
                return lpDAO.CountListLP();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertLoaiPhong(LoaiPhongDTO lpDTO)
        {
            try
            {
                lpDAO.insertLoaiPhong(lpDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteLoaiPhong(string idLoaiPhong)
        {
            try
            {
                lpDAO.deleteLoaiPhong(idLoaiPhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateLoaiPhong(LoaiPhongDTO lpDTO)
        {
            try
            {
                lpDAO.updateLoaiPhong(lpDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
