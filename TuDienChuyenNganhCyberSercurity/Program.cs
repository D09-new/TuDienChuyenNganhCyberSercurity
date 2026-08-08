using System.Windows.Forms;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace TuDienChuyenNganhCyberSecurity
{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public string connstr = "Data Source=MSI\\MAIN;Initial Catalog=TuDienChuyenNganhCS;User ID=RAWTUDIENCS;Password=123";
        static public SqlConnection conn = new SqlConnection();
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static bool ComboBoxCoGiaTri(ComboBox cmb, string tenCot, string giaTriCanTim)
        {
            foreach (object item in cmb.Items)
            {
                if (item is DataRowView row)
                {
                    string value = row[tenCot].ToString().Trim();

                    if (value == giaTriCanTim.Trim())
                        return true;
                }
            }

            return false;
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}