using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using System.Collections;

namespace Quanlykhachsan3lop
{
    public partial class FormHoaDon : Form
    {
        public FormMain frmMain;
        public string maphieuthue = "";

        private decimal tienphong = 0;
        private decimal tiendichvu = 0;

        public bool flagtinhtien = false;

        HoaDonBUS hdBUS;
        HoaDonDTO hdDTO;

        DichVuBUS dvBUS;

        PhongBUS pBUS;
        PhongDTO pDTO;

        InHoaDonDichVuBUS inhddvBUS;

        InHoaDonPhongBUS inhdpBUS;

        LoaiPhongBUS lpBUS;

        PhieuThuePhongBUS ptpBUS;

        PhieuDatPhongBUS pdpBUS;
        PhieuDatPhongDTO pdpDTO;

        KhachHangBUS khBUS;

        ChiTietDatPhongBUS ctdpBUS;

        ChiTietThuePhongBUS cttpBUS;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            labMaHD.Text = "HD00" + showid();
            if (frmMain.m_chucvu == "Quản lý")
            {
                btnTinhTien.Enabled = false;
                btnInhoadon.Enabled = false;
            }
            emtylsvgKH();
            show_MaPT();
            if (cmbMaPT.Text != "")
            {
                show_KH();
                show_Phong();
                show_DV();
            }
            
            
            dtpNgay.Enabled = false;
        }

        private int showid()
        {
            hdBUS = new HoaDonBUS();
            return hdBUS.Count() + 1;
        }

        private void emtylsvgKH()
        {
            for (int i = 0; i < lsvKH.Items.Count; i++)
            {
                lsvKH.Items[i].SubItems.Add("");
            }
        }
        private void Enablequanly()
        {
            btnTinhTien.Enabled = false;
        }
        private void show_MaPT()
        {
            cmbMaPT.Items.Clear();
            ptpBUS = new PhieuThuePhongBUS();
            hdBUS = new HoaDonBUS();
            IList<PhieuThuePhongDTO> listptp = ptpBUS.getListPhieuThuePhongAll();
            IList<HoaDonDTO> listHD = hdBUS.getListHoaDonAll();
            foreach (PhieuThuePhongDTO pt in listptp)
            {
                if (listHD.Count <= 0)
                {
                    cmbMaPT.Items.Add(pt.Maphieuthue);
                }
                else
                {
                    if(ktHD(pt.Maphieuthue))
                    {
                        cmbMaPT.Items.Add(pt.Maphieuthue);
                    }
                }
            }
            if (maphieuthue == "" && cmbMaPT.Items.Count >0)
            {
                cmbMaPT.SelectedIndex = 0;
            }else if (maphieuthue != "")
            {
                cmbMaPT.Text = maphieuthue;

            }
        }

        private bool ktHD(string maphieuthue)
        {
            
            IList<HoaDonDTO> listHD = hdBUS.getListHoaDonAll();


            foreach (HoaDonDTO hd in listHD)
            {
                if (hd.Maphieuthue == maphieuthue)
                {
                    return false;
                }
            }
            return true;
        }
        private void show_KH()
        {
            //lsvKH.Items.Clear();
            ptpBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO listptp = ptpBUS.getPhieuThuePhongByID(cmbMaPT.Text);
            pdpBUS = new PhieuDatPhongBUS();
            PhieuDatPhongDTO pdp = pdpBUS.getPhieuDatPhongByID(listptp.Maphieudat);
            labTDC.Text = pdp.Sotiendatcoc.ToString("0,0");
            khBUS = new KhachHangBUS();
           // emtylsvgKH();
            KhachHangDTO kh = khBUS.getKhachHangByID(pdp.Makhachhang);
            lsvKH.Items[0].SubItems[1].Text = kh.Makhachhang;
            lsvKH.Items[1].SubItems[1].Text = kh.Tenkhachhang;
            lsvKH.Items[2].SubItems[1].Text = kh.CMND_PASSPORT;
            lsvKH.Items[3].SubItems[1].Text = kh.Diachi;
            lsvKH.Items[4].SubItems[1].Text = kh.Coquan;
            lsvKH.Items[5].SubItems[1].Text = kh.Sodienthoai;
            lsvKH.Items[6].SubItems[1].Text = kh.Email;
        }

