namespace GUI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.txtTendangnhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtReMK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMatkhaumoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnTrove = new DevComponents.DotNetBar.ButtonX();
            this.btnThaydoi = new DevComponents.DotNetBar.ButtonX();
            this.txtMakhaucu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTendangnhap
            // 
            // 
            // 
            // 
            this.txtTendangnhap.Border.Class = "TextBoxBorder";
            this.txtTendangnhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTendangnhap.Location = new System.Drawing.Point(118, 23);
            this.txtTendangnhap.MaxLength = 5;
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(163, 20);
            this.txtTendangnhap.TabIndex = 2;
            this.txtTendangnhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTendangnhap_KeyDown);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(145, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(235, 43);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel3.Controls.Add(this.txtReMK);
            this.panel3.Controls.Add(this.labelX5);
            this.panel3.Controls.Add(this.txtMatkhaumoi);
            this.panel3.Controls.Add(this.labelX4);
            this.panel3.Controls.Add(this.btnTrove);
            this.panel3.Controls.Add(this.btnThaydoi);
            this.panel3.Controls.Add(this.txtMakhaucu);
            this.panel3.Controls.Add(this.txtTendangnhap);
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Location = new System.Drawing.Point(207, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 258);
            this.panel3.TabIndex = 8;
            // 
            // txtReMK
            // 
            // 
            // 
            // 
            this.txtReMK.Border.Class = "TextBoxBorder";
            this.txtReMK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReMK.Location = new System.Drawing.Point(177, 147);
            this.txtReMK.MaxLength = 15;
            this.txtReMK.Name = "txtReMK";
            this.txtReMK.PasswordChar = '*';
            this.txtReMK.Size = new System.Drawing.Size(104, 20);
            this.txtReMK.TabIndex = 9;
            this.txtReMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReMK_KeyDown);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(21, 147);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(150, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Nhập lại mật khẩu mới";
            // 
            // txtMatkhaumoi
            // 
            // 
            // 
            // 
            this.txtMatkhaumoi.Border.Class = "TextBoxBorder";
            this.txtMatkhaumoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatkhaumoi.Location = new System.Drawing.Point(118, 105);
            this.txtMatkhaumoi.MaxLength = 15;
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(163, 20);
            this.txtMatkhaumoi.TabIndex = 7;
            this.txtMatkhaumoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatkhaumoi_KeyDown);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(21, 105);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Mật khẩu mới";
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.Image = ((System.Drawing.Image)(resources.GetObject("btnTrove.Image")));
            this.btnTrove.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnTrove.Location = new System.Drawing.Point(154, 199);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(127, 34);
            this.btnTrove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTrove.TabIndex = 5;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnThaydoi
            // 
            this.btnThaydoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThaydoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnThaydoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThaydoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThaydoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThaydoi.Image")));
            this.btnThaydoi.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnThaydoi.Location = new System.Drawing.Point(21, 200);
            this.btnThaydoi.Name = "btnThaydoi";
            this.btnThaydoi.Size = new System.Drawing.Size(127, 33);
            this.btnThaydoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThaydoi.TabIndex = 4;
            this.btnThaydoi.Text = "Thay đổi";
            this.btnThaydoi.Click += new System.EventHandler(this.btnThaydoi_Click);
            // 
            // txtMakhaucu
            // 
            // 
            // 
            // 
            this.txtMakhaucu.Border.Class = "TextBoxBorder";
            this.txtMakhaucu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMakhaucu.Location = new System.Drawing.Point(118, 62);
            this.txtMakhaucu.MaxLength = 15;
            this.txtMakhaucu.Name = "txtMakhaucu";
            this.txtMakhaucu.PasswordChar = '*';
            this.txtMakhaucu.Size = new System.Drawing.Size(163, 20);
            this.txtMakhaucu.TabIndex = 3;
            this.txtMakhaucu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMakhaucu_KeyDown);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(21, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Mật khẩu cũ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(21, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 54);
            this.panel1.TabIndex = 7;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 331);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTendangnhap;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatkhaumoi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnTrove;
        private DevComponents.DotNetBar.ButtonX btnThaydoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMakhaucu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtReMK;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}