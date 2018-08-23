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
    public partial class TaiKhoan : Form
    {
        Proceduce pro = new Proceduce();
        public TaiKhoan()
        {
            InitializeComponent();
            SQLiteConnection connection;
            connection = new SQLiteConnection("Data Source = C:\\SQLite3\\Nhaydu.db");
            connection.Open();
            SQLiteCommand cm = new SQLiteCommand(@"select IDChiHuyND,TenChiHuyND,CMSQ,CapBac,DonVi,GhiChu from ChiHuyNhayDu inner join CapBac on ChiHuyNhayDu.IDCapBac = CapBac.IDCapBac;", connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
        }
        private void Main_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.ShowDialog();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == txtNhapLaiMK.Text)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                pro.ThemTaiKhoan(txtTenTaiKhoan.Text, txtMatKhau.Text, 2);
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp");
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMK.Clear();
        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTenTaiKhoan.Text, @"^[a-zA-Z0-9]+$") && txtTenTaiKhoan.Text.Length <= 20)
            {
                erTenTaiKhoan.SetError(txtTenTaiKhoan, "Hợp lệ!");
                erTenTaiKhoan.Icon = Properties.Resources.check;
            }
            else
            {
                erTenTaiKhoan.SetError(txtTenTaiKhoan, "Nhập dưới 20 kí tự, không nhập kí tự đặc biệt");
                erTenTaiKhoan.Icon = Properties.Resources.error;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMatKhau.Text, @"^[a-zA-Z0-9]+$") && txtMatKhau.Text.Length <= 10)
            {
                erMatKhau.SetError(txtMatKhau, "Hợp lệ!");
                erMatKhau.Icon = Properties.Resources.check;
            }
            else
            {
                erMatKhau.SetError(txtMatKhau, "Nhập dưới 20 kí tự, không nhập kí tự đặc biệt");
                erMatKhau.Icon = Properties.Resources.error;
            }
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == txtMatKhau.Text)
            {
                erNhapLaiMK.SetError(txtNhapLaiMK, "Hợp lệ!");
                erNhapLaiMK.Icon = Properties.Resources.check;
            }
            else
            {
                erNhapLaiMK.SetError(txtNhapLaiMK, "Mật khẩu không khớp!");
                erNhapLaiMK.Icon = Properties.Resources.error;
            }
        }
    }
}
