using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GiaoDichChungKhoan
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public class Data
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public Main()
        {

            InitializeComponent();
          
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gDCHUNGKHOANDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.TableAdapterLENHDAT.Fill(this.GDCHUNGKHOANDataSet.LENHDAT);

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

            dateTimeNgayDat.Value = DateTime.Today;
        }

        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            if(txtMaCP.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã Cổ phiếu!", "Thông báo", MessageBoxButtons.OK);
                txtMaCP.Focus();
            }
            else if(float.Parse(txtGiaDat.Text.Trim()) <= 0)
            {
                MessageBox.Show("Vui lòng nhập Giá đặt lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtGiaDat.Focus();
            }
            else if (int.Parse(txtSoLuong.Text.Trim()) <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng lớn hơn 0!", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
            }

            if (Program.KetNoi() == 0) 
                return;

            string thucThi = "EXEC SP_KHOPLENH_LO N'" + txtMaCP.Text + "',N'" + dateTimeNgayDat.Value.ToString("dd-MM-yyyy") + "',N'" + cmbLoaiGD.SelectedValue.ToString() + "'," + txtSoLuong.Text + "," + txtGiaDat.Text;
            try
            {
                Program.dataReader = Program.ExecSqlDataReader(thucThi);
                if(Program.dataReader != null)
                {
                    Program.dataReader.Read();
                    Int32 ret = Program.dataReader.GetInt32(0);

                    MessageBox.Show("Đặt lệnh thành công.\nSố lượng cổ phiếu khớp: " + ret.ToString(), "Thông báo", MessageBoxButtons.OK);

                    this.TableAdapterLENHDAT.Fill(this.GDCHUNGKHOANDataSet.LENHDAT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đặt lệnh!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbLoaiGD.SelectedIndex = 0;
            txtMaCP.Text = "";
            txtSoLuong.Text = "";
            txtGiaDat.Text = "";
            if (Program.dataReader == null)
                return;
            Program.conn.Close();


        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {

        }

        private void lENHDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLENHDAT.EndEdit();
            this.tableAdapterManagerLD.UpdateAll(this.GDCHUNGKHOANDataSet);

        }
    }
}
