namespace QuanLyQuanKaraoke
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SuaNV = new DevComponents.DotNetBar.ButtonX();
            this.btn_ThemNV = new DevComponents.DotNetBar.ButtonX();
            this.cbb_GioiTinhNV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTS_QL_NhanVien = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVien();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.DTI_NgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label8 = new System.Windows.Forms.Label();
            this.DTI_NgayVaoLam = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CMNDNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SDTNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DiaChiNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTen_NV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMa_NV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_NgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_NgayVaoLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvNhanVien, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.1781F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.82191F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.tableLayoutPanel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(2, 2);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1089, 249);
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
            this.groupPanel1.Text = "Thông tin nhân viên";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1083, 225);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SuaNV);
            this.panel1.Controls.Add(this.btn_ThemNV);
            this.panel1.Controls.Add(this.cbb_GioiTinhNV);
            this.panel1.Controls.Add(this.DTI_NgaySinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DTI_NgayVaoLam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_CMNDNV);
            this.panel1.Controls.Add(this.txt_SDTNV);
            this.panel1.Controls.Add(this.txt_DiaChiNV);
            this.panel1.Controls.Add(this.txtTen_NV);
            this.panel1.Controls.Add(this.txtMa_NV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(165, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 219);
            this.panel1.TabIndex = 0;
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SuaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
            this.btn_SuaNV.Location = new System.Drawing.Point(443, 207);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(136, 48);
            this.btn_SuaNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SuaNV.TabIndex = 7;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
            this.btn_ThemNV.Location = new System.Drawing.Point(233, 207);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(136, 48);
            this.btn_ThemNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemNV.TabIndex = 6;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // cbb_GioiTinhNV
            // 
            this.cbb_GioiTinhNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "GioiTinh", true));
            this.cbb_GioiTinhNV.DisplayMember = "Text";
            this.cbb_GioiTinhNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_GioiTinhNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_GioiTinhNV.Enabled = false;
            this.cbb_GioiTinhNV.FormattingEnabled = true;
            this.cbb_GioiTinhNV.ItemHeight = 17;
            this.cbb_GioiTinhNV.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbb_GioiTinhNV.Location = new System.Drawing.Point(162, 113);
            this.cbb_GioiTinhNV.Name = "cbb_GioiTinhNV";
            this.cbb_GioiTinhNV.Size = new System.Drawing.Size(175, 23);
            this.cbb_GioiTinhNV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_GioiTinhNV.TabIndex = 1;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dTS_QL_NhanVien;
            // 
            // dTS_QL_NhanVien
            // 
            this.dTS_QL_NhanVien.DataSetName = "DTS_QL_NhanVien";
            this.dTS_QL_NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Nam";
            this.comboItem1.Value = "Nam";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Nữ";
            this.comboItem2.Value = "Nữ";
            // 
            // DTI_NgaySinh
            // 
            // 
            // 
            // 
            this.DTI_NgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTI_NgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTI_NgaySinh.ButtonDropDown.Visible = true;
            this.DTI_NgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.nhanVienBindingSource, "NgaySinh", true));
            this.DTI_NgaySinh.Enabled = false;
            this.DTI_NgaySinh.IsPopupCalendarOpen = false;
            this.DTI_NgaySinh.Location = new System.Drawing.Point(520, 25);
            // 
            // 
            // 
            this.DTI_NgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_NgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTI_NgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTI_NgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.DTI_NgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.DTI_NgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTI_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_NgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTI_NgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.DTI_NgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.DTI_NgaySinh.Name = "DTI_NgaySinh";
            this.DTI_NgaySinh.Size = new System.Drawing.Size(187, 23);
            this.DTI_NgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTI_NgaySinh.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày Sinh:";
            // 
            // DTI_NgayVaoLam
            // 
            // 
            // 
            // 
            this.DTI_NgayVaoLam.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DTI_NgayVaoLam.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgayVaoLam.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DTI_NgayVaoLam.ButtonDropDown.Visible = true;
            this.DTI_NgayVaoLam.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.nhanVienBindingSource, "NgayVaoLam", true));
            this.DTI_NgayVaoLam.Enabled = false;
            this.DTI_NgayVaoLam.IsPopupCalendarOpen = false;
            this.DTI_NgayVaoLam.Location = new System.Drawing.Point(520, 154);
            // 
            // 
            // 
            this.DTI_NgayVaoLam.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_NgayVaoLam.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgayVaoLam.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DTI_NgayVaoLam.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DTI_NgayVaoLam.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgayVaoLam.MonthCalendar.DisplayMonth = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.DTI_NgayVaoLam.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.DTI_NgayVaoLam.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DTI_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DTI_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DTI_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DTI_NgayVaoLam.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DTI_NgayVaoLam.MonthCalendar.TodayButtonVisible = true;
            this.DTI_NgayVaoLam.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.DTI_NgayVaoLam.Name = "DTI_NgayVaoLam";
            this.DTI_NgayVaoLam.Size = new System.Drawing.Size(187, 23);
            this.DTI_NgayVaoLam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTI_NgayVaoLam.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ngày Vào Làm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giới Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // txt_CMNDNV
            // 
            // 
            // 
            // 
            this.txt_CMNDNV.Border.Class = "TextBoxBorder";
            this.txt_CMNDNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_CMNDNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "CMND", true));
            this.txt_CMNDNV.Enabled = false;
            this.txt_CMNDNV.Location = new System.Drawing.Point(520, 113);
            this.txt_CMNDNV.MaxLength = 9;
            this.txt_CMNDNV.Name = "txt_CMNDNV";
            this.txt_CMNDNV.Size = new System.Drawing.Size(187, 23);
            this.txt_CMNDNV.TabIndex = 4;
            this.txt_CMNDNV.TextChanged += new System.EventHandler(this.txtTen_NV_TextChanged);
            this.txt_CMNDNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDTNV_KeyPress);
            // 
            // txt_SDTNV
            // 
            // 
            // 
            // 
            this.txt_SDTNV.Border.Class = "TextBoxBorder";
            this.txt_SDTNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SDTNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "SDT", true));
            this.txt_SDTNV.Enabled = false;
            this.txt_SDTNV.Location = new System.Drawing.Point(520, 69);
            this.txt_SDTNV.MaxLength = 10;
            this.txt_SDTNV.Name = "txt_SDTNV";
            this.txt_SDTNV.Size = new System.Drawing.Size(187, 23);
            this.txt_SDTNV.TabIndex = 3;
            this.txt_SDTNV.TextChanged += new System.EventHandler(this.txtTen_NV_TextChanged);
            this.txt_SDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDTNV_KeyPress);
            this.txt_SDTNV.Leave += new System.EventHandler(this.txt_SDTNV_Leave);
            // 
            // txt_DiaChiNV
            // 
            // 
            // 
            // 
            this.txt_DiaChiNV.Border.Class = "TextBoxBorder";
            this.txt_DiaChiNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DiaChiNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.txt_DiaChiNV.Enabled = false;
            this.txt_DiaChiNV.Location = new System.Drawing.Point(162, 158);
            this.txt_DiaChiNV.Name = "txt_DiaChiNV";
            this.txt_DiaChiNV.Size = new System.Drawing.Size(175, 23);
            this.txt_DiaChiNV.TabIndex = 2;
            this.txt_DiaChiNV.TextChanged += new System.EventHandler(this.txtTen_NV_TextChanged);
            // 
            // txtTen_NV
            // 
            // 
            // 
            // 
            this.txtTen_NV.Border.Class = "TextBoxBorder";
            this.txtTen_NV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTen_NV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNV", true));
            this.txtTen_NV.Enabled = false;
            this.txtTen_NV.Location = new System.Drawing.Point(162, 69);
            this.txtTen_NV.Name = "txtTen_NV";
            this.txtTen_NV.Size = new System.Drawing.Size(175, 23);
            this.txtTen_NV.TabIndex = 0;
            this.txtTen_NV.TextChanged += new System.EventHandler(this.txtTen_NV_TextChanged);
            // 
            // txtMa_NV
            // 
            // 
            // 
            // 
            this.txtMa_NV.Border.Class = "TextBoxBorder";
            this.txtMa_NV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMa_NV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.txtMa_NV.Enabled = false;
            this.txtMa_NV.Location = new System.Drawing.Point(162, 27);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(175, 23);
            this.txtMa_NV.TabIndex = 24;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.ngayVaoLamDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nhanVienBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(2, 255);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1089, 330);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNVDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên Nhân Viên";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            this.tenNVDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNVDataGridViewTextBoxColumn.Width = 200;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 150;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 250;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "Số Điện Thoại";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 150;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMNDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ngayVaoLamDataGridViewTextBoxColumn
            // 
            this.ngayVaoLamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam";
            this.ngayVaoLamDataGridViewTextBoxColumn.HeaderText = "Ngày Vào Làm";
            this.ngayVaoLamDataGridViewTextBoxColumn.Name = "ngayVaoLamDataGridViewTextBoxColumn";
            this.ngayVaoLamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTPN_DichVuTableAdapter = null;
            this.tableAdapterManager.CTPN_ThietBiTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.DoThatLacTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.ThietBiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_NgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_NgayVaoLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_GioiTinhNV;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTI_NgayVaoLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_CMNDNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SDTNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DiaChiNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTen_NV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMa_NV;
        private DevComponents.DotNetBar.ButtonX btn_SuaNV;
        private DevComponents.DotNetBar.ButtonX btn_ThemNV;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private QL_NhanVien_KhachHang.DTS_QL_NhanVien dTS_QL_NhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLamDataGridViewTextBoxColumn;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTI_NgaySinh;
        private System.Windows.Forms.Label label8;

    }
}