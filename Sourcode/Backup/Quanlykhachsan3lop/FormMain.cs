using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using DTO;
using BUS;

namespace Quanlykhachsan3lop
{
    public partial class FormMain : Form
    {
        public FormLogin frmLogin;
        public FormDoiMatKhau frmDoimatkhau;
        public FormNhanVien frmNhanvien;
        public FormPhong frmPhong;
        public int CountList = 5;
        public string m_chucvu = "";
        public string m_username = "";
        public string m_maNV = "";


        PhongBUS pBUS;
        ChiTietDatPhongBUS ctdpBUS;
        PhieuDatPhongBUS pdpBUS;
        PhieuThuePhongBUS ptpBUS;

        private bool num;

        public FormMain()
        {
            InitializeComponent();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien frm = new FormNhanVien();
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MainNoEnabled();
            frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (m_username == "")
            {
                Application.Exit();
            }
            if (m_chucvu == "admin")
            {
                MainEnabled();
            }
            else if (m_chucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
            labUser.Text = "Hi! " + m_username;
            capnhatphong();
        }

        public void capnhatphong()
        {
            lsvMain.Items.Clear();

            pdpBUS = new PhieuDatPhongBUS();
            IList<PhieuDatPhongDTO> listpdp = pdpBUS.getListPhieuDatPhongAll();
            if (listpdp != null)
            {
                foreach (PhieuDatPhongDTO pdp in listpdp)
                {
                    if (pdp.Tinhtrang == "waitting")
                    {
                        ctdpBUS = new ChiTietDatPhongBUS();
                        IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(pdp.Maphieudat);
                        foreach (ChiTietDatPhongDTO ctdp in listctdp)
                        {
                            pBUS = new PhongBUS();
                            PhongDTO p = pBUS.getPhongByID(ctdp.Maphong);
                            if (p.Dadat == false && p.Danhan == false)
                            {
                                PhongDTO pDTO = new PhongDTO();
                                pDTO.Maphong = p.Maphong;
                                pDTO.Maloai = p.Maloai;
                                pDTO.Dadat = true;
                                pDTO.Danhan = false;
                                pBUS.updatePhong(pDTO);
                            }
                        }
                    }
                }
            }

            pBUS = new PhongBUS();
            IList<PhongDTO> listp = pBUS.getListPhongAll();
            foreach (PhongDTO dread in listp)
            {
                int i = lsvMain.Items.Count;
                lsvMain.Items.Add(dread.Maphong);
                string dat = "", nhan = "";
                int imgidx = 0;
                dat = dread.Dadat.ToString();
                nhan = dread.Danhan.ToString();
                if (dat == "False" && nhan == "False")
                    imgidx = 0;
                else if (dat == "True" && nhan == "False")
                    imgidx = 1;
                else if (dat == "False" && nhan == "True")
                    imgidx = 2;
                else if (dat == "True" && nhan == "True")
                    imgidx = 3;
                lsvMain.Items[i].ImageIndex = imgidx;

            }
        }


        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin = new FormLogin();
            frmLogin.frmMain = this;
            frmLogin.ShowDialog();
            if (m_chucvu == "admin")
            {
                MainEnabled();
            }
            else if (m_chucvu == "Quản lý")
            {
                MainEnQuanLy();
            }
            else
            {
                MainEnNhanVien();
            }
            labUser.Text = "Hi! " + m_username;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainNoEnabled();
            MessageBox.Show("Bạn vừa đăng xuất thành công!");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau = new FormDoiMatKhau();
            frmDoimatkhau.frmMain = this;
            frmDoimatkhau.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong = new FormPhong();
            frmPhong.frmMain = this;
            frmPhong.ShowDialog();
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVatTu frmVT = new FormVatTu();
            frmVT.frmMain = this;
            frmVT.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien = new FormNhanVien();
            frmNhanvien.frmMain = this;
            frmNhanvien.ShowDialog();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDichVu frmDichVu = new FormDichVu();
            frmDichVu.frmMain = this;
            frmDichVu.ShowDialog();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHeThong frmHeThong = new FormHeThong();
            frmHeThong.frmMain = this;
            frmHeThong.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKH = new FormKhachHang();
            frmKH.frmMain = this;
            frmKH.ShowDialog();
        }

        private void phiếuĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuDatphong frmPhieuDatPhong = new FormPhieuDatphong();
            frmPhieuDatPhong.frmMain = this;
            frmPhieuDatPhong.ShowDialog();
        }

