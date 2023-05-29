using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using DTO;
using BUS;
using System.Collections;

namespace Quanlykhachsan3lop
{
    public partial class FormPhieuDatphong : Form
    {
        //HotelDataContext hotel = new HotelDataContext();

        public double tongtien;
        public FormPhieuThuePhong frmPThuePhong;
        public FormKhachHang frmKH;
        public FormMain frmMain;
        public SqlCommand com;
        public FormLogin frmLogin;
        public string maphieudat;
        public string khachhang="";

        public string maphieudatT="";

        PhieuDatPhongBUS pdpBUS;
        PhieuDatPhongDTO pdpDTO;
        KhachHangBUS khBUS;
        KiemTraPhongBUS ktpBUS;
        PhongBUS pBUS;
        PhongDTO pDTO;
        LoaiPhongBUS lpBUS;
        ChiTietDatPhongBUS ctdpBUS;
        ChiTietDatPhongDTO ctdpDTO;

        public FormPhieuDatphong()
        {
            InitializeComponent();
        }
        public void FormPhieuDatPhong_Load(object sender, EventArgs e)
        {
            if (frmMain.m_chucvu == "Quản lý")
            {
                button1_datphong.Enabled = false;
                btnSua.Enabled = false;
                button1_NhanPhong.Enabled = false;
                dtpNgayden.Enabled = false;
                dtpNgaydi.Enabled = false;
                btnHuy.Enabled = false;
            }
           
            emtyLsvChiTiet();
            showCmbKH();
            show_lsvPDP();
            chkwait.Checked = true;
            labMaPD.Text = "PDP00" + newid();
            if (khachhang != "")
            {
                cmbKhachHang.Text = khachhang;
            }
            if (maphieudatT != "")
            {
               
                tabControl1.SelectedTab = tabPage2;
                
                for (int i = 0; i < lsvDSPhieuDatPhong.Items.Count; i++)
                {
                    //MessageBox.Show(lsvDSPhieuDatPhong.Items[i].SubItems[0].Text);
                    if (lsvDSPhieuDatPhong.Items[i].SubItems[0].Text == maphieudatT)
                    {
                        lsvDSPhieuDatPhong.Items[i].Selected = true;
                    }
                }
            }
            
        }
        private int newid()
        {
            pdpBUS = new PhieuDatPhongBUS();

            return pdpBUS.Count() + 1;

        }
        private void Enablequanly()
        {


        }
        private void showCmbKH()
        {

            khBUS = new KhachHangBUS();
            cmbKhachHang.DataSource = khBUS.getListKhachHangAll();
            cmbKhachHang.DisplayMember = "Tenkhachhang";
            cmbKhachHang.ValueMember = "Makhachhang";
            //
            /*
            DataTableReader read = frmMain.dtKhachhang.CreateDataReader();
            cmbKhachHang.Items.Clear();
            while (read.Read())
            {
                cmbKhachHang.Items.Add(read["tenkhachhang"].ToString());
            }*/
        }
        private void show_lsvPDP()
        {
            lsvDSPhieuDatPhong.Items.Clear();
            //Show tinh trang phong
            pdpBUS = new PhieuDatPhongBUS();
            IList<PhieuDatPhongDTO> list = pdpBUS.getListPhieuDatPhongAll();
            if (list != null)
            {

                if (chkwait.Checked == true && chksub.Checked == false && chkcan.Checked == false && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if (readpdp.Tinhtrang == "waitting")
                        {

                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == false && chksub.Checked == false && chkcan.Checked == true && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if (readpdp.Tinhtrang == "cancel")
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == false && chksub.Checked == true && chkcan.Checked == false && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if (readpdp.Tinhtrang == "busy")
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == false && chksub.Checked == false && chkcan.Checked == false && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if (readpdp.Tinhtrang == "finish")
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == true && chksub.Checked == false && chkcan.Checked == true && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "cancel"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == true && chksub.Checked == true && chkcan.Checked == false && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "busy"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == false && chksub.Checked == true && chkcan.Checked == true && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "busy") || (readpdp.Tinhtrang == "cancel"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == false && chksub.Checked == false && chkcan.Checked == true && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "finish") || (readpdp.Tinhtrang == "cancel"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == false && chksub.Checked == true && chkcan.Checked == false && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "finish") || (readpdp.Tinhtrang == "busy"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == true && chksub.Checked == false && chkcan.Checked == false && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "finish") || (readpdp.Tinhtrang == "waitting"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }

                if (chkwait.Checked == true && chksub.Checked == false && chkcan.Checked == true && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "cancel") || (readpdp.Tinhtrang == "finish"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == true && chksub.Checked == true && chkcan.Checked == true && chkfin.Checked == false)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "busy") || (readpdp.Tinhtrang == "cancel"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == true && chksub.Checked == true && chkcan.Checked == false && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "busy") || (readpdp.Tinhtrang == "finish"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == false && chksub.Checked == true && chkcan.Checked == true && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "busy") || (readpdp.Tinhtrang == "cancel") || (readpdp.Tinhtrang == "finish"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
                if (chkwait.Checked == true && chksub.Checked == true && chkcan.Checked == true && chkfin.Checked == true)
                {
                    foreach (PhieuDatPhongDTO readpdp in list)
                    {
                        if ((readpdp.Tinhtrang == "waitting") || (readpdp.Tinhtrang == "busy") || (readpdp.Tinhtrang == "cancel") || (readpdp.Tinhtrang == "finish"))
                        {
                            int i = lsvDSPhieuDatPhong.Items.Count;
                            lsvDSPhieuDatPhong.Items.Add(readpdp.Maphieudat);
                            string fe = readpdp.Makhachhang;
                            khBUS = new KhachHangBUS();
                            KhachHangDTO listKH = khBUS.getKhachHangByID(fe);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(listKH.Tenkhachhang);

                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Songuoi.ToString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngayden.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Ngaydi.ToShortDateString());
                            lsvDSPhieuDatPhong.Items[i].SubItems.Add(readpdp.Tinhtrang);
                        }
                    }
                }
            }
        }
        private void button1_datphong_Click(object sender, EventArgs e)
        {
            if (kiemtradl() == false)
            {
                MessageBox.Show("Chưa nhập đủ thông tin, Kiểm tra lại!!!");
                return;
            }
            if (ktsonguoi() == false)
            {
                MessageBox.Show("Quá số người quy định cho phòng!!!.Kiểm tra lại.");
                return;
            }
            pdpBUS = new PhieuDatPhongBUS();
            pdpDTO = new PhieuDatPhongDTO();
            pdpDTO.Maphieudat = labMaPD.Text;
            maphieudat = pdpDTO.Maphieudat;
            pdpDTO.Makhachhang = cmbKhachHang.SelectedValue.ToString();
            pdpDTO.Username = frmMain.m_username;
            pdpDTO.Ngayden = dtpNgayden.Value;
            pdpDTO.Ngaydi = dtpNgaydi.Value;
            pdpDTO.Sotiendatcoc = decimal.Parse(txtTiencoc.Text);
            pdpDTO.Tinhtrang = "waitting";
            pdpDTO.Songuoi = int.Parse(txtSonguoi.Text);
            if (pdpBUS.insertPhieuDatPhong(pdpDTO) == 1)
            {

                for (int i = 0; i < lsvViewPhong.Items.Count; i++)
                {
                    //MessageBox.Show(i.ToString());
                    ctdpBUS = new ChiTietDatPhongBUS();
                    ctdpDTO = new ChiTietDatPhongDTO();
                    ctdpDTO.Maphieudat = pdpDTO.Maphieudat;
                    ctdpDTO.Maphong = lsvViewPhong.Items[i].SubItems[0].Text;
                    ctdpBUS.insertChiTietDatPhong(ctdpDTO);

                    pBUS = new PhongBUS();
                    pDTO = new PhongDTO();
                    pDTO.Maphong = ctdpDTO.Maphong;
                    PhongDTO ptemp = pBUS.getPhongByID(ctdpDTO.Maphong);
                    pDTO.Maloai = lsvViewPhong.Items[i].SubItems[1].Text;
                    pDTO.Dadat = true;
                    pDTO.Danhan = ptemp.Danhan;
                    pBUS.updatePhong(pDTO);
                }
                MessageBox.Show("Đã tạo phiếu đặt phòng!");
            }
            else
            {
                MessageBox.Show("Không tạo được!");
                labMaPD.Text = "PDP00" + newid();
            }
            ///MessageBox.Show("OK");

            //show_lsvPDP();
            //showCmbKH();
            lsvTimPhong.Items.Clear();
            lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
            txtSonguoi.Clear();
            txtTiencoc.Clear();
            lsvViewPhong.Items.Clear();
            frmMain.capnhatphong();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            /*frmKH = new FormKhachHang();
            frmKH.frmPDP = this;
            frmKH.frmMain = frmMain;
            frmKH.flag = true;
            frmKH.ShowDialog();*/
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (chang == true||Nochangdi==true||Nochangden==true)
            {
                if (kiemtradl() == false)
                {
                    MessageBox.Show("Chưa nhập đủ thông tin, Kiểm tra lại!!!");
                    return;
                }
                if (ktsonguoi() == false)
                {
                    MessageBox.Show("Quá số người quy định cho phòng!!!.Kiểm tra lại.");
                    return;
                }
                sua();

                pdpBUS = new PhieuDatPhongBUS();
                PhieuDatPhongDTO listpdp = pdpBUS.getPhieuDatPhongByID(labMaPD.Text);
                pdpDTO = new PhieuDatPhongDTO();
                pdpDTO.Maphieudat = listpdp.Maphieudat;
                pdpDTO.Makhachhang = listpdp.Makhachhang;
                pdpDTO.Ngayden = DateTime.Parse(lsvChiTiet.Groups[1].Items[0].SubItems[1].Text);
                pdpDTO.Ngaydi = DateTime.Parse(lsvChiTiet.Groups[1].Items[1].SubItems[1].Text);
                pdpDTO.Songuoi = int.Parse(lsvChiTiet.Groups[1].Items[2].SubItems[1].Text);
                pdpDTO.Sotiendatcoc = decimal.Parse(lsvChiTiet.Groups[1].Items[3].SubItems[1].Text);
                pdpDTO.Username = frmMain.m_username;
                pdpDTO.Tinhtrang = "waitting";

                if (pdpBUS.updatePhieuDatPhong(pdpDTO) == 1)
                {

                    for (int i = 0; i < lsvViewPhong.Items.Count; i++)
                    {
                        //MessageBox.Show(i.ToString());
                        ctdpBUS = new ChiTietDatPhongBUS();
                        ctdpDTO = new ChiTietDatPhongDTO();
                        ctdpDTO.Maphieudat = pdpDTO.Maphieudat;
                        ctdpDTO.Maphong = lsvViewPhong.Items[i].SubItems[0].Text;
                        ctdpBUS.insertChiTietDatPhong(ctdpDTO);

                        pBUS = new PhongBUS();
                        pDTO = new PhongDTO();
                        pDTO.Maphong = ctdpDTO.Maphong;
                        pDTO.Maloai = lsvViewPhong.Items[i].SubItems[1].Text;
                        pDTO.Danhan = false;
                        pDTO.Dadat = true;
                        pBUS.updatePhong(pDTO);
                    }
                    lsvViewPhong.Items.Clear();
                    ctdpBUS = new ChiTietDatPhongBUS();
                    IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(labMaPD.Text);
                    foreach (ChiTietDatPhongDTO ctdp in listctdp)
                    {
                        int i = lsvViewPhong.Items.Count;
                        lsvViewPhong.Items.Add(ctdp.Maphong);
                        pBUS = new PhongBUS();
                        IList<PhongDTO> listp = pBUS.getLikePhongByID(ctdp.Maphong);
                        foreach (PhongDTO p in listp)
                        {
                            lpBUS = new LoaiPhongBUS();
                            LoaiPhongDTO listlp = lpBUS.getLoaiPhongByID(p.Maloai);
                            lsvViewPhong.Items[i].SubItems.Add(listlp.Maloai);
                            lsvViewPhong.Items[i].SubItems.Add(listlp.Songuoi.ToString());
                            lsvViewPhong.Items[i].SubItems.Add(listlp.Gia.ToString("0,0"));
                        }
                    }
                    show_lsvPDP();
                    lsvTimPhong.Items.Clear();
                    frmMain.capnhatphong();
                    MessageBox.Show("Đã sửa thành công!");
                    chang = false;
                    Nochangden = false;
                    Nochangdi = false;
                    lsvTimPhong.Items.Clear();
                    
                    lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                    txtSonguoi.Clear();
                    txtTiencoc.Clear();
                    lsvViewPhong.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Error!");
                    return;
                }
            }
            else
            {
                lsvViewPhong.Items.Clear();
                lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                labMaPD.Text = "HD00" + newid();
                MessageBox.Show("Chưa tạo phiếu đặt phòng!");
            }
        }

