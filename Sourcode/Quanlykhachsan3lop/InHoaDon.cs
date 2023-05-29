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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        public DataTable dtdv;
        public DataTable dtp;
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            crpInHoaDon rp = new crpInHoaDon();
            rp.SetDataSource(dtp);
            
            rp.Subreports["crpInHoaDonPhong.rpt"].SetDataSource(dtp);
            //rp.SetDataSource(dtdv);
            rp.Subreports["crpInDichVu.rpt"].SetDataSource(dtdv);
            crv.ReportSource = rp;
        }
    }
}
