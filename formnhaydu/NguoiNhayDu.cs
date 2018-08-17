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
using Excel = Microsoft.Office.Interop.Excel;

namespace formnhaydu
{
    public partial class QLNguoiNhayDu : Form
    {
        private Proceduce pro;
        int row = -1;
        int column = -1;
        int user = 0;
        int id;
        int status = 1;
        DataView view;
        public QLNguoiNhayDu()
        {
            InitializeComponent();
            LoadcmbCapBac();
            loadDataNguoiNhayDu();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        /// <summary>
        /// Xet tai khoan phan quyen
        /// </summary>
        /// <param name="x"></param>
        public QLNguoiNhayDu(int x)
        {
            user = x;//xét tài khoản
            InitializeComponent();
            if (x == 2)
            {
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = 1;
            txtTenNguoiND.Clear();
            txtMaNND.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenNguoiND.Clear();
            txtMaNND.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pro.XoaNguoiNhayDu(id);
                dgvNguoiNhayDu.DataSource = pro.getNguoiNhayDu();
                txtTenNguoiND.Clear();
                txtMaNND.Clear();
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
            if (status == 1) themNguoiNhayDu();
            else if (status == 2) suaNguoiNhayDu();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvNguoiNhayDu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (row == dgvNguoiNhayDu.CurrentCell.RowIndex && column == dgvNguoiNhayDu.CurrentCell.ColumnIndex)
            {
                dgvNguoiNhayDu.Rows[row].Cells[column].ReadOnly = true;
            }
            else if (row != -1 && column != -1)
            {
                dgvNguoiNhayDu.Rows[row].Cells[column].ReadOnly = false;
                column = dgvNguoiNhayDu.CurrentCell.ColumnIndex;
                row = dgvNguoiNhayDu.CurrentCell.RowIndex;
            }
            else
            {
                column = dgvNguoiNhayDu.CurrentCell.ColumnIndex;
                row = dgvNguoiNhayDu.CurrentCell.RowIndex;
            }
            //if (user == 1)
            //{
            int index = dgvNguoiNhayDu.CurrentCell.RowIndex;
            if (index < dgvNguoiNhayDu.RowCount - 1)
            {
                int indexcol = dgvNguoiNhayDu.CurrentCell.ColumnIndex;
                id = int.Parse(dgvNguoiNhayDu.Rows[index].Cells[0].Value.ToString());
                if (indexcol != dgvNguoiNhayDu.ColumnCount - 1)
                {
                    status = 2;
                    txtTenNguoiND.Text = dgvNguoiNhayDu.Rows[index].Cells[1].Value.ToString();
                    txtMaNND.Text = dgvNguoiNhayDu.Rows[index].Cells[2].Value.ToString();
                    cmbCapBac.Text = dgvNguoiNhayDu.Rows[index].Cells[3].Value.ToString();
                    txtDonVi.Text = dgvNguoiNhayDu.Rows[index].Cells[4].Value.ToString();
                    txtGhiChu.Text = dgvNguoiNhayDu.Rows[index].Cells[5].Value.ToString();
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
            else
            {
                txtTenNguoiND.Clear();
                txtMaNND.Clear();
                txtDonVi.Clear();
                txtGhiChu.Clear();
            }
            //}
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            view = pro.getNguoiNhayDu().DefaultView;
            dgvNguoiNhayDu.DataSource = view;
            string output = "";
            string[] KeyWord = txtTimKiem.Text.Split(' ');
            if (txtTimKiem.Text != "Tìm kiếm...")
            {

                foreach (string word in KeyWord)
                {
                    if (output.Length == 0)
                    {
                        output = "TenNguoiND LIKE '%" + word + "%'";
                    }
                    else
                    {
                        output += "AND TenNguoiND like '%" + word + "%'";
                    }
                    view.RowFilter = output;

                }
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
                for (int i = 0; i < dgvNguoiNhayDu.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dgvNguoiNhayDu.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvNguoiNhayDu.Columns[j].HeaderText;
                        }
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = dgvNguoiNhayDu.Rows[i].Cells[j].Value.ToString();
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

        private void loadDataNguoiNhayDu()
        {
            pro = new Proceduce();
            dgvNguoiNhayDu.DataSource = pro.getNguoiNhayDu();
            dgvNguoiNhayDu.Columns["IDNguoiND"].Visible = false;
            dgvNguoiNhayDu.Columns[1].HeaderText = "Họ Tên";
            dgvNguoiNhayDu.Columns[2].HeaderText = "Mã NND";
            dgvNguoiNhayDu.Columns[3].HeaderText = "Cấp Bậc";
            dgvNguoiNhayDu.Columns[4].HeaderText = "Đơn vị";
            dgvNguoiNhayDu.Columns[5].HeaderText = "Ghi chú";
            lbSoLuong.Text = (dgvNguoiNhayDu.RowCount - 1).ToString();

        }

        private void themNguoiNhayDu()
        {
            status = 1;
            pro = new Proceduce();
            pro.ThemNguoiNhayDu(txtTenNguoiND.Text, txtMaNND.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            txtTenNguoiND.Clear();
            txtMaNND.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            loadDataNguoiNhayDu();
        }

        private void suaNguoiNhayDu()
        {
            status = 2;
            pro.SuaNguoiNhayDu(id.ToString(), txtTenNguoiND.Text, txtMaNND.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            dgvNguoiNhayDu.DataSource = pro.getNguoiNhayDu();
            btnThem.Enabled = true;
            txtTenNguoiND.Clear();
            txtMaNND.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            loadDataNguoiNhayDu();
        }

        private void addDataInDatabase()
        {
            int row = Proceduce.dataExcel.Count;
            for (int i = 0; i < row; i++)
            {
                List<string> dataRow = Proceduce.dataExcel[i];
                int col = dataRow.Count;
                if (pro.checkDataNND(dataRow[1]))
                {
                    pro.ThemNguoiNhayDu(dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4]);
                    view = pro.getNguoiNhayDu().DefaultView;
                    dgvNguoiNhayDu.DataSource = view;
                    loadDataNguoiNhayDu();
                }
            }
        }

        private void txtTenNguoiND_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTenNguoiND.Text, @"^[a-zA-uZ-ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ- ]+$"))
            {
                erHoTen.SetError(txtTenNguoiND, "Hợp lệ!");
                erHoTen.Icon = Properties.Resources.check;
            }
            else
            {
                erHoTen.SetError(txtTenNguoiND, "Nhập chữ cái!");
                erHoTen.Icon = Properties.Resources.error;
            }
        }

        private void txtMaNND_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMaNND.Text, @"^[a-zA-Z0-9]+$") && txtMaNND.Text.Length <= 20)
            {
                erMaNND.SetError(txtMaNND, "Hợp lệ!");
                erMaNND.Icon = Properties.Resources.check;
            }
            else
            {
                erMaNND.SetError(txtMaNND, "Nhập dưới 20 kí tự, không nhập kí tự đặc biệt");
                erMaNND.Icon = Properties.Resources.error;
            }
        }
    }
}