namespace QuanLyQuanKaraoke
{
    partial class ThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTaiKhoan));
            this.txtten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtmatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtmanv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_TaiKhoan = new QuanLyQuanKaraoke.QL_TaiKhoan();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbbnhom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.qL_NhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.cbbhoten = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ckbHoatDong = new System.Windows.Forms.CheckBox();
            this.qL_NhomNguoiDungTableAdapter = new QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.QL_NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.NhanVienTableAdapter();
            this.qL_TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_TaiKhoanTableAdapter = new QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.QL_TaiKhoanTableAdapter();
            this.qL_PhanQuyenTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PhanQuyenTaiKhoanTableAdapter = new QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.QL_PhanQuyenTaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtten
            // 
            // 
            // 
            // 
            this.txtten.Border.Class = "TextBoxBorder";
            this.txtten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtten.Location = new System.Drawing.Point(173, 32);
            this.txtten.Margin = new System.Windows.Forms.Padding(4);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(197, 25);
            this.txtten.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(52, 29);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 30);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tên Đăng Nhập:";
            // 
            // txtmatkhau
            // 
            // 
            // 
            // 
            this.txtmatkhau.Border.Class = "TextBoxBorder";
            this.txtmatkhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmatkhau.Enabled = false;
            this.txtmatkhau.Location = new System.Drawing.Point(174, 204);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(197, 25);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.Text = "11111";
            this.txtmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(81, 202);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 30);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Mật Khẩu:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(78, 159);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(78, 30);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Hoạt Động:";
            // 
            // txtmanv
            // 
            // 
            // 
            // 
            this.txtmanv.Border.Class = "TextBoxBorder";
            this.txtmanv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmanv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNV", true));
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(173, 75);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(197, 25);
            this.txtmanv.TabIndex = 1;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qL_TaiKhoan;
            // 
            // qL_TaiKhoan
            // 
            this.qL_TaiKhoan.DataSetName = "QL_TaiKhoan";
            this.qL_TaiKhoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(56, 74);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 30);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Mã Nhân Viên:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(101, 117);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(55, 30);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Họ Tên:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(26, 246);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(130, 30);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Nhóm Người Dùng:";
            // 
            // cbbnhom
            // 
            this.cbbnhom.DataSource = this.qL_NhomNguoiDungBindingSource;
            this.cbbnhom.DisplayMember = "TenNhom";
            this.cbbnhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbnhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnhom.FormattingEnabled = true;
            this.cbbnhom.ItemHeight = 19;
            this.cbbnhom.Location = new System.Drawing.Point(174, 251);
            this.cbbnhom.Name = "cbbnhom";
            this.cbbnhom.Size = new System.Drawing.Size(196, 25);
            this.cbbnhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbnhom.TabIndex = 3;
            this.cbbnhom.ValueMember = "MaNhom";
            // 
            // qL_NhomNguoiDungBindingSource
            // 
            this.qL_NhomNguoiDungBindingSource.DataMember = "QL_NhomNguoiDung";
            this.qL_NhomNguoiDungBindingSource.DataSource = this.qL_TaiKhoan;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(153, 304);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 40);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbhoten
            // 
            this.cbbhoten.DataSource = this.nhanVienBindingSource;
            this.cbbhoten.DisplayMember = "TenNV";
            this.cbbhoten.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbhoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbhoten.FormattingEnabled = true;
            this.cbbhoten.ItemHeight = 19;
            this.cbbhoten.Location = new System.Drawing.Point(175, 117);
            this.cbbhoten.Name = "cbbhoten";
            this.cbbhoten.Size = new System.Drawing.Size(196, 25);
            this.cbbhoten.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbhoten.TabIndex = 1;
            this.cbbhoten.ValueMember = "MaNV";
            // 
            // ckbHoatDong
            // 
            this.ckbHoatDong.Location = new System.Drawing.Point(175, 165);
            this.ckbHoatDong.Name = "ckbHoatDong";
            this.ckbHoatDong.Size = new System.Drawing.Size(31, 24);
            this.ckbHoatDong.TabIndex = 13;
            this.ckbHoatDong.UseVisualStyleBackColor = true;
            // 
            // qL_NhomNguoiDungTableAdapter
            // 
            this.qL_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.QL_NhomNguoiDungTableAdapter = this.qL_NhomNguoiDungTableAdapter;
            this.tableAdapterManager.QL_PhanQuyenTableAdapter = null;
            this.tableAdapterManager.QL_PhanQuyenTaiKhoanTableAdapter = null;
            this.tableAdapterManager.QL_TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyQuanKaraoke.QL_TaiKhoanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // qL_TaiKhoanBindingSource
            // 
            this.qL_TaiKhoanBindingSource.DataMember = "QL_TaiKhoan";
            this.qL_TaiKhoanBindingSource.DataSource = this.qL_TaiKhoan;
            // 
            // qL_TaiKhoanTableAdapter
            // 
            this.qL_TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PhanQuyenTaiKhoanBindingSource
            // 
            this.qL_PhanQuyenTaiKhoanBindingSource.DataMember = "QL_PhanQuyenTaiKhoan";
            this.qL_PhanQuyenTaiKhoanBindingSource.DataSource = this.qL_TaiKhoan;
            // 
            // qL_PhanQuyenTaiKhoanTableAdapter
            // 
            this.qL_PhanQuyenTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 396);
            this.Controls.Add(this.ckbHoatDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbbhoten);
            this.Controls.Add(this.cbbnhom);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtten);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.ThemTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PhanQuyenTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtten;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmatkhau;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmanv;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbnhom;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbhoten;
        private QL_TaiKhoan qL_TaiKhoan;
        private System.Windows.Forms.BindingSource qL_NhomNguoiDungBindingSource;
        private QL_TaiKhoanTableAdapters.QL_NhomNguoiDungTableAdapter qL_NhomNguoiDungTableAdapter;
        private QL_TaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private QL_TaiKhoanTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.CheckBox ckbHoatDong;
        private System.Windows.Forms.BindingSource qL_TaiKhoanBindingSource;
        private QL_TaiKhoanTableAdapters.QL_TaiKhoanTableAdapter qL_TaiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.BindingSource qL_PhanQuyenTaiKhoanBindingSource;
        private QL_TaiKhoanTableAdapters.QL_PhanQuyenTaiKhoanTableAdapter qL_PhanQuyenTaiKhoanTableAdapter;
    }
}