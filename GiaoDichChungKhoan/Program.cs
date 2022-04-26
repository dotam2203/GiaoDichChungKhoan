using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace GiaoDichChungKhoan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //Kết nối database
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlCmd = new SqlCommand();
        public static SqlDataReader dataReader;
        public static String connstr;

        //===================Database=============
        public static String connstr_publisher = "Data Source=PIPI;Initial Catalog=GDCHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=123";

        public static String servername = "PIPI"; // luu ten server tra vè ở form dang nhap
        public static String username = "";
        public static String mlogin = "sa";
        public static String password = "123";
        public static String database = "GDCHUNGKHOAN";

        
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password. " + e.Message, "Kết nối", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            /*Tham số 1: chuỗi lệnh, Tham số 2: Đường kết nối là đối tượng SqlConnect*/
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            //chuỗi lệnh sử dụng text
            sqlcmd.CommandType = CommandType.Text;
            try
            {
                //thực thi câu lệnh chỉ cho đọc
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            } 
        
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            //tải về bằng fill
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
