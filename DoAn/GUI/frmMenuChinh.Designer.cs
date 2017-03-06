namespace GUI
{
    partial class frmMenuChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuChinh));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribThueTraPhong = new DevComponents.DotNetBar.RibbonBar();
            this.btnThuePhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnTraPhong = new DevComponents.DotNetBar.ButtonItem();
            this.ribMoRong = new DevComponents.DotNetBar.RibbonBar();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.ribDienNuoc = new DevComponents.DotNetBar.RibbonBar();
            this.btnSoGhiDienNuoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnHoaDonTienDienNuoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnDichVu = new DevComponents.DotNetBar.ButtonItem();
            this.ribSinhVien = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnSinhVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnHopDong = new DevComponents.DotNetBar.ButtonItem();
            this.btnHoaDonTienPhong = new DevComponents.DotNetBar.ButtonItem();
            this.ribPhong = new DevComponents.DotNetBar.RibbonBar();
            this.btnDayPhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhong = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoimatkhau = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangxuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangnhap = new DevComponents.DotNetBar.ButtonItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.btnBaoCaoThongKe = new DevComponents.DotNetBar.ButtonItem();
            this.btnTaiKhoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnNhanVien = new DevComponents.DotNetBar.ButtonItem();
            this.ribNangCao = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.FontBold = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Chức Năng Chính";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribThueTraPhong);
            this.ribbonPanel1.Controls.Add(this.ribMoRong);
            this.ribbonPanel1.Controls.Add(this.ribDienNuoc);
            this.ribbonPanel1.Controls.Add(this.ribSinhVien);
            this.ribbonPanel1.Controls.Add(this.ribPhong);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(992, 185);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // ribThueTraPhong
            // 
            this.ribThueTraPhong.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribThueTraPhong.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribThueTraPhong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribThueTraPhong.ContainerControlProcessDialogKey = true;
            this.ribThueTraPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribThueTraPhong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThuePhong,
            this.btnTraPhong});
            this.ribThueTraPhong.Location = new System.Drawing.Point(848, 0);
            this.ribThueTraPhong.Name = "ribThueTraPhong";
            this.ribThueTraPhong.Size = new System.Drawing.Size(210, 182);
            this.ribThueTraPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribThueTraPhong.TabIndex = 4;
            this.ribThueTraPhong.Text = "Thuê - Trả phòng";
            // 
            // 
            // 
            this.ribThueTraPhong.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribThueTraPhong.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Image = ((System.Drawing.Image)(resources.GetObject("btnThuePhong.Image")));
            this.btnThuePhong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnThuePhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.SubItemsExpandWidth = 14;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnTraPhong.Image")));
            this.btnTraPhong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnTraPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.SubItemsExpandWidth = 14;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // ribMoRong
            // 
            this.ribMoRong.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribMoRong.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribMoRong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribMoRong.ContainerControlProcessDialogKey = true;
            this.ribMoRong.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribMoRong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTimKiem});
            this.ribMoRong.Location = new System.Drawing.Point(763, 0);
            this.ribMoRong.Name = "ribMoRong";
            this.ribMoRong.Size = new System.Drawing.Size(85, 182);
            this.ribMoRong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribMoRong.TabIndex = 3;
            this.ribMoRong.Text = "Mở rộng";
            // 
            // 
            // 
            this.ribMoRong.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribMoRong.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnTimKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.SubItemsExpandWidth = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // ribDienNuoc
            // 
            this.ribDienNuoc.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribDienNuoc.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribDienNuoc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribDienNuoc.ContainerControlProcessDialogKey = true;
            this.ribDienNuoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribDienNuoc.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSoGhiDienNuoc,
            this.btnHoaDonTienDienNuoc,
            this.btnDichVu});
            this.ribDienNuoc.Location = new System.Drawing.Point(480, 0);
            this.ribDienNuoc.Name = "ribDienNuoc";
            this.ribDienNuoc.Size = new System.Drawing.Size(283, 182);
            this.ribDienNuoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribDienNuoc.TabIndex = 2;
            this.ribDienNuoc.Text = "Điện - Nước";
            // 
            // 
            // 
            this.ribDienNuoc.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribDienNuoc.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSoGhiDienNuoc
            // 
            this.btnSoGhiDienNuoc.FixedSize = new System.Drawing.Size(80, 0);
            this.btnSoGhiDienNuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnSoGhiDienNuoc.Image")));
            this.btnSoGhiDienNuoc.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnSoGhiDienNuoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSoGhiDienNuoc.Name = "btnSoGhiDienNuoc";
            this.btnSoGhiDienNuoc.SubItemsExpandWidth = 14;
            this.btnSoGhiDienNuoc.Text = "Sổ Ghi Điện - Nước";
            this.btnSoGhiDienNuoc.Click += new System.EventHandler(this.btnSoGhiDienNuoc_Click);
            // 
            // btnHoaDonTienDienNuoc
            // 
            this.btnHoaDonTienDienNuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDonTienDienNuoc.Image")));
            this.btnHoaDonTienDienNuoc.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnHoaDonTienDienNuoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHoaDonTienDienNuoc.Name = "btnHoaDonTienDienNuoc";
            this.btnHoaDonTienDienNuoc.SubItemsExpandWidth = 14;
            this.btnHoaDonTienDienNuoc.Text = "Hóa Đơn Tiền Điện - Nước";
            this.btnHoaDonTienDienNuoc.Click += new System.EventHandler(this.btnHoaDonTienDienNuoc_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Image = ((System.Drawing.Image)(resources.GetObject("btnDichVu.Image")));
            this.btnDichVu.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnDichVu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.SubItemsExpandWidth = 14;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // ribSinhVien
            // 
            this.ribSinhVien.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribSinhVien.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribSinhVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribSinhVien.ContainerControlProcessDialogKey = true;
            this.ribSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribSinhVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.btnSinhVien,
            this.btnHopDong,
            this.btnHoaDonTienPhong});
            this.ribSinhVien.Location = new System.Drawing.Point(183, 0);
            this.ribSinhVien.Name = "ribSinhVien";
            this.ribSinhVien.Size = new System.Drawing.Size(297, 182);
            this.ribSinhVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribSinhVien.TabIndex = 1;
            this.ribSinhVien.Text = "Sinh Viên";
            // 
            // 
            // 
            this.ribSinhVien.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribSinhVien.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Image")));
            this.btnSinhVien.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnSinhVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.SubItemsExpandWidth = 14;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Image = ((System.Drawing.Image)(resources.GetObject("btnHopDong.Image")));
            this.btnHopDong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnHopDong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.SubItemsExpandWidth = 14;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnHoaDonTienPhong
            // 
            this.btnHoaDonTienPhong.FixedSize = new System.Drawing.Size(110, 0);
            this.btnHoaDonTienPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDonTienPhong.Image")));
            this.btnHoaDonTienPhong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnHoaDonTienPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHoaDonTienPhong.Name = "btnHoaDonTienPhong";
            this.btnHoaDonTienPhong.SubItemsExpandWidth = 14;
            this.btnHoaDonTienPhong.Text = "Hóa Đơn Tiền Phòng";
            this.btnHoaDonTienPhong.Click += new System.EventHandler(this.btnHoaDonTienPhong_Click);
            // 
            // ribPhong
            // 
            this.ribPhong.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribPhong.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPhong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribPhong.ContainerControlProcessDialogKey = true;
            this.ribPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribPhong.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDayPhong,
            this.btnPhong});
            this.ribPhong.Location = new System.Drawing.Point(3, 0);
            this.ribPhong.Name = "ribPhong";
            this.ribPhong.Size = new System.Drawing.Size(180, 182);
            this.ribPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribPhong.TabIndex = 0;
            this.ribPhong.Text = "Phòng";
            // 
            // 
            // 
            this.ribPhong.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribPhong.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDayPhong
            // 
            this.btnDayPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDayPhong.Image")));
            this.btnDayPhong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnDayPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDayPhong.Name = "btnDayPhong";
            this.btnDayPhong.SubItemsExpandWidth = 14;
            this.btnDayPhong.Text = "Dãy Phòng";
            this.btnDayPhong.Click += new System.EventHandler(this.btnDayPhong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhong.Image")));
            this.btnPhong.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnPhong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.SubItemsExpandWidth = 14;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ctrl4);
            this.btnThoat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.Image")));
            this.btnDoimatkhau.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ctrl3);
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.Click += new System.EventHandler(this.btnDoimatkhau_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Image")));
            this.btnDangxuat.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ctrl2);
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangnhap.Image")));
            this.btnDangnhap.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ctrl1);
            this.btnDangnhap.Text = "Đăng nhập   ";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.FontBold = true;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 0;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangnhap,
            this.btnDangxuat,
            this.btnDoimatkhau,
            this.btnThoat});
            this.applicationButton1.Text = "&Hệ Thống";
            this.applicationButton1.Click += new System.EventHandler(this.applicationButton1_Click);
            // 
            // btnBaoCaoThongKe
            // 
            this.btnBaoCaoThongKe.FixedSize = new System.Drawing.Size(150, 0);
            this.btnBaoCaoThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoThongKe.Image")));
            this.btnBaoCaoThongKe.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnBaoCaoThongKe.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            this.btnBaoCaoThongKe.SubItemsExpandWidth = 14;
            this.btnBaoCaoThongKe.Text = "Báo Cáo - Thống Kê";
            this.btnBaoCaoThongKe.Click += new System.EventHandler(this.btnBaoCaoThongKe_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnTaiKhoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.SubItemsExpandWidth = 14;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnNhanVien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.SubItemsExpandWidth = 14;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // ribNangCao
            // 
            this.ribNangCao.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribNangCao.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribNangCao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribNangCao.ContainerControlProcessDialogKey = true;
            this.ribNangCao.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribNangCao.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNhanVien,
            this.btnTaiKhoan,
            this.btnBaoCaoThongKe});
            this.ribNangCao.Location = new System.Drawing.Point(3, 0);
            this.ribNangCao.Name = "ribNangCao";
            this.ribNangCao.Size = new System.Drawing.Size(312, 182);
            this.ribNangCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribNangCao.TabIndex = 0;
            // 
            // 
            // 
            this.ribNangCao.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribNangCao.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribNangCao);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonPanel2.Size = new System.Drawing.Size(992, 185);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.FontBold = true;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Chức Năng Năng Cao";
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(992, 188);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 1;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 208);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuChinh_Load);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribMoRong;
        private DevComponents.DotNetBar.ButtonItem btnTimKiem;
        private DevComponents.DotNetBar.RibbonBar ribDienNuoc;
        private DevComponents.DotNetBar.ButtonItem btnSoGhiDienNuoc;
        private DevComponents.DotNetBar.ButtonItem btnHoaDonTienDienNuoc;
        private DevComponents.DotNetBar.ButtonItem btnDichVu;
        private DevComponents.DotNetBar.RibbonBar ribSinhVien;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnSinhVien;
        private DevComponents.DotNetBar.ButtonItem btnHopDong;
        private DevComponents.DotNetBar.ButtonItem btnHoaDonTienPhong;
        private DevComponents.DotNetBar.RibbonBar ribPhong;
        private DevComponents.DotNetBar.ButtonItem btnPhong;
        private DevComponents.DotNetBar.ButtonItem btnDayPhong;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.ButtonItem btnDoimatkhau;
        private DevComponents.DotNetBar.ButtonItem btnDangxuat;
        private DevComponents.DotNetBar.ButtonItem btnDangnhap;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ButtonItem btnBaoCaoThongKe;
        private DevComponents.DotNetBar.ButtonItem btnTaiKhoan;
        private DevComponents.DotNetBar.ButtonItem btnNhanVien;
        private DevComponents.DotNetBar.RibbonBar ribNangCao;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonBar ribThueTraPhong;
        private DevComponents.DotNetBar.ButtonItem btnThuePhong;
        private DevComponents.DotNetBar.ButtonItem btnTraPhong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}