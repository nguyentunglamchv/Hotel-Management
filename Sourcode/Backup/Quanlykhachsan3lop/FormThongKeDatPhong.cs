using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlykhachsan3lop
{
    public partial class FormThongKeDatPhong : Form
    {
        public FormMain frmMain;
        public FormThongKeDatPhong()
        {
            InitializeComponent();
        }

        private void FormThongKeDatPhong_Load(object sender, EventArgs e)
        {
            showthang();
            shownam();
        }

        private void showthang()
        {
            cmbThang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
            if (cmbThang.Items.Count > 0)
            {
                cmbThang.SelectedIndex = 0;
            }
        }

        private void shownam()
        {
            cmbNam.Items.Clear();
            for (int i = 1999; i <= 2015; i++)
            {
                cmbNam.Items.Add(i);
            }
            if (cmbNam.Items.Count > 0)
            {
                cmbNam.SelectedIndex = 0;
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=qlks3lop;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            com.CommandText = "thongkedatphong " + cmbThang.Text + "," + cmbNam.Text;
            com.Connection = con;
            con.Open();
            da.SelectCommand=com;
            da.Fill(dt);
            FormCRThongKeDatPhong frm = new FormCRThongKeDatPhong();
            frm.frmTK = this;
            frm.frmMain = this.frmMain;
            frm.dt = dt;
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
