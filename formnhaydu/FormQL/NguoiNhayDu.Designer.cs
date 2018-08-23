namespace formnhaydu
{
    partial class QLNguoiNhayDu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNguoiNhayDu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.cmbCapBac = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtMaNND = new System.Windows.Forms.TextBox();
            this.txtTenNguoiND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.dgvNguoiNhayDu = new System.Windows.Forms.DataGridView();
            this.erHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.erMaNND = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiNhayDu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erMaNND)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLoadExcel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(108, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 73);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(209, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 73);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(657, 47);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(204, 20);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXuatExcel.Location = new System.Drawing.Point(515, 16);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(96, 73);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất file";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(311, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 73);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::formnhaydu.Properties.Resources.them;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(6, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 73);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.FlatAppearance.BorderSize = 0;
            this.btnLoadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadExcel.Image")));
            this.btnLoadExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadExcel.Location = new System.Drawing.Point(413, 16);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(96, 73);
            this.btnLoadExcel.TabIndex = 10;
            this.btnLoadExcel.Text = "Chọn tệp..";
            this.btnLoadExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // cmbCapBac
            // 
            this.cmbCapBac.FormattingEnabled = true;
            this.cmbCapBac.Items.AddRange(new object[] {
            "Thiếu úy",
            "Trung úy",
            "Thượng úy",
            "Đai úy",
            "Thiếu tá",
            "Trung tá",
            "Thượng tá",
            "Đại tá",
            "Thiếu tướng",
            "Trung tướng",
            "Thượng tướng",
            "Đại tướng"});
            this.cmbCapBac.Location = new System.Drawing.Point(114, 122);
            this.cmbCapBac.Name = "cmbCapBac";
            this.cmbCapBac.Size = new System.Drawing.Size(112, 21);
            this.cmbCapBac.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(114, 245);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(186, 50);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtDonVi
            // 
            this.txtDonVi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonVi.Location = new System.Drawing.Point(114, 169);
            this.txtDonVi.Multiline = true;
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(186, 50);
            this.txtDonVi.TabIndex = 4;
            // 
            // txtMaNND
            // 
            this.txtMaNND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNND.Location = new System.Drawing.Point(114, 73);
            this.txtMaNND.Name = "txtMaNND";
            this.txtMaNND.Size = new System.Drawing.Size(186, 20);
            this.txtMaNND.TabIndex = 2;
            this.txtMaNND.TextChanged += new System.EventHandler(this.txtMaNND_TextChanged);
            // 
            // txtTenNguoiND
            // 
            this.txtTenNguoiND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNguoiND.Location = new System.Drawing.Point(114, 29);
            this.txtTenNguoiND.Name = "txtTenNguoiND";
            this.txtTenNguoiND.Size = new System.Drawing.Size(186, 20);
            this.txtTenNguoiND.TabIndex = 1;
            this.txtTenNguoiND.TextChanged += new System.EventHandler(this.txtTenNguoiND_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã số NND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cấp bậc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.txtMaNND);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCapBac);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDonVi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenNguoiND);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng số người nhảy dù: ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.lbSoLuong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dgvNguoiNhayDu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(329, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 388);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách  người nhảy dù";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(457, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(13, 13);
            this.lbSoLuong.TabIndex = 10;
            this.lbSoLuong.Text = "0";
            // 
            // dgvNguoiNhayDu
            // 
            this.dgvNguoiNhayDu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNguoiNhayDu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiNhayDu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiNhayDu.Location = new System.Drawing.Point(3, 16);
            this.dgvNguoiNhayDu.Name = "dgvNguoiNhayDu";
            this.dgvNguoiNhayDu.Size = new System.Drawing.Size(543, 369);
            this.dgvNguoiNhayDu.TabIndex = 13;
            this.dgvNguoiNhayDu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiNhayDu_CellClick);
            // 
            // erHoTen
            // 
            this.erHoTen.ContainerControl = this;
            // 
            // erMaNND
            // 
            this.erMaNND.ContainerControl = this;
            // 
            // QLNguoiNhayDu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QLNguoiNhayDu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NguoiNhayDu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiNhayDu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erMaNND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbCapBac;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtMaNND;
        private System.Windows.Forms.TextBox txtTenNguoiND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvNguoiNhayDu;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.ErrorProvider erHoTen;
        private System.Windows.Forms.ErrorProvider erMaNND;
        private System.Windows.Forms.Button btnXoa;
    }
}