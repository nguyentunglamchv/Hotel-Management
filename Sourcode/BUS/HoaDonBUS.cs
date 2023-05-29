using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdDAO = new HoaDonDAO();

        public IList<HoaDonDTO> getListHoaDonAll()
        {
            try
            {
                return hdDAO.getListHoaDonAll();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<HoaDonDTO> getListHoaDonLMAll(int a)
        {
            try
            {
                return hdDAO.getListHoaDonLMAll(a);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public HoaDonDTO getHoaDonByID(string ID)
        {
            try
            {
                return hdDAO.getHoaDonByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<HoaDonDTO> getListHoaDonByDate(DateTime date)
        {
            try
            {
                return hdDAO.getListHoaDonByDate(date);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<HoaDonDTO> getLikeHoaDonByID(string ID)
        {
            try
            {
                return hdDAO.getLikeHoaDonByID(ID);
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
                return hdDAO.CountListHD();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertHoaDon(HoaDonDTO hdDTO)
        {
            try
            {
                hdDAO.insertHoaDon(hdDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteHoaDon(string idHoaDon)
        {
            try
            {
                hdDAO.deleteHoaDon(idHoaDon);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateHoaDon(HoaDonDTO hdDTO)
        {
            try
            {
                hdDAO.updateHoaDon(hdDTO);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
    }
}
