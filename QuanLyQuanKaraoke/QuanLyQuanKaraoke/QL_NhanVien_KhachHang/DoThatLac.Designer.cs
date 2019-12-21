namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    partial class DoThatLac
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
            this.dgv_dothatlac = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doThatLacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTS_QL_NhanVien = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVien();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbnow = new System.Windows.Forms.Label();
            this.btn_ThemDTL = new DevComponents.DotNetBar.ButtonX();
            this.btn_SuaDTL = new DevComponents.DotNetBar.ButtonX();
            this.btn_XoaDTL = new DevComponents.DotNetBar.ButtonX();
            this.lbgio = new System.Windows.Forms.Label();
            this.lbngay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbbsaf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_GhiChu_DTL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbb_MaPhong_DTL = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doThatLacTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.DoThatLacTableAdapter();
            this.tableAdapterManager = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager();
            this.phongTableAdapter = new QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.PhongTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dothatlac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doThatLacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_dothatlac, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(690, 490);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // dgv_dothatlac
            // 
            this.dgv_dothatlac.AllowUserToAddRows = false;
            this.dgv_dothatlac.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dothatlac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_dothatlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dothatlac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_dothatlac.DataSource = this.doThatLacBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dothatlac.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dothatlac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dothatlac.EnableHeadersVisualStyles = false;
            this.dgv_dothatlac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_dothatlac.Location = new System.Drawing.Point(3, 303);
            this.dgv_dothatlac.Name = "dgv_dothatlac";
            this.dgv_dothatlac.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dothatlac.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_dothatlac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dothatlac.Size = new System.Drawing.Size(684, 184);
            this.dgv_dothatlac.TabIndex = 1;
            this.dgv_dothatlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dothatlac_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phòng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NgayGio";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày, giờ khách để quên đồ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // doThatLacBindingSource
            // 
            this.doThatLacBindingSource.DataMember = "DoThatLac";
            this.doThatLacBindingSource.DataSource = this.dTS_QL_NhanVien;
            // 
            // dTS_QL_NhanVien
            // 
            this.dTS_QL_NhanVien.DataSetName = "DTS_QL_NhanVien";
            this.dTS_QL_NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 620F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(684, 294);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbnow);
            this.panel1.Controls.Add(this.btn_ThemDTL);
            this.panel1.Controls.Add(this.btn_SuaDTL);
            this.panel1.Controls.Add(this.btn_XoaDTL);
            this.panel1.Controls.Add(this.lbgio);
            this.panel1.Controls.Add(this.lbngay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbbsaf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_GhiChu_DTL);
            this.panel1.Controls.Add(this.cbb_MaPhong_DTL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(35, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 288);
            this.panel1.TabIndex = 0;
            // 
            // lbnow
            // 
            this.lbnow.AutoSize = true;
            this.lbnow.Location = new System.Drawing.Point(344, 37);
            this.lbnow.Name = "lbnow";
            this.lbnow.Size = new System.Drawing.Size(0, 19);
            this.lbnow.TabIndex = 53;
            // 
            // btn_ThemDTL
            // 
            this.btn_ThemDTL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ThemDTL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ThemDTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDTL.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_add_48;
            this.btn_ThemDTL.Location = new System.Drawing.Point(127, 214);
            this.btn_ThemDTL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemDTL.Name = "btn_ThemDTL";
            this.btn_ThemDTL.Size = new System.Drawing.Size(112, 41);
            this.btn_ThemDTL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ThemDTL.TabIndex = 0;
            this.btn_ThemDTL.Text = "Thêm";
            this.btn_ThemDTL.Click += new System.EventHandler(this.btn_ThemDTL_Click);
            // 
            // btn_SuaDTL
            // 
            this.btn_SuaDTL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SuaDTL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SuaDTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaDTL.Image = global::QuanLyQuanKaraoke.Properties.Resources.icons8_update_48;
            this.btn_SuaDTL.Location = new System.Drawing.Point(278, 214);
            this.btn_SuaDTL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaDTL.Name = "btn_SuaDTL";
            this.btn_SuaDTL.Size = new System.Drawing.Size(112, 39);
            this.btn_SuaDTL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SuaDTL.TabIndex = 1;
            this.btn_SuaDTL.Text = "Sửa";
            this.btn_SuaDTL.Click += new System.EventHandler(this.btn_SuaDTL_Click);
            // 
            // btn_XoaDTL
            // 
            this.btn_XoaDTL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XoaDTL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_XoaDTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDTL.Image = global::QuanLyQuanKaraoke.Properties.Resources.close_window_48;
            this.btn_XoaDTL.Location = new System.Drawing.Point(431, 214);
            this.btn_XoaDTL.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaDTL.Name = "btn_XoaDTL";
            this.btn_XoaDTL.Size = new System.Drawing.Size(109, 41);
            this.btn_XoaDTL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_XoaDTL.TabIndex = 2;
            this.btn_XoaDTL.Text = "Xóa";
            this.btn_XoaDTL.Click += new System.EventHandler(this.btn_XoaDTL_Click);
            // 
            // lbgio
            // 
            this.lbgio.AutoSize = true;
            this.lbgio.Location = new System.Drawing.Point(427, 80);
            this.lbgio.Name = "lbgio";
            this.lbgio.Size = new System.Drawing.Size(0, 19);
            this.lbgio.TabIndex = 48;
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Location = new System.Drawing.Point(227, 80);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(0, 19);
            this.lbngay.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Giờ nhận đồ:";
            // 
            // lbbsaf
            // 
            this.lbbsaf.AutoSize = true;
            this.lbbsaf.Location = new System.Drawing.Point(123, 80);
            this.lbbsaf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbsaf.Name = "lbbsaf";
            this.lbbsaf.Size = new System.Drawing.Size(97, 19);
            this.lbbsaf.TabIndex = 45;
            this.lbbsaf.Text = "Ngày nhận đồ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ghi Chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã Phòng:";
            // 
            // txt_GhiChu_DTL
            // 
            this.txt_GhiChu_DTL.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txt_GhiChu_DTL.Border.Class = "TextBoxBorder";
            this.txt_GhiChu_DTL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_GhiChu_DTL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doThatLacBindingSource, "GhiChu", true));
            this.txt_GhiChu_DTL.Enabled = false;
            this.txt_GhiChu_DTL.ForeColor = System.Drawing.Color.Black;
            this.txt_GhiChu_DTL.Location = new System.Drawing.Point(127, 126);
            this.txt_GhiChu_DTL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GhiChu_DTL.Multiline = true;
            this.txt_GhiChu_DTL.Name = "txt_GhiChu_DTL";
            this.txt_GhiChu_DTL.Size = new System.Drawing.Size(414, 67);
            this.txt_GhiChu_DTL.TabIndex = 44;
            // 
            // cbb_MaPhong_DTL
            // 
            this.cbb_MaPhong_DTL.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phongBindingSource, "MaPhong", true));
            this.cbb_MaPhong_DTL.DataSource = this.phongBindingSource1;
            this.cbb_MaPhong_DTL.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbb_MaPhong_DTL.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_MaPhong_DTL.DisplayMember = "MaPhong";
            this.cbb_MaPhong_DTL.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_MaPhong_DTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_MaPhong_DTL.Enabled = false;
            this.cbb_MaPhong_DTL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaPhong_DTL.FormattingEnabled = true;
            this.cbb_MaPhong_DTL.ItemHeight = 20;
            this.cbb_MaPhong_DTL.Location = new System.Drawing.Point(127, 33);
            this.cbb_MaPhong_DTL.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_MaPhong_DTL.Name = "cbb_MaPhong_DTL";
            this.cbb_MaPhong_DTL.Size = new System.Drawing.Size(132, 26);
            this.cbb_MaPhong_DTL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_MaPhong_DTL.TabIndex = 43;
            this.cbb_MaPhong_DTL.ValueMember = "MaPhong";
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.dTS_QL_NhanVien;
            // 
            // phongBindingSource1
            // 
            this.phongBindingSource1.DataMember = "Phong";
            this.phongBindingSource1.DataSource = this.dTS_QL_NhanVien;
            // 
            // doThatLacTableAdapter
            // 
            this.doThatLacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTPN_DichVuTableAdapter = null;
            this.tableAdapterManager.CTPN_ThietBiTableAdapter = null;
            this.tableAdapterManager.DichVuTableAdapter = null;
            this.tableAdapterManager.DoThatLacTableAdapter = this.doThatLacTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhongTableAdapter = null;
            this.tableAdapterManager.ThietBiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyQuanKaraoke.QL_NhanVien_KhachHang.DTS_QL_NhanVienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DoThatLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoThatLac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ Thất Lạc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoThatLac_FormClosing);
            this.Load += new System.EventHandler(this.DoThatLac_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dothatlac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doThatLacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTS_QL_NhanVien)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbbsaf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_GhiChu_DTL;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_MaPhong_DTL;
        private DTS_QL_NhanVien dTS_QL_NhanVien;
        private System.Windows.Forms.BindingSource doThatLacBindingSource;
        private DTS_QL_NhanVienTableAdapters.DoThatLacTableAdapter doThatLacTableAdapter;
        private DTS_QL_NhanVienTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_dothatlac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private DTS_QL_NhanVienTableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource1;
        private System.Windows.Forms.Label lbgio;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btn_ThemDTL;
        private DevComponents.DotNetBar.ButtonX btn_SuaDTL;
        private DevComponents.DotNetBar.ButtonX btn_XoaDTL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbnow;

    }
}