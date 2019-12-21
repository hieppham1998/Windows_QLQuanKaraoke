namespace QuanLyQuanKaraoke.QL_NhanVien_KhachHang
{
    partial class ThemThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThietBi));
            this.btn_luutb = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_tentbthem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_matbthem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btn_luutb
            // 
            this.btn_luutb.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luutb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luutb.Image = ((System.Drawing.Image)(resources.GetObject("btn_luutb.Image")));
            this.btn_luutb.Location = new System.Drawing.Point(156, 165);
            this.btn_luutb.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luutb.Name = "btn_luutb";
            this.btn_luutb.Size = new System.Drawing.Size(148, 52);
            this.btn_luutb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luutb.TabIndex = 24;
            this.btn_luutb.Text = "Lưu";
            this.btn_luutb.Click += new System.EventHandler(this.btn_luutb_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(42, 98);
            this.labelX4.Margin = new System.Windows.Forms.Padding(5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 39);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Tên Thiết Bị";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 35);
            this.labelX1.Margin = new System.Windows.Forms.Padding(5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 39);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "Mã Thiết Bị";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_tentbthem
            // 
            // 
            // 
            // 
            this.txt_tentbthem.Border.Class = "TextBoxBorder";
            this.txt_tentbthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tentbthem.Location = new System.Drawing.Point(156, 105);
            this.txt_tentbthem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tentbthem.Name = "txt_tentbthem";
            this.txt_tentbthem.Size = new System.Drawing.Size(263, 26);
            this.txt_tentbthem.TabIndex = 22;
            // 
            // txt_matbthem
            // 
            // 
            // 
            // 
            this.txt_matbthem.Border.Class = "TextBoxBorder";
            this.txt_matbthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_matbthem.Enabled = false;
            this.txt_matbthem.Location = new System.Drawing.Point(156, 42);
            this.txt_matbthem.Margin = new System.Windows.Forms.Padding(5);
            this.txt_matbthem.Name = "txt_matbthem";
            this.txt_matbthem.Size = new System.Drawing.Size(263, 26);
            this.txt_matbthem.TabIndex = 25;
            // 
            // ThemThietBi
            // 
            this.AcceptButton = this.btn_luutb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 260);
            this.Controls.Add(this.btn_luutb);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_tentbthem);
            this.Controls.Add(this.txt_matbthem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemThietBi";
            this.Text = "Thêm Thiết Bị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemThietBi_FormClosing);
            this.Load += new System.EventHandler(this.ThemThietBi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_luutb;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tentbthem;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_matbthem;
    }
}