using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace formnhaydu
{
    public partial class DangNhap : Form
    {
        Proceduce pro = new Proceduce();
        bool taikhoan = true;
        bool matkhau = true;
        public DangNhap()
        {
            InitializeComponent();
        }
        private void ktraTaiKhoan()
        {
            DataTable reader = pro.DangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text);
            if (reader.Rows.Count > 0 && reader.Rows[0][0] != null && reader.Rows[0][0].ToString().Trim() != "")
            {
                int x = int.Parse(reader.Rows[0][0].ToString());
                Visible = false;// ẩn form đăng nhập
                Form main = new Main(x);
                main.ShowDialog();
                Visible = true;
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                label2.Text = "Tên tài khoản hoặc mật khẩu không đúng!";
            }
        }
        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && taikhoan && matkhau)
            {
                ktraTaiKhoan();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(taikhoan && matkhau)
            ktraTaiKhoan();
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTenTaiKhoan.Text, @"^[a-zA-Z0-9]+$"))
            {
                erTenDangNhap.SetError(txtTenTaiKhoan, "Hợp lệ!");
                erTenDangNhap.Icon = Properties.Resources.check;
                taikhoan = true;
            }
            else
            {
                erTenDangNhap.SetError(txtTenTaiKhoan, "Không nhập kí tự đặc biệt!");
                erTenDangNhap.Icon = Properties.Resources.error;
                taikhoan = false;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMatKhau.Text, @"^[a-zA-Z0-9]+$"))
            {
                matkhau = true;
                erMatKhau.SetError(txtMatKhau, "Hợp lệ!");
                erMatKhau.Icon = Properties.Resources.check;
            }
            else
            {
                matkhau = false;
                erMatKhau.SetError(txtMatKhau, "Không nhập kí tự đặc biệt!");
                erMatKhau.Icon = Properties.Resources.error;
            }
        }
    }
}