        private void button1_NhanPhong_Click(object sender, EventArgs e)
        {
            if (lsvDSPhieuDatPhong.SelectedItems.Count <= 0)
                 MessageBox.Show("Chọn một phiếu đặt phòng!!!");
            else
                if (DateTime.Parse(lsvDSPhieuDatPhong.SelectedItems[0].SubItems[3].Text) == DateTime.Now.Date)
                {
                    if (lsvDSPhieuDatPhong.SelectedItems[0].SubItems[5].Text == "waitting")
                    {
                        string maphieudat = lsvDSPhieuDatPhong.SelectedItems[0].SubItems[0].Text;
                        pdpBUS = new PhieuDatPhongBUS();
                        PhieuDatPhongDTO listpdp = pdpBUS.getPhieuDatPhongByID(maphieudat);
                        pdpDTO = new PhieuDatPhongDTO();
                        pdpDTO.Maphieudat = listpdp.Maphieudat;
                        pdpDTO.Makhachhang = listpdp.Makhachhang;
                        pdpDTO.Ngayden = listpdp.Ngayden;
                        pdpDTO.Ngaydi = listpdp.Ngaydi;
                        pdpDTO.Songuoi = listpdp.Songuoi;
                        pdpDTO.Sotiendatcoc = listpdp.Sotiendatcoc;
                        pdpDTO.Tinhtrang = "busy";
                        pdpBUS.updatePhieuDatPhong(pdpDTO);
                        ctdpBUS = new ChiTietDatPhongBUS();
                        IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(maphieudat);
                        foreach (ChiTietDatPhongDTO ctpd in listctdp)
                        {
                            pBUS = new PhongBUS();
                            PhongDTO listp = pBUS.getPhongByID(ctpd.Maphong);
                            pDTO = new PhongDTO();
                            pDTO.Maphong = listp.Maphong;
                            pDTO.Maloai = listp.Maloai;
                            pDTO.Dadat = false;
                            pDTO.Danhan = true;
                            pBUS.updatePhong(pDTO);
                        }

                        show_lsvPDP();

                        frmPThuePhong = new FormPhieuThuePhong();
                        frmPThuePhong.frmPDatPhong = this;
                        frmPThuePhong.frmMain = frmMain;
                        //MessageBox.Show(maloai);
                        frmPThuePhong.maphieudat = maphieudat;
                        frmPThuePhong.ShowDialog();
                        chang = false;
                        Nochangden = false;
                        Nochangdi = false;
                        labMaPD.Text = "PDP00" + newid();
                        lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                        txtSonguoi.Clear();
                        txtTiencoc.Clear();
                        lsvViewPhong.Items.Clear();
                        frmMain.capnhatphong();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Chỉ có thể Nhận các Phiếu WAITTING!!!");
                        labMaPD.Text = "PDP00" + newid();
                        chang = false;
                        Nochangden = false;
                        Nochangdi = false;
                        labMaPD.Text = "PDP00" + newid();
                        lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                        txtSonguoi.Clear();
                        txtTiencoc.Clear();
                        lsvViewPhong.Items.Clear();
                        return;
                    }
                }
                else
                {
                    chang = false;
                    Nochangden = false;
                    Nochangdi = false;
                    labMaPD.Text = "PDP00" + newid();
                    lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                    txtSonguoi.Clear();
                    txtTiencoc.Clear();
                    lsvViewPhong.Items.Clear();
                    labMaPD.Text = "PDP00" + newid();
                    MessageBox.Show("Chưa đến thời gian nhận phòng!");
                    return;
                }
        }
        //-------------------------------------------------------------------------------
        //-----------------------------------Chi tiết--------------------------------------
        private void cmbKhachHang_SelectedValueChanged(object sender, EventArgs e)
        {
            //lsvDSPhieuDatPhong.SelectedItems.Clear();
            chang = false;
            txtSonguoi.Clear();
            txtTiencoc.Clear();
            lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
            lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
            lsvTimPhong.Items.Clear();
            lsvViewPhong.Items.Clear();

            labMaPD.Text = "PDP00" + newid();
            khBUS = new KhachHangBUS();
            KhachHangDTO drKH = khBUS.getKhachHangByID(cmbKhachHang.SelectedValue.ToString());
            if (drKH != null)
            {
                lsvChiTiet.Items[0].SubItems[1].Text = drKH.Makhachhang;
                lsvChiTiet.Items[1].SubItems[1].Text = drKH.Tenkhachhang;
                if (drKH.Gioitinh.ToString() == "True")
                {
                    lsvChiTiet.Items[2].SubItems[1].Text = "Nam";
                }
                else
                {
                    lsvChiTiet.Items[2].SubItems[1].Text = "Nữ";
                }
                lsvChiTiet.Items[3].SubItems[1].Text = drKH.CMND_PASSPORT;
                lsvChiTiet.Items[4].SubItems[1].Text = drKH.Diachi;
                lsvChiTiet.Items[5].SubItems[1].Text = drKH.Coquan;
                lsvChiTiet.Items[6].SubItems[1].Text = drKH.Sodienthoai;
                lsvChiTiet.Items[7].SubItems[1].Text = drKH.Email;
            }
           
        }

