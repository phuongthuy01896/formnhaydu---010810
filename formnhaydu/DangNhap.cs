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

namespace formnhaydu
{
    public partial class DangNhap : Form
    {
        Proceduce pro = new Proceduce();
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
                //MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                label2.Text = "Tên tài khoản hoặc mật khẩu không đúng!";
                //txtTenTaiKhoan.Clear();
                //txtMatKhau.Clear();
            }
        }
        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                ktraTaiKhoan();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ktraTaiKhoan();
        }
    }
}
