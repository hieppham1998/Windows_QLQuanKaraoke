namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    partial class NhapKho_DV
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
            System.Windows.Forms.Label maPhieNhapLabel;
            System.Windows.Forms.Label maNhanVienLabel;
            System.Windows.Forms.Label ngayNhapLabel;
            System.Windows.Forms.Label tongPNLabel;
            System.Windows.Forms.Label maDVLabel;
            System.Windows.Forms.Label tenDichVuLabel;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaNhapLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_chitietnhap = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DTI_ngaynhap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_LuuPN = new DevComponents.DotNetBar.ButtonX();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tongpn = new System.Windows.Forms.TextBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_xoachitiet = new DevComponents.DotNetBar.ButtonX();
            this.btn_suachitiet = new DevComponents.DotNetBar.ButtonX();
            this.btn_themchitiet = new DevComponents.DotNetBar.ButtonX();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_sln = new System.Windows.Forms.TextBox();
            this.txt_dgn = new System.Windows.Forms.TextBox();
            this.txt_dvtn = new System.Windows.Forms.TextBox();
            this.dTS_QL_NhanVien = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVien();
            this.phieuNhapTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager();
            this.cTPN_DichVuTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.CTPN_DichVuTableAdapter();
            maPhieNhapLabel = new System.Windows.Forms.Label();
            maNhanVienLabel = new System.Windows.Forms.Label();
            ngayNhapLabel = new System.Windows.Forms.Label();
            tongPNLabel = new System.Windows.Forms.Label();
            maDVLabel = new System.Windows.Forms.Label();
            tenDichVuLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaNhapLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_ngaynhap)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // maPhieNhapLabel
            // 
            maPhieNhapLabel.AutoSize = true;
            maPhieNhapLabel.Location = new System.Drawing.Point(270, 20);
            maPhieNhapLabel.Name = "maPhieNhapLabel";
            maPhieNhapLabel.Size = new System.Drawing.Size(104, 17);
            maPhieNhapLabel.TabIndex = 0;
            maPhieNhapLabel.Text = "Mã Phiếu Nhập:";
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(658, 23);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(98, 17);
            maNhanVienLabel.TabIndex = 2;
            maNhanVienLabel.Text = "Mã Nhân Viên:";
            // 
            // ngayNhapLabel
            // 
            ngayNhapLabel.AutoSize = true;
            ngayNhapLabel.Location = new System.Drawing.Point(294, 74);
            ngayNhapLabel.Name = "ngayNhapLabel";
            ngayNhapLabel.Size = new System.Drawing.Size(76, 17);
            ngayNhapLabel.TabIndex = 4;
            ngayNhapLabel.Text = "Ngày Nhập";
            // 
            // tongPNLabel
            // 
            tongPNLabel.AutoSize = true;
            tongPNLabel.Location = new System.Drawing.Point(644, 73);
            tongPNLabel.Name = "tongPNLabel";
            tongPNLabel.Size = new System.Drawing.Size(114, 17);
            tongPNLabel.TabIndex = 6;
            tongPNLabel.Text = "Tổng Phiếu Nhập:";
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Location = new System.Drawing.Point(346, 14);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(82, 17);
            maDVLabel.TabIndex = 0;
            maDVLabel.Text = "Mã Dịch Vụ";
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(657, 11);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(85, 17);
            tenDichVuLabel.TabIndex = 2;
            tenDichVuLabel.Text = "Tên Dịch Vụ";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(230, 61);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(102, 17);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "Số Lượng Nhập";
            // 
            // donGiaNhapLabel
            // 
            donGiaNhapLabel.AutoSize = true;
            donGiaNhapLabel.Location = new System.Drawing.Point(521, 63);
            donGiaNhapLabel.Name = "donGiaNhapLabel";
            donGiaNhapLabel.Size = new System.Drawing.Size(94, 17);
            donGiaNhapLabel.TabIndex = 6;
            donGiaNhapLabel.Text = "Đơn Giá Nhập";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(811, 63);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(118, 17);
            dVTLabel.TabIndex = 10;
            dVTLabel.Text = "Đơn Vị Tính Nhập";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_chitietnhap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1054, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_chitietnhap
            // 
            this.dgv_chitietnhap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitietnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chitietnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDV,
            this.TenDichVu,
            this.SoLuong,
            this.DonGiaNhap,
            this.DVT,
            this.ThanhTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chitietnhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chitietnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chitietnhap.EnableHeadersVisualStyles = false;
            this.dgv_chitietnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv_chitietnhap.Location = new System.Drawing.Point(3, 395);
            this.dgv_chitietnhap.Name = "dgv_chitietnhap";
            this.dgv_chitietnhap.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitietnhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_chitietnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietnhap.Size = new System.Drawing.Size(1048, 263);
            this.dgv_chitietnhap.TabIndex = 1;
            this.dgv_chitietnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietnhap_CellClick);
            this.dgv_chitietnhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietnhap_CellValueChanged);
            this.dgv_chitietnhap.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_chitietnhap_RowsAdded);
            this.dgv_chitietnhap.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_chitietnhap_RowsRemoved);
            // 
            // MaDV
            // 
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            this.MaDV.ReadOnly = true;
            this.MaDV.Width = 200;
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên Mặt Hàng";
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            this.TenDichVu.Width = 250;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng Nhập";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 200;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 200;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DVT.HeaderText = "Đơn Vị Tính Nhập";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupPanel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1048, 386);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupPanel1
            // 
            this.groupPanel1.AutoScroll = true;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.DTI_ngaynhap);
            this.groupPanel1.Controls.Add(this.btn_LuuPN);
            this.groupPanel1.Controls.Add(maPhieNhapLabel);
            this.groupPanel1.Controls.Add(this.txt_mapn);
            this.groupPanel1.Controls.Add(maNhanVienLabel);
            this.groupPanel1.Controls.Add(this.txt_manv);
            this.groupPanel1.Controls.Add(ngayNhapLabel);
            this.groupPanel1.Controls.Add(tongPNLabel);
            this.groupPanel1.Controls.Add(this.txt_tongpn);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1042, 187);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông tin phiếu nhập";
            // 
            // DTI_ngaynhap
            // 
            // 
            // 
            // 
            this.DTI_ngaynhap.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTI_ngaynhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_ngaynhap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTI_ngaynhap.ButtonDropDown.Visible = true;
            this.DTI_ngaynhap.IsPopupCalendarOpen = false;
            this.DTI_ngaynhap.Location = new System.Drawing.Point(381, 70);
            // 
            // 
            // 
            this.DTI_ngaynhap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_ngaynhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_ngaynhap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTI_ngaynhap.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTI_ngaynhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_ngaynhap.MonthCalendar.DisplayMonth = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.DTI_ngaynhap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.DTI_ngaynhap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTI_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_ngaynhap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTI_ngaynhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_ngaynhap.MonthCalendar.TodayButtonVisible = true;
            this.DTI_ngaynhap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.DTI_ngaynhap.Name = "DTI_ngaynhap";
            this.DTI_ngaynhap.Size = new System.Drawing.Size(200, 25);
            this.DTI_ngaynhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTI_ngaynhap.TabIndex = 0;
            // 
            // btn_LuuPN
            // 
            this.btn_LuuPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LuuPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_LuuPN.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
            this.btn_LuuPN.Location = new System.Drawing.Point(547, 105);
            this.btn_LuuPN.Name = "btn_LuuPN";
            this.btn_LuuPN.Size = new System.Drawing.Size(170, 42);
            this.btn_LuuPN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_LuuPN.TabIndex = 1;
            this.btn_LuuPN.Text = "Lưu Phiếu Nhập";
            this.btn_LuuPN.Click += new System.EventHandler(this.btn_LuuPN_Click);
            // 
            // txt_mapn
            // 
            this.txt_mapn.Enabled = false;
            this.txt_mapn.Location = new System.Drawing.Point(381, 17);
            this.txt_mapn.Name = "txt_mapn";
            this.txt_mapn.Size = new System.Drawing.Size(200, 25);
            this.txt_mapn.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(762, 20);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 25);
            this.txt_manv.TabIndex = 3;
            // 
            // txt_tongpn
            // 
            this.txt_tongpn.Enabled = false;
            this.txt_tongpn.Location = new System.Drawing.Point(759, 70);
            this.txt_tongpn.MaxLength = 1000;
            this.txt_tongpn.Name = "txt_tongpn";
            this.txt_tongpn.Size = new System.Drawing.Size(200, 25);
            this.txt_tongpn.TabIndex = 7;
            // 
            // groupPanel2
            // 
            this.groupPanel2.AutoScroll = true;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btn_xoachitiet);
            this.groupPanel2.Controls.Add(this.btn_suachitiet);
            this.groupPanel2.Controls.Add(this.btn_themchitiet);
            this.groupPanel2.Controls.Add(maDVLabel);
            this.groupPanel2.Controls.Add(this.txt_madv);
            this.groupPanel2.Controls.Add(tenDichVuLabel);
            this.groupPanel2.Controls.Add(this.txt_tendv);
            this.groupPanel2.Controls.Add(soLuongLabel);
            this.groupPanel2.Controls.Add(this.txt_sln);
            this.groupPanel2.Controls.Add(donGiaNhapLabel);
            this.groupPanel2.Controls.Add(this.txt_dgn);
            this.groupPanel2.Controls.Add(dVTLabel);
            this.groupPanel2.Controls.Add(this.txt_dvtn);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(3, 196);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1042, 187);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Thông tin dịch vụ";
            // 
            // btn_xoachitiet
            // 
            this.btn_xoachitiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoachitiet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoachitiet.Image = global::QuanLyQuanKaraoke.Properties.Resources.close_window_48;
            this.btn_xoachitiet.Location = new System.Drawing.Point(857, 99);
            this.btn_xoachitiet.Name = "btn_xoachitiet";
            this.btn_xoachitiet.Size = new System.Drawing.Size(168, 44);
            this.btn_xoachitiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoachitiet.TabIndex = 6;
            this.btn_xoachitiet.Text = "Xóa Chi Tiết";
            this.btn_xoachitiet.Click += new System.EventHandler(this.btn_xoachitiet_Click);
            // 
            // btn_suachitiet
            // 
            this.btn_suachitiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_suachitiet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_suachitiet.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
            this.btn_suachitiet.Location = new System.Drawing.Point(622, 100);
            this.btn_suachitiet.Name = "btn_suachitiet";
            this.btn_suachitiet.Size = new System.Drawing.Size(168, 44);
            this.btn_suachitiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_suachitiet.TabIndex = 5;
            this.btn_suachitiet.Text = "Sửa Chi Tiết";
            this.btn_suachitiet.Click += new System.EventHandler(this.btn_suachitiet_Click);
            // 
            // btn_themchitiet
            // 
            this.btn_themchitiet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_themchitiet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_themchitiet.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
            this.btn_themchitiet.Location = new System.Drawing.Point(362, 100);
            this.btn_themchitiet.Name = "btn_themchitiet";
            this.btn_themchitiet.Size = new System.Drawing.Size(168, 44);
            this.btn_themchitiet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_themchitiet.TabIndex = 4;
            this.btn_themchitiet.Text = "Thêm Chi Tiết";
            this.btn_themchitiet.Click += new System.EventHandler(this.btn_themchitiet_Click);
            // 
            // txt_madv
            // 
            this.txt_madv.Enabled = false;
            this.txt_madv.Location = new System.Drawing.Point(448, 11);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(144, 25);
            this.txt_madv.TabIndex = 1;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(759, 6);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(144, 25);
            this.txt_tendv.TabIndex = 0;
            this.txt_tendv.Leave += new System.EventHandler(this.txt_tendv_Leave);
            // 
            // txt_sln
            // 
            this.txt_sln.Location = new System.Drawing.Point(338, 58);
            this.txt_sln.Name = "txt_sln";
            this.txt_sln.Size = new System.Drawing.Size(144, 25);
            this.txt_sln.TabIndex = 1;
            this.txt_sln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sln_KeyPress);
            // 
            // txt_dgn
            // 
            this.txt_dgn.Location = new System.Drawing.Point(623, 60);
            this.txt_dgn.Name = "txt_dgn";
            this.txt_dgn.Size = new System.Drawing.Size(144, 25);
            this.txt_dgn.TabIndex = 2;
            this.txt_dgn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sln_KeyPress);
            // 
            // txt_dvtn
            // 
            this.txt_dvtn.Location = new System.Drawing.Point(939, 60);
            this.txt_dvtn.Name = "txt_dvtn";
            this.txt_dvtn.Size = new System.Drawing.Size(144, 25);
            this.txt_dvtn.TabIndex = 3;
            // 
            // dTS_QL_NhanVien
            // 
            this.dTS_QL_NhanVien.DataSetName = "DTS_QL_NhanVien";
            this.dTS_QL_NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTPN_DichVuTableAdapter = this.cTPN_DichVuTableAdapter;
            this.tableAdapterManager.CTPN_ThietBiTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.DoThatLacTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.ThietBiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTPN_DichVuTableAdapter
            // 
            this.cTPN_DichVuTableAdapter.ClearBeforeFill = true;
            // 
            // NhapKho_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NhapKho_DV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho Dịch Vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapKho_DV_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_ngaynhap)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_chitietnhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tongpn;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.TextBox txt_sln;
        private System.Windows.Forms.TextBox txt_dgn;
        private System.Windows.Forms.TextBox txt_dvtn;
        private DevComponents.DotNetBar.ButtonX btn_LuuPN;
        private DevComponents.DotNetBar.ButtonX btn_themchitiet;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTI_ngaynhap;
        private DevComponents.DotNetBar.ButtonX btn_xoachitiet;
        private DevComponents.DotNetBar.ButtonX btn_suachitiet;
        private DTS_QL_NhanVien dTS_QL_NhanVien;
        private DTS_QL_NhanVienTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DTS_QL_NhanVienTableAdapters.TableAdapterManager tableAdapterManager;
        private DTS_QL_NhanVienTableAdapters.CTPN_DichVuTableAdapter cTPN_DichVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}