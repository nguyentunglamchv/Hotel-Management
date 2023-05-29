using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuThuePhongBUS
    {
        PhieuThuePhongDAO ptpDAO = new PhieuThuePhongDAO();

        public IList<PhieuThuePhongDTO> getListPhieuThuePhongAll()
        {
            try
            {
                return ptpDAO.getListPhieuThuePhongAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuThuePhongDTO> getListPhieuThuePhongLMAll(int a)
        {
            try
            {
                return ptpDAO.getListPhieuThuePhongLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public PhieuThuePhongDTO getPhieuThuePhongByID(string ID)
        {
            try
            {
                return ptpDAO.getPhieuThuePhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuThuePhongDTO> getListPhieuThuePhongByMaPhieuDat(string name)
        {
            try
            {
                return ptpDAO.getListPhieuThuePhongByMaPhieuDat(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuThuePhongDTO> getLikePhieuThuePhongByID(string ID)
        {
            try
            {
                return ptpDAO.getLikePhieuThuePhongByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<PhieuThuePhongDTO> getListLikePhieuThuePhongByMaPhieuDat(string name)
        {
            try
            {
                return ptpDAO.getListLikePhieuThuePhongByMaPhieuDat(name);
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
                return ptpDAO.CountListPTP();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertPhieuThuePhong(PhieuThuePhongDTO ptpDTO)
        {
            try
            {
                ptpDAO.insertPhieuThuePhong(ptpDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deletePhieuThuePhong(string idPhieuThuePhong)
        {
            try
            {
                ptpDAO.deletePhieuThuePhong(idPhieuThuePhong);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updatePhieuThuePhong(PhieuThuePhongDTO ptpDTO)
        {
            try
            {
                ptpDAO.updatePhieuThuePhong(ptpDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
