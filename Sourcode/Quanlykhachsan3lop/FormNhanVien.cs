using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using DTO;
using BUS;
using System.Collections;

namespace Quanlykhachsan3lop
{
    public partial class FormNhanVien : Form
    {
        public FormMain frmMain;
        NhanVienBUS nvBUS;
        NhanVienDTO nvDTO;
        private int limit;
        Object[] ql = {"Nhân viên","Quản lý"};
        Object[] nv = { "Nhân viên" };
        public FormNhanVien()
        {
            InitializeComponent();
        }
        
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dtpNS.Value = DateTime.Now.AddYears(-18).Date;
            txtMaNV.Focus();
            limit = 0;
            loadDS(limit);
            if (limit == 0)
            {
                btnLSP.Enabled = false;
                btnSLF.Enabled = false;
            }
            if (frmMain.m_chucvu == "Quản lý")
            {
                foreach (string t in nv)
                {
                    cmbChucVu.Items.Add(t);
                }
            }
            else
            {
                foreach (string t in ql)
                {
                    cmbChucVu.Items.Add(t);
                }
            }
            cmbChucVu.SelectedIndex = 0;
        }

        private void loadDS(int longlist)
        {
            lsvNV.Items.Clear();
            nvBUS = new NhanVienBUS();
            IList<NhanVienDTO> lst = nvBUS.getListNhanvienLMAll(longlist);
            foreach (NhanVienDTO nvDTO in lst)
            {
                if (nvDTO.Chucvu != frmMain.m_chucvu)
                {
                    int i = lsvNV.Items.Count;
                    lsvNV.Items.Add(nvDTO.Manhanvien.ToString());
                    lsvNV.Items[i].SubItems.Add(nvDTO.Tennhanvien.ToString());
                    lsvNV.Items[i].SubItems.Add(nvDTO.Ngaysinh.ToShortDateString());
                    if (nvDTO.Phai.ToString() == "True")
                    {
                        lsvNV.Items[i].SubItems.Add("Nam");
                    }
                    else
                    {
                        lsvNV.Items[i].SubItems.Add("Nữ"); ;
                    }
                    lsvNV.Items[i].SubItems.Add(nvDTO.Diachi.ToString());
                    lsvNV.Items[i].SubItems.Add(nvDTO.Phone.ToString());
                    lsvNV.Items[i].SubItems.Add(nvDTO.Chucvu.ToString());
                }
            }
        }

        private void btnSLF_Click(object sender, EventArgs e)
        {
            btnSLF.ForeColor = Color.Red;
            btnLSP.ForeColor = Color.Black;
            btnLSN.ForeColor = Color.Black;
            btnSLL.ForeColor = Color.Black;
            limit = 0;
            loadDS(limit);
            btnSLF.Enabled = false;
            btnLSP.Enabled = false;
            btnSLL.Enabled = true;
            btnLSN.Enabled = true;
        }

        private void runNext()
        {
           nvBUS = new NhanVienBUS();
           btnSLF.Enabled = true;
           btnLSP.Enabled = true;
           int count = nvBUS.Count();
           while(limit+frmMain.CountList<count)
           {
               limit += frmMain.CountList;
               loadDS(limit);
               break;
           }
           if (limit + frmMain.CountList >= count)
           {
               btnLSN.Enabled = false;
               btnSLL.Enabled = false;
           }
        }

        private void runFirst()
        {
            nvBUS = new NhanVienBUS();
           btnSLL.Enabled = true;
           btnLSN.Enabled = true;
           int count = nvBUS.Count();
           while(limit>0)
           {
               if (limit - frmMain.CountList > 0)
               {
                   limit -= frmMain.CountList;
                   loadDS(limit);
               }
               else
               {
                   limit = 0;
                   loadDS(limit);
               }
               break;
           }
           if (limit == 0)
           {
               btnLSP.Enabled = false;
               btnSLF.Enabled = false;
           }
        }

        private void btnLSP_Click(object sender, EventArgs e)
        {
            btnSLF.ForeColor = Color.Black;
            btnLSP.ForeColor = Color.Red;
            btnLSN.ForeColor = Color.Black;
            btnSLL.ForeColor = Color.Black;
            runFirst();
        }

        private void btnLSN_Click(object sender, EventArgs e)
        {
            btnSLF.ForeColor = Color.Black;
            btnLSP.ForeColor = Color.Black;
            btnLSN.ForeColor = Color.Red;
            btnSLL.ForeColor = Color.Black;
            runNext();
            
        }

        private void btnSLL_Click(object sender, EventArgs e)
        {
            btnSLF.ForeColor = Color.Black;
            btnLSP.ForeColor = Color.Black;
            btnLSN.ForeColor = Color.Black;
            btnSLL.ForeColor = Color.Red;
            limit = nvBUS.Count() - 5;
            loadDS(limit);
            btnSLL.Enabled = false;
            btnLSN.Enabled = false;
            btnLSP.Enabled = true;
            btnSLF.Enabled = true;
        }

