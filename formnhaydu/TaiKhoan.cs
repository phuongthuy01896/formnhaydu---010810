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
    }
}
