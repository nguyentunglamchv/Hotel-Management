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
    public partial class FormHeThong : Form
    {
        public FormMain frmMain;
        HeThongBUS htBUS;
        HeThongDTO htDTO;
        NhanVienBUS nvBUS;
        public FormHeThong()
        {
            InitializeComponent();
        }

        private void FormHeThong_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
            show_nguoidung();
        }

        

        private void show_nguoidung()
        {
            lsvnguoidung.Items.Clear();
            nvBUS = new NhanVienBUS();
            htBUS = new HeThongBUS();
            IList<NhanVienDTO> listNVDTO = nvBUS.getListNhanvienAll();
            foreach(NhanVienDTO nv in listNVDTO)
            {
                if (nv.Chucvu != frmMain.m_chucvu)
                {
                    htDTO = new HeThongDTO();
                    htDTO = htBUS.getListHeThongByID(nv.Manhanvien);
                    int i = lsvnguoidung.Items.Count;
                    lsvnguoidung.Items.Add(nv.Manhanvien);
                    lsvnguoidung.Items[i].SubItems.Add(nv.Tennhanvien);
                    if (htDTO != null)
                    {
                        lsvnguoidung.Items[i].SubItems.Add(htDTO.Username);
                        lsvnguoidung.Items[i].SubItems.Add(htDTO.Password);
                    }
                    else
                    {
                        lsvnguoidung.Items[i].SubItems.Add("");
                        lsvnguoidung.Items[i].SubItems.Add("");
                    }
                    lsvnguoidung.Items[i].SubItems.Add(nv.Chucvu);
                }
            }
        }

      
        private void show_lcnguoidung(string tim)
        {
            lsvnguoidung.Items.Clear();
            nvBUS = new NhanVienBUS();
            IList<NhanVienDTO> list = nvBUS.getListLikeNhanVienByID(tim);
            if (list == null)
            {
                list = nvBUS.getListLikeNhanVienByName(tim);
            }
            if(list!=null)
            foreach (NhanVienDTO nv in list)
            {
                if (nv.Chucvu != frmMain.m_chucvu)
                {
                    int i = lsvnguoidung.Items.Count;
                    lsvnguoidung.Items.Add(nv.Manhanvien);
                    lsvnguoidung.Items[i].SubItems.Add(nv.Tennhanvien);
                    htDTO = new HeThongDTO();
                    htDTO = htBUS.getListHeThongByID(nv.Manhanvien);
                    lsvnguoidung.Items[i].SubItems.Add(htDTO.Username);
                    lsvnguoidung.Items[i].SubItems.Add(htDTO.Password);
                    lsvnguoidung.Items[i].SubItems.Add(nv.Chucvu);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                htBUS = new HeThongBUS();
                htDTO = new HeThongDTO();
                htDTO.Username = txtuser.Text;
                htDTO.Manhanvien = txtMaNV.Text;
                htDTO.Password = frmMain.MaHoa(txtPass.Text);
                if (htBUS.insertHeThong(htDTO) == 1)
                {
                    show_nguoidung();
                }
                else
                {
                    MessageBox.Show("Tên User đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lsvnguoidung.SelectedItems.Count <= 0) return;
                htBUS = new HeThongBUS();
                string fe = txtMaNV.Text;
                if (htBUS.deleteHeThong(fe) == 1)
                {
                    show_nguoidung();
                    txtuser.Clear();
                    txtPass.Clear();
                    txtMaNV.Clear();
                }
                else
                {
                    MessageBox.Show("Không thể xóa vì nó đang được tham chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                lsvnguoidung.SelectedItems.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvnguoidung.SelectedItems.Count <= 0)
            {
                return;
            }
            if (lsvnguoidung.SelectedItems[0].SubItems[2].Text == "") btnThem_Click(sender, e);
            else
            {
                if (kiemtrauser())
                {
                    htDTO = new HeThongDTO();
                    htBUS = new HeThongBUS();
                    htDTO.Manhanvien = txtMaNV.Text;
                    htDTO.Username = txtuser.Text;
                    if (txtPass.Text != "")
                    {
                        htDTO.Password = frmMain.MaHoa(txtPass.Text);
                    }
                    else
                    {
                        HeThongDTO ht = htBUS.getListHeThongByID(txtMaNV.Text);
                        htDTO.Password = ht.Password;
                    }
                    if (htBUS.updateHeThong(htDTO) == 1)
                    {
                        show_nguoidung();
                    }
                    else
                    {
                        MessageBox.Show("Tên User đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtuser.SelectAll();
                        txtuser.Focus();
                    }
                }
            }
        }

        private void lsvnguoidung_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private bool kiemtrauser()
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Tên User không được rỗng!");
                txtuser.Focus();
                return false;
            }
            return true;
        }

        private bool kiemtrapass()
        {
            if (txtPass.Text == "")
            {
                MessageBox.Show("Password không được rỗng!");
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private bool kiemtra()
        {
            return (kiemtrauser() && kiemtrapass());
        }

        private void txtTim_KeyUp(object sender, KeyEventArgs e)
        {
            show_lcnguoidung(txtTim.Text);
        }

        private void lsvnguoidung_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            if (lsvnguoidung.SelectedItems.Count <= 0) return;
            txtMaNV.Text = lsvnguoidung.SelectedItems[0].SubItems[0].Text;
            txtuser.Text = lsvnguoidung.SelectedItems[0].SubItems[2].Text;
            if (lsvnguoidung.SelectedItems[0].SubItems[2].Text != "")
            {
                txtuser.Enabled = false;
            }
            else
            {
                txtuser.Enabled = true;
            }
            //txtPass.Text = lsvnguoidung.SelectedItems[0].SubItems[3].Text;
        }
    }
}
