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
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace formnhaydu
{
    public partial class QLChiHuyNhayDu : Form
    {
        private Proceduce pro;
        int user = 0;
        int id;
        int status = 1;
        int row = -1;
        int column = -1;
        bool testName = true;
        bool testCMSQ = true;
        DataView view;
        public QLChiHuyNhayDu()
        {
            InitializeComponent();
            LoadcmbCapBac();
            loadDataChiHuyND();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        /// <summary>
        /// Xet tai khoan phan quyen
        /// </summary>
        /// <param name="x"></param>
        public QLChiHuyNhayDu(int x)
        {

            InitializeComponent();
            LoadcmbCapBac();
            user = x;//xét tài khoản
            if (x == 2)
            {
                dgvChiHuyND.ReadOnly = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
            }
            loadDataChiHuyND();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = 1;
            txtTenChiHuyND.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenChiHuyND.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pro.XoaChiHuyNhayDu(id);
                dgvChiHuyND.DataSource = pro.getChiHuyNhayDu();
                txtTenChiHuyND.Clear();
                txtCMSQ.Clear();
                txtDonVi.Clear();
                txtGhiChu.Clear();
                cmbCapBac.Text = "";
                MessageBox.Show("Xóa thành công!");
                btnXoa.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (status == 1 && testName && testCMSQ) themChiHuyND();
            else if (status == 2 && testName && testCMSQ) suaChiHuyND();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvChiHuyND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (row == dgvChiHuyND.CurrentCell.RowIndex && column == dgvChiHuyND.CurrentCell.ColumnIndex)
            {
                dgvChiHuyND.Rows[row].Cells[column].ReadOnly = true;
            }
            else if (row != -1 && column != -1)
            {
                dgvChiHuyND.Rows[row].Cells[column].ReadOnly = false;
                column = dgvChiHuyND.CurrentCell.ColumnIndex;
                row = dgvChiHuyND.CurrentCell.RowIndex;
            }
            else
            {
                column = dgvChiHuyND.CurrentCell.ColumnIndex;
                row = dgvChiHuyND.CurrentCell.RowIndex;
            }
            if (user == 1)
            {

                int index = dgvChiHuyND.CurrentCell.RowIndex;
                if (index < dgvChiHuyND.RowCount - 1)
                {
                    int indexcol = dgvChiHuyND.CurrentCell.ColumnIndex;
                    id = int.Parse(dgvChiHuyND.Rows[index].Cells[0].Value.ToString());
                    if (indexcol != dgvChiHuyND.ColumnCount - 1)
                    {
                        status = 2;
                        txtTenChiHuyND.Text = dgvChiHuyND.Rows[index].Cells[1].Value.ToString();
                        txtCMSQ.Text = dgvChiHuyND.Rows[index].Cells[2].Value.ToString();
                        cmbCapBac.Text = dgvChiHuyND.Rows[index].Cells[3].Value.ToString();
                        txtDonVi.Text = dgvChiHuyND.Rows[index].Cells[4].Value.ToString();
                        txtGhiChu.Text = dgvChiHuyND.Rows[index].Cells[5].Value.ToString();
                        btnXoa.Enabled = true;
                        btnLuu.Enabled = true;
                        btnHuy.Enabled = true;
                    }
                }
                else
                {
                    txtTenChiHuyND.Clear();
                    txtCMSQ.Clear();
                    txtDonVi.Clear();
                    txtGhiChu.Clear();
                }
            }
            else
            {
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            view = pro.getChiHuyNhayDu().DefaultView;
            dgvChiHuyND.DataSource = view;
            string output = "";
            string[] KeyWord = txtTimKiem.Text.Split(' ');
            if (txtTimKiem.Text != "Tìm kiếm...")


                foreach (string word in KeyWord)
                {
                    if (output.Length == 0)
                    {
                        output = "TenChiHuyND LIKE '%" + word + "%'";
                    }
                    else
                    {
                        output += "AND TenChiHuyND like '%" + word + "%'";
                    }
                    view.RowFilter = output;


                }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Tìm kiếm...";
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm...")
            {
                txtTimKiem.Text = "";
            }
        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            pro.openFileDialog_Excel();
            this.addDataInDatabase();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Excel._Application excel = new Excel.Application();
            Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";
                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dgvChiHuyND.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dgvChiHuyND.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvChiHuyND.Columns[j].HeaderText;
                        }
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = dgvChiHuyND.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 2;
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void LoadcmbCapBac()
        {
            pro = new Proceduce();
            cmbCapBac.DataSource = pro.loadCapBac();
            cmbCapBac.ValueMember = "IDCapBac";
            cmbCapBac.DisplayMember = "CapBac";
        }

        private void loadDataChiHuyND()
        {
            pro = new Proceduce();
            dgvChiHuyND.DataSource = pro.getChiHuyNhayDu();
            dgvChiHuyND.Columns["IDChiHuyND"].Visible = false;
            dgvChiHuyND.Columns[1].HeaderText = "Họ Tên";
            dgvChiHuyND.Columns[2].HeaderText = "CMSQ";
            dgvChiHuyND.Columns[3].HeaderText = "Cấp Bậc";
            dgvChiHuyND.Columns[4].HeaderText = "Đơn vị";
            dgvChiHuyND.Columns[5].HeaderText = "Ghi chú";
            lbSoLuong.Text = (dgvChiHuyND.RowCount - 1).ToString();
        }

        private void themChiHuyND()
        {
            status = 1;
            pro = new Proceduce();
            pro.ThemChiHuyNhayDu(txtTenChiHuyND.Text, txtCMSQ.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            txtTenChiHuyND.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            loadDataChiHuyND();
        }

        private void suaChiHuyND()
        {
            status = 2;
            pro.SuaChiHuyNhayDu(id.ToString(), txtTenChiHuyND.Text, txtCMSQ.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            dgvChiHuyND.DataSource = pro.getChiHuyNhayDu();
            btnThem.Enabled = true;
            txtTenChiHuyND.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            loadDataChiHuyND();
        }

        private void addDataInDatabase()
        {
            int row = Proceduce.dataExcel.Count;
            for (int i = 0; i < row; i++)
            {
                List<string> dataRow = Proceduce.dataExcel[i];
                int col = dataRow.Count;
                if (pro.checkData(dataRow[1]))
                {
                    pro.ThemChiHuyNhayDu(dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4]);
                    view = pro.getChiHuyNhayDu().DefaultView;
                    dgvChiHuyND.DataSource = view;
                    loadDataChiHuyND();
                }
            }
        }

        private void txtTenChiHuyND_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTenChiHuyND.Text, @"^[a-zA-uZ-ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ- ]+$"))
            {
                testName = true;
                erHoTen.SetError(txtTenChiHuyND, "Hợp lệ!");
                erHoTen.Icon = Properties.Resources.check;
            }
            else
            {
                testName = false; 
                erHoTen.SetError(txtTenChiHuyND, "Nhập chữ cái!");
                erHoTen.Icon = Properties.Resources.error;
            }
        }

        private void txtCMSQ_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCMSQ.Text, @"^[a-zA-Z0-9]+$") && txtCMSQ.Text.Length <= 20)
            {
                testCMSQ = true;
                erCMSQ.SetError(txtCMSQ, "Hợp lệ!");
                erCMSQ.Icon = Properties.Resources.check;
            }
            else
            {
                testCMSQ = false;
                erCMSQ.SetError(txtCMSQ, "Nhập dưới 20 kí tự, không nhập kí tự đặc biệt");
                erCMSQ.Icon = Properties.Resources.error;
            }
        }
    }
}
