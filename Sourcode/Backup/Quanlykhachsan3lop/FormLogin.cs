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
    public partial class FormLogin : Form
    {
        public FormMain frmMain;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginBUS lgBUS = new LoginBUS();

            IList<LoginDTO> list = lgBUS.Login(txtTenDangNhap.Text, frmMain.MaHoa(txtMatKhau.Text));

            if (list.Count == 0)
            {
                if (MessageBox.Show("Đăng nhập không thành công!", "Lỗi!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
                {
                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                foreach (LoginDTO lgDTO in list)
                {
                     frmMain.m_username= lgDTO.Username;
                     frmMain.m_chucvu = lgDTO.ChucVu;
                     frmMain.m_maNV = lgDTO.MaNV;
                }
                MessageBox.Show("Bạn đang đăng nhập dưới quyền " + frmMain.m_chucvu);
                this.Close();             
            }
            

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
