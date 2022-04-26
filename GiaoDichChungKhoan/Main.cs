using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace GiaoDichChungKhoan
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private const string bangTT = "BANGGIATRUCTUYEN";
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet showData = null;

        private int change = 0;

        public class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public Main()
        {
            InitializeComponent();
            if (CanRequestNotifications() == true)
                Connect();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "Notification", MessageBoxButtons.OK);

        }

        private bool CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                return false;
            }
        }

        //Tạo thành phần của bảng giá trực tuyến
        private string createBGTT()
        {
            return "SELECT MACP AS[Mã CP],GIAMUA3 AS[Giá mua 3],KLMUA3 AS[Khối lượng mua 3], GIAMUA2 AS[Giá mua 2], KLMUA2 AS[Khối lượng mua 2], GIAMUA1 AS[Giá mua 1], KLMUA1 AS[Khối lượng mua 1], GIAKHOP AS[Giá khớp], KHOILUONGKHOP AS[Khối lượng khớp], GIABAN1 AS[Giá bán 1], KLBAN1 AS[Khối lượng bán 1], GIABAN2 AS[Giá bán 2], KLBAN2 AS[Khối lượng bán 2], GIABAN3 AS[Giá bán 3], KLBAN3 AS[Khối lượng bán 3] FROM DBO.BANGGIATRUCTUYEN";
        }

        //Load dữ liệu bảng trực tuyến và bảng lệnh khớp
        private void Main_Load(object sender, EventArgs e)
        {
            GDCHUNGKHOANDataSet.EnforceConstraints = false;
            this.TableAdapterLENHDAT.Connection.ConnectionString = Program.connstr_publisher;
            this.TableAdapterLENHDAT.Fill(this.GDCHUNGKHOANDataSet.LENHDAT);

            BindingList<Data> cmbItems = new BindingList<Data>();

            cmbItems.Add(new Data { Name = "Mua", Value = "M" });
            cmbItems.Add(new Data { Name = "Bán", Value = "B" });

            cmbLoaiGD.DataSource = cmbItems;
            cmbLoaiGD.DisplayMember = "Name";
            cmbLoaiGD.ValueMember = "Value";

            cmbLoaiGD.SelectedIndex = -1;
            cmbLoaiGD.SelectedIndex = 0;
        }

        //Đặt lệnh
        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            if(txtMaCP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã Cổ phiếu!", "Thông báo", MessageBoxButtons.OK);
                txtMaCP.Focus();
            }
            else if (int.Parse(txtSoLuong.Text.Trim()) <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
            }
            else if (float.Parse(txtGiaDat.Text.Trim()) <= 0)
            {
                MessageBox.Show("Vui lòng nhập Giá đặt lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtGiaDat.Focus();
            }
            else
            {
                if (Program.KetNoi() == 0)
                    return;
                string thucThi = "EXEC SP_KHOPLENH_LO N'" + txtMaCP.Text.ToUpper() + "',N'" + DateTime.Today + "',N'" + cmbLoaiGD.SelectedValue.ToString() + "'," + txtSoLuong.Text + "," + txtGiaDat.Text;
                try
                {
                    Program.dataReader = Program.ExecSqlDataReader(thucThi);
                    if (Program.dataReader != null)
                    {
                        Program.dataReader.Read();
                        Int32 sum = Program.dataReader.GetInt32(0);

                        MessageBox.Show("Đặt lệnh thành công!\nSố lượng cổ phiếu khớp: " + sum.ToString(), "Thông báo", MessageBoxButtons.OK);

                        this.TableAdapterLENHDAT.Fill(this.GDCHUNGKHOANDataSet.LENHDAT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đặt lệnh!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            cmbLoaiGD.SelectedIndex = 0;
            txtMaCP.Text = "";
            txtSoLuong.Text = "";
            txtGiaDat.Text = "";
            if (Program.dataReader == null)
                return;
            Program.conn.Close();


        }

        //Reset lại dữ liệu cả trên bảng lệnh khớp và cả bảng trực tuyến
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn làm mới tất cả?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Program.KetNoi() == 0) return;
                string strLenh = "EXEC SP_RESET_TRANGTHAILENH " +
                                 "EXEC SP_RESET_BANGGIA";
                try
                {
                    Program.dataReader = Program.ExecSqlDataReader(strLenh);
                    MessageBox.Show("Cập nhật Bảng trực tuyến thành công! ", "Thông báo", MessageBoxButtons.OK);
                    this.TableAdapterLENHDAT.Fill(this.GDCHUNGKHOANDataSet.LENHDAT);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi SP!\n" + ex.Message, "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Program.dataReader == null) return;
                Program.dataReader.Read();
                Program.conn.Close();
            }
            else return;
            
           
        }

        //Dữ liệu thay đổi cập nhật lên bảng trực tuyến
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);
                object[] args = new[] { sender, e };
                i.BeginInvoke(tempDelegate, args);
                return;
            }
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;
            change += 1;
            GetData();
        }

        private void Connect()
        {
            change = 0;

            SqlDependency.Stop(Program.connstr_publisher);
            try
            {
                SqlDependency.Start(Program.connstr_publisher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK);
                return;
            }

            if (connection == null)
            {
                connection = new SqlConnection(Program.connstr_publisher);
                connection.Open();
            }

            if (command == null)
                command = new SqlCommand(createBGTT(), connection);

            if (showData == null)
                showData = new DataSet();
            GetData();
        }

        //Hiển thị dữ liệu lên bảng trực tuyến
        private void GetData()
        {
            showData.Clear();
            command.Notification = null;
            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += dependency_OnChange;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(showData, bangTT);
                this.gridViewBGTT.DataSource = showData;
                this.gridViewBGTT.DataMember = bangTT;

                setChangeGridView();

            }
        }

        //Edit giao diện của bảng trực tuyến
        private void setChangeGridView()
        {
            foreach (DataGridViewRow row in gridViewBGTT.Rows)
            {
                gridViewBGTT.DefaultCellStyle.BackColor = Color.Black;
                gridViewBGTT.DefaultCellStyle.ForeColor = Color.Red;
            }
                

            gridViewBGTT.Columns["Mã CP"].Width = 75;
            gridViewBGTT.Columns["Giá mua 3"].Width = 105;
            gridViewBGTT.Columns["Giá mua 2"].Width = 105;
            gridViewBGTT.Columns["Giá mua 1"].Width = 105;
            gridViewBGTT.Columns["Giá bán 3"].Width = 105;
            gridViewBGTT.Columns["Giá bán 2"].Width = 105;
            gridViewBGTT.Columns["Giá bán 1"].Width = 105;

            gridViewBGTT.Columns["Khối lượng mua 3"].Width = 155;
            gridViewBGTT.Columns["Khối lượng mua 2"].Width = 155;
            gridViewBGTT.Columns["Khối lượng mua 1"].Width = 155;
            gridViewBGTT.Columns["Khối lượng bán 3"].Width = 155;
            gridViewBGTT.Columns["Khối lượng bán 2"].Width = 155;
            gridViewBGTT.Columns["Khối lượng bán 1"].Width = 155;

            gridViewBGTT.Columns["Khối lượng khớp"].Width = 145;
            gridViewBGTT.Columns["Giá khớp"].Width = 100;
        }

        private void lENHDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLENHDAT.EndEdit();
            this.tableAdapterManagerLD.UpdateAll(this.GDCHUNGKHOANDataSet);
        }
        //================================Bắt lỗi nhập vào============
        private void txtMaCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().IndexOfAny(@"0123456789!@#$%^&*()_+=|\{}[]?><.,';:".ToCharArray()) != -1)  // chổ nầy ko hiểu tại sao lại !=-1
            {
                e.Handled = true;
                MessageBox.Show("Mã cổ phiếu phải nhập chữ in & không có ký tự đặc biệt", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
                e.Handled = false;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng.\nVui lòng nhập số!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
                e.Handled = false;
        }

        private void txtGiaDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng.\nVui lòng nhập số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                e.Handled = false;
        }
        //=====================================================
    }
}
