namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    partial class NhapKho_TB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_chitietnhap = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_xoachitiet = new DevComponents.DotNetBar.ButtonX();
            this.btn_suachitiet = new DevComponents.DotNetBar.ButtonX();
            this.btn_themchitiet = new DevComponents.DotNetBar.ButtonX();
            this.txt_matb = new System.Windows.Forms.TextBox();
            this.txt_tentb = new System.Windows.Forms.TextBox();
            this.txt_sln = new System.Windows.Forms.TextBox();
            this.txt_dgn = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.DTI_ngaynhap = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btn_LuuPN = new DevComponents.DotNetBar.ButtonX();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tongpn = new System.Windows.Forms.TextBox();
            this.dTS_QL_NhanVien = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVien();
            this.phieuNhapTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager();
            this.cTPN_ThietBiTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.CTPN_ThietBiTableAdapter();
            maPhieNhapLabel = new System.Windows.Forms.Label();
            maNhanVienLabel = new System.Windows.Forms.Label();
            ngayNhapLabel = new System.Windows.Forms.Label();
            tongPNLabel = new System.Windows.Forms.Label();
            maDVLabel = new System.Windows.Forms.Label();
            tenDichVuLabel = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaNhapLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_ngaynhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // maPhieNhapLabel
            // 
            maPhieNhapLabel.AutoSize = true;
            maPhieNhapLabel.Location = new System.Drawing.Point(270, 20);
            maPhieNhapLabel.Name = "maPhieNhapLabel";
            maPhieNhapLabel.Size = new System.Drawing.Size(108, 19);
            maPhieNhapLabel.TabIndex = 0;
            maPhieNhapLabel.Text = "Mã Phiếu Nhập:";
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(676, 23);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(101, 19);
            maNhanVienLabel.TabIndex = 2;
            maNhanVienLabel.Text = "Mã Nhân Viên:";
            // 
            // ngayNhapLabel
            // 
            ngayNhapLabel.AutoSize = true;
            ngayNhapLabel.Location = new System.Drawing.Point(295, 74);
            ngayNhapLabel.Name = "ngayNhapLabel";
            ngayNhapLabel.Size = new System.Drawing.Size(80, 19);
            ngayNhapLabel.TabIndex = 4;
            ngayNhapLabel.Text = "Ngày Nhập";
            // 
            // tongPNLabel
            // 
            tongPNLabel.AutoSize = true;
            tongPNLabel.Location = new System.Drawing.Point(659, 73);
            tongPNLabel.Name = "tongPNLabel";
            tongPNLabel.Size = new System.Drawing.Size(118, 19);
            tongPNLabel.TabIndex = 6;
            tongPNLabel.Text = "Tổng Phiếu Nhập:";
            // 
            // maDVLabel
            // 
            maDVLabel.AutoSize = true;
            maDVLabel.Location = new System.Drawing.Point(326, 14);
            maDVLabel.Name = "maDVLabel";
            maDVLabel.Size = new System.Drawing.Size(81, 19);
            maDVLabel.TabIndex = 0;
            maDVLabel.Text = "Mã Thiết Bị";
            // 
            // tenDichVuLabel
            // 
            tenDichVuLabel.AutoSize = true;
            tenDichVuLabel.Location = new System.Drawing.Point(705, 11);
            tenDichVuLabel.Name = "tenDichVuLabel";
            tenDichVuLabel.Size = new System.Drawing.Size(83, 19);
            tenDichVuLabel.TabIndex = 2;
            tenDichVuLabel.Text = "Tên Thiết Bị";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(320, 58);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(108, 19);
            soLuongLabel.TabIndex = 4;
            soLuongLabel.Text = "Số Lượng Nhập";
            // 
            // donGiaNhapLabel
            // 
            donGiaNhapLabel.AutoSize = true;
            donGiaNhapLabel.Location = new System.Drawing.Point(705, 61);
            donGiaNhapLabel.Name = "donGiaNhapLabel";
            donGiaNhapLabel.Size = new System.Drawing.Size(98, 19);
            donGiaNhapLabel.TabIndex = 6;
            donGiaNhapLabel.Text = "Đơn Giá Nhập";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_chitietnhap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_chitietnhap
            // 
            this.dgv_chitietnhap.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitietnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_chitietnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.TenThietBi,
            this.SoLuong,
            this.DonGiaNhap,
            this.ThanhTien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chitietnhap.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_chitietnhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_chitietnhap.EnableHeadersVisualStyles = false;
            this.dgv_chitietnhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgv_chitietnhap.Location = new System.Drawing.Point(3, 434);
            this.dgv_chitietnhap.Name = "dgv_chitietnhap";
            this.dgv_chitietnhap.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitietnhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_chitietnhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietnhap.Size = new System.Drawing.Size(907, 115);
            this.dgv_chitietnhap.TabIndex = 2;
            this.dgv_chitietnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietnhap_CellClick);
            this.dgv_chitietnhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietnhap_CellValueChanged);
            this.dgv_chitietnhap.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_chitietnhap_RowsAdded);
            this.dgv_chitietnhap.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_chitietnhap_RowsRemoved);
            // 
            // MaThietBi
            // 
            this.MaThietBi.HeaderText = "Mã Thiết Bị";
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.ReadOnly = true;
            this.MaThietBi.Width = 200;
            // 
            // TenThietBi
            // 
            this.TenThietBi.HeaderText = "Tên Thiết Bị";
            this.TenThietBi.Name = "TenThietBi";
            this.TenThietBi.ReadOnly = true;
            this.TenThietBi.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng Nhập";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 250;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 250;
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
            this.tableLayoutPanel2.Controls.Add(this.groupPanel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 425);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.groupPanel2.Controls.Add(this.txt_matb);
            this.groupPanel2.Controls.Add(tenDichVuLabel);
            this.groupPanel2.Controls.Add(this.txt_tentb);
            this.groupPanel2.Controls.Add(soLuongLabel);
            this.groupPanel2.Controls.Add(this.txt_sln);
            this.groupPanel2.Controls.Add(donGiaNhapLabel);
            this.groupPanel2.Controls.Add(this.txt_dgn);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(3, 215);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(901, 207);
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
            this.groupPanel2.TabIndex = 2;
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
            this.btn_xoachitiet.TabIndex = 5;
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
            this.btn_suachitiet.TabIndex = 4;
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
            this.btn_themchitiet.TabIndex = 3;
            this.btn_themchitiet.Text = "Thêm Chi Tiết";
            this.btn_themchitiet.Click += new System.EventHandler(this.btn_themchitiet_Click);
            // 
            // txt_matb
            // 
            this.txt_matb.Enabled = false;
            this.txt_matb.Location = new System.Drawing.Point(428, 11);
            this.txt_matb.Name = "txt_matb";
            this.txt_matb.Size = new System.Drawing.Size(163, 26);
            this.txt_matb.TabIndex = 1;
            // 
            // txt_tentb
            // 
            this.txt_tentb.Location = new System.Drawing.Point(807, 6);
            this.txt_tentb.Name = "txt_tentb";
            this.txt_tentb.Size = new System.Drawing.Size(163, 26);
            this.txt_tentb.TabIndex = 0;
            this.txt_tentb.Leave += new System.EventHandler(this.txt_tentb_Leave);
            // 
            // txt_sln
            // 
            this.txt_sln.Location = new System.Drawing.Point(428, 55);
            this.txt_sln.Name = "txt_sln";
            this.txt_sln.Size = new System.Drawing.Size(163, 26);
            this.txt_sln.TabIndex = 1;
            this.txt_sln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sln_KeyPress);
            // 
            // txt_dgn
            // 
            this.txt_dgn.Location = new System.Drawing.Point(807, 58);
            this.txt_dgn.Name = "txt_dgn";
            this.txt_dgn.Size = new System.Drawing.Size(163, 26);
            this.txt_dgn.TabIndex = 2;
            this.txt_dgn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sln_KeyPress);
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
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(901, 206);
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
            this.groupPanel1.TabIndex = 1;
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
            this.DTI_ngaynhap.Size = new System.Drawing.Size(200, 26);
            this.DTI_ngaynhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DTI_ngaynhap.TabIndex = 0;
            // 
            // btn_LuuPN
            // 
            this.btn_LuuPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LuuPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_LuuPN.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_download_30;
            this.btn_LuuPN.Location = new System.Drawing.Point(547, 113);
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
            this.txt_mapn.Size = new System.Drawing.Size(200, 26);
            this.txt_mapn.TabIndex = 1;
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(781, 20);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(200, 26);
            this.txt_manv.TabIndex = 3;
            // 
            // txt_tongpn
            // 
            this.txt_tongpn.Enabled = false;
            this.txt_tongpn.Location = new System.Drawing.Point(781, 70);
            this.txt_tongpn.Name = "txt_tongpn";
            this.txt_tongpn.Size = new System.Drawing.Size(200, 26);
            this.txt_tongpn.TabIndex = 7;
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
            this.tableAdapterManager.CTPN_DichVuTableAdapter = null;
            this.tableAdapterManager.CTPN_ThietBiTableAdapter = this.cTPN_ThietBiTableAdapter;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.DoThatLacTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.ThietBiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTPN_ThietBiTableAdapter
            // 
            this.cTPN_ThietBiTableAdapter.ClearBeforeFill = true;
            // 
            // NhapKho_TB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NhapKho_TB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho Thiết Bị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapKho_TB_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietnhap)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTI_ngaynhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DTI_ngaynhap;
        private DevComponents.DotNetBar.ButtonX btn_LuuPN;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.TextBox txt_tongpn;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btn_xoachitiet;
        private DevComponents.DotNetBar.ButtonX btn_suachitiet;
        private DevComponents.DotNetBar.ButtonX btn_themchitiet;
        private System.Windows.Forms.TextBox txt_matb;
        private System.Windows.Forms.TextBox txt_tentb;
        private System.Windows.Forms.TextBox txt_sln;
        private System.Windows.Forms.TextBox txt_dgn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_chitietnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private DTS_QL_NhanVien dTS_QL_NhanVien;
        private DTS_QL_NhanVienTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DTS_QL_NhanVienTableAdapters.TableAdapterManager tableAdapterManager;
        private DTS_QL_NhanVienTableAdapters.CTPN_ThietBiTableAdapter cTPN_ThietBiTableAdapter;
    }
}