        private void show_Phong()
        {
            lsvPhong.Items.Clear();
            tienphong = 0;
            ptpBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO ptp = ptpBUS.getPhieuThuePhongByID(cmbMaPT.Text);
            pdpBUS = new PhieuDatPhongBUS();
            PhieuDatPhongDTO pdp = pdpBUS.getPhieuDatPhongByID(ptp.Maphieudat);
            ctdpBUS = new ChiTietDatPhongBUS();
            IList<ChiTietDatPhongDTO> list = ctdpBUS.getChiTietDatPhongByID(pdp.Maphieudat);
            pBUS = new PhongBUS();
            lpBUS = new LoaiPhongBUS();
            foreach (ChiTietDatPhongDTO ctdp in list)
            {
                int i=lsvPhong.Items.Count;
                PhongDTO p = pBUS.getPhongByID(ctdp.Maphong);
                LoaiPhongDTO lp = lpBUS.getLoaiPhongByID(p.Maloai);
                lsvPhong.Items.Add(ctdp.Maphong);
                lsvPhong.Items[i].SubItems.Add(lp.Gia.ToString("0,0"));
                lsvPhong.Items[i].SubItems.Add(pdp.Ngayden.ToShortDateString());
                lsvPhong.Items[i].SubItems.Add(pdp.Ngaydi.ToShortDateString());
                TimeSpan sno = pdp.Ngaydi.Date.AddDays(1) - pdp.Ngayden.Date;
                lsvPhong.Items[i].SubItems.Add(sno.Days.ToString());
                decimal tp = lp.Gia * sno.Days;
                lsvPhong.Items[i].SubItems.Add(tp.ToString("0,0"));
                tienphong += tp;
            }
            labTP.Text = tienphong.ToString("0,0");
        }

        private void show_DV()
        {
            lsvDV.Items.Clear();
            tiendichvu = 0;
            ptpBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO ptp = ptpBUS.getPhieuThuePhongByID(cmbMaPT.Text);
            cttpBUS = new ChiTietThuePhongBUS();
            IList<ChiTietThuePhongDTO> listcttp = cttpBUS.getChiTietThuePhongByID(ptp.Maphieuthue);
            dvBUS = new DichVuBUS();
            foreach (ChiTietThuePhongDTO cttp in listcttp)
            {
                int i = lsvDV.Items.Count;
                DichVuDTO dv = dvBUS.getDichVuByID(cttp.Madichvu);
                lsvDV.Items.Add(dv.Tendichvu);
                lsvDV.Items[i].SubItems.Add(cttp.Maphong);
                lsvDV.Items[i].SubItems.Add(cttp.Ngay.ToShortDateString());
                lsvDV.Items[i].SubItems.Add(cttp.Ngay.ToLongTimeString());
                lsvDV.Items[i].SubItems.Add(dv.Gia.ToString("0,0"));
                lsvDV.Items[i].SubItems.Add(cttp.Soluong.ToString());
                decimal tt = dv.Gia * cttp.Soluong;
                lsvDV.Items[i].SubItems.Add(tt.ToString("0,0"));
                tiendichvu += tt;
            }
            labTDV.Text = tiendichvu.ToString("0,0");
            
        }

