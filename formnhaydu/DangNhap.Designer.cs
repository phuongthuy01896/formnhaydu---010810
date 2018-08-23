namespace formnhaydu
{
    partial class DangNhap
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
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.erTenDangNhap = new System.Windows.Forms.ErrorProvider(this.components);
            this.erMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(51, 101);
            this.txtTenTaiKhoan.MaximumSize = new System.Drawing.Size(250, 250);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(250, 26);
            this.txtTenTaiKhoan.TabIndex = 1;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            this.txtTenTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenTaiKhoan_KeyDown);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMatKhau.Location = new System.Drawing.Point(51, 158);
            this.txtMatKhau.MaximumSize = new System.Drawing.Size(250, 250);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(250, 26);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenTaiKhoan_KeyDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangNhap.Location = new System.Drawing.Point(0, 220);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(357, 70);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Sitka Display", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbTitle.Location = new System.Drawing.Point(64, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(227, 29);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(60, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 9;
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(51, 82);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(78, 13);
            this.lbTenDangNhap.TabIndex = 10;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(54, 139);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(53, 13);
            this.lbMatKhau.TabIndex = 11;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // erTenDangNhap
            // 
            this.erTenDangNhap.ContainerControl = this;
            // 
            // erMatKhau
            // 
            this.erMatKhau.ContainerControl = this;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.erTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.ErrorProvider erTenDangNhap;
        private System.Windows.Forms.ErrorProvider erMatKhau;
    }
}