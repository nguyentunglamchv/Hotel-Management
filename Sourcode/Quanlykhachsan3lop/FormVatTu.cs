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
    public partial class FormVatTu : Form
    {
        public FormPhong frmPhong;
        public FormMain frmMain;
        public string maloai="";
        VatTuBUS vtBUS;
        ChiTietVatTuBUS ctvtBUS;
        VatTuDTO vtDTO;
        ChiTietVatTuDTO ctvtDTO;

        public FormVatTu()
        {
            InitializeComponent();
        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            show_Mloai();
            show_mvattu();
            Show_Vattu();
            Show_ChitietVT();
            if (maloai != "")
            {
                cmbLoaiPhong.Text = maloai;
            }
        }
      
        private void Show_Vattu()
        {
            lsvQLVattu.Items.Clear();
            vtBUS=new VatTuBUS();
           IList<VatTuDTO> listVT=vtBUS.getListVatTuAll();
            foreach(VatTuDTO vt in listVT)
            {
                int i = lsvQLVattu.Items.Count;
                lsvQLVattu.Items.Add(vt.Mavattu);
                lsvQLVattu.Items[i].SubItems.Add(vt.Tenvattu);
            }
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (mavt() && tenvt())
            {
                vtDTO = new VatTuDTO();
                vtBUS = new VatTuBUS();
                vtDTO.Mavattu = txtMaVatTu.Text;
                vtDTO.Tenvattu = txtTenVatTu.Text;
                if (vtBUS.insertVatTu(vtDTO) == 1)
                {
                    Show_Vattu();
                    txtMaVatTu.Clear();
                    txtTenVatTu.Clear();
                }
                else
                {
                    MessageBox.Show("Dữ liệu đã có!");
                    txtMaVatTu.SelectAll();
                    txtMaVatTu.Focus();
                    return;
                }
            }
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            if (lsvQLVattu.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    vtBUS = new VatTuBUS();
                    string fe = lsvQLVattu.SelectedItems[0].SubItems[0].Text;
                    if (vtBUS.deleteVatTu(fe) == 1)
                    {
                        Show_Vattu();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì nó đang được tham chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                else
                {
                    lsvQLVattu.SelectedItems.Clear();
                    txtMaVatTu.Clear();
                    txtTenVatTu.Clear();
                }
            }
        }
        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            if (lsvQLVattu.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (tenvt())
                {
                    vtDTO = new VatTuDTO();
                    vtBUS = new VatTuBUS();
                    vtDTO.Mavattu = lsvQLVattu.SelectedItems[0].SubItems[0].Text;
                    vtDTO.Tenvattu = txtTenVatTu.Text;
                    if (vtBUS.updateVatTu(vtDTO) == 1)
                    {
                        Show_Vattu();
                        txtMaVatTu.Clear();
                        txtTenVatTu.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đã có!");
                        return;
                    }
                }
            }
        }

        private void lsvQLVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //Chi tiết vật tư------------------------------------------------
        private void show_mvattu()
        {
            vtBUS = new VatTuBUS();
            cmbVattu.DataSource = vtBUS.getListVatTuAll();
            cmbVattu.DisplayMember = "Tenvattu";
            cmbVattu.ValueMember = "Mavattu";
        }

        private void show_Mloai()
        {
            LoaiPhongBUS lpBUS = new LoaiPhongBUS();
            cmbLoaiPhong.DataSource = lpBUS.getListLoaiPhongAll();
            cmbLoaiPhong.DisplayMember = "Maloai";
            cmbLoaiPhong.ValueMember = "Maloai";
        }

        public void Show_ChitietVT()
        {
            lsvCTVattu.Items.Clear();
            ctvtBUS = new ChiTietVatTuBUS();
            string maLP = cmbLoaiPhong.Text;
            IList<ChiTietVatTuDTO> listCTVT = ctvtBUS.getListChiTietVatTuByMaLP(maLP);
            if(listCTVT!=null)
            foreach (ChiTietVatTuDTO ctvt in listCTVT)
            {
                vtBUS = new VatTuBUS();
                vtDTO = new VatTuDTO();
                vtDTO = vtBUS.getVatTuByID(ctvt.Mavattu);
                int i = lsvCTVattu.Items.Count;
                lsvCTVattu.Items.Add(vtDTO.Tenvattu);
                lsvCTVattu.Items[i].SubItems.Add(ctvt.Soluong.ToString());
            }
            
        }
        private void lsvCTVattu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThemCTVT_Click(object sender, EventArgs e)
        {
            if (kiemtrabotri())
            {

                ctvtBUS = new ChiTietVatTuBUS();
                ctvtDTO = new ChiTietVatTuDTO();
                ctvtDTO.Mavattu = cmbVattu.SelectedValue.ToString();
                ctvtDTO.Maloaiphong = cmbLoaiPhong.SelectedValue.ToString();
                ctvtDTO.Soluong = int.Parse(numSL.Value.ToString());
                if (ctvtBUS.insertChiTietVatTu(ctvtDTO) == 1)
                {
                    Show_ChitietVT();
                }
                else
                {
                    MessageBox.Show("Dữ liệu này đã có!");
                }
            }
        }

        private void btnXoaCTVT_Click(object sender, EventArgs e)
        {
            if (lsvCTVattu.SelectedItems.Count <= 0)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc thực hiện việc này không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string MaLP = cmbLoaiPhong.SelectedValue.ToString();
                    string MaVT = cmbVattu.SelectedValue.ToString();
                    ctvtBUS = new ChiTietVatTuBUS();
                    if (ctvtBUS.deleteChiTietVatTu(MaVT, MaLP) == 1)
                    {
                        Show_ChitietVT();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    lsvCTVattu.SelectedItems.Clear();
                }
            }
        }

        private void btnSuaCTVT_Click(object sender, EventArgs e)
        {
            if (lsvCTVattu.SelectedItems.Count <= 0)
            {
                return;
            }
            if (soluong())
            {
                string MaLP = cmbLoaiPhong.SelectedValue.ToString();
                string MaVT = cmbVattu.SelectedValue.ToString();
                ctvtBUS = new ChiTietVatTuBUS();
                ctvtDTO = new ChiTietVatTuDTO();
                ctvtDTO.Maloaiphong = MaLP;
                ctvtDTO.Mavattu = MaVT;
                ctvtDTO.Soluong = int.Parse(numSL.Value.ToString());
                ctvtBUS.updateChiTietVatTu(ctvtDTO);
                Show_ChitietVT();
            }
        } 

        private bool vattu()
        {
            if (cmbVattu.Text == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool loaiphong()
        {
            if (cmbLoaiPhong.Text == "")
            {
                MessageBox.Show("Phòng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool soluong()
        {
            if (numSL.Value == 0)
            {
                MessageBox.Show("Số lượng không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool kiemtrabotri()
        {
            if (loaiphong() && soluong() && vattu())
            {
                return true;
            }
            return false;
        }

        
        private bool mavt()
        {
            if (txtMaVatTu.Text == "")
            {
                MessageBox.Show("Mã vật tư không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool tenvt()
        {
            if (txtTenVatTu.Text == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            show_mvattu();
            Show_ChitietVT();
        }

        private void cmbLoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            Show_ChitietVT();
        }

        private void lsvCTVattu_Click(object sender, EventArgs e)
        {
            if (lsvCTVattu.SelectedItems.Count <= 0) return;
            cmbVattu.Text = lsvCTVattu.SelectedItems[0].SubItems[0].Text;
            numSL.Value = int.Parse(lsvCTVattu.SelectedItems[0].SubItems[1].Text);
        }

        private void lsvQLVattu_Click(object sender, EventArgs e)
        {
            if (lsvQLVattu.SelectedItems.Count <= 0) return;
            txtMaVatTu.Clear();
            txtTenVatTu.Text = lsvQLVattu.SelectedItems[0].SubItems[1].Text;
        }     
    }
}