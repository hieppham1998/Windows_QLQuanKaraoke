namespace QuanLyQuanKaraoke
{
    partial class TaoKetNoi
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
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.cbb_servername = new System.Windows.Forms.ComboBox();
            this.cbb_database = new System.Windows.Forms.ComboBox();
            this.cbb_authentication = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Location = new System.Drawing.Point(258, 234);
            this.btnkiemtra.Margin = new System.Windows.Forms.Padding(4);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(148, 30);
            this.btnkiemtra.TabIndex = 16;
            this.btnkiemtra.Text = "Connect";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ServerName";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(163, 144);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(243, 25);
            this.txtpass.TabIndex = 9;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(163, 103);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(243, 25);
            this.txtuser.TabIndex = 8;
            // 
            // cbb_servername
            // 
            this.cbb_servername.FormattingEnabled = true;
            this.cbb_servername.Location = new System.Drawing.Point(163, 21);
            this.cbb_servername.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_servername.Name = "cbb_servername";
            this.cbb_servername.Size = new System.Drawing.Size(243, 25);
            this.cbb_servername.TabIndex = 17;
            this.cbb_servername.Leave += new System.EventHandler(this.cbb_servername_Leave);
            // 
            // cbb_database
            // 
            this.cbb_database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_database.FormattingEnabled = true;
            this.cbb_database.Location = new System.Drawing.Point(163, 188);
            this.cbb_database.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_database.Name = "cbb_database";
            this.cbb_database.Size = new System.Drawing.Size(243, 25);
            this.cbb_database.TabIndex = 18;
            // 
            // cbb_authentication
            // 
            this.cbb_authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_authentication.FormattingEnabled = true;
            this.cbb_authentication.Location = new System.Drawing.Point(163, 62);
            this.cbb_authentication.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_authentication.Name = "cbb_authentication";
            this.cbb_authentication.Size = new System.Drawing.Size(243, 25);
            this.cbb_authentication.TabIndex = 20;
            this.cbb_authentication.SelectedIndexChanged += new System.EventHandler(this.cbb_authentication_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Authentication";
            // 
            // TaoKetNoi
            // 
            this.AcceptButton = this.btnkiemtra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 304);
            this.Controls.Add(this.cbb_authentication);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_database);
            this.Controls.Add(this.cbb_servername);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaoKetNoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect SQL Server";
            this.Load += new System.EventHandler(this.TaoKetNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ComboBox cbb_servername;
        private System.Windows.Forms.ComboBox cbb_database;
        private System.Windows.Forms.ComboBox cbb_authentication;
        private System.Windows.Forms.Label label5;
    }
}

