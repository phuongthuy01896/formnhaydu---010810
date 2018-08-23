using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace formnhaydu
{
    public partial class QLGiaoVienDu : Form
    {
        private Proceduce pro;
        int user = 0;
        int row = -1;
        int column = -1;
        int id;
        int status = 1;
        bool testName = true;
        bool testCMSQ = true;
        DataView view;
        public QLGiaoVienDu()
        {
            InitializeComponent();
            LoadcmbCapBac();
            loadDataGiaoVienDu();
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        
       

        /// <summary>
        /// Xet tai khoan phan quyen
        /// </summary>
        /// <param name="x"></param>
        //public QLGiaoVienDu(int x)
        //{
        //    user = x;//xét tài khoản
        //    InitializeComponent();
        //    if (x == 2)
        //    {
        //        btnThem.Enabled = false;
        //        btnLuu.Enabled = false;
        //    }
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = 1;
            txtTenGiaoVien.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenGiaoVien.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa?", "Xóa thông tin", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pro.XoaGiaoVienDu(id);
                dgvGiaoVienDu.DataSource = pro.getGiaoVienDu();
                txtTenGiaoVien.Clear();
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
            if (status == 1 && testName && testCMSQ) themGiaoVienDu();
            else if (status == 2 && testName && testCMSQ) suaGiaoVienDu();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvGiaoVienDu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (row == dgvGiaoVienDu.CurrentCell.RowIndex && column == dgvGiaoVienDu.CurrentCell.ColumnIndex)
            {
                dgvGiaoVienDu.Rows[row].Cells[column].ReadOnly = true;
            }
            else if (row != -1 && column != -1)
            {
                dgvGiaoVienDu.Rows[row].Cells[column].ReadOnly = false;
                column = dgvGiaoVienDu.CurrentCell.ColumnIndex;
                row = dgvGiaoVienDu.CurrentCell.RowIndex;
            }
            else
            {
                column = dgvGiaoVienDu.CurrentCell.ColumnIndex;
                row = dgvGiaoVienDu.CurrentCell.RowIndex;
            }
            //if (user == 1)
            //{
            int index = dgvGiaoVienDu.CurrentCell.RowIndex;
            if (index < dgvGiaoVienDu.RowCount - 1)
            {
                int indexcol = dgvGiaoVienDu.CurrentCell.ColumnIndex;
                id = int.Parse(dgvGiaoVienDu.Rows[index].Cells[0].Value.ToString());
                if (indexcol != dgvGiaoVienDu.ColumnCount - 1)
                {
                    status = 2;
                    txtTenGiaoVien.Text = dgvGiaoVienDu.Rows[index].Cells[1].Value.ToString();
                    txtCMSQ.Text = dgvGiaoVienDu.Rows[index].Cells[2].Value.ToString();
                    cmbCapBac.Text = dgvGiaoVienDu.Rows[index].Cells[3].Value.ToString();
                    txtDonVi.Text = dgvGiaoVienDu.Rows[index].Cells[4].Value.ToString();
                    txtGhiChu.Text = dgvGiaoVienDu.Rows[index].Cells[5].Value.ToString();
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
            else
            {
                txtTenGiaoVien.Clear();
                txtCMSQ.Clear();
                txtDonVi.Clear();
                txtGhiChu.Clear();
            }
            //}
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            view = pro.getGiaoVienDu().DefaultView;
            dgvGiaoVienDu.DataSource = view;
            string output = "";
            string[] KeyWord = txtTimKiem.Text.Split(' ');
            if (txtTimKiem.Text != "Tìm kiếm...")
            {

                foreach (string word in KeyWord)
                {
                    if (output.Length == 0)
                    {
                        output = "TenGiaoVienDu LIKE '%" + word + "%'";
                    }
                    else
                    {
                        output += "AND TenGiaoVienDu like '%" + word + "%'";
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
                for (int i = 0; i < dgvGiaoVienDu.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dgvGiaoVienDu.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvGiaoVienDu.Columns[j].HeaderText;
                        }
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = dgvGiaoVienDu.Rows[i].Cells[j].Value.ToString();
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
                    MessageBox.Show("Export Successful");
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

        private void loadDataGiaoVienDu()
        {
            pro = new Proceduce();
            dgvGiaoVienDu.DataSource = pro.getGiaoVienDu();
            dgvGiaoVienDu.Columns["IDGiaoVienDu"].Visible = false;
            dgvGiaoVienDu.Columns[1].HeaderText = "Họ Tên";
            dgvGiaoVienDu.Columns[2].HeaderText = "CMSQ";
            dgvGiaoVienDu.Columns[3].HeaderText = "Cấp Bậc";
            dgvGiaoVienDu.Columns[4].HeaderText = "Đơn vị";
            dgvGiaoVienDu.Columns[5].HeaderText = "Ghi chú";
            lbSoLuong.Text = (dgvGiaoVienDu.RowCount - 1).ToString();

        }

        private void themGiaoVienDu()
        {
            status = 1;
            pro = new Proceduce();
            pro.ThemGiaoVienDu(txtTenGiaoVien.Text, txtCMSQ.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            txtTenGiaoVien.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            cmbCapBac.Text = "";
            loadDataGiaoVienDu();
        }

        private void suaGiaoVienDu()
        {
            status = 2;
            pro.SuaGiaoVienDu(id.ToString(), txtTenGiaoVien.Text, txtCMSQ.Text, cmbCapBac.SelectedValue.ToString(), txtDonVi.Text, txtGhiChu.Text);
            dgvGiaoVienDu.DataSource = pro.getGiaoVienDu();
            btnThem.Enabled = true;
            txtTenGiaoVien.Clear();
            txtCMSQ.Clear();
            txtDonVi.Clear();
            txtGhiChu.Clear();
            loadDataGiaoVienDu();
        }

        private void addDataInDatabase()
        {
            int row = Proceduce.dataExcel.Count;
            for (int i = 0; i < row; i++)
            {
                List<string> dataRow = Proceduce.dataExcel[i];
                int col = dataRow.Count;
                if (pro.checkDataGVD(dataRow[1]))
                {
                    pro.ThemGiaoVienDu(dataRow[0], dataRow[1], dataRow[2], dataRow[3], dataRow[4]);
                    view = pro.getGiaoVienDu().DefaultView;
                    dgvGiaoVienDu.DataSource = view;
                    loadDataGiaoVienDu();
                }
            }
        }

        private void txtTenGiaoVien_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTenGiaoVien.Text, @"^[a-zA-uZ-ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚÝàáâãèéêìíòóôõùúýĂăĐđĨĩŨũƠơƯưẠ-ỹ- ]+$"))
            {
                testName = true;
                erHoTen.SetError(txtTenGiaoVien, "Hợp lệ!");
                erHoTen.Icon = Properties.Resources.check;
            }
            else
            {
                testName = false;
                erHoTen.SetError(txtTenGiaoVien, "Nhập chữ cái!");
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

