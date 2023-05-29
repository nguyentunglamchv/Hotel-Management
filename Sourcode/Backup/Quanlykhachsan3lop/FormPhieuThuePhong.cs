using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Collections;

namespace Quanlykhachsan3lop
{
    public partial class FormPhieuThuePhong : Form
    {
        public string str = "";
        public string maphieudat="";
        public string maphieuthue = "";
        public string maphong="";
        public FormPhieuDatphong frmPDatPhong;
        public FormMain frmMain;
        public string MaDV;


        PhieuThuePhongBUS ptpBUS;
        PhieuThuePhongDTO ptpDTO;

        PhieuDatPhongBUS pdpBUS;

        ChiTietThuePhongBUS cttpBUS;
        ChiTietThuePhongDTO cttpDT0;

        ChiTietDatPhongBUS ctdpBUS;

        KhachHangBUS khBUS;

        HoaDonBUS hdBUS;

        DichVuBUS dvBUS;

        Size sizeOld;
        public FormPhieuThuePhong()
        {
            InitializeComponent();
        }

        private void FormPhieuThuePhong_Load(object sender, EventArgs e)
        {
            if (frmMain.m_chucvu == "Quản lý")
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            dtpNgayGio.Format = DateTimePickerFormat.Custom;
            dtpNgayGio.CustomFormat = "dd/MM/yyyy h:mm:ss";
            sizeOld = this.Size;
            if (maphieudat != "")
                nhanphong(maphieudat);
            dvBUS = new DichVuBUS();
            cmbMaDV.DataSource = dvBUS.getListDichVuAll();
            cmbMaDV.DisplayMember = "Tendichvu";
            cmbMaDV.ValueMember = "Madichvu";
            emtylsvgKH();
            lbTitle.Text+= str;
            
            show_MaPT();
           
            if (cmbMaPT.Text != "")
            {
                show_CTTP();

                show_kh();
            }
            if (maphieuthue != "" && maphong!="")
            {
                cmbMaPT.Text = maphieuthue;
                cmbMaPT.Text = maphong;
            }

        }
        private void emtylsvgKH()
        {
            for (int i = 0; i < lsvKH.Items.Count; i++)
            {
                lsvKH.Items[i].SubItems.Add(" ");
            }
        }
        private void show_kh()
        {
            ptpBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO listptp = ptpBUS.getPhieuThuePhongByID(cmbMaPT.Text);
            pdpBUS = new PhieuDatPhongBUS();
            PhieuDatPhongDTO listpdp = pdpBUS.getPhieuDatPhongByID(listptp.Maphieudat);
            khBUS = new KhachHangBUS();
            KhachHangDTO listkh = khBUS.getKhachHangByID(listpdp.Makhachhang);

            emtylsvgKH();
            lsvKH.Items[0].SubItems[1].Text = listkh.Makhachhang;
            lsvKH.Items[1].SubItems[1].Text = listkh.Tenkhachhang;
            lsvKH.Items[2].SubItems[1].Text = listkh.CMND_PASSPORT;
            lsvKH.Items[3].SubItems[1].Text = listkh.Diachi;
            lsvKH.Items[4].SubItems[1].Text = listkh.Coquan;
            lsvKH.Items[5].SubItems[1].Text = listkh.Sodienthoai;
            lsvKH.Items[6].SubItems[1].Text = listkh.Email;

        }
        
