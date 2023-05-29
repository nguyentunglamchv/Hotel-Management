using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Collections;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO nvDAO = new NhanVienDAO();

        public IList<NhanVienDTO> getListNhanvienAll()
        {
            try
            {
                return nvDAO.getListNhanVienAll();
            }
            catch
            {
                throw new Exception("Không lấy được danh sách nhân viên!");
            }
        }

        public IList<NhanVienDTO> getListNhanVienByChucVu(string chucvu)
        {
            try
            {
                return nvDAO.getListNhanVienByChucvu(chucvu);
            }
            catch
            {
                throw new Exception("Không lấy được danh sách nhân viên!");
            }
        }

        public IList<NhanVienDTO> getListNhanvienLMAll(int a)
        {
            try
            {
                return nvDAO.getListNhanVienLMAll(a);
            }
            catch
            {
                throw new Exception("Không lấy được danh sách nhân viên!");
            }
        }

        public NhanVienDTO getListNhanVienByID(string ID)
        {
            try
            {
                return nvDAO.getNhanVienByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<NhanVienDTO> getListNhanVienByName(string name)
        {
            try
            {
                return nvDAO.getListNhanVienByName(name);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<NhanVienDTO> getListLikeNhanVienByID(string ID)
        {
            try
            {
                return nvDAO.getLikeNhanVienByID(ID);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<NhanVienDTO> getListLikeNhanVienByName(string name)
        {
            try
            {
                return nvDAO.getListLikeNhanVienByName(name);
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
                return nvDAO.CountListNV();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountNV()
        {
            try
            {
                return nvDAO.CountChucvuNV();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int CountQL()
        {
            try
            {
                return nvDAO.CountChucvuQL();
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public int insertNhanVien(NhanVienDTO nvDTO)
        {
            try
            {
                nvDAO.insertNhanVien(nvDTO);
                return 1;
            }
            catch
            {
                return 0;
                //throw new Exception("Không thêm được dữ liệu!");
            }
        }

        public int deleteNhanVien(string idNhanvien)
        {
            try
            {
                nvDAO.deleteNhanVien(idNhanvien);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int updateNhanVien(NhanVienDTO nvDTO)
        {
            try
            {
                nvDAO.updateNhanVien(nvDTO);
                return 1;
            }
            catch 
            {
                return 0;
            }
            
        }
    }
}
