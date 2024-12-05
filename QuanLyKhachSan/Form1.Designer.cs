namespace QuanLyKhachSan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.đ = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelerror = new System.Windows.Forms.Label();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtpasswork = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.đ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // đ
            // 
            this.đ.BackColor = System.Drawing.Color.White;
            this.đ.Controls.Add(this.label3);
            this.đ.Controls.Add(this.labelerror);
            this.đ.Controls.Add(this.btnlogin);
            this.đ.Controls.Add(this.txtpasswork);
            this.đ.Controls.Add(this.txtname);
            this.đ.Controls.Add(this.label1);
            this.đ.Controls.Add(this.guna2CirclePictureBox1);
            this.đ.Controls.Add(this.btnexit);
            this.đ.Location = new System.Drawing.Point(200, 150);
            this.đ.Name = "đ";
            this.đ.Size = new System.Drawing.Size(1108, 535);
            this.đ.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(237, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(558, 413);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(209, 16);
            this.labelerror.TabIndex = 6;
            this.labelerror.Text = "Tên đăng nhập hoặc mật khẩu sai";
            this.labelerror.Visible = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 18;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(473, 340);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(415, 45);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpasswork
            // 
            this.txtpasswork.BorderRadius = 18;
            this.txtpasswork.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpasswork.DefaultText = "";
            this.txtpasswork.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpasswork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpasswork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpasswork.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpasswork.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpasswork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpasswork.ForeColor = System.Drawing.Color.Black;
            this.txtpasswork.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpasswork.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpasswork.IconLeft")));
            this.txtpasswork.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtpasswork.Location = new System.Drawing.Point(472, 234);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.PasswordChar = '*';
            this.txtpasswork.PlaceholderText = "Password";
            this.txtpasswork.SelectedText = "";
            this.txtpasswork.Size = new System.Drawing.Size(415, 67);
            this.txtpasswork.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.BorderRadius = 18;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtname.IconLeft")));
            this.txtname.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtname.Location = new System.Drawing.Point(473, 135);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Đăng nhập";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(415, 67);
            this.txtname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng Nhập";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(85, 135);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(274, 281);
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.White;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(0, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(50, 41);
            this.btnexit.TabIndex = 0;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1848, 761);
            this.Controls.Add(this.đ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.đ.ResumeLayout(false);
            this.đ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel đ;
        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2TextBox txtpasswork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelerror;
    }
}

