using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace formnhaydu
{

    public partial class Main : Form
    {
        private Proceduce pro;
        DataTable datatable = new DataTable();
        DataView view;
        int nhom = 0;

        public Main(int x)
        {
            InitializeComponent();
            nhom = x;
            pro = new Proceduce();
            datatable = pro.checkDataInMain();
            LoadcmbDiaHinh();
            LoadcmbMayBay();

            dgvDanhSachNhayDu.Rows.Clear();
            

        }
        public Main()
        {
            InitializeComponent();
            //   datatb = pro.checkDataInMain();
        }
        private void QLChiHuyNhayDu_Click(object sender, EventArgs e)
        {
            Visible = false;
            QLChiHuyNhayDu QLCHND = new QLChiHuyNhayDu(nhom);
            QLCHND.ShowDialog();
            Visible = true;
        }

        private void QLGiaoVienDu_Click(object sender, EventArgs e)
        {
            Visible = false;
            QLGiaoVienDu QLGVD = new QLGiaoVienDu();
            QLGVD.ShowDialog();
            Visible = true;
        }

        private void QLNguoiNhayDu_Click(object sender, EventArgs e)
        {
            Visible = false;
            QLNguoiNhayDu QLNND = new QLNguoiNhayDu();
            QLNND.ShowDialog();
            Visible = true;
        }

        private void QLKetQua_Click(object sender, EventArgs e)
        {
            Visible = false;
            QLKetQua QLKQ = new QLKetQua();
            QLKQ.ShowDialog();
            Visible = true;
        }

        private void TaiKhoan_click(object sender, EventArgs e)
        {
            if (nhom == 1)
            {
                TaiKhoan TK = new TaiKhoan();
                TK.ShowDialog();
            }
            else
            { }
        }

        private void addDataInDatabase()
        {
            int row = Proceduce.dataExcel.Count;
            for (int i = 0; i < row; i++)
            {
                List<string> dataRow = Proceduce.dataExcel[i];
                int col = dataRow.Count;
                DataRow[] r;
                try
                {
                   // r = datatable.Select("MaNND='" + dataRow[1] + "'");
                   // DataTable dbtest = new DataTable();
                   // dgvDanhSachNhayDu.SelectedColumns[1].;
                   
                   
                        if(!checkdatagridview(dataRow[1]))
                            {
                            String[] roROw = { dgvDanhSachNhayDu.Rows.Count.ToString(), dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4] };
                            dgvDanhSachNhayDu.Rows.Add(roROw);
                        }
                    
                    
                }
                catch
                {
                    String[] roROw = { dgvDanhSachNhayDu.Rows.Count.ToString(), dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4] };
                    dgvDanhSachNhayDu.Rows.Add(roROw);
                }
            }
        }
        private bool checkdatagridview(String searchValue)
        {
            foreach (DataGridViewRow row in dgvDanhSachNhayDu.Rows)
            {
                if (row.Cells[2].Value.ToString().Equals(searchValue))
                {
                    return true;
                }
            }
            return false;
        }
        private void LoadExcel_Click(object sender, EventArgs e)
        {
            pro = new Proceduce();
            pro.openFileDialog_Excel();
            this.addDataInDatabase();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cmbDiaHinh.Text = "";
            cmbMayBay.Text = "";
            txtHuongGio.Clear();
            txtVanTocGio.Clear();
        }

        private void LoadcmbDiaHinh()
        {
            pro = new Proceduce();
            cmbDiaHinh.DataSource = pro.loadDiaHinh();
            cmbDiaHinh.ValueMember = "IDDiaHinh";
            cmbDiaHinh.DisplayMember = "TenDiaHinh";
        }

        private void LoadcmbMayBay()
        {
            pro = new Proceduce();
            cmbMayBay.DataSource = pro.loadMayBay();
            cmbMayBay.ValueMember = "IDMayBay";
            cmbMayBay.DisplayMember = "TenMayBay";
        }
    }
}
