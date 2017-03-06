namespace GUI
{
    partial class frmSoGhiDienNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoGhiDienNuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txtSoNuoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtSoDien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSoPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtThang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbId = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTangTrang = new DevComponents.DotNetBar.ButtonX();
            this.btnLuiTrang = new DevComponents.DotNetBar.ButtonX();
            this.lblTrangHienTai = new DevComponents.DotNetBar.LabelX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.dgvSoGhi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoGhi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 37);
            this.panel1.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(122, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(296, 22);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "QUẢN LÝ SỔ GHI ĐIỆN NƯỚC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtSoNuoc);
            this.panel2.Controls.Add(this.labelX5);
            this.panel2.Controls.Add(this.txtSoDien);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.cbSoPhong);
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.cbId);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Location = new System.Drawing.Point(1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 179);
            this.panel2.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnHuy.Location = new System.Drawing.Point(407, 140);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 27);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 74;
            this.btnHuy.Text = "Kết Thúc";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnLuu.Location = new System.Drawing.Point(310, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 27);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnXoa.Location = new System.Drawing.Point(181, 143);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 27);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 71;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnSua.Location = new System.Drawing.Point(104, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 27);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 72;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnThem.Location = new System.Drawing.Point(20, 143);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 27);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Ghi";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoNuoc
            // 
            // 
            // 
            // 
            this.txtSoNuoc.Border.Class = "TextBoxBorder";
            this.txtSoNuoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoNuoc.Location = new System.Drawing.Point(353, 77);
            this.txtSoNuoc.MaxLength = 8;
            this.txtSoNuoc.Name = "txtSoNuoc";
            this.txtSoNuoc.Size = new System.Drawing.Size(138, 20);
            this.txtSoNuoc.TabIndex = 70;
            this.txtSoNuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNuoc_KeyPress);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(271, 74);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 69;
            this.labelX5.Text = "Chỉ số nước:";
            // 
            // txtSoDien
            // 
            // 
            // 
            // 
            this.txtSoDien.Border.Class = "TextBoxBorder";
            this.txtSoDien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSoDien.Location = new System.Drawing.Point(101, 78);
            this.txtSoDien.MaxLength = 8;
            this.txtSoDien.Name = "txtSoDien";
            this.txtSoDien.Size = new System.Drawing.Size(159, 20);
            this.txtSoDien.TabIndex = 68;
            this.txtSoDien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDien_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(20, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 67;
            this.labelX3.Text = "Chỉ số điện:";
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSoPhong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSoPhong.DisplayMember = "Text";
            this.cbSoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.ItemHeight = 14;
            this.cbSoPhong.Location = new System.Drawing.Point(101, 45);
            this.cbSoPhong.MaxLength = 3;
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(159, 20);
            this.cbSoPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSoPhong.TabIndex = 66;
            this.cbSoPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSoPhong_KeyPress);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX7.Location = new System.Drawing.Point(20, 44);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 65;
            this.labelX7.Text = "Số phòng:";
            // 
            // txtThang
            // 
            // 
            // 
            // 
            this.txtThang.Border.Class = "TextBoxBorder";
            this.txtThang.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtThang.Location = new System.Drawing.Point(353, 15);
            this.txtThang.Name = "txtThang";
            this.txtThang.ReadOnly = true;
            this.txtThang.Size = new System.Drawing.Size(138, 20);
            this.txtThang.TabIndex = 64;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(271, 16);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(53, 23);
            this.labelX2.TabIndex = 63;
            this.labelX2.Text = "Tháng:";
            // 
            // cbId
            // 
            this.cbId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbId.DisplayMember = "Text";
            this.cbId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbId.FormattingEnabled = true;
            this.cbId.ItemHeight = 14;
            this.cbId.Location = new System.Drawing.Point(101, 16);
            this.cbId.MaxLength = 9;
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(159, 20);
            this.cbId.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbId.TabIndex = 62;
            this.cbId.SelectedIndexChanged += new System.EventHandler(this.cbId_SelectedIndexChanged);
            this.cbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbId_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(20, 15);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 23);
            this.labelX4.TabIndex = 61;
            this.labelX4.Text = "Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.btnTangTrang);
            this.panel3.Controls.Add(this.btnLuiTrang);
            this.panel3.Controls.Add(this.lblTrangHienTai);
            this.panel3.Controls.Add(this.btnTroVe);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.dgvSoGhi);
            this.panel3.Location = new System.Drawing.Point(2, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 311);
            this.panel3.TabIndex = 4;
            // 
            // btnTangTrang
            // 
            this.btnTangTrang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTangTrang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTangTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnTangTrang.Image")));
            this.btnTangTrang.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnTangTrang.Location = new System.Drawing.Point(473, 255);
            this.btnTangTrang.Name = "btnTangTrang";
            this.btnTangTrang.Size = new System.Drawing.Size(32, 23);
            this.btnTangTrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTangTrang.TabIndex = 35;
            this.btnTangTrang.Click += new System.EventHandler(this.btnTangTrang_Click);
            // 
            // btnLuiTrang
            // 
            this.btnLuiTrang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuiTrang.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuiTrang.Image = ((System.Drawing.Image)(resources.GetObject("btnLuiTrang.Image")));
            this.btnLuiTrang.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnLuiTrang.Location = new System.Drawing.Point(397, 256);
            this.btnLuiTrang.Name = "btnLuiTrang";
            this.btnLuiTrang.Size = new System.Drawing.Size(32, 23);
            this.btnLuiTrang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuiTrang.TabIndex = 34;
            this.btnLuiTrang.Click += new System.EventHandler(this.btnLuiTrang_Click);
            // 
            // lblTrangHienTai
            // 
            // 
            // 
            // 
            this.lblTrangHienTai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTrangHienTai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangHienTai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTrangHienTai.Location = new System.Drawing.Point(435, 256);
            this.lblTrangHienTai.Name = "lblTrangHienTai";
            this.lblTrangHienTai.Size = new System.Drawing.Size(35, 23);
            this.lblTrangHienTai.TabIndex = 36;
            this.lblTrangHienTai.Text = "0/0";
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnTroVe.Location = new System.Drawing.Point(10, 256);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(85, 27);
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
            this.btnThoat.Location = new System.Drawing.Point(107, 256);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 27);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvSoGhi
            // 
            this.dgvSoGhi.AllowUserToAddRows = false;
            this.dgvSoGhi.AllowUserToDeleteRows = false;
            this.dgvSoGhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoGhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoGhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoGhi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoGhi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSoGhi.Location = new System.Drawing.Point(3, 18);
            this.dgvSoGhi.Name = "dgvSoGhi";
            this.dgvSoGhi.ReadOnly = true;
            this.dgvSoGhi.Size = new System.Drawing.Size(502, 231);
            this.dgvSoGhi.TabIndex = 0;
            this.dgvSoGhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSoGhi_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tháng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số phòng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Chỉ số điện";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chỉ số nước";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmSoGhiDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSoGhiDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSoGhiDienNuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoGhi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtThang;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbId;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSoPhong;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoNuoc;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoDien;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSoGhi;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnTangTrang;
        private DevComponents.DotNetBar.ButtonX btnLuiTrang;
        private DevComponents.DotNetBar.LabelX lblTrangHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}