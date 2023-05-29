using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DichVuBUS
    {
        DichVuDAO dvDAO = new DichVuDAO();

        public IList<DichVuDTO> getListDichVuAll()
        {
            try
            {
                return dvDAO.getListDichVuAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<DichVuDTO> getListDichVuLMAll(int a)
        {
            try
            {
                return dvDAO.getListDichVuLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public DichVuDTO getDichVuByID(string ID)
        {
            try
            {
                return dvDAO.getDichVuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<DichVuDTO> getListDichVuByName(string name)
        {
            try
            {
                return dvDAO.getListDichVuByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<DichVuDTO> getLikeDichVuByID(string ID)
        {
            try
            {
                return dvDAO.getLikeDichVuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<DichVuDTO> getListLikeDichVuByName(string name)
        {
            try
            {
                return dvDAO.getListLikeDichVuByName(name);
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
                return dvDAO.CountListdv();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertDichVu(DichVuDTO dvDTO)
        {
            try
            {
                dvDAO.insertDichVu(dvDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteDichVu(string idDichVu)
        {
            try
            {
                dvDAO.deleteDichVu(idDichVu);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateDichVu(DichVuDTO dvDTO)
        {
            try
            {
                dvDAO.updateDichVu(dvDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
