using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class VatTuBUS
    {
        VatTuDAO vtDAO = new VatTuDAO();

        public IList<VatTuDTO> getListVatTuAll()
        {
            try
            {
                return vtDAO.getListVatTuAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<VatTuDTO> getListVatTuLMAll(int a)
        {
            try
            {
                return vtDAO.getListVatTuLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public VatTuDTO getVatTuByID(string ID)
        {
            try
            {
                return vtDAO.getVatTuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<VatTuDTO> getListVatTuByName(string name)
        {
            try
            {
                return vtDAO.getListVatTuByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<VatTuDTO> getLikeVatTuByID(string ID)
        {
            try
            {
                return vtDAO.getLikeVatTuByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<VatTuDTO> getListLikeVatTuByName(string name)
        {
            try
            {
                return vtDAO.getListLikeVatTuByName(name);
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
                return vtDAO.CountListvVT();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertVatTu(VatTuDTO vtDTO)
        {
            try
            {
                vtDAO.insertVatTu(vtDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteVatTu(string idVatTu)
        {
            try
            {
                vtDAO.deleteVatTu(idVatTu);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateVatTu(VatTuDTO vtDTO)
        {
            try
            {
                vtDAO.updateVatTu(vtDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
