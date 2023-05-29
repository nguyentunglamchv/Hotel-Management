using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlykhachsan3lop
{
    public partial class FormCRThongKeDatPhong : Form
    {
        public FormThongKeDatPhong frmTK;
        public DataTable dt;
        public FormMain frmMain;
        public FormCRThongKeDatPhong()
        {
            InitializeComponent();
        }

        private void FormCRThongKeDatPhong_Load(object sender, EventArgs e)
        {
            Baocaodatphong cr = new Baocaodatphong();
            cr.SetDataSource(dt);
            crv.ReportSource = cr;
        }
    }
}