        private void cmbMaPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_KH();
            show_Phong();
            show_DV();
            flagtinhtien = false;
            if(cmbMaPT.Text!="")
            labMaHD.Text = "HD00" + showid();
        }

        private bool kiemtra()
        {
            if (labMaHD.Text == "")
            {
                MessageBox.Show("Mã hóa đơn không được để trống!");
                labMaHD.Focus();
                return false;
            }
            else if (cmbMaPT.Text == "")
            {
                MessageBox.Show("Mã phiếu thuê không được bỏ trống!");
                return false;
            }
            return true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            ArrayList listdv = new ArrayList();
            ArrayList listp = new ArrayList();
            listdv.Clear();
            listp.Clear();
            if (flagtinhtien == true)
            {
                inhddvBUS = new InHoaDonDichVuBUS();
                inhdpBUS = new InHoaDonPhongBUS();
                listdv = inhddvBUS.InHoaDonDivhVu(labMaHD.Text);
                listp = inhdpBUS.InHoaDonPhong(labMaHD.Text);
                qlks3lopDataSet.InhoadonDichVuDataTable dtdv = new qlks3lopDataSet.InhoadonDichVuDataTable();
                qlks3lopDataSet.InhoadonPhongDataTable dtp = new qlks3lopDataSet.InhoadonPhongDataTable();
                foreach(InHoaDonDichVuDTO hddv in listdv)
                {
                    dtdv.Rows.Add(hddv.Maphieuthue, hddv.Tendichvu, hddv.Gia, hddv.Donvitinh,hddv.Soluong,hddv.MaPhong,hddv.Mahoadon,hddv.Ngay);
                }
                foreach (InHoaDonPhongDTO hdp in listp)
                {
                    dtp.Rows.Add(hdp.Mahoadon, hdp.Tenkhachhang, hdp.Songayo, hdp.CMND, hdp.Diachi, hdp.Coquan, hdp.Sodienthoai, hdp.Email, hdp.Ngayden, hdp.Ngaydi, hdp.Sotiendatcoc, hdp.Gia, hdp.Maphong, hdp.Tennhanvien,hdp.Tongtien);
                }
                InHoaDon frmInHoaDon = new InHoaDon();
                frmInHoaDon.dtdv=dtdv;
                frmInHoaDon.dtp = dtp;
                frmInHoaDon.ShowDialog();
                //show_MaPT();
            }
            else MessageBox.Show("Thanh toán trước khi in hóa đơn");
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                    labTPT.Text = Math.Round(decimal.Parse(labTP.Text) + decimal.Parse(labTDV.Text) - decimal.Parse(labTDC.Text), 0).ToString("0,0");
                    ptpBUS = new PhieuThuePhongBUS();
                    hdBUS = new HoaDonBUS();
                    pdpBUS=new PhieuDatPhongBUS();
                    hdDTO = new HoaDonDTO();
                    ctdpBUS = new ChiTietDatPhongBUS();
                    pBUS = new PhongBUS();
                    PhieuThuePhongDTO ptp = ptpBUS.getPhieuThuePhongByID(cmbMaPT.Text);
                    PhieuDatPhongDTO pdp=pdpBUS.getPhieuDatPhongByID(ptp.Maphieudat);
                    hdDTO.Mahoadon = labMaHD.Text;
                    hdDTO.Ngaythanhtoan = dtpNgay.Value;
                    hdDTO.Tongtien = decimal.Parse(labTPT.Text);
                    hdDTO.Maphieuthue = cmbMaPT.Text;
                    hdDTO.Makhachhang = pdp.Makhachhang;
                    hdDTO.Username = frmMain.m_username;
                    if (hdBUS.insertHoaDon(hdDTO) == 1)
                    {
                        pdpDTO = new PhieuDatPhongDTO();
                        pdpDTO.Maphieudat = pdp.Maphieudat;
                        pdpDTO.Makhachhang = pdp.Makhachhang;
                        pdpDTO.Ngayden = pdp.Ngayden;
                        pdpDTO.Ngaydi = pdp.Ngaydi;
                        pdpDTO.Sotiendatcoc = pdp.Sotiendatcoc;
                        pdpDTO.Username = pdp.Username;
                        pdpDTO.Tinhtrang = "finish";
                        pdpDTO.Songuoi = pdp.Songuoi;
                        if (pdpBUS.updatePhieuDatPhong(pdpDTO) == 1)
                        {
                            IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(pdp.Maphieudat);
                            foreach (ChiTietDatPhongDTO ctdp in listctdp)
                            {
                                pDTO = new PhongDTO();
                                PhongDTO p = pBUS.getPhongByID(ctdp.Maphong);
                                pDTO.Maphong = p.Maphong;
                                pDTO.Maloai = p.Maloai;
                                pDTO.Dadat = false;
                                pDTO.Danhan = false;
                                if (pBUS.updatePhong(pDTO) == 1)
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi sửa phòng!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lỗi sửa phiếu đặt phòng!");
                        }

                        flagtinhtien = true;
                        show_KH();
                        show_Phong();
                        show_DV();
                        //show_MaPT();
                        frmMain.capnhatphong();
                        MessageBox.Show("Đã tính tiền!");
                        btnInhoadon.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi dữ liệu!");
                    }
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhTien_MouseMove(object sender, MouseEventArgs e)
        {
            dtpNgay.Value = DateTime.Now;
        }
    }
}