        private void emtyLsvChiTiet()
        {
            for (int i = 0; i < lsvChiTiet.Items.Count; i++)
            {
                lsvChiTiet.Items[i].SubItems.Add("");
            }

        }
        bool Nochangden = false;
        bool Nochangdi = false;
        private void dtpNgayden_ValueChanged(object sender, EventArgs e)
        {
            if (lsvChiTiet.Groups[1].Items[0].SubItems[1].Text != "")
            //if (((chang == true && Nochangden == true) || Nochangdi == false) && tabControl1.SelectedTab == tabPage1)
            if ((chang == true && dtpNgayden.Value != DateTime.Parse(lsvChiTiet.Groups[1].Items[0].SubItems[1].Text) && tabControl1.SelectedTab == tabPage1 && lsvViewPhong.Items.Count > 0) || (Nochangden == true && dtpNgayden.Value != DateTime.Parse(lsvChiTiet.Groups[1].Items[0].SubItems[1].Text) && tabControl1.SelectedTab == tabPage1 && lsvViewPhong.Items.Count > 0))
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc sửa phòng này!", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sua();
                    Nochangden = false;
                    lsvViewPhong.Items.Clear();
                }
                else
                {
                    Nochangden = true;
                    chang = false;
                    dtpNgayden.Value = DateTime.Parse(lsvChiTiet.Groups[1].Items[0].SubItems[1].Text);
                    //lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = dtpNgayden.Value.ToShortDateString();
                    return;
                }
            }

