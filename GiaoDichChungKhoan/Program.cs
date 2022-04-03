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
        public static String connstr;

        //===================Database=============
        //Data Source=PIPI;Initial Catalog=GDCHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=123
        public static String connstr_publisher = "Data Source=PIPI;Initial Catalog=GDCHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=123";

        public static String database = "GDCHUNGKHOAN";
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Xem lại Username & Password" + e);
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

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;//reset db mặc định tối đa 10p
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex) 
            {
                //demo
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn fomat Cell lại cột \"Ngày tạo\" qua kiểu Number hoặc mở File Excel.");
                else
                    MessageBox.Show(ex.Message);
                conn.Close();
                //trạng thái lỗi gửi từ RaisError trong SQL Server qua
                return ex.State;
            }
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
