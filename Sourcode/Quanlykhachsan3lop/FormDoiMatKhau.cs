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
    public partial class FormDoiMatKhau : Form
    {
        public FormMain frmMain;
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            labUser.Text = frmMain.m_username;
            btnXN.Enabled = false;
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            LoginBUS lgBUS = new LoginBUS();
            IList<LoginDTO> list = lgBUS.Login(labUser.Text, frmMain.MaHoa(txtMKC.Text));
            if (list.Count == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKC.Text = "";
                txtMKC.Focus();
            }
            else
            {
                HeThongBUS htBUS = new HeThongBUS();
                HeThongDTO htDTO = new HeThongDTO();
                htDTO.Username = labUser.Text;
                htDTO.Password = frmMain.MaHoa(txtMKMoiAgain.Text);
                htDTO.Manhanvien = frmMain.m_maNV;
                if (htBUS.updateHeThong(htDTO) == 0)
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMKMoiAgain_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtMKMoi.Text != txtMKMoiAgain.Text || txtMKMoi.Text=="")
            {
                btnXN.Enabled = false;
                loi.SetError(txtMKMoiAgain, "Mật khẩu không khớp!");
            }
            else
            {
                btnXN.Enabled = true;
                loi.SetError(txtMKMoiAgain, "");
            }
        }

        private void txtMKMoi_KeyUp(object sender, KeyEventArgs e)
        {
            txtMKMoiAgain_KeyUp(sender, e);
        }

    }
}
