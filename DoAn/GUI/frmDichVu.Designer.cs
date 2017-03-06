namespace GUI
{
    partial class frmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaNuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtGiaDien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaPhongUuDai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtPhiVeSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtGiaPhong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(-4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 40);
            this.panel1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(203, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(160, 22);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(-4, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 167);
            this.panel2.TabIndex = 1;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX7.Location = new System.Drawing.Point(468, 132);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(83, 23);
            this.labelX7.TabIndex = 55;
            this.labelX7.Text = "(Đơn vị : VND)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGiaNuoc);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.txtGiaDien);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Location = new System.Drawing.Point(287, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điện - Nước";
            // 
            // txtGiaNuoc
            // 
            // 
            // 
            // 
            this.txtGiaNuoc.Border.Class = "TextBoxBorder";
            this.txtGiaNuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaNuoc.Location = new System.Drawing.Point(98, 73);
            this.txtGiaNuoc.MaxLength = 8;
            this.txtGiaNuoc.Name = "txtGiaNuoc";
            this.txtGiaNuoc.Size = new System.Drawing.Size(158, 20);
            this.txtGiaNuoc.TabIndex = 50;
            this.txtGiaNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX5_KeyPress);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX6.Location = new System.Drawing.Point(6, 73);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(104, 23);
            this.labelX6.TabIndex = 49;
            this.labelX6.Text = "Giá nước/Số :";
            // 
            // txtGiaDien
            // 
            // 
            // 
            // 
            this.txtGiaDien.Border.Class = "TextBoxBorder";
            this.txtGiaDien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaDien.Location = new System.Drawing.Point(98, 28);
            this.txtGiaDien.MaxLength = 8;
            this.txtGiaDien.Name = "txtGiaDien";
            this.txtGiaDien.Size = new System.Drawing.Size(158, 20);
            this.txtGiaDien.TabIndex = 48;
            this.txtGiaDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX4_KeyPress);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(6, 28);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(104, 23);
            this.labelX5.TabIndex = 47;
            this.labelX5.Text = "Giá điện/Số:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaPhongUuDai);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtPhiVeSinh);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.txtGiaPhong);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng";
            // 
            // txtGiaPhongUuDai
            // 
            // 
            // 
            // 
            this.txtGiaPhongUuDai.Border.Class = "TextBoxBorder";
            this.txtGiaPhongUuDai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaPhongUuDai.Location = new System.Drawing.Point(140, 73);
            this.txtGiaPhongUuDai.MaxLength = 8;
            this.txtGiaPhongUuDai.Name = "txtGiaPhongUuDai";
            this.txtGiaPhongUuDai.Size = new System.Drawing.Size(121, 20);
            this.txtGiaPhongUuDai.TabIndex = 50;
            this.txtGiaPhongUuDai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX3_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(5, 73);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(139, 23);
            this.labelX3.TabIndex = 49;
            this.labelX3.Text = "Giá phòng ưu đãi/Kỳ:";
            // 
            // txtPhiVeSinh
            // 
            // 
            // 
            // 
            this.txtPhiVeSinh.Border.Class = "TextBoxBorder";
            this.txtPhiVeSinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhiVeSinh.Location = new System.Drawing.Point(140, 115);
            this.txtPhiVeSinh.MaxLength = 8;
            this.txtPhiVeSinh.Name = "txtPhiVeSinh";
            this.txtPhiVeSinh.Size = new System.Drawing.Size(122, 20);
            this.txtPhiVeSinh.TabIndex = 48;
            this.txtPhiVeSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(6, 115);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(103, 23);
            this.labelX2.TabIndex = 47;
            this.labelX2.Text = "Phí vệ sinh/Kỳ:";
            // 
            // txtGiaPhong
            // 
            // 
            // 
            // 
            this.txtGiaPhong.Border.Class = "TextBoxBorder";
            this.txtGiaPhong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaPhong.Location = new System.Drawing.Point(103, 28);
            this.txtGiaPhong.MaxLength = 8;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(158, 20);
            this.txtGiaPhong.TabIndex = 46;
            this.txtGiaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(6, 28);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(104, 23);
            this.labelX4.TabIndex = 45;
            this.labelX4.Text = "Giá phòng/Kỳ :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.btnHuy);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnTroVe);
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Location = new System.Drawing.Point(-4, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 74);
            this.panel4.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnHuy.Location = new System.Drawing.Point(135, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 29);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnSua.Location = new System.Drawing.Point(10, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 29);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnTroVe.Location = new System.Drawing.Point(354, 16);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(95, 29);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 23;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnThoat.Location = new System.Drawing.Point(458, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 29);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 281);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaNuoc;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaDien;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaPhongUuDai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhiVeSinh;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaPhong;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnHuy;






    }
}