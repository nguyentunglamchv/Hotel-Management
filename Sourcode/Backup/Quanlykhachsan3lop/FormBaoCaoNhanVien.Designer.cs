namespace Quanlykhachsan3lop
{
    partial class FormBaoCaoNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.rdQuanLy = new System.Windows.Forms.RadioButton();
            this.rdNhanVien = new System.Windows.Forms.RadioButton();
            this.crvNhanvien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(380, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo";
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Location = new System.Drawing.Point(179, 114);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(106, 17);
            this.rdTatCa.TabIndex = 1;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả nhân viên";
            this.rdTatCa.UseVisualStyleBackColor = true;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.rdTatCa_CheckedChanged);
            // 
            // rdQuanLy
            // 
            this.rdQuanLy.AutoSize = true;
            this.rdQuanLy.Location = new System.Drawing.Point(365, 114);
            this.rdQuanLy.Name = "rdQuanLy";
            this.rdQuanLy.Size = new System.Drawing.Size(61, 17);
            this.rdQuanLy.TabIndex = 2;
            this.rdQuanLy.TabStop = true;
            this.rdQuanLy.Text = "Quản lý";
            this.rdQuanLy.UseVisualStyleBackColor = true;
            this.rdQuanLy.CheckedChanged += new System.EventHandler(this.rdQuanLy_CheckedChanged);
            // 
            // rdNhanVien
            // 
            this.rdNhanVien.AutoSize = true;
            this.rdNhanVien.Location = new System.Drawing.Point(523, 114);
            this.rdNhanVien.Name = "rdNhanVien";
            this.rdNhanVien.Size = new System.Drawing.Size(74, 17);
            this.rdNhanVien.TabIndex = 3;
            this.rdNhanVien.TabStop = true;
            this.rdNhanVien.Text = "Nhân viên";
            this.rdNhanVien.UseVisualStyleBackColor = true;
            this.rdNhanVien.CheckedChanged += new System.EventHandler(this.rdNhanVien_CheckedChanged);
            // 
            // crvNhanvien
            // 
            this.crvNhanvien.ActiveViewIndex = -1;
            this.crvNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanvien.DisplayGroupTree = false;
            this.crvNhanvien.Location = new System.Drawing.Point(12, 150);
            this.crvNhanvien.Name = "crvNhanvien";
            this.crvNhanvien.SelectionFormula = "";
            this.crvNhanvien.Size = new System.Drawing.Size(874, 338);
            this.crvNhanvien.TabIndex = 4;
            this.crvNhanvien.ViewTimeSelectionFormula = "";
            // 
            // FormBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 500);
            this.Controls.Add(this.crvNhanvien);
            this.Controls.Add(this.rdNhanVien);
            this.Controls.Add(this.rdQuanLy);
            this.Controls.Add(this.rdTatCa);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoNhanVien";
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.FormBaoCaoNhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.RadioButton rdQuanLy;
        private System.Windows.Forms.RadioButton rdNhanVien;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhanvien;
    }
}