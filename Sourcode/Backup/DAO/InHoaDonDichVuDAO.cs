using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Collections;

namespace DAO
{
    public class InHoaDonDichVuDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();
        ArrayList list = new ArrayList();
        public ArrayList inhoadondv(string mahoadon)
        {
            var kdv = htDataContext.InhoadonDichVu(mahoadon);
            list.Clear();
            foreach (InhoadonDichVuResult dv in kdv)
            {
                InHoaDonDichVuDTO dvDTO = new InHoaDonDichVuDTO();

                dvDTO.Maphieuthue = dv.maphieuthue;
                dvDTO.Mahoadon = dv.mahoadon;
                dvDTO.Tendichvu = dv.tendichvu;
                dvDTO.Gia = (decimal)dv.gia;
                dvDTO.Donvitinh = dv.donvitinh;
                dvDTO.Soluong = (int)dv.soluong;
                dvDTO.MaPhong = dv.maphong;
                dvDTO.Ngay = dv.ngay;
                list.Add(dvDTO);
            }
            return list;
        }
    }
}