        private void phiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhieuThuePhong frmPhieuThuePhong = new FormPhieuThuePhong();
            frmPhieuThuePhong.frmMain = this;
            frmPhieuThuePhong.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoadon = new FormHoaDon();
            frmHoadon.frmMain = this;
            frmHoadon.ShowDialog();
        }

        private void MainEnabled()
        {
            qUẢNLÝToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            kHÁCHHÀNGToolStripMenuItem.Enabled = true;
            tHUÊPHÒNGToolStripMenuItem.Enabled = true;
            bÁOCÁOToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }

        private void MainNoEnabled()
        {
            qUẢNLÝToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            kHÁCHHÀNGToolStripMenuItem.Enabled = false;
            tHUÊPHÒNGToolStripMenuItem.Enabled = false;
            bÁOCÁOToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
        }

        private void MainEnQuanLy()
        {
            qUẢNLÝToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            kHÁCHHÀNGToolStripMenuItem.Enabled = true;
            tHUÊPHÒNGToolStripMenuItem.Enabled = true;
            bÁOCÁOToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }

        private void MainEnNhanVien()
        {
            qUẢNLÝToolStripMenuItem.Enabled =false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            kHÁCHHÀNGToolStripMenuItem.Enabled = true;
            tHUÊPHÒNGToolStripMenuItem.Enabled = true;
            bÁOCÁOToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }

        private void MainNoEnQuanLy(Button bt)
        {
            bt.Enabled = false;
        }

        private void MainNoEnNhanVien()
        {
            qUẢNLÝToolStripMenuItem.Enabled = false;
            bÁOCÁOToolStripMenuItem.Enabled = false;
        }

        /*Ham kiem tra du lieu nhap vao khong duoc la so
        txt là textbox để xuất hiện thông báo lỗi, loi là sự kiện hiển thị khi có lỗi*/
        public void KTChiChu(object o, KeyEventArgs e, TextBox txt, ErrorProvider loi)
        {
            if ((e.KeyCode < Keys.A || e.KeyCode > Keys.Z) && (e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.ShiftKey) && (e.KeyCode != Keys.Space) && (e.KeyCode != Keys.Enter) && (e.KeyCode != Keys.Control))
            {
                if (e.KeyCode < Keys.A || e.KeyCode > Keys.Z)
                {
                    loi.SetError(txt, "Tên không được nhập số!");
                    num = true;
                }
                else
                {
                    loi.SetError(txt, "");
                }
            }
            else
            {
                loi.SetError(txt, "");
            }
        }

        //Ham khong cho nhap so
        public void KoNhapSo(object o, KeyPressEventArgs e)
        {
            if (num == true)
                e.Handled = true;
            num = false;
        }

        /*Hàm kiểm tra dữ liệu không phải là chữ
         txt là textbox để xuất hiện thông báo lỗi, loi là sự kiện hiển thị khi có lỗi*/
        public void KTChiSo(object o, KeyEventArgs e, TextBox txt, ErrorProvider loi)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad0) && (e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Enter) && (e.KeyCode != Keys.Control))
            {
                if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad0))
                {
                    loi.SetError(txt, "Không được nhập chữ!");
                    num = false;
                }
                else
                {
                    loi.SetError(txt, "");
                }
            }
            else
            {
                loi.SetError(txt, "");
            }
        }

        //Ham khong cho nhap chữ
        public void KoNhapChu(object o, KeyPressEventArgs e)
        {
            if (num == false)
                e.Handled = true;
            num = true;
        }

        private void tRỢGIÚPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\NewProject.chm");

            // MessageBox.Show(hp.HelpNamespace)
        }

        public string MaHoa(string inputString)
        {
            UnicodeEncoding u = new UnicodeEncoding();
            byte[] bytes = u.GetBytes(inputString); //get original string
            MD5 md = new MD5CryptoServiceProvider(); // using md5 algorithm
            byte[] result = md.ComputeHash(bytes); // encrypted input bytes into encrypted bytes
            return Convert.ToBase64String(result); //return encrypted string
        }

        private void vậtTưToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBaoCaoVatTu frmBCVT = new FormBaoCaoVatTu();
            frmBCVT.frmMain = this;
            frmBCVT.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBaoCaoNhanVien frmBCNV = new FormBaoCaoNhanVien();
            frmBCNV.frmMain = this;
            frmBCNV.ShowDialog();
        }

        private void đạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvMain.SelectedItems.Count <= 0)
            {
                MessageBox.Show("chon mot phong!!!");
                return;
            }

            FormPhieuDatphong frmPDP = new FormPhieuDatphong();
            frmPDP.frmMain = this;
            frmPDP.ShowDialog();
        }
        
        private void ặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvMain.SelectedItems.Count <= 0)
            {
                MessageBox.Show("chon mot phong!!!");
                return;
            }
            string maphieudat="";
            pBUS = new PhongBUS();
            PhongDTO pDTO = pBUS.getPhongByID(lsvMain.SelectedItems[0].Text);
            if (pDTO.Dadat == true && pDTO.Danhan==false)
            {
                ctdpBUS = new ChiTietDatPhongBUS();
                IList<ChiTietDatPhongDTO> listctdp=ctdpBUS.getListChiTietDatPhongByName(pDTO.Maphong);
                foreach(ChiTietDatPhongDTO ctdp in listctdp)
                {
                    maphieudat=ctdp.Maphieudat;
                }
                FormPhieuDatphong frmPDP = new FormPhieuDatphong();
                frmPDP.frmMain = this;
                frmPDP.maphieudatT = maphieudat;
                //MessageBox.Show(maphieudat);
                frmPDP.ShowDialog();
            }
            else if (pDTO.Dadat == true && pDTO.Danhan == true)
            {
                MessageBox.Show("Phòng có người ở!");
                return;
            }
            else
            {
                MessageBox.Show("Phòng chưa được thuê!");
                return;
            }
        }

        private void dịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lsvMain.SelectedItems.Count <= 0)
            {
                MessageBox.Show("chon mot phong!!!");
                return;
            }
            pBUS = new PhongBUS();
            PhongDTO pDTO = pBUS.getPhongByID(lsvMain.SelectedItems[0].Text);
            if (pDTO.Danhan == true)
            {
                string mpt="";
                ctdpBUS = new ChiTietDatPhongBUS();
                IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getListChiTietDatPhongByName(pDTO.Maphong);
                foreach (ChiTietDatPhongDTO ctdp in listctdp)
                {
                    pdpBUS = new PhieuDatPhongBUS();
                    ptpBUS = new PhieuThuePhongBUS();
                    PhieuDatPhongDTO pdp = pdpBUS.getPhieuDatPhongByID(ctdp.Maphieudat);
                    IList<PhieuThuePhongDTO> ptp = ptpBUS.getListPhieuThuePhongByMaPhieuDat(pdp.Maphieudat);
                    if (ptp != null)
                    {
                        foreach (PhieuThuePhongDTO pt in ptp)
                        {
                            mpt = pt.Maphieuthue;
                        }
                    }
                }
                FormPhieuThuePhong frmPTP = new FormPhieuThuePhong();
                frmPTP.frmMain = this;
                frmPTP.maphong = pDTO.Maphong;
                frmPTP.maphieuthue = mpt;
                frmPTP.ShowDialog();

            }
            else
            {
                MessageBox.Show("Phòng chưa có người!");
                return;
            }
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvMain.SelectedItems.Count <= 0)
            {
                MessageBox.Show("chon mot phong!!!");
                return;
            }
            pBUS = new PhongBUS();
            PhongDTO pDTO = pBUS.getPhongByID(lsvMain.SelectedItems[0].Text);
            if (pDTO.Danhan == true)
            {
                string mpt = "";
                ctdpBUS = new ChiTietDatPhongBUS();
                IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getListChiTietDatPhongByName(pDTO.Maphong);
                foreach (ChiTietDatPhongDTO ctdp in listctdp)
                {
                    pdpBUS = new PhieuDatPhongBUS();
                    ptpBUS = new PhieuThuePhongBUS();
                    PhieuDatPhongDTO pdp = pdpBUS.getPhieuDatPhongByID(ctdp.Maphieudat);
                    IList<PhieuThuePhongDTO> ptp = ptpBUS.getListPhieuThuePhongByMaPhieuDat(pdp.Maphieudat);
                    if (ptp != null)
                    {
                        foreach (PhieuThuePhongDTO pt in ptp)
                        {
                            mpt = pt.Maphieuthue;
                        }
                    }
                }
                FormHoaDon frmHD = new FormHoaDon();
                frmHD.frmMain = this;
                frmHD.maphieuthue = mpt;
                frmHD.ShowDialog();

            }
            else
            {
                MessageBox.Show("Phòng chưa có người!");
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout frmAb = new FormAbout();
            frmAb.frmMain = this;
            frmAb.ShowDialog();
        }

        private void thongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeDatPhong frm = new FormThongKeDatPhong();
            frm.frmMain = this;
            frm.ShowDialog();
        }
    }
}
