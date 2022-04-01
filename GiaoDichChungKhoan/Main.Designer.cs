
namespace GiaoDichChungKhoan
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mACPLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label nGAYDATLabel;
            System.Windows.Forms.Label lOAILENHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label gIADATLabel;
            this.bdsLENHDAT = new System.Windows.Forms.BindingSource(this.components);
            this.GDCHUNGKHOANDataSet = new GiaoDichChungKhoan.GDCHUNGKHOANDataSet();
            this.groupBoxBGTT = new System.Windows.Forms.GroupBox();
            this.tableAdapterLENHDAT = new GiaoDichChungKhoan.GDCHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter();
            this.tableAdapterManager = new GiaoDichChungKhoan.GDCHUNGKHOANDataSetTableAdapters.TableAdapterManager();
            this.groupBox1DSLenhDat = new System.Windows.Forms.GroupBox();
            this.groupBoxDatLenh = new System.Windows.Forms.GroupBox();
            this.gridControlLenhDat = new DevExpress.XtraGrid.GridControl();
            this.gridViewLenhDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAILENH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIADAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRANGTHAILENH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaCP = new DevExpress.XtraEditors.TextEdit();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtLoaiLenh = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtGiaDat = new DevExpress.XtraEditors.SpinEdit();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.btnDatLai = new System.Windows.Forms.Button();
            mACPLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            nGAYDATLabel = new System.Windows.Forms.Label();
            lOAILENHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            gIADATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLENHDAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDCHUNGKHOANDataSet)).BeginInit();
            this.groupBox1DSLenhDat.SuspendLayout();
            this.groupBoxDatLenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLenhDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLenhDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiLenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsLENHDAT
            // 
            this.bdsLENHDAT.DataMember = "LENHDAT";
            this.bdsLENHDAT.DataSource = this.GDCHUNGKHOANDataSet;
            // 
            // GDCHUNGKHOANDataSet
            // 
            this.GDCHUNGKHOANDataSet.DataSetName = "GDCHUNGKHOANDataSet";
            this.GDCHUNGKHOANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxBGTT
            // 
            this.groupBoxBGTT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxBGTT.Location = new System.Drawing.Point(0, 401);
            this.groupBoxBGTT.Name = "groupBoxBGTT";
            this.groupBoxBGTT.Size = new System.Drawing.Size(1638, 337);
            this.groupBoxBGTT.TabIndex = 1;
            this.groupBoxBGTT.TabStop = false;
            this.groupBoxBGTT.Text = "Bảng Giá Trực Tuyến";
            // 
            // tableAdapterLENHDAT
            // 
            this.tableAdapterLENHDAT.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGGIATRUCTUYENTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = this.tableAdapterLENHDAT;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GiaoDichChungKhoan.GDCHUNGKHOANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1DSLenhDat
            // 
            this.groupBox1DSLenhDat.Controls.Add(this.groupBoxDatLenh);
            this.groupBox1DSLenhDat.Controls.Add(this.gridControlLenhDat);
            this.groupBox1DSLenhDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1DSLenhDat.Location = new System.Drawing.Point(0, 0);
            this.groupBox1DSLenhDat.Name = "groupBox1DSLenhDat";
            this.groupBox1DSLenhDat.Size = new System.Drawing.Size(1638, 401);
            this.groupBox1DSLenhDat.TabIndex = 2;
            this.groupBox1DSLenhDat.TabStop = false;
            this.groupBox1DSLenhDat.Text = "Danh Sách Lệnh Đặt";
            // 
            // groupBoxDatLenh
            // 
            this.groupBoxDatLenh.Controls.Add(this.btnDatLai);
            this.groupBoxDatLenh.Controls.Add(this.btnDatLenh);
            this.groupBoxDatLenh.Controls.Add(gIADATLabel);
            this.groupBoxDatLenh.Controls.Add(this.txtGiaDat);
            this.groupBoxDatLenh.Controls.Add(sOLUONGLabel);
            this.groupBoxDatLenh.Controls.Add(this.txtSoLuong);
            this.groupBoxDatLenh.Controls.Add(lOAILENHLabel);
            this.groupBoxDatLenh.Controls.Add(this.txtLoaiLenh);
            this.groupBoxDatLenh.Controls.Add(nGAYDATLabel);
            this.groupBoxDatLenh.Controls.Add(this.dateTimeNgayDat);
            this.groupBoxDatLenh.Controls.Add(lOAIGDLabel);
            this.groupBoxDatLenh.Controls.Add(this.cmbLoaiGD);
            this.groupBoxDatLenh.Controls.Add(mACPLabel);
            this.groupBoxDatLenh.Controls.Add(this.txtMaCP);
            this.groupBoxDatLenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDatLenh.Location = new System.Drawing.Point(1088, 19);
            this.groupBoxDatLenh.Name = "groupBoxDatLenh";
            this.groupBoxDatLenh.Size = new System.Drawing.Size(547, 379);
            this.groupBoxDatLenh.TabIndex = 3;
            this.groupBoxDatLenh.TabStop = false;
            this.groupBoxDatLenh.Text = "Giao Dịch Chứng Khoán";
            // 
            // gridControlLenhDat
            // 
            this.gridControlLenhDat.DataSource = this.bdsLENHDAT;
            this.gridControlLenhDat.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControlLenhDat.Location = new System.Drawing.Point(3, 19);
            this.gridControlLenhDat.MainView = this.gridViewLenhDat;
            this.gridControlLenhDat.Name = "gridControlLenhDat";
            this.gridControlLenhDat.Size = new System.Drawing.Size(1085, 379);
            this.gridControlLenhDat.TabIndex = 2;
            this.gridControlLenhDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLenhDat});
            // 
            // gridViewLenhDat
            // 
            this.gridViewLenhDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMACP,
            this.colNGAYDAT,
            this.colLOAIGD,
            this.colLOAILENH,
            this.colSOLUONG,
            this.colGIADAT,
            this.colTRANGTHAILENH});
            this.gridViewLenhDat.GridControl = this.gridControlLenhDat;
            this.gridViewLenhDat.Name = "gridViewLenhDat";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colMACP
            // 
            this.colMACP.FieldName = "MACP";
            this.colMACP.MinWidth = 25;
            this.colMACP.Name = "colMACP";
            this.colMACP.Visible = true;
            this.colMACP.VisibleIndex = 1;
            this.colMACP.Width = 94;
            // 
            // colNGAYDAT
            // 
            this.colNGAYDAT.FieldName = "NGAYDAT";
            this.colNGAYDAT.MinWidth = 25;
            this.colNGAYDAT.Name = "colNGAYDAT";
            this.colNGAYDAT.Visible = true;
            this.colNGAYDAT.VisibleIndex = 2;
            this.colNGAYDAT.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 3;
            this.colLOAIGD.Width = 94;
            // 
            // colLOAILENH
            // 
            this.colLOAILENH.FieldName = "LOAILENH";
            this.colLOAILENH.MinWidth = 25;
            this.colLOAILENH.Name = "colLOAILENH";
            this.colLOAILENH.Visible = true;
            this.colLOAILENH.VisibleIndex = 4;
            this.colLOAILENH.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOLUONG.AppearanceCell.Options.UseFont = true;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 5;
            this.colSOLUONG.Width = 94;
            // 
            // colGIADAT
            // 
            this.colGIADAT.FieldName = "GIADAT";
            this.colGIADAT.MinWidth = 25;
            this.colGIADAT.Name = "colGIADAT";
            this.colGIADAT.Visible = true;
            this.colGIADAT.VisibleIndex = 6;
            this.colGIADAT.Width = 94;
            // 
            // colTRANGTHAILENH
            // 
            this.colTRANGTHAILENH.FieldName = "TRANGTHAILENH";
            this.colTRANGTHAILENH.MinWidth = 25;
            this.colTRANGTHAILENH.Name = "colTRANGTHAILENH";
            this.colTRANGTHAILENH.Visible = true;
            this.colTRANGTHAILENH.VisibleIndex = 7;
            this.colTRANGTHAILENH.Width = 94;
            // 
            // mACPLabel
            // 
            mACPLabel.AutoSize = true;
            mACPLabel.Location = new System.Drawing.Point(65, 96);
            mACPLabel.Name = "mACPLabel";
            mACPLabel.Size = new System.Drawing.Size(54, 17);
            mACPLabel.TabIndex = 0;
            mACPLabel.Text = "MACP:";
            // 
            // txtMaCP
            // 
            this.txtMaCP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLENHDAT, "MACP", true));
            this.txtMaCP.Location = new System.Drawing.Point(155, 93);
            this.txtMaCP.Name = "txtMaCP";
            this.txtMaCP.Size = new System.Drawing.Size(125, 22);
            this.txtMaCP.TabIndex = 1;
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Location = new System.Drawing.Point(50, 34);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(69, 17);
            lOAIGDLabel.TabIndex = 2;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLENHDAT, "LOAIGD", true));
            this.cmbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiGD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Location = new System.Drawing.Point(155, 31);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(121, 24);
            this.cmbLoaiGD.TabIndex = 3;
            // 
            // nGAYDATLabel
            // 
            nGAYDATLabel.AutoSize = true;
            nGAYDATLabel.Location = new System.Drawing.Point(37, 159);
            nGAYDATLabel.Name = "nGAYDATLabel";
            nGAYDATLabel.Size = new System.Drawing.Size(82, 17);
            nGAYDATLabel.TabIndex = 4;
            nGAYDATLabel.Text = "NGAYDAT:";
            // 
            // dateTimeNgayDat
            // 
            this.dateTimeNgayDat.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsLENHDAT, "NGAYDAT", true));
            this.dateTimeNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayDat.Location = new System.Drawing.Point(155, 155);
            this.dateTimeNgayDat.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimeNgayDat.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimeNgayDat.Name = "dateTimeNgayDat";
            this.dateTimeNgayDat.Size = new System.Drawing.Size(125, 23);
            this.dateTimeNgayDat.TabIndex = 5;
            this.dateTimeNgayDat.Value = new System.DateTime(2022, 4, 1, 0, 50, 0, 0);
            // 
            // lOAILENHLabel
            // 
            lOAILENHLabel.AutoSize = true;
            lOAILENHLabel.Location = new System.Drawing.Point(31, 219);
            lOAILENHLabel.Name = "lOAILENHLabel";
            lOAILENHLabel.Size = new System.Drawing.Size(88, 17);
            lOAILENHLabel.TabIndex = 6;
            lOAILENHLabel.Text = "LOAILENH:";
            // 
            // txtLoaiLenh
            // 
            this.txtLoaiLenh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLENHDAT, "LOAILENH", true));
            this.txtLoaiLenh.EditValue = "LO";
            this.txtLoaiLenh.Enabled = false;
            this.txtLoaiLenh.Location = new System.Drawing.Point(155, 216);
            this.txtLoaiLenh.Name = "txtLoaiLenh";
            this.txtLoaiLenh.Size = new System.Drawing.Size(125, 22);
            this.txtLoaiLenh.TabIndex = 7;
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(36, 280);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(83, 17);
            sOLUONGLabel.TabIndex = 8;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLENHDAT, "SOLUONG", true));
            this.txtSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(155, 277);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Size = new System.Drawing.Size(125, 24);
            this.txtSoLuong.TabIndex = 9;
            // 
            // gIADATLabel
            // 
            gIADATLabel.AutoSize = true;
            gIADATLabel.Location = new System.Drawing.Point(50, 341);
            gIADATLabel.Name = "gIADATLabel";
            gIADATLabel.Size = new System.Drawing.Size(69, 17);
            gIADATLabel.TabIndex = 10;
            gIADATLabel.Text = "GIADAT:";
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLENHDAT, "GIADAT", true));
            this.txtGiaDat.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGiaDat.Location = new System.Drawing.Point(155, 338);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaDat.Size = new System.Drawing.Size(125, 24);
            this.txtGiaDat.TabIndex = 11;
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDatLenh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatLenh.Location = new System.Drawing.Point(393, 114);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(100, 49);
            this.btnDatLenh.TabIndex = 12;
            this.btnDatLenh.Text = "Đặt Lệnh";
            this.btnDatLenh.UseVisualStyleBackColor = false;
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDatLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatLai.Location = new System.Drawing.Point(393, 219);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(100, 49);
            this.btnDatLai.TabIndex = 13;
            this.btnDatLai.Text = "Đặt Lại";
            this.btnDatLai.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1638, 738);
            this.Controls.Add(this.groupBox1DSLenhDat);
            this.Controls.Add(this.groupBoxBGTT);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Giao Dịch Chứng Khoán";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLENHDAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDCHUNGKHOANDataSet)).EndInit();
            this.groupBox1DSLenhDat.ResumeLayout(false);
            this.groupBoxDatLenh.ResumeLayout(false);
            this.groupBoxDatLenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLenhDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLenhDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiLenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxBGTT;
        private GDCHUNGKHOANDataSet GDCHUNGKHOANDataSet;
        private System.Windows.Forms.BindingSource bdsLENHDAT;
        private GDCHUNGKHOANDataSetTableAdapters.LENHDATTableAdapter tableAdapterLENHDAT;
        private GDCHUNGKHOANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1DSLenhDat;
        private System.Windows.Forms.GroupBox groupBoxDatLenh;
        private DevExpress.XtraGrid.GridControl gridControlLenhDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLenhDat;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMACP;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDAT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAILENH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colGIADAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTRANGTHAILENH;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnDatLenh;
        private DevExpress.XtraEditors.SpinEdit txtGiaDat;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.TextEdit txtLoaiLenh;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDat;
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private DevExpress.XtraEditors.TextEdit txtMaCP;
    }
}

