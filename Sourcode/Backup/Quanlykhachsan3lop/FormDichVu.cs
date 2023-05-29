using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.Collections;

namespace Quanlykhachsan3lop
{
    public partial class FormDichVu : Form
    {
        public  FormMain frmMain;
        DichVuBUS dvBUS;
        DichVuDTO dvDTO;
       // public FormPhieuThuePhong frmThue;
        public FormDichVu()
        {
            InitializeComponent();
        }
        string[] a = { "phần", "lon", "chai", "kg" };
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            show_DichVu();
            show_dvt();
        }

        private void show_dvt()
        {
            cmbDVtinh.Items.Clear();
            for (int i = 0; i < a.Count(); i++)
            {
                cmbDVtinh.Items.Add(a[i].ToString());
            }
        }
        private void show_DichVu()
        {
            show_dvt();
            dvBUS = new DichVuBUS();
            IList<DichVuDTO> listDV = dvBUS.getListDichVuAll();
            cmbDVtinh.Items.Clear();
            lsvDichVu.Items.Clear();
            foreach(DichVuDTO dv in listDV)
            {
                int i = lsvDichVu.Items.Count;
                lsvDichVu.Items.Add(dv.Madichvu);
                lsvDichVu.Items[i].SubItems.Add(dv.Tendichvu);
                lsvDichVu.Items[i].SubItems.Add(dv.Gia.ToString("0,0"));
                lsvDichVu.Items[i].SubItems.Add(dv.Donvitinh);
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                dvBUS = new DichVuBUS();
                dvDTO = new DichVuDTO();
                dvDTO.Madichvu = txtMaDV.Text;
                dvDTO.Tendichvu = txtTenDV.Text;
                dvDTO.Donvitinh = cmbDVtinh.Text;
                dvDTO.Gia = decimal.Parse(txtGia.Text);
                if (dvBUS.insertDichVu(dvDTO) == 1)
                {
                    show_DichVu();
                    show_dvt();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã có!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDichVu.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string fe = lsvDichVu.SelectedItems[0].SubItems[0].Text;
                    dvBUS = new DichVuBUS();
                    if (dvBUS.deleteDichVu(fe) == 1)
                    {
                        show_DichVu();
                        show_dvt();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì nó đang được tham chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    lsvDichVu.SelectedItems.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tendv() && dvtinh() && gia())
            {
                dvBUS = new DichVuBUS();
                dvDTO = new DichVuDTO();
                dvDTO.Madichvu = lsvDichVu.SelectedItems[0].SubItems[0].Text;
                dvDTO.Tendichvu = txtTenDV.Text;
                dvDTO.Donvitinh = cmbDVtinh.Text;
                dvDTO.Gia = decimal.Parse(txtGia.Text);
                if (dvBUS.updateDichVu(dvDTO) == 1)
                {
                    show_DichVu();
                    show_dvt();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã có!");
                    return;
                }
            }
        }

        private void lsvDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txtGia_KeyDown(object sender, KeyEventArgs e)
        {
            frmMain.KTChiSo(sender, e, txtGia, loi);
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmMain.KoNhapChu(sender, e);
        }
        private bool madv()
        {
            if (txtMaDV.Text == "")
            {
                MessageBox.Show("Mã dịch vụ không được để trống!");
                return false;
            }
            return true;
        }
        private bool tendv()
        {
            if (txtTenDV.Text == "")
            {
                MessageBox.Show("Tên dịch vụ không được để trống!");
                return false;
            }
            return true;
        }
        private bool dvtinh()
        {
            if (cmbDVtinh.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống!");
                return false;
            }
            return true;
        }
        private bool gia()
        {
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được để trống!");
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (madv() && tendv() && dvtinh() && gia())
            {
                return true;
            }
            return false;
        }
        private void show_lcdichvu(string chuoi)
        {
            lsvDichVu.Items.Clear();
            dvBUS = new DichVuBUS();
            IList<DichVuDTO> listdv = dvBUS.getLikeDichVuByID(chuoi);
            if (listdv.Count <= 0)
            {
                listdv = dvBUS.getListLikeDichVuByName(chuoi);
            }
            foreach(DichVuDTO dv in listdv)
            {
                int i = lsvDichVu.Items.Count;
                lsvDichVu.Items.Add(dv.Madichvu);
                lsvDichVu.Items[i].SubItems.Add(dv.Tendichvu);
                lsvDichVu.Items[i].SubItems.Add(dv.Gia.ToString());
                lsvDichVu.Items[i].SubItems.Add(dv.Donvitinh);           
            }
        }

        private void lsvDichVu_Click(object sender, EventArgs e)
        {
            show_dvt();
            if (lsvDichVu.SelectedItems.Count <= 0) return;
            txtMaDV.Clear();
            txtTenDV.Text = lsvDichVu.SelectedItems[0].SubItems[1].Text;
            cmbDVtinh.Text = lsvDichVu.SelectedItems[0].SubItems[3].Text;
            txtGia.Text = lsvDichVu.SelectedItems[0].SubItems[2].Text;
        }
    }
}
