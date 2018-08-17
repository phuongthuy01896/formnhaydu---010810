using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace formnhaydu
{
    class Proceduce
    {
        public static List<List<String>> dataExcel = new List<List<string>>();
        SQLiteConnection connection;
        private string[] DSCapBac = { "Hạ sĩ", "Trung sĩ", "Thượng sĩ", "Thiếu úy", "Trung úy", "Thượng úy", "Đại úy", "Thiếu tá", "Trung tá", "Thượng tá", "Đại tá", "Thiếu tướng", "Trung tướng", "Thượng tướng ", "Đại tướng" };
        /// ket noi
        /// </summary>
        public void Ketnoi()
        {
            connection = new SQLiteConnection("Data Source = C:\\SQLite3\\Nhaydu.db");
            connection.Open();
        }

        /* lay thong tin nhay du khong ket noi
         */
        public DataTable getChiHuyNhayDu()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand(@"select IDChiHuyND,TenChiHuyND,CMSQ,CapBac,DonVi,GhiChu from ChiHuyNhayDu inner join CapBac on ChiHuyNhayDu.IDCapBac = CapBac.IDCapBac;", connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;


        }
        public bool openFileDialog_Excel()
        {
            OpenFileDialog ofdOpenExecise = new OpenFileDialog();
            ofdOpenExecise.Title = "Nhập danh sách từ file Excel";
            ofdOpenExecise.Filter = "Bài tập(*.xlsx)|*.xlsx";
            ofdOpenExecise.FilterIndex = 0;
            ofdOpenExecise.Multiselect = true;
            ofdOpenExecise.InitialDirectory = Application.StartupPath + "\\DanhSach\\";
            bool isFileSelected = false;
            if (ofdOpenExecise.ShowDialog() == DialogResult.OK)
            {
                dataExcel.Clear();
                foreach (String fileName in ofdOpenExecise.FileNames)
                {
                    if (File.Exists(fileName))
                    {
                        readfileExcel(fileName);
                        isFileSelected = true;
                    }
                }
            }
            return isFileSelected;
        }
        private static void readfileExcel(string fileName) // full path
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 2; i <= rowCount; i++)
            {
                List<string> dataRow = new List<string>();
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j].Value2 != null)
                    {
                        dataRow.Add(xlRange.Cells[i, j].Value2.ToString());
                    }

                    else
                    {
                        dataRow.Add("");
                    }

                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                }
                dataExcel.Add(dataRow);
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
        public DataTable loadCapBac()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand("select * from CapBac;", connection);
            cm.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }
        public bool checkData(string CMSQ)
        {
            Ketnoi();
            string da = string.Format("select 1 from ChiHuyNhayDu where CMSQ=@CMSQ");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.ExecuteNonQuery();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql);
            DataTable datatable = new DataTable();
            data.Fill(datatable);
            connection.Close();
            int count = datatable.Rows.Count;
            if (count != 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Them chi huy nhay du
        /// </summary>
        /// <returns></returns>
        public void ThemChiHuyNhayDu(string TenChiHuyND, string CMSQ, string CapBac, string DonVi, string GhiChu)
        {
            int cap = 0;
            if (int.TryParse(CapBac, out cap))
            {

            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    if (CapBac == DSCapBac[i])
                    {
                        cap = i + 1;
                        break;
                    }
                }
            }


            Ketnoi();
            string da = string.Format(@"insert into ChiHuyNhayDu(TenChiHuyND,CMSQ,IDCapBac,DonVi,GhiChu) 
                                                          values (@TenChiHuyND,@CMSQ,@IDCapBac,@DonVi,@GhiChu);");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@TenChiHuyND", TenChiHuyND));
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", cap));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Xóa chỉ huy nhảy dù
        /// </summary>
        /// <param name="IDChiHuyND"></param>
        public void XoaChiHuyNhayDu(int IDChiHuyND)
        {
            Ketnoi();
            string da = string.Format(@"delete from ChiHuyNhayDu where IDChiHuyND=@IDChiHuyND;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDChiHuyND", IDChiHuyND));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        public void SuaChiHuyNhayDu(string IDChiHuyND, string TenChiHuyND, string CMSQ, string CapBac, string DonVi, string GhiChu)
        {
            Ketnoi();
            string da = string.Format(@"update ChiHuyNhayDu set TenChiHuyND=@TenChiHuyND, CMSQ=@CMSQ, IDCapBac=@IDCapBac, DonVi=@DonVi, GhiChu=@GhiChu where IDChiHuyND=@IDChiHuyND;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDChiHuyND", IDChiHuyND));
            sql.Parameters.Add(new SQLiteParameter("@TenChiHuyND", TenChiHuyND));
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", CapBac));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }

        //NguoiNhayDu
        /// <summary>
        /// Lấy thông tin Người Nhảy dù
        /// </summary>
        /// <returns></returns>
        public DataTable getNguoiNhayDu()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand(@"select IDNguoiND,TenNguoiND,MaNND,CapBac,DonVi,GhiChu from NguoiNhayDu inner join CapBac on NguoiNhayDu.IDCapBac = CapBac.IDCapBac;", connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }
        /// <summary>
        /// Them nguoi nhay du
        /// </summary>
        /// <returns></returns>
        public void ThemNguoiNhayDu(string TenNguoiND, string MaNND, string CapBac, string DonVi, string GhiChu)
        {
            int cap = 0;
            if (int.TryParse(CapBac, out cap))
            {

            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    if (CapBac == DSCapBac[i])
                    {
                        cap = i + 1;
                        break;
                    }
                }
            }
            Ketnoi();
            string da = string.Format(@"insert into NguoiNhayDu(TenNguoiND,MaNND,IDCapBac,DonVi,GhiChu) 
                                                          values (@TenNguoiND,@MaNND,@IDCapBac,@DonVi,@GhiChu);");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@TenNguoiND", TenNguoiND));
            sql.Parameters.Add(new SQLiteParameter("@MaNND", MaNND));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", cap));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Xóa người nhảy dù
        /// </summary>
        /// <param name="IDNguoiND"></param>
        public void XoaNguoiNhayDu(int IDNguoiND)
        {
            Ketnoi();
            string da = string.Format(@"delete from NguoiNhayDu where IDNguoiND=@IDNguoiND;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDNguoiND", IDNguoiND));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Sửa người nhảy dù
        /// </summary>
        /// <param name="IDNguoiND"></param>
        /// <param name="TenNguoiND"></param>
        /// <param name="MaNND"></param>
        /// <param name="CapBac"></param>
        /// <param name="DonVi"></param>
        /// <param name="GhiChu"></param>
        public void SuaNguoiNhayDu(string IDNguoiND, string TenNguoiND, string MaNND, string CapBac, string DonVi, string GhiChu)
        {
            Ketnoi();
            string da = string.Format(@"update NguoiNhayDu set TenNguoiND=@TenNguoiND, MaNND=@MaNND, IDCapBac=@IDCapBac, DonVi=@DonVi, GhiChu=@GhiChu where IDNguoiND=@IDNguoiND;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDNguoiND", IDNguoiND));
            sql.Parameters.Add(new SQLiteParameter("@TenNguoiND", TenNguoiND));
            sql.Parameters.Add(new SQLiteParameter("@MaNND", MaNND));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", CapBac));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// kiểm tra dữ liệu người nhảy dù có bị trùng hay k
        /// </summary>
        /// <param name="MaNND"></param>
        /// <returns></returns>
        public bool checkDataNND(string MaNND)
        {
            Ketnoi();
            string da = string.Format("select 1 from NguoiNhayDu where MaNND=@MaNND");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@MaNND", MaNND));
            sql.ExecuteNonQuery();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql);
            DataTable datatable = new DataTable();
            data.Fill(datatable);
            connection.Close();
            int count = datatable.Rows.Count;
            if (count != 0)
            {
                return false;
            }
            return true;
        }

        ///Giao vien du
        public DataTable getGiaoVienDu()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand(@"select IDGiaoVienDu,TenGiaoVienDu,CMSQ,CapBac,DonVi,GhiChu from GiaoVienDu inner join CapBac on GiaoVienDu.IDCapBac = CapBac.IDCapBac;", connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }
        /// <summary>
        /// Them giao vien du
        /// </summary>
        /// <returns></returns>
        public void ThemGiaoVienDu(string TenGiaoVienDu, string CMSQ, string CapBac, string DonVi, string GhiChu)
        {
            int cap = 0;
            if (int.TryParse(CapBac, out cap))
            {

            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    if (CapBac == DSCapBac[i])
                    {
                        cap = i + 1;
                        break;
                    }
                }
            }
            Ketnoi();
            string da = string.Format(@"insert into GiaoVienDu(TenGiaoVienDu,CMSQ,IDCapBac,DonVi,GhiChu) 
                                                          values (@TenGiaoVienDu,@CMSQ,@IDCapBac,@DonVi,@GhiChu);");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@TenGiaoVienDu", TenGiaoVienDu));
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", cap));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// Xóa giáo viên dù
        /// </summary>
        /// <param name="IDGiaoVienDu"></param>
        public void XoaGiaoVienDu(int IDGiaoVienDu)
        {
            Ketnoi();
            string da = string.Format(@"delete from GiaoVienDu where IDGiaoVienDu=@IDGiaoVienDu;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDGiaoVienDu", IDGiaoVienDu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        public void SuaGiaoVienDu(string IDGiaoVienDu, string TenGiaoVienDu, string CMSQ, string CapBac, string DonVi, string GhiChu)
        {
            Ketnoi();
            string da = string.Format(@"update GiaoVienDu set TenGiaoVienDu=@TenGiaoVienDu, CMSQ=@CMSQ, IDCapBac=@IDCapBac, DonVi=@DonVi, GhiChu=@GhiChu where IDGiaoVienDu=@IDGiaoVienDu;");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@IDGiaoVienDu", IDGiaoVienDu));
            sql.Parameters.Add(new SQLiteParameter("@TenGiaoVienDu", TenGiaoVienDu));
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.Parameters.Add(new SQLiteParameter("@IDCapBac", CapBac));
            sql.Parameters.Add(new SQLiteParameter("@DonVi", DonVi));
            sql.Parameters.Add(new SQLiteParameter("@GhiChu", GhiChu));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        public bool checkDataGVD(string CMSQ)
        {
            Ketnoi();
            string da = string.Format("select 1 from GiaoVienDu where CMSQ=@CMSQ");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@CMSQ", CMSQ));
            sql.ExecuteNonQuery();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql);
            DataTable datatable = new DataTable();
            data.Fill(datatable);
            connection.Close();
            int count = datatable.Rows.Count;
            if (count != 0)
            {
                return false;
            }
            return true;
        }
        public void ThemTaiKhoan(string TenTaiKhoan, string MatKhau, int IDNhomNguoiDung)
        {
            Ketnoi();
            string da = string.Format(@"insert into TaiKhoan(TenTaiKhoan,MatKhau,IDNhomNguoiDung) 
                                                          values (@TenTaiKhoan,@MatKhau,@IDNhomNguoiDung);");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.Parameters.Add(new SQLiteParameter("@TenTaiKhoan", TenTaiKhoan));
            sql.Parameters.Add(new SQLiteParameter("@MatKhau", MatKhau));
            sql.Parameters.Add(new SQLiteParameter("@IDNhomNguoiDung", IDNhomNguoiDung));
            sql.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable DangNhap(string TenTaiKhoan, string MatKhau)
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand(@"select IDNhomNguoiDung from TaiKhoan where TenTaiKhoan = '" + TenTaiKhoan + "' and MatKhau = '" + MatKhau + "';", connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }

        //Main
        public DataTable checkDataInMain()
        {
            Ketnoi();
            string da = string.Format("select MaNND from NguoiNhayDu order by MaNND desc");
            SQLiteCommand sql = new SQLiteCommand(da, connection);
            sql.ExecuteNonQuery();
            SQLiteDataAdapter data = new SQLiteDataAdapter(sql);
            DataTable datatable = new DataTable();
            data.Fill(datatable);
            connection.Close();
            return datatable;
        }
        public DataTable loadDiaHinh()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand("select IDDiaHinh,TenDiaHinh from DiaHinhKhuVucSB;", connection);
            cm.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable loadMayBay()
        {
            Ketnoi();
            SQLiteCommand cm = new SQLiteCommand("select IDMayBay,TenMayBay from MayBay;", connection);
            cm.ExecuteNonQuery();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
            DataTable data = new DataTable();
            da.Fill(data);
            connection.Close();
            return data;
        }
        
        // ThongKe
        //public void getKetQua()
        //{
        //    Ketnoi();
        //    SQLiteCommand cm = new SQLiteCommand(@"select KipNhay,ThoiGian,CMSQ,CapBac,DonVi,GhiChu from GiaoVienDu inner join CapBac on GiaoVienDu.IDCapBac = CapBac.IDCapBac;", connection);
        //    SQLiteDataAdapter da = new SQLiteDataAdapter(cm);
        //    DataTable data = new DataTable();
        //    da.Fill(data);
        //    connection.Close();
        // //   return data;
        //}
    }
}