        private void show_MaPT()
        {
            cmbMaPT.Items.Clear();
            ptpBUS = new PhieuThuePhongBUS();
            IList<PhieuThuePhongDTO> listptp = ptpBUS.getListPhieuThuePhongAll();
            foreach (PhieuThuePhongDTO ptp in listptp)
            {
               if(kt_phieuthue_hoadon(ptp.Maphieuthue))
               {
                   cmbMaPT.Items.Add(ptp.Maphieuthue);
               }
            }
            if (maphieudat != "")
            {
                ptpBUS = new PhieuThuePhongBUS();
                IList<PhieuThuePhongDTO> list = ptpBUS.getListPhieuThuePhongByMaPhieuDat(maphieudat);
                foreach (PhieuThuePhongDTO ptp in list)
                {
                    cmbMaPT.Text = ptp.Maphieuthue;
                }
            }
            else if(cmbMaPT.Items.Count>0)
            {
                cmbMaPT.SelectedIndex = 0;
            }
        }
        private bool kt_phieuthue_hoadon(string maphieuthue)
        {
            hdBUS = new HoaDonBUS();
            IList<HoaDonDTO> listhd = hdBUS.getListHoaDonAll();
            foreach (HoaDonDTO hd in listhd)
            {
                if (hd.Maphieuthue == maphieuthue)
                {
                    return false;
                }
            }
            return true;
        }
        private void cmbMaPT_SelectedValueChanged(object sender, EventArgs e)
        {
            show_Phong();
            show_kh();
            show_CTTP();
        }
        private void show_Phong()
        {

            cmbMaphong.Items.Clear();
            string fe = cmbMaPT.SelectedItem.ToString();
            ptpBUS = new PhieuThuePhongBUS();
            PhieuThuePhongDTO listptp = ptpBUS.getPhieuThuePhongByID(fe);
            
            string fe1 = listptp.Maphieudat;
            pdpBUS = new PhieuDatPhongBUS();
            PhieuDatPhongDTO listpdt = pdpBUS.getPhieuDatPhongByID(fe1);

            string fe2 = listptp.Maphieudat;
            ctdpBUS = new ChiTietDatPhongBUS();
            IList<ChiTietDatPhongDTO> listcttp = ctdpBUS.getChiTietDatPhongByID(fe2);
            foreach (ChiTietDatPhongDTO ctdp in listcttp)
            {
                cmbMaphong.Items.Add(ctdp.Maphong);
            }


            if (maphong != "")
            {
                cmbMaphong.Text = maphong;
            }
            else
            {
                cmbMaphong.SelectedIndex = 0;
            }
        }
        private void show_CTTP()
        {
            lsvCTPT.Items.Clear();
            decimal t = 0;
            txtTongTien.Clear();
            dtpNgayGio.Enabled = false;
            dtpNgayGio.Format = DateTimePickerFormat.Custom;
            dtpNgayGio.CustomFormat = "dd/MM/yyyy h:mm:ss";
            dtpNgayGio.Value = DateTime.Now;
            string fePT = cmbMaPT.SelectedItem.ToString();
            cttpBUS = new ChiTietThuePhongBUS();
            IList<ChiTietThuePhongDTO> listcttp = cttpBUS.getChiTietThuePhongByID(fePT);
            foreach (ChiTietThuePhongDTO cttp in listcttp)
            {
                int i = lsvCTPT.Items.Count;
                if (cmbMaphong.Text != "")
                {
                    if (cttp.Maphong == cmbMaphong.SelectedItem.ToString())
                    {
                        dvBUS = new DichVuBUS();
                        DichVuDTO listdv = dvBUS.getDichVuByID(cttp.Madichvu);
                        
                        
                            lsvCTPT.Items.Add(listdv.Tendichvu);
                            lsvCTPT.Items[i].SubItems.Add(cttp.Ngay.ToString());
                            lsvCTPT.Items[i].SubItems.Add(cttp.Soluong.ToString());
                            int sl = cttp.Soluong;
                            decimal gia = listdv.Gia;
                            decimal tien = sl * gia;
                            t += tien;
                            lsvCTPT.Items[i].SubItems.Add(tien.ToString("0,0"));
                        
                    }
                }
            }
            txtTongTien.Text = t.ToString("0,0");
        }
        private void Enablequanly()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private int showid()
        {
            ptpBUS = new PhieuThuePhongBUS();
            return ptpBUS.Count() + 1;
        }

