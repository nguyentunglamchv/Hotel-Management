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

namespace Quanlykhachsan3lop
{
    public partial class FormBaoCaoNhanVien : Form
    {

        NhanVienBUS nvBUS;
        public FormMain frmMain;
        DataTable dtNV;

        public FormBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void rdTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTatCa.Checked)
            {
                //MessageBox.Show("a");
                crpNhanVien rp = new crpNhanVien();
                nvBUS = new NhanVienBUS();
                IList<NhanVienDTO> listNV = nvBUS.getListNhanvienAll();
                qlks3lopDataSet.nhanvienDataTable dtNVS = new qlks3lopDataSet.nhanvienDataTable();
                foreach (NhanVienDTO nv in listNV)
                {
                    dtNVS.Rows.Add(nv.Manhanvien, nv.Tennhanvien, nv.Ngaysinh, nv.Phai, nv.Diachi, nv.Phone, nv.Chucvu);
                }
                dtNV = dtNVS;
                rp.SetDataSource(dtNV);
                crvNhanvien.ReportSource = rp;
            }
        }

        private void rdQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdQuanLy.Checked)
            {
                crpNhanVien rp = new crpNhanVien();
                nvBUS = new NhanVienBUS();
                IList<NhanVienDTO> listNV = nvBUS.getListNhanVienByChucVu("Quản lý");
                qlks3lopDataSet.nhanvienDataTable dtNVS = new qlks3lopDataSet.nhanvienDataTable();
                foreach (NhanVienDTO nv in listNV)
                {
                    dtNVS.Rows.Add(nv.Manhanvien, nv.Tennhanvien, nv.Ngaysinh, nv.Phai, nv.Diachi, nv.Phone, nv.Chucvu);
                }
                dtNV = dtNVS;
                rp.SetDataSource(dtNV);
                crvNhanvien.ReportSource = rp;
            }
        }

        private void rdNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNhanVien.Checked)
            {
                crpNhanVien rp = new crpNhanVien();
                nvBUS = new NhanVienBUS();
                IList<NhanVienDTO> listNV = nvBUS.getListNhanVienByChucVu("Nhân viên");
                qlks3lopDataSet.nhanvienDataTable dtNVS = new qlks3lopDataSet.nhanvienDataTable();
                foreach (NhanVienDTO nv in listNV)
                {
                    dtNVS.Rows.Add(nv.Manhanvien, nv.Tennhanvien, nv.Ngaysinh, nv.Phai, nv.Diachi, nv.Phone, nv.Chucvu);
                }
                dtNV = dtNVS;
                rp.SetDataSource(dtNV);
                crvNhanvien.ReportSource = rp;
            }
        }

        private void FormBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            if (frmMain.m_chucvu == "admin")
            {
                rdTatCa.Visible = true;
                rdQuanLy.Visible = true;
                rdNhanVien.Visible = true;
                rdTatCa.Checked = true;
            }
            else if (frmMain.m_chucvu == "Quản lý")
            {
                rdTatCa.Visible = false;
                rdQuanLy.Visible = false;
                rdNhanVien.Visible = true;
                rdNhanVien.Checked = true;
            }
            else
            {
                rdTatCa.Visible = false;
                rdQuanLy.Visible = false;
                rdNhanVien.Visible = false;
                //rdNhanVien.Checked = true;
            }
        }
    }
}
