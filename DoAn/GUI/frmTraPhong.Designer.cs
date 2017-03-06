namespace GUI
{
    partial class frmTraPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraPhong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbMaSinhVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbHoTen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnTroVe = new DevComponents.DotNetBar.ButtonX();
            this.btnTraPhong = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 33);
            this.panel1.TabIndex = 0;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(166, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(131, 22);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "TRẢ PHÒNG";
            // 
            // cbMaSinhVien
            // 
            this.cbMaSinhVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSinhVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSinhVien.DisplayMember = "Text";
            this.cbMaSinhVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaSinhVien.FormattingEnabled = true;
            this.cbMaSinhVien.ItemHeight = 14;
            this.cbMaSinhVien.Location = new System.Drawing.Point(76, 50);
            this.cbMaSinhVien.MaxLength = 10;
            this.cbMaSinhVien.Name = "cbMaSinhVien";
            this.cbMaSinhVien.Size = new System.Drawing.Size(121, 20);
            this.cbMaSinhVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaSinhVien.TabIndex = 56;
            this.cbMaSinhVien.SelectedIndexChanged += new System.EventHandler(this.cbMaSinhVien_SelectedIndexChanged);
            this.cbMaSinhVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMaSinhVien_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(12, 50);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 55;
            this.labelX4.Text = "Mã SV:";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // cbHoTen
            // 
            this.cbHoTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHoTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoTen.DisplayMember = "Text";
            this.cbHoTen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.ItemHeight = 14;
            this.cbHoTen.Location = new System.Drawing.Point(282, 47);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(158, 20);
            this.cbHoTen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbHoTen.TabIndex = 58;
            this.cbHoTen.SelectedIndexChanged += new System.EventHandler(this.cbHoTen_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(215, 47);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 57;
            this.labelX1.Text = "Họ tên:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTroVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTroVe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTroVe.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVe.Image")));
            this.btnTroVe.ImageFixedSize = new System.Drawing.Size(19, 19);
            this.btnTroVe.Location = new System.Drawing.Point(282, 106);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(124, 27);
            this.btnTroVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTroVe.TabIndex = 60;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTraPhong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTraPhong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTraPhong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.Image")));
            this.btnTraPhong.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnTraPhong.Location = new System.Drawing.Point(76, 106);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(121, 27);
            this.btnTraPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTraPhong.TabIndex = 61;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 148);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.cbHoTen);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbMaSinhVien);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaSinhVien;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHoTen;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnTroVe;
        private DevComponents.DotNetBar.ButtonX btnTraPhong;
    }
}