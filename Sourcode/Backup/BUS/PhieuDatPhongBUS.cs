using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuDatPhongBUS
    {
        PhieuDatPhongDAO pdpDAO = new  PhieuDatPhongDAO();

        public IList<PhieuDatPhongDTO> getListPhieuDatPhongAll()
        {
            try
            {
                return pdpDAO.getListPhieuDatPhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuDatPhongDTO> getListPhieuDatPhongLMAll(int a)
        {
            try
            {
                return pdpDAO.getListPhieuDatPhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public PhieuDatPhongDTO getPhieuDatPhongByID(string ID)
        {
            try
            {
                return pdpDAO.getPhieuDatPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuDatPhongDTO> getListPhieuDatPhongByMKH(string name)
        {
            try
            {
                return pdpDAO.getListLikePhieuDatPhongByMKH(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuDatPhongDTO> getLikePhieuDatPhongByID(string ID)
        {
            try
            {
                return pdpDAO.getLikePhieuDatPhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuDatPhongDTO> getListLikePhieuDatPhongByMKH(string name)
        {
            try
            {
                return pdpDAO.getListLikePhieuDatPhongByMKH(name);
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
                return pdpDAO.CountListPDP();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertPhieuDatPhong(PhieuDatPhongDTO pdpDTO)
        {
            try
            {
                pdpDAO.insertPhieuDatPhong(pdpDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deletePhieuDatPhong(string IDPhieuDatPhong)
        {
            try
            {
                pdpDAO.deletePhieuDatPhong(IDPhieuDatPhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updatePhieuDatPhong(PhieuDatPhongDTO pdpDTO)
        {
            try
            {
                pdpDAO.updatePhieuDatPhong(pdpDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
