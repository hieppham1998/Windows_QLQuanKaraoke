namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    partial class ThemDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDichVu));
            this.btn_luudv = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_tendvthem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_madvthem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_dvtthem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btn_luudv
            // 
            this.btn_luudv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luudv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luudv.Image = ((System.Drawing.Image)(resources.GetObject("btn_luudv.Image")));
            this.btn_luudv.Location = new System.Drawing.Point(207, 230);
            this.btn_luudv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luudv.Name = "btn_luudv";
            this.btn_luudv.Size = new System.Drawing.Size(148, 52);
            this.btn_luudv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luudv.TabIndex = 2;
            this.btn_luudv.Text = "Lưu";
            this.btn_luudv.Click += new System.EventHandler(this.btn_luudv_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(43, 89);
            this.labelX4.Margin = new System.Windows.Forms.Padding(5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(133, 39);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Tên Dịch Vụ";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 26);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(139, 39);
            this.labelX1.TabIndex = 21;
            this.labelX1.Text = "Mã Dịch Vụ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_tendvthem
            // 
            // 
            // 
            // 
            this.txt_tendvthem.Border.Class = "TextBoxBorder";
            this.txt_tendvthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tendvthem.Location = new System.Drawing.Point(199, 96);
            this.txt_tendvthem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tendvthem.Name = "txt_tendvthem";
            this.txt_tendvthem.Size = new System.Drawing.Size(263, 25);
            this.txt_tendvthem.TabIndex = 0;
            // 
            // txt_madvthem
            // 
            // 
            // 
            // 
            this.txt_madvthem.Border.Class = "TextBoxBorder";
            this.txt_madvthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_madvthem.Enabled = false;
            this.txt_madvthem.Location = new System.Drawing.Point(199, 33);
            this.txt_madvthem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_madvthem.Name = "txt_madvthem";
            this.txt_madvthem.Size = new System.Drawing.Size(263, 25);
            this.txt_madvthem.TabIndex = 14;
            // 
            // txt_dvtthem
            // 
            // 
            // 
            // 
            this.txt_dvtthem.Border.Class = "TextBoxBorder";
            this.txt_dvtthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_dvtthem.Location = new System.Drawing.Point(199, 162);
            this.txt_dvtthem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_dvtthem.Name = "txt_dvtthem";
            this.txt_dvtthem.Size = new System.Drawing.Size(263, 25);
            this.txt_dvtthem.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 154);
            this.labelX2.Margin = new System.Windows.Forms.Padding(5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(163, 39);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Đơn Vị Tính Nhỏ Nhất";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // ThemDichVu
            // 
            this.AcceptButton = this.btn_luudv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 339);
            this.Controls.Add(this.btn_luudv);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_tendvthem);
            this.Controls.Add(this.txt_dvtthem);
            this.Controls.Add(this.txt_madvthem);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Dịch Vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemDichVu_FormClosing);
            this.Load += new System.EventHandler(this.ThemDichVu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_luudv;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tendvthem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_madvthem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_dvtthem;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}