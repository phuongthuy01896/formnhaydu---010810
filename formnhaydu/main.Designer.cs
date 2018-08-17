namespace formnhaydu
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDanhSachNhayDu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoiND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDiaHinh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMayBay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHuongGio = new System.Windows.Forms.TextBox();
            this.txtVanTocGio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.LoadExcel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLChiHuyNhayDu = new System.Windows.Forms.ToolStripMenuItem();
            this.QLGiaoVienDu = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNguoiNhayDu = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupB = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhayDu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupB.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 649);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dgvDanhSachNhayDu);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbDiaHinh);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbMayBay);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHuongGio);
            this.groupBox4.Controls.Add(this.txtVanTocGio);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(707, 523);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ĐIỀU KIỆN NHẢY DÙ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(626, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "m/s";
            // 
            // dgvDanhSachNhayDu
            // 
            this.dgvDanhSachNhayDu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachNhayDu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhayDu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNguoiND,
            this.MaNND,
            this.CapBac,
            this.DonVi,
            this.GhiChu});
            this.dgvDanhSachNhayDu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDanhSachNhayDu.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachNhayDu.Name = "dgvDanhSachNhayDu";
            this.dgvDanhSachNhayDu.Size = new System.Drawing.Size(394, 504);
            this.dgvDanhSachNhayDu.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 63.45178F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // TenNguoiND
            // 
            this.TenNguoiND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNguoiND.FillWeight = 93.27411F;
            this.TenNguoiND.HeaderText = "Họ tên";
            this.TenNguoiND.Name = "TenNguoiND";
            // 
            // MaNND
            // 
            this.MaNND.FillWeight = 93.27411F;
            this.MaNND.HeaderText = "Mã NND";
            this.MaNND.Name = "MaNND";
            // 
            // CapBac
            // 
            this.CapBac.HeaderText = "Cấp Bậc";
            this.CapBac.Name = "CapBac";
            this.CapBac.Visible = false;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn vị";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = false;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "độ";
            // 
            // cmbDiaHinh
            // 
            this.cmbDiaHinh.BackColor = System.Drawing.Color.White;
            this.cmbDiaHinh.FormattingEnabled = true;
            this.cmbDiaHinh.Location = new System.Drawing.Point(533, 36);
            this.cmbDiaHinh.Name = "cmbDiaHinh";
            this.cmbDiaHinh.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaHinh.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "HƯỚNG GIÓ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "VẬN TỐC GIÓ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ĐỊA HÌNH SB";
            // 
            // cmbMayBay
            // 
            this.cmbMayBay.FormattingEnabled = true;
            this.cmbMayBay.Location = new System.Drawing.Point(533, 83);
            this.cmbMayBay.Name = "cmbMayBay";
            this.cmbMayBay.Size = new System.Drawing.Size(121, 21);
            this.cmbMayBay.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(436, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "MÁY BAY";
            // 
            // txtHuongGio
            // 
            this.txtHuongGio.Location = new System.Drawing.Point(533, 133);
            this.txtHuongGio.Name = "txtHuongGio";
            this.txtHuongGio.Size = new System.Drawing.Size(87, 20);
            this.txtHuongGio.TabIndex = 12;
            // 
            // txtVanTocGio
            // 
            this.txtVanTocGio.Location = new System.Drawing.Point(533, 179);
            this.txtVanTocGio.Name = "txtVanTocGio";
            this.txtVanTocGio.Size = new System.Drawing.Size(87, 20);
            this.txtVanTocGio.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.btnEnd);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.LoadExcel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(707, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnd.Location = new System.Drawing.Point(373, 15);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(102, 62);
            this.btnEnd.TabIndex = 18;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(251, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 62);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(129, 15);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 62);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // LoadExcel
            // 
            this.LoadExcel.BackColor = System.Drawing.Color.Snow;
            this.LoadExcel.FlatAppearance.BorderSize = 0;
            this.LoadExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExcel.Image = ((System.Drawing.Image)(resources.GetObject("LoadExcel.Image")));
            this.LoadExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadExcel.Location = new System.Drawing.Point(9, 15);
            this.LoadExcel.Name = "LoadExcel";
            this.LoadExcel.Size = new System.Drawing.Size(102, 62);
            this.LoadExcel.TabIndex = 17;
            this.LoadExcel.Text = "Chọn tệp";
            this.LoadExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LoadExcel.UseVisualStyleBackColor = false;
            this.LoadExcel.Click += new System.EventHandler(this.LoadExcel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Snow;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.QuanLyToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoMớiToolStripMenuItem,
            this.mởBàiTậpToolStripMenuItem,
            this.lưuBàiTậpToolStripMenuItem,
            this.TaiKhoan});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            // 
            // mởBàiTậpToolStripMenuItem
            // 
            this.mởBàiTậpToolStripMenuItem.Name = "mởBàiTậpToolStripMenuItem";
            this.mởBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mởBàiTậpToolStripMenuItem.Text = "Mở bài tập";
            // 
            // lưuBàiTậpToolStripMenuItem
            // 
            this.lưuBàiTậpToolStripMenuItem.Name = "lưuBàiTậpToolStripMenuItem";
            this.lưuBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lưuBàiTậpToolStripMenuItem.Text = "Lưu bài tập";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Size = new System.Drawing.Size(152, 22);
            this.TaiKhoan.Text = "Tạo tài khoản";
            this.TaiKhoan.Click += new System.EventHandler(this.TaiKhoan_click);
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLChiHuyNhayDu,
            this.QLGiaoVienDu,
            this.QLNguoiNhayDu,
            this.QLKetQua});
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.QuanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // QLChiHuyNhayDu
            // 
            this.QLChiHuyNhayDu.Name = "QLChiHuyNhayDu";
            this.QLChiHuyNhayDu.Size = new System.Drawing.Size(255, 22);
            this.QLChiHuyNhayDu.Text = "Quản lý thông tin chỉ huy nhảy dù";
            this.QLChiHuyNhayDu.Click += new System.EventHandler(this.QLChiHuyNhayDu_Click);
            // 
            // QLGiaoVienDu
            // 
            this.QLGiaoVienDu.Name = "QLGiaoVienDu";
            this.QLGiaoVienDu.Size = new System.Drawing.Size(255, 22);
            this.QLGiaoVienDu.Text = "Quản lý thông tin giáo viên dù";
            this.QLGiaoVienDu.Click += new System.EventHandler(this.QLGiaoVienDu_Click);
            // 
            // QLNguoiNhayDu
            // 
            this.QLNguoiNhayDu.Name = "QLNguoiNhayDu";
            this.QLNguoiNhayDu.Size = new System.Drawing.Size(255, 22);
            this.QLNguoiNhayDu.Text = "Quản lý thông tin người nhảy dù";
            this.QLNguoiNhayDu.Click += new System.EventHandler(this.QLNguoiNhayDu_Click);
            // 
            // QLKetQua
            // 
            this.QLKetQua.Name = "QLKetQua";
            this.QLKetQua.Size = new System.Drawing.Size(255, 22);
            this.QLKetQua.Text = "Quản lý kết quả";
            this.QLKetQua.Click += new System.EventHandler(this.QLKetQua_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // groupB
            // 
            this.groupB.BackColor = System.Drawing.Color.White;
            this.groupB.Controls.Add(this.groupBox5);
            this.groupB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupB.Location = new System.Drawing.Point(713, 0);
            this.groupB.Margin = new System.Windows.Forms.Padding(0);
            this.groupB.Name = "groupB";
            this.groupB.Padding = new System.Windows.Forms.Padding(0);
            this.groupB.Size = new System.Drawing.Size(651, 649);
            this.groupB.TabIndex = 1;
            this.groupB.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Snow;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(651, 52);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số NND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1364, 649);
            this.Controls.Add(this.groupB);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhayDu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupB.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem QLChiHuyNhayDu;
        private System.Windows.Forms.ToolStripMenuItem QLGiaoVienDu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDanhSachNhayDu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button LoadExcel;
        private System.Windows.Forms.ComboBox cmbMayBay;
        private System.Windows.Forms.ComboBox cmbDiaHinh;
        private System.Windows.Forms.TextBox txtVanTocGio;
        private System.Windows.Forms.TextBox txtHuongGio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem QLNguoiNhayDu;
        private System.Windows.Forms.ToolStripMenuItem QLKetQua;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởBàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuBàiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoiND;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNND;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}