            if (dtpNgaydi.Value < dtpNgayden.Value)
            {
                //MessageBox.Show("Ngày đến không được lớn hơn ngày đi!");
                //lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                //lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                dtpNgaydi.Value = dtpNgayden.Value;
               // return;
            }
            //dtpNgaydi.Value = dtpNgayden.Value;
            lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = (dtpNgayden.Value.ToShortDateString());
            lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = (dtpNgaydi.Value.ToShortDateString());
            lsvTimPhong.Items.Clear();
            //lsvViewPhong.Items.Clear();
        }

        private void dtpNgaydi_ValueChanged(object sender, EventArgs e)
        {
            if(lsvChiTiet.Groups[1].Items[1].SubItems[1].Text!="")
                if ((chang == true && dtpNgaydi.Value != DateTime.Parse(lsvChiTiet.Groups[1].Items[1].SubItems[1].Text) && tabControl1.SelectedTab == tabPage1 && lsvViewPhong.Items.Count > 0) || (Nochangdi == true && dtpNgaydi.Value != DateTime.Parse(lsvChiTiet.Groups[1].Items[1].SubItems[1].Text) && tabControl1.SelectedTab == tabPage1 && lsvViewPhong.Items.Count > 0))
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc sửa phòng này!", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sua();
                    Nochangdi = false;
                    lsvViewPhong.Items.Clear();
                }
                else
                {
                    Nochangdi = true;
                    chang = false;
                    dtpNgaydi.Value = DateTime.Parse(lsvChiTiet.Groups[1].Items[1].SubItems[1].Text);
                    //dtpNgaydi.Value = ngaydi;
                    //lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = dtpNgaydi.Value.ToShortDateString();
                    return;
                }
            }

            if (dtpNgayden.Value.Date > dtpNgaydi.Value.Date)
            {
                MessageBox.Show("Ngày đi không được nhỏ hơn ngày đến!");
                lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                dtpNgaydi.Value = dtpNgayden.Value;
                return;
            }
            lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = (dtpNgayden.Value.ToShortDateString());
            lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = (dtpNgaydi.Value.ToShortDateString());
            lsvTimPhong.Items.Clear();
            //lsvViewPhong.Items.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //string fe;
            lsvTimPhong.Items.Clear();
            lsvViewPhong.Items.Clear();
            if (lsvChiTiet.Groups[1].Items[0].SubItems[1].Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày!");
                return;
            }
            string ngayden = dtpNgayden.Value.Year.ToString() + "-" + dtpNgayden.Value.Month.ToString() + "-" + dtpNgayden.Value.Day.ToString() + " 00:00:00";
            string ngaydi = dtpNgaydi.Value.Year.ToString() + "-" + dtpNgaydi.Value.Month.ToString() + "-" + dtpNgaydi.Value.Day.ToString() + " 23:59:59";

            pBUS = new PhongBUS();
            IList<PhongDTO> listphong = pBUS.getListPhongAll();
            foreach (PhongDTO p in listphong)
            {
                //MessageBox.Show(p.Maphong);
                if (kiemtraphong(p.Maphong, ngayden, ngaydi))
                {
                    int i = lsvTimPhong.Items.Count;
                    lsvTimPhong.Items.Add(p.Maphong);
                    lsvTimPhong.Items[i].SubItems.Add(p.Maloai);
                    lpBUS = new LoaiPhongBUS();

                    LoaiPhongDTO lp = lpBUS.getLoaiPhongByID(p.Maloai);

                    lsvTimPhong.Items[i].SubItems.Add(lp.Songuoi.ToString());
                    lsvTimPhong.Items[i].SubItems.Add(lp.Gia.ToString("0,0"));
                }
            }
        }
        private void sua()
        {
            ctdpBUS = new ChiTietDatPhongBUS();
            ctdpBUS.deleteChiTietDatPhong(labMaPD.Text);        
            int i = lsvViewPhong.Items.Count;
            for (int j = 0; j < i; j++)
            {
                string maphong = lsvViewPhong.Items[j].SubItems[0].Text;
                pBUS = new PhongBUS();
                PhongDTO p = pBUS.getPhongByID(maphong);
                //MessageBox.Show(maphong);
                pDTO = new PhongDTO();
                pDTO.Maphong = p.Maphong;
                pDTO.Maloai = p.Maloai;
                pDTO.Dadat = false;
                pDTO.Danhan = false;
                pBUS.updatePhong(pDTO);
            }
            pdpBUS = new PhieuDatPhongBUS();
            PhieuDatPhongDTO listpdp = pdpBUS.getPhieuDatPhongByID(labMaPD.Text);
            pdpDTO = new PhieuDatPhongDTO();
            pdpDTO.Maphieudat = listpdp.Maphieudat;
            pdpDTO.Makhachhang = listpdp.Makhachhang;
            pdpDTO.Ngayden = listpdp.Ngayden;
            pdpDTO.Ngaydi = listpdp.Ngaydi;
            pdpDTO.Sotiendatcoc = listpdp.Sotiendatcoc;
            pdpDTO.Username = listpdp.Username;
            pdpDTO.Tinhtrang = "cancel";
            pdpDTO.Songuoi = listpdp.Songuoi;
            pdpBUS.updatePhieuDatPhong(pdpDTO);
            frmMain.capnhatphong();
            
        }
        private bool kiemtraphong(string maphong, string ngayden, string ngaydi)
        {
            ktpBUS = new KiemTraPhongBUS();
            ArrayList list = ktpBUS.KiemTraPhong(DateTime.Parse(ngayden), DateTime.Parse(ngaydi));
            foreach (KiemTraPhongDTO ktp in list)
            {
                if (ktp.Maphong == maphong)
                {
                    return false;
                }
            }
            return true;
        }

        private void txtSonguoi_KeyDown(object sender, KeyEventArgs e)
        {
            frmMain.KTChiSo(sender, e, txtSonguoi, loi);
        }

        private void txtSonguoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmMain.KoNhapChu(sender, e);
        }

        private void txtTiencoc_KeyDown(object sender, KeyEventArgs e)
        {
            frmMain.KTChiSo(sender, e, txtTiencoc, loi);
        }

        private void txtTiencoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmMain.KoNhapChu(sender, e);
        }


        private bool kiemtradl()
        {
            if (lsvChiTiet.Groups[0].Items[0].SubItems[1].Text == "")
                return false;
            if (cmbKhachHang.SelectedValue.ToString() == "")
                return false;
            for (int i = 0; i <= 3; i++)
            {
                if (lsvChiTiet.Groups[1].Items[i].SubItems[1].Text == "")
                    return false;
            }
            if (lsvViewPhong.Items.Count <= 0)
                return false;
            else if (lsvViewPhong.Items[0].SubItems[0].Text == "")
                return false;
            return true;
        }
        private bool ktsonguoi()
        {
            int songuoi = 0;
            for (int i = 0; i < lsvViewPhong.Items.Count; i++)
            {
                songuoi += int.Parse(lsvViewPhong.Items[i].SubItems[2].Text);
            }
            //MessageBox.Show("songuoi" + songuoi.ToString() + "            " + txtSonguoi.Text);
            if (songuoi < int.Parse(txtSonguoi.Text))
            {
                return false;
            }

            return true;
        }

        private void txtTiencoc_TextChanged(object sender, EventArgs e)
        {
            lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = txtTiencoc.Text;
        }

        private void txtSonguoi_TextChanged(object sender, EventArgs e)
        {
            lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = txtSonguoi.Text;
        }


        private void chkwait_CheckedChanged(object sender, EventArgs e)
        {
            show_lsvPDP();

        }

        private void chkcan_CheckedChanged(object sender, EventArgs e)
        {
            show_lsvPDP();
        }

        private void chksub_CheckedChanged(object sender, EventArgs e)
        {
            show_lsvPDP();
        }

        private void chkfin_CheckedChanged(object sender, EventArgs e)
        {
            show_lsvPDP();
        }

        private void lsvTimPhong_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            lsvViewPhong.Items.Clear();
            //Cập nhật lại cũ
            ctdpBUS = new ChiTietDatPhongBUS();
            IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(labMaPD.Text);
            if (listctdp != null)
                foreach (ChiTietDatPhongDTO ctdp in listctdp)
                {
                    int i = lsvViewPhong.Items.Count;
                    lsvViewPhong.Items.Add(ctdp.Maphong);
                    pBUS = new PhongBUS();
                    IList<PhongDTO> listp = pBUS.getLikePhongByID(ctdp.Maphong);
                    foreach (PhongDTO p in listp)
                    {
                        lpBUS = new LoaiPhongBUS();
                        LoaiPhongDTO listlp = lpBUS.getLoaiPhongByID(p.Maloai);
                        lsvViewPhong.Items[i].SubItems.Add(listlp.Maloai);
                        lsvViewPhong.Items[i].SubItems.Add(listlp.Songuoi.ToString());
                        lsvViewPhong.Items[i].SubItems.Add(listlp.Gia.ToString("0,0"));
                    }
                }
            //
            ListView.CheckedListViewItemCollection checkedItems = lsvTimPhong.CheckedItems;
            foreach (ListViewItem item in checkedItems)
            {
                int i = lsvViewPhong.Items.Count;
                lsvViewPhong.Items.Add(item.SubItems[0].Text);
                lsvViewPhong.Items[i].SubItems.Add(item.SubItems[1].Text);
                lsvViewPhong.Items[i].SubItems.Add(item.SubItems[2].Text);
                lsvViewPhong.Items[i].SubItems.Add(item.SubItems[3].Text);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            show_lsvPDP();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (lsvDSPhieuDatPhong.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Chọn một phiếu đặt phòng!!!");
                return;
            }
            else
                if (DateTime.Parse(lsvDSPhieuDatPhong.SelectedItems[0].SubItems[3].Text)<DateTime.Now.Date.AddDays(-3))
                {
                    if (lsvDSPhieuDatPhong.SelectedItems[0].SubItems[5].Text == "waitting")
                    {
                        if (MessageBox.Show("Bạn có chắc hủy phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string maphieudat = lsvDSPhieuDatPhong.SelectedItems[0].SubItems[0].Text;
                            pdpBUS = new PhieuDatPhongBUS();
                            PhieuDatPhongDTO listpdp = pdpBUS.getPhieuDatPhongByID(maphieudat);
                            pdpDTO = new PhieuDatPhongDTO();
                            pdpDTO.Maphieudat = listpdp.Maphieudat;
                            pdpDTO.Makhachhang = listpdp.Makhachhang;
                            pdpDTO.Ngayden = listpdp.Ngayden;
                            pdpDTO.Ngaydi = listpdp.Ngaydi;
                            pdpDTO.Sotiendatcoc = listpdp.Sotiendatcoc;
                            pdpDTO.Username = listpdp.Username;
                            pdpDTO.Tinhtrang = "cancel";
                            pdpDTO.Songuoi = listpdp.Songuoi;
                            if (pdpBUS.updatePhieuDatPhong(pdpDTO) == 1)
                            {
                                IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(listpdp.Maphieudat);
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
                                show_lsvPDP();
                                lsvViewPhong.Items.Clear();
                                labMaPD.Text = "PDP00" + newid();
                                MessageBox.Show("Đã hủy đặt phòng!");
                                frmMain.capnhatphong();
                                labMaPD.Text = "PDP00" + newid();
                                chang = false;
                                Nochangden = false;
                                Nochangdi = false;
                                lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                                lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                                lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                                lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                                txtSonguoi.Clear();
                                txtTiencoc.Clear();
                                lsvViewPhong.Items.Clear();
                            }
                        }
                        else
                        {
                            lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                            lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                            lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                            lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                            txtSonguoi.Clear();
                            txtTiencoc.Clear();
                            lsvViewPhong.Items.Clear();
                            chang = false;
                            Nochangden = false;
                            Nochangdi = false;
                        }
                    }
                    else
                    {
                        lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                        lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                        txtSonguoi.Clear();
                        txtTiencoc.Clear();
                        lsvViewPhong.Items.Clear();
                        chang = false;
                        Nochangden = false;
                        Nochangdi = false;
                        MessageBox.Show("Lỗi! Chỉ có thể Hủy các Phiếu WAITTING!!!");
                    }
                }
                else
                {
                    labMaPD.Text = "PDP00" + newid();
                    lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[2].SubItems[1].Text = "";
                    lsvChiTiet.Groups[1].Items[3].SubItems[1].Text = "";
                    txtSonguoi.Clear();
                    txtTiencoc.Clear();
                    lsvViewPhong.Items.Clear();
                    chang = false;
                    Nochangden = false;
                    Nochangdi = false;
                    MessageBox.Show("Đã quá thời hạn cho phép hủy phòng!");
                    return;
                }
        }
        bool chang = false;
        DateTime ngayden;
        DateTime ngaydi;
        private void lsvDSPhieuDatPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayden_MouseDown(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("a");
        }

        private void lsvDSPhieuDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSPhieuDatPhong.SelectedItems.Count <= 0)
            {
                return;
            }

            pdpBUS = new PhieuDatPhongBUS();
            //dtpNgayden.Value = DateTime.Now;
            //dtpNgaydi.Value = DateTime.Now;
            IList<PhieuDatPhongDTO> listpdp = pdpBUS.getLikePhieuDatPhongByID(lsvDSPhieuDatPhong.SelectedItems[0].SubItems[0].Text);
            foreach (PhieuDatPhongDTO pdp in listpdp)
            {
                cmbKhachHang.SelectedValue = pdp.Makhachhang;
                //MessageBox.Show(r["makhachhang"].ToString());
                labMaPD.Text = pdp.Maphieudat;
                lsvChiTiet.Groups[1].Items[0].SubItems[1].Text = pdp.Ngayden.ToShortDateString();
                lsvChiTiet.Groups[1].Items[1].SubItems[1].Text = pdp.Ngaydi.ToShortDateString();
                //MessageBox.Show(pdp.Ngayden.ToShortDateString());
                dtpNgayden.Value = pdp.Ngayden;
                dtpNgaydi.Value = pdp.Ngaydi;
                //MessageBox.Show(pdp.Ngayden.ToShortDateString());
                txtTiencoc.Text = pdp.Sotiendatcoc.ToString("0,0");
                txtSonguoi.Text = pdp.Songuoi.ToString();
                ngayden = pdp.Ngayden;
                ngaydi = pdp.Ngaydi;
            }

            lsvViewPhong.Items.Clear();
            ctdpBUS = new ChiTietDatPhongBUS();
            IList<ChiTietDatPhongDTO> listctdp = ctdpBUS.getChiTietDatPhongByID(lsvDSPhieuDatPhong.SelectedItems[0].SubItems[0].Text);
            foreach (ChiTietDatPhongDTO ctdp in listctdp)
            {
                int i = lsvViewPhong.Items.Count;
                lsvViewPhong.Items.Add(ctdp.Maphong);
                pBUS = new PhongBUS();
                IList<PhongDTO> listp = pBUS.getLikePhongByID(ctdp.Maphong);
                foreach (PhongDTO p in listp)
                {
                    lpBUS = new LoaiPhongBUS();
                    LoaiPhongDTO listlp = lpBUS.getLoaiPhongByID(p.Maloai);
                    lsvViewPhong.Items[i].SubItems.Add(listlp.Maloai);
                    lsvViewPhong.Items[i].SubItems.Add(listlp.Songuoi.ToString());
                    lsvViewPhong.Items[i].SubItems.Add(listlp.Gia.ToString("0,0"));
                }
            }
            if (lsvDSPhieuDatPhong.SelectedItems[0].SubItems[5].Text == "waitting")
            {
                chang = true;
                Nochangden = true;
                Nochangdi = true;
            }
        }
    }
    
}
