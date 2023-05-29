using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khDAO = new KhachHangDAO();

        public IList<KhachHangDTO> getListKhachHangAll()
        {
            try
            {
                return khDAO.getListKhachHangAll();
            }
            catch
            {
                throw new Exception("Không lấy được danh sách người dùng!");
            }
        }

        public IList<KhachHangDTO> getListKhachHangLMAll(int a)
        {
            try
            {
                return khDAO.getListKhachHangLMAll(a);
            }
            catch
            {
                throw new Exception("Không lấy được danh sách người dùng!");
            }
        }

        public KhachHangDTO getKhachHangByID(string ID)
        {
            try
            {
                return khDAO.getKhachHangByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<KhachHangDTO> getListKhachHangByName(string name)
        {
            try
            {
                return khDAO.getListKhachHangByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<KhachHangDTO> getLikeKhachHangByID(string ID)
        {
            try
            {
                return khDAO.getLikeKhachHangByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<KhachHangDTO> getListLikeKhachHangByName(string name)
        {
            try
            {
                return khDAO.getListLikeKhachHangByName(name);
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
                return khDAO.CountListKH();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertKhachHang(KhachHangDTO khDTO)
        {
            try
            {
                khDAO.insertKhachHang(khDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteKhachHang(string idKhachHang)
        {
            try
            {
                khDAO.deleteKhachHang(idKhachHang);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateKhachHang(KhachHangDTO khDTO)
        {
            try
            {
                khDAO.updateKhachHang(khDTO);
                return 1;
            }
            catch 
            {
                return 0;
            }
            
        }
    }
}
