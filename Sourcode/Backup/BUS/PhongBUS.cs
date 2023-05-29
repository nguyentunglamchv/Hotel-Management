using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class PhongBUS
    {
        PhongDAO pDAO = new  PhongDAO();

        public IList<PhongDTO> getListPhongAll()
        {
            try
            {
                return pDAO.getListPhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhongDTO> getListPhongLMAll(int a)
        {
            try
            {
                return pDAO.getListPhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public PhongDTO getPhongByID(string ID)
        {
            try
            {
                return pDAO.getPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhongDTO> getListPhongByLoai(string name)
        {
            try
            {
                return pDAO.getListPhongByLoai(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhongDTO> getLikePhongByID(string ID)
        {
            try
            {
                return pDAO.getLikePhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhongDTO> getLikePhongByLoai(string name)
        {
            try
            {
                return pDAO.getListLikePhongByLoai(name);
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
                return pDAO.CountListP();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertPhong(PhongDTO pDTO)
        {
            try
            {
                pDAO.insertPhong(pDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deletePhong(string idPhong)
        {
            try
            {
                pDAO.deletePhong(idPhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updatePhong(PhongDTO pDTO)
        {
            try
            {
                pDAO.updatePhong(pDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
