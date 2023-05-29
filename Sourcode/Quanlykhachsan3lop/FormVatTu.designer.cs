namespace Quanlykhachsan3lop
{
    partial class FormVatTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lsvCTVattu = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSuaCTVT = new System.Windows.Forms.Button();
            this.btnXoaCTVT = new System.Windows.Forms.Button();
            this.btnThemCTVT = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cmbVattu = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSuaVT = new System.Windows.Forms.Button();
            this.btnXoaVT = new System.Windows.Forms.Button();
            this.btnThemVT = new System.Windows.Forms.Button();
            this.lsvQLVattu = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaVatTu = new System.Windows.Forms.TextBox();
            this.txtTenVatTu = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vật Tư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng:";
            // 
            // cmbLoaiPhong
            // 
            this.cmbLoaiPhong.FormattingEnabled = true;
            this.cmbLoaiPhong.Location = new System.Drawing.Point(150, 28);
            this.cmbLoaiPhong.Name = "cmbLoaiPhong";
            this.cmbLoaiPhong.Size = new System.Drawing.Size(200, 21);
            this.cmbLoaiPhong.TabIndex = 5;
            this.cmbLoaiPhong.SelectedValueChanged += new System.EventHandler(this.cmbLoaiPhong_SelectedValueChanged);
            // 
            // lsvCTVattu
            // 
            this.lsvCTVattu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvCTVattu.FullRowSelect = true;
            this.lsvCTVattu.GridLines = true;
            this.lsvCTVattu.Location = new System.Drawing.Point(26, 207);
            this.lsvCTVattu.MultiSelect = false;
            this.lsvCTVattu.Name = "lsvCTVattu";
            this.lsvCTVattu.Size = new System.Drawing.Size(390, 205);
            this.lsvCTVattu.TabIndex = 6;
            this.lsvCTVattu.UseCompatibleStateImageBehavior = false;
            this.lsvCTVattu.View = System.Windows.Forms.View.Details;
            this.lsvCTVattu.SelectedIndexChanged += new System.EventHandler(this.lsvCTVattu_SelectedIndexChanged);
            this.lsvCTVattu.Click += new System.EventHandler(this.lsvCTVattu_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên vật tư";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 183;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số Lượng";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 472);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSuaCTVT);
            this.tabPage1.Controls.Add(this.btnXoaCTVT);
            this.tabPage1.Controls.Add(this.btnThemCTVT);
            this.tabPage1.Controls.Add(this.numSL);
            this.tabPage1.Controls.Add(this.cmbVattu);
            this.tabPage1.Controls.Add(this.lsvCTVattu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbLoaiPhong);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bố trí";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnSuaCTVT
            // 
            this.btnSuaCTVT.Location = new System.Drawing.Point(285, 167);
            this.btnSuaCTVT.Name = "btnSuaCTVT";
            this.btnSuaCTVT.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCTVT.TabIndex = 20;
            this.btnSuaCTVT.Text = "Sửa";
            this.btnSuaCTVT.UseVisualStyleBackColor = true;
            this.btnSuaCTVT.Click += new System.EventHandler(this.btnSuaCTVT_Click);
            // 
            // btnXoaCTVT
            // 
            this.btnXoaCTVT.Location = new System.Drawing.Point(190, 167);
            this.btnXoaCTVT.Name = "btnXoaCTVT";
            this.btnXoaCTVT.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCTVT.TabIndex = 19;
            this.btnXoaCTVT.Text = "Xóa";
            this.btnXoaCTVT.UseVisualStyleBackColor = true;
            this.btnXoaCTVT.Click += new System.EventHandler(this.btnXoaCTVT_Click);
            // 
            // btnThemCTVT
            // 
            this.btnThemCTVT.Location = new System.Drawing.Point(95, 167);
            this.btnThemCTVT.Name = "btnThemCTVT";
            this.btnThemCTVT.Size = new System.Drawing.Size(75, 23);
            this.btnThemCTVT.TabIndex = 18;
            this.btnThemCTVT.Text = "Thêm";
            this.btnThemCTVT.UseVisualStyleBackColor = true;
            this.btnThemCTVT.Click += new System.EventHandler(this.btnThemCTVT_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(150, 111);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(200, 20);
            this.numSL.TabIndex = 17;
            // 
            // cmbVattu
            // 
            this.cmbVattu.FormattingEnabled = true;
            this.cmbVattu.Location = new System.Drawing.Point(150, 71);
            this.cmbVattu.Name = "cmbVattu";
            this.cmbVattu.Size = new System.Drawing.Size(200, 21);
            this.cmbVattu.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSuaVT);
            this.tabPage2.Controls.Add(this.btnXoaVT);
            this.tabPage2.Controls.Add(this.btnThemVT);
            this.tabPage2.Controls.Add(this.lsvQLVattu);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtMaVatTu);
            this.tabPage2.Controls.Add(this.txtTenVatTu);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Location = new System.Drawing.Point(274, 122);
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(75, 23);
            this.btnSuaVT.TabIndex = 20;
            this.btnSuaVT.Text = "Sửa";
            this.btnSuaVT.UseVisualStyleBackColor = true;
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Location = new System.Drawing.Point(174, 122);
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(75, 23);
            this.btnXoaVT.TabIndex = 19;
            this.btnXoaVT.Text = "Xóa";
            this.btnXoaVT.UseVisualStyleBackColor = true;
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Location = new System.Drawing.Point(74, 122);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(75, 23);
            this.btnThemVT.TabIndex = 18;
            this.btnThemVT.Text = "Thêm";
            this.btnThemVT.UseVisualStyleBackColor = true;
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // lsvQLVattu
            // 
            this.lsvQLVattu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lsvQLVattu.FullRowSelect = true;
            this.lsvQLVattu.GridLines = true;
            this.lsvQLVattu.Location = new System.Drawing.Point(25, 175);
            this.lsvQLVattu.MultiSelect = false;
            this.lsvQLVattu.Name = "lsvQLVattu";
            this.lsvQLVattu.Size = new System.Drawing.Size(390, 240);
            this.lsvQLVattu.TabIndex = 17;
            this.lsvQLVattu.UseCompatibleStateImageBehavior = false;
            this.lsvQLVattu.View = System.Windows.Forms.View.Details;
            this.lsvQLVattu.SelectedIndexChanged += new System.EventHandler(this.lsvQLVattu_SelectedIndexChanged);
            this.lsvQLVattu.Click += new System.EventHandler(this.lsvQLVattu_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mã Vật Tư";
            this.columnHeader9.Width = 190;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tên Vật Tư";
            this.columnHeader10.Width = 196;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mã Vật Tư:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Tên Vật tư";
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Location = new System.Drawing.Point(127, 34);
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(209, 20);
            this.txtMaVatTu.TabIndex = 12;
            // 
            // txtTenVatTu
            // 
            this.txtTenVatTu.Location = new System.Drawing.Point(127, 69);
            this.txtTenVatTu.Name = "txtTenVatTu";
            this.txtTenVatTu.Size = new System.Drawing.Size(209, 20);
            this.txtTenVatTu.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 444);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Bố trí";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 216);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 222);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Vật Tư";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Vật Tư";
            this.columnHeader6.Width = 121;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại phòng";
            this.columnHeader7.Width = 103;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng";
            this.columnHeader8.Width = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Vật Tư:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên Vật tư";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã loại phòng:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tìm kiếm mã/tên vật tư";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(442, 444);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Quản lý";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // loi
            // 
            this.loi.ContainerControl = this;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormVatTu";
            this.Text = "Quản Lý Vật Tư";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiPhong;
        private System.Windows.Forms.ListView lsvCTVattu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaVatTu;
        private System.Windows.Forms.TextBox txtTenVatTu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lsvQLVattu;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cmbVattu;
        private System.Windows.Forms.ErrorProvider loi;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnSuaVT;
        private System.Windows.Forms.Button btnXoaVT;
        private System.Windows.Forms.Button btnThemVT;
        private System.Windows.Forms.Button btnSuaCTVT;
        private System.Windows.Forms.Button btnXoaCTVT;
        private System.Windows.Forms.Button btnThemCTVT;
    }
}