namespace Quanlykhachsan3lop
{
    partial class FormKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.lsvKhachhang = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtCoquan = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSLL = new System.Windows.Forms.Button();
            this.btnLSN = new System.Windows.Forms.Button();
            this.btnLSP = new System.Windows.Forms.Button();
            this.btnSLF = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMKH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvKhachhang
            // 
            this.lsvKhachhang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvKhachhang.FullRowSelect = true;
            this.lsvKhachhang.GridLines = true;
            this.lsvKhachhang.Location = new System.Drawing.Point(12, 261);
            this.lsvKhachhang.MultiSelect = false;
            this.lsvKhachhang.Name = "lsvKhachhang";
            this.lsvKhachhang.Size = new System.Drawing.Size(688, 224);
            this.lsvKhachhang.TabIndex = 23;
            this.lsvKhachhang.UseCompatibleStateImageBehavior = false;
            this.lsvKhachhang.View = System.Windows.Forms.View.Details;
            this.lsvKhachhang.Click += new System.EventHandler(this.lsvKhachhang_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giới tính";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CMND/Passport";
            this.columnHeader5.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa chỉ";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cơ quan";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số ĐT";
            this.columnHeader6.Width = 79;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 81;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(476, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(476, 80);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(186, 20);
            this.txtSoDT.TabIndex = 8;
            this.txtSoDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoDT_KeyDown);
            this.txtSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDT_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(110, 112);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(186, 20);
            this.txtCMND.TabIndex = 5;
            this.txtCMND.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMND_KeyDown);
            // 
            // txtCoquan
            // 
            this.txtCoquan.Location = new System.Drawing.Point(476, 48);
            this.txtCoquan.Name = "txtCoquan";
            this.txtCoquan.Size = new System.Drawing.Size(186, 20);
            this.txtCoquan.TabIndex = 7;
            this.txtCoquan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoquan_KeyDown);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(476, 16);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(186, 20);
            this.txtDiachi.TabIndex = 6;
            this.txtDiachi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyDown);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(110, 48);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(186, 20);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenKH_KeyDown);
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "CMND/Passport:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cơ quan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã khách hàng:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(498, 219);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(186, 20);
            this.txtTim.TabIndex = 39;
            this.txtTim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tìm mã/tên khách hàng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Giới tính:";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(110, 83);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(200, 83);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // btnSLL
            // 
            this.btnSLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLL.Location = new System.Drawing.Point(173, 226);
            this.btnSLL.Name = "btnSLL";
            this.btnSLL.Size = new System.Drawing.Size(44, 23);
            this.btnSLL.TabIndex = 48;
            this.btnSLL.Text = "Last";
            this.btnSLL.UseVisualStyleBackColor = true;
            this.btnSLL.Click += new System.EventHandler(this.btnSLL_Click);
            // 
            // btnLSN
            // 
            this.btnLSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSN.Location = new System.Drawing.Point(123, 226);
            this.btnLSN.Name = "btnLSN";
            this.btnLSN.Size = new System.Drawing.Size(44, 23);
            this.btnLSN.TabIndex = 47;
            this.btnLSN.Text = ">>";
            this.btnLSN.UseVisualStyleBackColor = true;
            this.btnLSN.Click += new System.EventHandler(this.btnLSN_Click);
            // 
            // btnLSP
            // 
            this.btnLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLSP.Location = new System.Drawing.Point(73, 226);
            this.btnLSP.Name = "btnLSP";
            this.btnLSP.Size = new System.Drawing.Size(44, 23);
            this.btnLSP.TabIndex = 46;
            this.btnLSP.Text = "<<";
            this.btnLSP.UseVisualStyleBackColor = true;
            this.btnLSP.Click += new System.EventHandler(this.btnLSP_Click);
            // 
            // btnSLF
            // 
            this.btnSLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSLF.Location = new System.Drawing.Point(23, 226);
            this.btnSLF.Name = "btnSLF";
            this.btnSLF.Size = new System.Drawing.Size(44, 23);
            this.btnSLF.TabIndex = 45;
            this.btnSLF.Text = "First";
            this.btnSLF.UseVisualStyleBackColor = true;
            this.btnSLF.Click += new System.EventHandler(this.btnSLF_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(229, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(334, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(433, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMKH
            // 
            this.txtMKH.Location = new System.Drawing.Point(110, 20);
            this.txtMKH.Name = "txtMKH";
            this.txtMKH.Size = new System.Drawing.Size(186, 20);
            this.txtMKH.TabIndex = 52;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 497);
            this.Controls.Add(this.txtMKH);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSLL);
            this.Controls.Add(this.btnLSN);
            this.Controls.Add(this.btnLSP);
            this.Controls.Add(this.btnSLF);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtCoquan);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvKhachhang);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvKhachhang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtCoquan;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.Button btnSLL;
        private System.Windows.Forms.Button btnLSN;
        private System.Windows.Forms.Button btnLSP;
        private System.Windows.Forms.Button btnSLF;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMKH;
    }
}