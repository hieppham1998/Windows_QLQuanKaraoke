namespace QuanLyQuanKaraoke
{
    partial class DangNhap
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
            this.control_dangnhap1 = new Control_DangNhap.Control_dangnhap();
            this.SuspendLayout();
            // 
            // control_dangnhap1
            // 
            this.control_dangnhap1.BackColor = System.Drawing.Color.White;
            this.control_dangnhap1.Location = new System.Drawing.Point(-3, -2);
            this.control_dangnhap1.Name = "control_dangnhap1";
            this.control_dangnhap1.Size = new System.Drawing.Size(684, 281);
            this.control_dangnhap1.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 278);
            this.Controls.Add(this.control_dangnhap1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control_DangNhap.Control_dangnhap control_dangnhap1;
    }
}