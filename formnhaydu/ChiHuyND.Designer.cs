namespace formnhaydu
{
    partial class QLChiHuyNhayDu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLChiHuyNhayDu));
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtCMSQ = new System.Windows.Forms.TextBox();
            this.txtTenChiHuyND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.dgvChiHuyND = new System.Windows.Forms.DataGridView();
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.cmbCapBac = new System.Windows.Forms.ComboBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.NhapThongTin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.erHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.erCMSQ = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiHuyND)).BeginInit();
            this.TimKiem.SuspendLayout();
            this.NhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCMSQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng số chỉ huy nhảy dù:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(690, 46);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(176, 20);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(118, 242);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(186, 50);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(118, 166);
            this.txtDonVi.Multiline = true;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(186, 50);
            this.txtDonVi.TabIndex = 4;
            // 
            // txtCMSQ
            // 
            this.txtCMSQ.Location = new System.Drawing.Point(118, 70);
            this.txtCMSQ.Name = "txtCMSQ";
            this.txtCMSQ.Size = new System.Drawing.Size(186, 20);
            this.txtCMSQ.TabIndex = 2;
            this.txtCMSQ.TextChanged += new System.EventHandler(this.txtCMSQ_TextChanged);
            // 
            // txtTenChiHuyND
            // 
            this.txtTenChiHuyND.Location = new System.Drawing.Point(118, 26);
            this.txtTenChiHuyND.Name = "txtTenChiHuyND";
            this.txtTenChiHuyND.Size = new System.Drawing.Size(186, 20);
            this.txtTenChiHuyND.TabIndex = 1;
            this.txtTenChiHuyND.TextChanged += new System.EventHandler(this.txtTenChiHuyND_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số CMSQ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cấp bậc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.lbSoLuong);
            this.groupBox3.Controls.Add(this.dgvChiHuyND);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(329, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 388);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách chỉ huy nhảy dù";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(503, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(13, 13);
            this.lbSoLuong.TabIndex = 6;
            this.lbSoLuong.Text = "0";
            // 
            // dgvChiHuyND
            // 
            this.dgvChiHuyND.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvChiHuyND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiHuyND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiHuyND.Location = new System.Drawing.Point(3, 16);
            this.dgvChiHuyND.Name = "dgvChiHuyND";
            this.dgvChiHuyND.Size = new System.Drawing.Size(543, 369);
            this.dgvChiHuyND.TabIndex = 13;
            this.dgvChiHuyND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiHuyND_CellClick);
            this.dgvChiHuyND.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiHuyND_CellEnter);
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.Snow;
            this.TimKiem.Controls.Add(this.txtCMSQ);
            this.TimKiem.Controls.Add(this.label1);
            this.TimKiem.Controls.Add(this.cmbCapBac);
            this.TimKiem.Controls.Add(this.label2);
            this.TimKiem.Controls.Add(this.txtGhiChu);
            this.TimKiem.Controls.Add(this.label3);
            this.TimKiem.Controls.Add(this.txtDonVi);
            this.TimKiem.Controls.Add(this.label4);
            this.TimKiem.Controls.Add(this.label5);
            this.TimKiem.Controls.Add(this.txtTenChiHuyND);
            this.TimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimKiem.Location = new System.Drawing.Point(0, 93);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(329, 388);
            this.TimKiem.TabIndex = 4;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Nhập thông tin";
            // 
            // cmbCapBac
            // 
            this.cmbCapBac.FormattingEnabled = true;
            this.cmbCapBac.Location = new System.Drawing.Point(118, 115);
            this.cmbCapBac.Name = "cmbCapBac";
            this.cmbCapBac.Size = new System.Drawing.Size(112, 21);
            this.cmbCapBac.TabIndex = 3;
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.BackColor = System.Drawing.Color.Snow;
            this.btnLoadExcel.FlatAppearance.BorderSize = 0;
            this.btnLoadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadExcel.Image")));
            this.btnLoadExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadExcel.Location = new System.Drawing.Point(420, 18);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(96, 73);
            this.btnLoadExcel.TabIndex = 8;
            this.btnLoadExcel.Text = "Chọn tệp..";
            this.btnLoadExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadExcel.UseVisualStyleBackColor = false;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.Snow;
            this.btnXuatFile.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatFile.Location = new System.Drawing.Point(522, 18);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(96, 73);
            this.btnXuatFile.TabIndex = 9;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // NhapThongTin
            // 
            this.NhapThongTin.BackColor = System.Drawing.Color.Snow;
            this.NhapThongTin.Controls.Add(this.btnXoa);
            this.NhapThongTin.Controls.Add(this.btnHuy);
            this.NhapThongTin.Controls.Add(this.btnLuu);
            this.NhapThongTin.Controls.Add(this.btnXuatFile);
            this.NhapThongTin.Controls.Add(this.btnLoadExcel);
            this.NhapThongTin.Controls.Add(this.txtTimKiem);
            this.NhapThongTin.Controls.Add(this.btnThem);
            this.NhapThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.NhapThongTin.Location = new System.Drawing.Point(0, 0);
            this.NhapThongTin.Name = "NhapThongTin";
            this.NhapThongTin.Size = new System.Drawing.Size(878, 93);
            this.NhapThongTin.TabIndex = 3;
            this.NhapThongTin.TabStop = false;
            this.NhapThongTin.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Snow;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(113, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 73);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Snow;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(318, 18);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 73);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Snow;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(216, 18);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 73);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Snow;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::formnhaydu.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(11, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 73);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseCompatibleTextRendering = true;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // erHoTen
            // 
            this.erHoTen.ContainerControl = this;
            // 
            // erCMSQ
            // 
            this.erCMSQ.ContainerControl = this;
            // 
            // QLChiHuyNhayDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.NhapThongTin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1005, 520);
            this.MinimizeBox = false;
            this.Name = "QLChiHuyNhayDu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thông tin chỉ huy nhảy dù";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiHuyND)).EndInit();
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            this.NhapThongTin.ResumeLayout(false);
            this.NhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erCMSQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtCMSQ;
        private System.Windows.Forms.TextBox txtTenChiHuyND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvChiHuyND;
        private System.Windows.Forms.GroupBox TimKiem;
        private System.Windows.Forms.GroupBox NhapThongTin;
        private System.Windows.Forms.ComboBox cmbCapBac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.ErrorProvider erHoTen;
        private System.Windows.Forms.ErrorProvider erCMSQ;
        private System.Windows.Forms.Button btnXoa;
    }
}