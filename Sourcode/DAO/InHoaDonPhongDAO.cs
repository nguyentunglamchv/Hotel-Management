using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Collections;

namespace DAO
{
    public class InHoaDonPhongDAO
    {
        HotelDataContext htDataContext = new HotelDataContext();
        public ArrayList InHoaDonPhong(string mahoadon)
        {
            ArrayList a = new ArrayList();
            a.Clear();
            var hd = htDataContext.InhoadonPhong(mahoadon);
            foreach (InhoadonPhongResult hdr in hd)
            {
                InHoaDonPhongDTO hdp = new InHoaDonPhongDTO();
                hdp.Mahoadon = hdr.mahoadon;
                hdp.Tenkhachhang = hdr.tenkhachhang;
                hdp.Songayo = (int)hdr.ngayo;
                hdp.CMND = hdr.cmnd_passport;
                hdp.Diachi = hdr.diachi;
                hdp.Coquan = hdr.coquan;
                hdp.Sodienthoai = hdr.sodienthoai;
                hdp.Email = hdr.email;
                hdp.Maphong = hdr.maphong;
                hdp.Ngayden = hdr.ngayden.Value;
                hdp.Ngaydi = hdr.ngaydi.Value;
                hdp.Sotiendatcoc = (decimal)hdr.sotiendatcoc;
                hdp.Gia = (decimal)hdr.gia;
                hdp.Tennhanvien = hdr.tennhanvien;
                hdp.Tongtien = (decimal)hdr.tongtien;
                a.Add(hdp);
            }
            return a;
        }
    }
}
