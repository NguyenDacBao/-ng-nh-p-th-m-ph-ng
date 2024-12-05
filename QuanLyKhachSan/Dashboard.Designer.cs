namespace QuanLyKhachSan
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.btnminisize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btnthongtin = new Guna.UI2.WinForms.Guna2Button();
            this.btnthanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.btndangky = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_AddRoom1 = new QuanLyKhachSan.All_Use_Control.UC_AddRoom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.Aqua;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnexit.Location = new System.Drawing.Point(0, -1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(44, 45);
            this.btnexit.TabIndex = 0;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnminisize
            // 
            this.btnminisize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnminisize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnminisize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnminisize.FillColor = System.Drawing.Color.Aqua;
            this.btnminisize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminisize.ForeColor = System.Drawing.Color.White;
            this.btnminisize.Image = ((System.Drawing.Image)(resources.GetObject("btnminisize.Image")));
            this.btnminisize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnminisize.Location = new System.Drawing.Point(0, 50);
            this.btnminisize.Name = "btnminisize";
            this.btnminisize.Size = new System.Drawing.Size(44, 45);
            this.btnminisize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnnhanvien);
            this.panel1.Controls.Add(this.btnthongtin);
            this.panel1.Controls.Add(this.btnthanhtoan);
            this.panel1.Controls.Add(this.btndangky);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Location = new System.Drawing.Point(48, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1765, 130);
            this.panel1.TabIndex = 2;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BorderRadius = 18;
            this.btnnhanvien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnnhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnnhanvien.Location = new System.Drawing.Point(1422, 3);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(284, 116);
            this.btnnhanvien.TabIndex = 4;
            this.btnnhanvien.Text = "Nhân Viên";
            // 
            // btnthongtin
            // 
            this.btnthongtin.BorderRadius = 18;
            this.btnthongtin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnthongtin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthongtin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthongtin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthongtin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthongtin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongtin.ForeColor = System.Drawing.Color.White;
            this.btnthongtin.Location = new System.Drawing.Point(1091, 7);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(284, 116);
            this.btnthongtin.TabIndex = 3;
            this.btnthongtin.Text = "Thông Tin Khách Hàng";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BorderRadius = 18;
            this.btnthanhtoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnthanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthanhtoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnthanhtoan.Location = new System.Drawing.Point(762, 7);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(284, 116);
            this.btnthanhtoan.TabIndex = 2;
            this.btnthanhtoan.Text = "Thanh Toán";
            // 
            // btndangky
            // 
            this.btndangky.BorderRadius = 18;
            this.btndangky.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndangky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangky.ForeColor = System.Drawing.Color.White;
            this.btndangky.Location = new System.Drawing.Point(406, 7);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(284, 116);
            this.btndangky.TabIndex = 1;
            this.btndangky.Text = "Đăng Ký Khách Hàng";
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.MediumPurple;
            this.btnthem.BorderRadius = 18;
            this.btnthem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(54, 7);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(284, 116);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm Phòng";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(11, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 812);
            this.panel2.TabIndex = 3;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.PanelMoving.Location = new System.Drawing.Point(113, 150);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(284, 10);
            this.PanelMoving.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(13, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1882, 852);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnminisize);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnminisize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnnhanvien;
        private Guna.UI2.WinForms.Guna2Button btnthongtin;
        private Guna.UI2.WinForms.Guna2Button btnthanhtoan;
        private Guna.UI2.WinForms.Guna2Button btndangky;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_Use_Control.UC_AddRoom uC_AddRoom1;
    }
}