        private void btnMaDV_Click(object sender, EventArgs e)
        {
            /*FormDichVu frm = new FormDichVu();
            frm.frmThue = this;
            frm.frmMain = frmMain;
            frm.ShowDialog();
            if (MaDV != null)
            {
                cmbMaDV.SelectedValue = MaDV;
            }*/
        }
        private void nhanphong(string maphieudat)
        {
            ptpBUS = new PhieuThuePhongBUS();
            ptpDTO = new PhieuThuePhongDTO();
            ptpDTO.Maphieuthue = "PT00" + showid();
            ptpDTO.Maphieudat = maphieudat;
            ptpDTO.Username = frmMain.m_username;
            if(ptpBUS.insertPhieuThuePhong(ptpDTO)==1)
            {
                
                
                show_MaPT();
                show_CTTP();
                MessageBox.Show("Đã tạo Phiếu Thuê Phòng từ Phiếu Đặt Phòng: " + maphieudat);
            }
            else
            {
                MessageBox.Show("Lỗi thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {

                dtpNgayGio.Format = DateTimePickerFormat.Custom;
                dtpNgayGio.CustomFormat = "dd/MM/yyyy h:mm:ss";
                cttpBUS = new ChiTietThuePhongBUS();
                cttpDT0 = new ChiTietThuePhongDTO();
                cttpDT0.Maphieuthue = cmbMaPT.SelectedItem.ToString();
                cttpDT0.Maphong = cmbMaphong.SelectedItem.ToString();
                cttpDT0.Ngay = DateTime.Parse(dtpNgayGio.Value.ToString());
                cttpDT0.Madichvu = cmbMaDV.SelectedValue.ToString();
                cttpDT0.Soluong = (int)numSL.Value;
                if (cttpBUS.insertChiTietThuePhong(cttpDT0) == 1)
                {
                    show_CTTP();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpNgayGio.Value = DateTime.Now;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvCTPT.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cttpBUS = new ChiTietThuePhongBUS();
                    cttpDT0.Maphieuthue = cmbMaPT.SelectedItem.ToString();
                    cttpDT0.Maphong = cmbMaphong.SelectedValue.ToString();
                    cttpDT0.Ngay = dtpNgayGio.Value;
                    if (cttpBUS.deleteChiTietThuePhong(cmbMaPT.SelectedItem.ToString(), cmbMaphong.SelectedValue.ToString(), dtpNgayGio.Value, cmbMaDV.SelectedValue.ToString()) == 1)
                    {
                        show_CTTP();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!");
                    }
                }
                else
                {
                    lsvCTPT.SelectedItems.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvCTPT.SelectedItems.Count <= 0) return;
            if (kiemtra())
            {
                cttpBUS = new ChiTietThuePhongBUS();
                cttpDT0 = new ChiTietThuePhongDTO();
                cttpDT0.Maphieuthue = cmbMaPT.SelectedItem.ToString();
                cttpDT0.Madichvu = cmbMaDV.SelectedValue.ToString();
                cttpDT0.Maphong = cmbMaphong.SelectedItem.ToString();
                cttpDT0.Ngay = dtpNgayGio.Value;
                cttpDT0.Soluong = (int)numSL.Value;
                if (cttpBUS.updateChiTietThuePhong(cttpDT0) == 1)
                {
                    show_CTTP();
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }
        private void cmbMaphong_SelectedValueChanged(object sender, EventArgs e)
        {
          show_CTTP();
        }
        private void cmbMaDV_SelectedValueChanged(object sender, EventArgs e)
        {
            dvBUS = new DichVuBUS();
            DichVuDTO dv=dvBUS.getDichVuByID(cmbMaDV.SelectedValue.ToString());
            if(dv!=null)
            labGia.Text = Math.Round(dv.Gia,0)+"/"+dv.Donvitinh;
            dtpNgayGio.Value = DateTime.Now;
        }
        private bool kiemtra()
        {
            if (SoL()&&Phong())
            {
                return true;
            }
            return false;
        }
        private bool SoL()
        {
            if (numSL.Value==0)
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSL.Select();
                return false;
            }
            return true;
        }

        private bool Phong()
        {
            if (cmbMaphong.Text == "")
            {
                MessageBox.Show("Phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        

        private void lsvCTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCTPT.SelectedItems.Count <= 0) return;
            cmbMaDV.Text = lsvCTPT.SelectedItems[0].SubItems[0].Text;
            numSL.Value = int.Parse(lsvCTPT.SelectedItems[0].SubItems[2].Text);
            dtpNgayGio.Value = DateTime.Parse(lsvCTPT.SelectedItems[0].SubItems[1].Text);
        }

        private void btnThem_MouseMove(object sender, MouseEventArgs e)
        {
            dtpNgayGio.Value = DateTime.Now;
        }

        private void FormPhieuThuePhong_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
