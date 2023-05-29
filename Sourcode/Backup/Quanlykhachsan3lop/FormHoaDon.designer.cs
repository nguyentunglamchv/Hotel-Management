namespace Quanlykhachsan3lop
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Khách hàng", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mã khách hàng:");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Tên khách hàng:");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("CMND/Passport");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Địa chỉ");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Cơ quan:");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Số điện thoại:");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Email:");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lsvKH = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.lsvPhong = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.lsvDV = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labMaHD = new System.Windows.Forms.Label();
            this.labTDC = new System.Windows.Forms.Label();
            this.labTP = new System.Windows.Forms.Label();
            this.labTDV = new System.Windows.Forms.Label();
            this.labTPT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày thanh toán:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(122, 119);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(140, 20);
            this.dtpNgay.TabIndex = 21;
            // 
            // lsvKH
            // 
            this.lsvKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader13});
            this.lsvKH.FullRowSelect = true;
            this.lsvKH.GridLines = true;
            listViewGroup1.Header = "Khách hàng";
            listViewGroup1.Name = "lsvgKH";
            this.lsvKH.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lsvKH.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup1;
            listViewItem7.Group = listViewGroup1;
            this.lsvKH.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lsvKH.Location = new System.Drawing.Point(299, 14);
            this.lsvKH.Name = "lsvKH";
            this.lsvKH.Scrollable = false;
            this.lsvKH.Size = new System.Drawing.Size(761, 160);
            this.lsvKH.TabIndex = 24;
            this.lsvKH.UseCompatibleStateImageBehavior = false;
            this.lsvKH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thông tin";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giá trị";
            this.columnHeader13.Width = 313;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã phiếu thuê:";
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(122, 31);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(140, 21);
            this.cmbMaPT.TabIndex = 26;
            this.cmbMaPT.SelectedIndexChanged += new System.EventHandler(this.cmbMaPT_SelectedIndexChanged);
            // 
            // lsvPhong
            // 
            this.lsvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvPhong.FullRowSelect = true;
            this.lsvPhong.GridLines = true;
            this.lsvPhong.Location = new System.Drawing.Point(299, 174);
            this.lsvPhong.MultiSelect = false;
            this.lsvPhong.Name = "lsvPhong";
            this.lsvPhong.Size = new System.Drawing.Size(761, 142);
            this.lsvPhong.TabIndex = 27;
            this.lsvPhong.UseCompatibleStateImageBehavior = false;
            this.lsvPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phòng";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày đến";
            this.columnHeader12.Width = 97;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Ngày đi";
            this.columnHeader14.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số ngày ở";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 165;
            // 
            // lsvDV
            // 
            this.lsvDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader15,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvDV.FullRowSelect = true;
            this.lsvDV.GridLines = true;
            this.lsvDV.Location = new System.Drawing.Point(299, 311);
            this.lsvDV.Name = "lsvDV";
            this.lsvDV.Size = new System.Drawing.Size(761, 187);
            this.lsvDV.TabIndex = 28;
            this.lsvDV.UseCompatibleStateImageBehavior = false;
            this.lsvDV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dịch vụ";
            this.columnHeader5.Width = 127;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phòng";
            this.columnHeader7.Width = 123;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngày";
            this.columnHeader8.Width = 114;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Giờ";
            this.columnHeader15.Width = 99;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giá";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượng";
            this.columnHeader10.Width = 96;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Thành tiền";
            this.columnHeader11.Width = 94;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 213);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 29;
            this.label.Text = "Tiền phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tiền dịch vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tiền đặt cọc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Số tiền phải trả:";
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Location = new System.Drawing.Point(187, 410);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(75, 23);
            this.btnInhoadon.TabIndex = 37;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Visible = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(26, 410);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 38;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnTinhTien_MouseMove);
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(108, 475);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // labMaHD
            // 
            this.labMaHD.AutoSize = true;
            this.labMaHD.Location = new System.Drawing.Point(119, 85);
            this.labMaHD.Name = "labMaHD";
            this.labMaHD.Size = new System.Drawing.Size(35, 13);
            this.labMaHD.TabIndex = 40;
            this.labMaHD.Text = "label7";
            // 
            // labTDC
            // 
            this.labTDC.AutoSize = true;
            this.labTDC.Location = new System.Drawing.Point(119, 169);
            this.labTDC.Name = "labTDC";
            this.labTDC.Size = new System.Drawing.Size(35, 13);
            this.labTDC.TabIndex = 41;
            this.labTDC.Text = "label7";
            // 
            // labTP
            // 
            this.labTP.AutoSize = true;
            this.labTP.Location = new System.Drawing.Point(119, 213);
            this.labTP.Name = "labTP";
            this.labTP.Size = new System.Drawing.Size(35, 13);
            this.labTP.TabIndex = 42;
            this.labTP.Text = "label7";
            // 
            // labTDV
            // 
            this.labTDV.AutoSize = true;
            this.labTDV.Location = new System.Drawing.Point(119, 261);
            this.labTDV.Name = "labTDV";
            this.labTDV.Size = new System.Drawing.Size(35, 13);
            this.labTDV.TabIndex = 43;
            this.labTDV.Text = "label7";
            // 
            // labTPT
            // 
            this.labTPT.AutoSize = true;
            this.labTPT.Location = new System.Drawing.Point(119, 303);
            this.labTPT.Name = "labTPT";
            this.labTPT.Size = new System.Drawing.Size(0, 13);
            this.labTPT.TabIndex = 44;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 548);
            this.Controls.Add(this.labTPT);
            this.Controls.Add(this.labTDV);
            this.Controls.Add(this.labTP);
            this.Controls.Add(this.labTDC);
            this.Controls.Add(this.labMaHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnInhoadon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lsvDV);
            this.Controls.Add(this.lsvPhong);
            this.Controls.Add(this.cmbMaPT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvKH);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.ListView lsvKH;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private System.Windows.Forms.ListView lsvPhong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lsvDV;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labMaHD;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label labTDC;
        private System.Windows.Forms.Label labTP;
        private System.Windows.Forms.Label labTDV;
        private System.Windows.Forms.Label labTPT;
    }
}