        private void lsvNV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtradulieu())
            {
                nvBUS = new NhanVienBUS();
                nvDTO = new NhanVienDTO();
                nvDTO.Manhanvien = txtMaNV.Text;
                nvDTO.Tennhanvien = txtTenNV.Text;
                nvDTO.Ngaysinh = dtpNS.Value;
                nvDTO.Phai = rdbNam.Checked;
                nvDTO.Diachi = txtDiaChi.Text;
                nvDTO.Phone = txtDienthoai.Text;
                nvDTO.Chucvu = cmbChucVu.Text;
                if (nvBUS.insertNhanVien(nvDTO) == 1)
                {
                    showTK(nvDTO.Manhanvien);
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã có!");
                    txtMaNV.Clear();
                    txtMaNV.Focus();
                    return;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    nvBUS = new NhanVienBUS();
                    if (nvBUS.deleteNhanVien(lsvNV.SelectedItems[0].SubItems[0].Text) == 1)
                    {
                        loadDS(limit);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa được!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    lsvNV.SelectedItems.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count <= 0)
                return;
            if (kiemtraten() && kiemtrangaysinh() && kiemtradiachi())
            {
                nvBUS = new NhanVienBUS();
                nvDTO = new NhanVienDTO();
                nvDTO.Manhanvien = lsvNV.SelectedItems[0].SubItems[0].Text;
                nvDTO.Tennhanvien = txtTenNV.Text;
                nvDTO.Ngaysinh = dtpNS.Value;
                nvDTO.Phai = rdbNam.Checked;
                nvDTO.Diachi = txtDiaChi.Text;
                nvDTO.Phone = txtDienthoai.Text;
                nvDTO.Chucvu = cmbChucVu.Text;
                nvBUS.updateNhanVien(nvDTO);
                showTK(nvDTO.Manhanvien);
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            showTK(txtTimKiem.Text);
        }

        private void showTK(string tk)
        {
            lsvNV.Items.Clear();
            nvBUS = new NhanVienBUS();
            IList<NhanVienDTO> list = nvBUS.getListLikeNhanVienByName(tk);
            if (list == null)
            {
                list = nvBUS.getListLikeNhanVienByID(tk);
            }
            if (list != null)
            {
                foreach (NhanVienDTO nvDTO in list)
                {
                    if (nvDTO.Chucvu != frmMain.m_chucvu)
                    {
                        int i = lsvNV.Items.Count;
                        lsvNV.Items.Add(nvDTO.Manhanvien.ToString());
                        lsvNV.Items[i].SubItems.Add(nvDTO.Tennhanvien.ToString());
                        lsvNV.Items[i].SubItems.Add(nvDTO.Ngaysinh.ToShortDateString());
                        if (nvDTO.Phai.ToString() == "True")
                        {
                            lsvNV.Items[i].SubItems.Add("Nam");
                        }
                        else
                        {
                            lsvNV.Items[i].SubItems.Add("Nữ"); ;
                        }
                        lsvNV.Items[i].SubItems.Add(nvDTO.Diachi.ToString());
                        lsvNV.Items[i].SubItems.Add(nvDTO.Phone.ToString());
                        lsvNV.Items[i].SubItems.Add(nvDTO.Chucvu.ToString());
                    }
                }
            }
        }

        private void txtDienthoai_KeyDown(object sender, KeyEventArgs e)
        {
            frmMain.KTChiSo(sender, e, txtDienthoai, loi);

            if (e.KeyCode == Keys.Enter)
            {
                cmbChucVu.Focus();
            }
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmMain.KoNhapChu(sender, e);
        }

        private Boolean kiemtraten()
        {
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                txtTenNV.Focus();
                return false;
            }
            return true;
        }
        private bool kiemtramanv()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mã nhân viên không được trống!");
                return false;
            }
            return true;
        }
        private Boolean kiemtrangaysinh()
        {
            if ((DateTime.Now.Year - dtpNS.Value.Year) < 18)
            {
                MessageBox.Show("Tuổi phải trên 18!");
                return false;
            }
            return true;
        }

        private Boolean kiemtradiachi()
        {
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được đề trống!");
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        private bool kiemtradulieu()
        {
            return (kiemtramanv() && kiemtraten() && kiemtrangaysinh() && kiemtradiachi());
        }

        private void lsvNV_Click(object sender, EventArgs e)
        {
            if (lsvNV.SelectedItems.Count <= 0)
            {
                return;
            }
            txtMaNV.Clear();
            txtTenNV.Text = lsvNV.SelectedItems[0].SubItems[1].Text;
            dtpNS.Value = DateTime.Parse(lsvNV.SelectedItems[0].SubItems[2].Text);
            if (lsvNV.SelectedItems[0].SubItems[3].Text == "Nam")
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            txtDiaChi.Text = lsvNV.SelectedItems[0].SubItems[4].Text;
            txtDienthoai.Text = lsvNV.SelectedItems[0].SubItems[5].Text;
            cmbChucVu.Text = lsvNV.SelectedItems[0].SubItems[6].Text;
        }

        private void dtpNS_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNS.Value.Date > DateTime.Now.AddYears(-18).Date)
            {
                MessageBox.Show("Tuổi phải trên 18!");
                dtpNS.Value = DateTime.Now.AddYears(-18).Date;
                return;
            }
        }
    }
}
