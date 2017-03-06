using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmTimKiem : DevComponents.DotNetBar.Office2007Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        int SvStatut = 0;
        int PhongStatut = 0;
        int NvStatut = 0;
        int HDStatut = 0;
        int HDTPStatut = 0;
        int SGStatut = 0;
        int HDTDNStatut = 0;
     
        SinhVienBLL SVBLL = new SinhVienBLL();
        PhongBLL PBLL = new PhongBLL();
        DayPhongBLL DPBLL = new DayPhongBLL();
        NhanVienBLL NVBLL = new NhanVienBLL();
        HopDongBLL HDBLL = new HopDongBLL();
        HoaDonTienPhongBLL HDTPBLL = new HoaDonTienPhongBLL();
        SoGhiDienNuocBLL SGDNBLL = new SoGhiDienNuocBLL();
        HoaDonTienDienNuocBLL HDTDNBLL = new HoaDonTienDienNuocBLL();
        DataTable dtSV = new DataTable();
        DataTable dtNV = new DataTable();
        DataTable dtPhong = new DataTable();
        DataTable dtHopDong = new DataTable();
        DataTable dtHoaDonTienPhong = new DataTable();
        DataTable dtHoaDonTienDienNuoc = new DataTable();
        DataTable dtSoGhi = new DataTable();

        private void mskNgaysinh_Leave(object sender, EventArgs e)
        {

        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSdt_Leave(object sender, EventArgs e)
        {

        }

        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX40_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            tabHDTDN_Click(sender, e);
        }

       

        private void cbSVMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSVSCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSVSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSVSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string TimKiemNgay(string ngay)
        {
            string strngay = "";
            string[] a = ngay.Split('/');
            string m = a[0].ToString().Trim();
            string d = a[1].ToString().Trim();
            string y = a[2].ToString().Trim();
            strngay = "%" + y + "%-%" + m + "-%" + d + "%";
            return strngay;
        }

        private void tabSinhVien_Click(object sender, EventArgs e)
        {
            if (SvStatut == 0)
            {
                SvStatut = 1;
                cbSVGioitinh.Items.Add("Nam");
                cbSVGioitinh.Items.Add("Nữ");
                cbSVChinhsach.Items.Add("Có");
                cbSVChinhsach.Items.Add("Không");
                cbSVTrangThai.Items.Add("Đang ở");
                cbSVTrangThai.Items.Add("Không còn ở");
                SVBLL.LoadCb(cbSVMaSV, "MASV");
                SVBLL.LoadCb(cbSVHoTen, "TENSV");
                SVBLL.LoadCb(cbSVSCMT, "CMT");
                SVBLL.LoadCb(cbSVSDT, "SDT");
                SVBLL.LoadCb(cbSVMaSV, "MASV");
                SVBLL.LoadCb(cbSVQueQuan, "QUEQUAN");
                PBLL.LoadCB(cbSVSoPhong, "SOPHONG", "Phong");
                cbSVMaSV.Text = cbSVHoTen.Text = cbSVSDT.Text = cbSVSCMT.Text = cbSVQueQuan.Text = cbSVSoPhong.Text = "";
                cbSVSoPhong.Enabled = false;
                
            }
        }

        private void cbSVTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSVTrangThai.SelectedIndex == 0)
            {
                cbSVSoPhong.Enabled = true;
            }
            else
            {
                cbSVSoPhong.Enabled = false;
                cbSVSoPhong.Text = "";
            }
        }

        private void btnSVTimKiem_Click(object sender, EventArgs e)
        {
            dgvSinhVien.Rows.Clear();
            SinhVien SV = new SinhVien(cbSVMaSV.Text, cbSVHoTen.Text, cbSVGioitinh.Text, cbSVQueQuan.Text, cbSVSDT.Text, cbSVChinhsach.Text);
            string ns = TimKiemNgay(mskSVNgaysinh.Text);
            string sophong = cbSVSoPhong.Text;
            string cmt = cbSVSCMT.Text;
            if (cbSVTrangThai.SelectedIndex == 0)
            {
                dtSV = SVBLL.TKSinhVienDangO(SV, ns, cmt, sophong);
            }
            else if (cbSVTrangThai.SelectedIndex == 1)
            {
                dtSV = SVBLL.TKSinhVienKhongO(SV, ns, cmt);
            }
            else
            {
                dtSV = SVBLL.TKSinhVienAll(SV, ns, cmt);
            }
            if (dtSV.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            for (int i = 0; i < dtSV.Rows.Count; i++)
            {
                string[] a = { dtSV.Rows[i][0].ToString(), dtSV.Rows[i][1].ToString(), new Utility().XuLyNgay(DateTime.Parse(dtSV.Rows[i][2].ToString())), dtSV.Rows[i][3].ToString(), dtSV.Rows[i][4].ToString(), dtSV.Rows[i][5].ToString(), dtSV.Rows[i][6].ToString(), dtSV.Rows[i][7].ToString() };
                dgvSinhVien.Rows.Add(a);
            }
        }

        private void btnSVLamMoi_Click(object sender, EventArgs e)
        {
            cbSVMaSV.Text = cbSVHoTen.Text = mskSVNgaysinh.Text = cbSVGioitinh.Text = cbSVSCMT.Text = cbSVSDT.Text = cbSVChinhsach.Text = cbSVQueQuan.Text = cbSVSoPhong.Text = cbSVTrangThai.Text = "";
            cbSVSoPhong.Enabled = false;
        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {
            if (NvStatut == 0)
            {
                NvStatut = 1;
                cbNVGioiTinh.Items.Add("Nam");
                cbNVGioiTinh.Items.Add("Nữ");
                cbNVTrangThai.Items.Add("Đang làm");
                cbNVTrangThai.Items.Add("Đã nghỉ việc");
                NVBLL.LoadCB(cbNVMaNV, "MANV");
                NVBLL.LoadCB(cbNVHoTen, "TENNV");
                NVBLL.LoadCB(cbNVSCMT, "CMT");
                NVBLL.LoadCB(cbNVSDT, "SDT");
                NVBLL.LoadCB(cbNVChucVu, "CHUCVU");
                NVBLL.LoadCB(cbNVQueQuan, "QUEQUAN");
                cbNVMaNV.Text = cbNVHoTen.Text = cbNVSCMT.Text = cbNVSDT.Text = cbNVChucVu.Text = cbNVQueQuan.Text = "";
            }
        }

        private void cbNVSCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbNVSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNVTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Clear();
            NhanVien NV = new NhanVien(cbNVMaNV.Text, cbNVHoTen.Text, cbNVGioiTinh.Text, cbNVQueQuan.Text, cbNVChucVu.Text, cbNVSDT.Text, cbNVTrangThai.Text);
            string cmt = cbNVSCMT.Text;
            string ns = TimKiemNgay(mskNVNgaySinh.Text);
            dtNV = NVBLL.TKNhanVienAll(NV, ns, cmt);
            if (dtNV.Rows.Count > 0)
            {
                dgvNhanVien.Rows.Clear();
                for (int i = 0; i < dtNV.Rows.Count; i++)
                {
                    string[] a = { dtNV.Rows[i][0].ToString(), dtNV.Rows[i][1].ToString(),new Utility().XuLyNgay(DateTime.Parse(dtNV.Rows[i][2].ToString())), dtNV.Rows[i][3].ToString(), dtNV.Rows[i][4].ToString(), dtNV.Rows[i][5].ToString(), dtNV.Rows[i][6].ToString(), dtNV.Rows[i][7].ToString(), dtNV.Rows[i][8].ToString()};
                    dgvNhanVien.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnNVLamMoi_Click(object sender, EventArgs e)
        {
            cbNVMaNV.Text = cbNVHoTen.Text = cbNVSCMT.Text = cbNVSDT.Text = cbNVChucVu.Text = cbNVQueQuan.Text = cbNVGioiTinh.Text = cbNVTrangThai.Text = mskNVNgaySinh.Text = "";
        }

        private void tabPhong_Click(object sender, EventArgs e)
        {
            if (PhongStatut == 0)
            {
                PhongStatut = 1;
                PBLL.LoadCB(cbPSoPhong, "SOPHONG", "Phong");
                PBLL.LoadCB(cbPSucChua, "SUCCHUA", "Phong");
                PBLL.LoadCBTrangThai(cbPTrangThai);
                PBLL.LoadCB(cbPMaDay, "MADAY", "DayPhong");
                PBLL.LoadCB(cbPLoaiPhong, "LOAIPHONG", "DayPhong");
                PBLL.LoadCB(cbPMaSV, "MASV", "SinhVien");
                cbPNhanVienQuanLy.DataSource = DPBLL.DanhSachNhanVien("%");
                cbPNhanVienQuanLy.ValueMember = "MANV";
                cbPNhanVienQuanLy.DisplayMember = "TENNV";
                cbPSoPhong.Text = cbPSucChua.Text = cbPMaDay.Text = cbPTrangThai.Text = cbPNhanVienQuanLy.Text = cbPLoaiPhong.Text = cbPMaSV.Text = "";
            }
        }

        private void cbPSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbPSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPSSVHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbPMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPTimKiem_Click(object sender, EventArgs e)
        {
            dgvPhong.Rows.Clear();
            string sophong = cbPSoPhong.Text;
            string succhua = cbPSucChua.Text;
            string ssvht = txtPSSVHT.Text;
            string mady = cbPMaDay.Text;
            string trangthai = cbPTrangThai.Text;
            string tennv = cbPNhanVienQuanLy.Text;
            string loaiphong = cbPLoaiPhong.Text;
            string masv = cbPMaSV.Text;

            if (masv == "")
            {
                dtPhong = PBLL.TKPhongAll(sophong, succhua, ssvht, mady, trangthai, tennv, loaiphong);
            }
            else
            {
                dtPhong = PBLL.TKPhongSV(sophong, succhua, ssvht, mady, trangthai, tennv, loaiphong, masv);
            }

            if (dtPhong.Rows.Count > 0)
            {
                dgvPhong.Rows.Clear();
                for (int i = 0; i < dtPhong.Rows.Count; i++)
                {
                    string[] a = { dtPhong.Rows[i][0].ToString(), dtPhong.Rows[i][1].ToString(), dtPhong.Rows[i][2].ToString(), dtPhong.Rows[i][3].ToString(), dtPhong.Rows[i][4].ToString()};
                    dgvPhong.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnPLamMoi_Click(object sender, EventArgs e)
        {
            cbPSoPhong.Text = cbPSucChua.Text = cbPMaDay.Text = cbPTrangThai.Text = cbPNhanVienQuanLy.Text = cbPLoaiPhong.Text = cbPMaSV.Text = txtPSSVHT.Text = "";
        }

        private void tabHopDong_Click(object sender, EventArgs e)
        {
            if (HDStatut == 0)
            {
                HDStatut = 1;
                PBLL.LoadCB(cbHDMaHD, "MAHD", "HopDong");
                PBLL.LoadCB(cbHDMaSV, "MASV", "SinhVien");
                PBLL.LoadCB(cbHDSoPhong, "SOPHONG", "Phong");
                PBLL.LoadCB(cbHDNhanVienLap, "TENNV", "NhanVien");
                cbHDMaHD.Text = cbHDMaSV.Text = cbHDSoPhong.Text = cbHDNhanVienLap.Text = "";
            }
        }

        private void cbHDMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbHDSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public string XuLyNgayFromTK(string ngay)
        {
            string strngay = "";
            string[] a = ngay.Split('/');
            string m = a[0].ToString().Trim();
            string d = a[1].ToString().Trim();
            string y = a[2].ToString().Trim();
            if (m == "")
                m = "01";
            if (d == "")
                d = "01";
            if (y == "")
                y = "1900";
            strngay = m + "/" + d + "/" + y;
            return strngay;
        }

        public string XuLyNgayToTK(string ngay)
        {
            string strngay = "";
            string[] a = ngay.Split('/');
            string m = a[0].ToString().Trim();
            string d = a[1].ToString().Trim();
            string y = a[2].ToString().Trim();
            if (m == "")
                m = "12";
            if (d == "")
                d = "30";
            if (y == "")
                y = "2100";
            strngay = m + "/" + d + "/" + y;
            return strngay;
        }

        private void btnHDTimKiem_Click(object sender, EventArgs e)
        {
            dgvHopDong.Rows.Clear();
            string mahd = cbHDMaHD.Text;
            string masv = cbHDMaSV.Text;
            string sophong = cbHDSoPhong.Text;
            string tennv = cbHDNhanVienLap.Text;
            string nltu = XuLyNgayFromTK(mskHDNgayLapTu.Text);
            string nlden = XuLyNgayToTK(mskHDNgayLapDen.Text);
            string nhhtu = XuLyNgayFromTK(mskHDNHHTu.Text);
            string nhhden = XuLyNgayToTK(mskHDNHHDen.Text);
            dtHopDong = HDBLL.TKHopDongAll(mahd, masv, sophong, tennv, nltu, nlden, nhhtu, nhhden);
            if (dtHopDong.Rows.Count > 0)
            {
                dgvHopDong.Rows.Clear();
                for (int i = 0; i < dtHopDong.Rows.Count; i++)
                {
                    string[] a = { dtHopDong.Rows[i][0].ToString(), new Utility().XuLyNgay(DateTime.Parse(dtHopDong.Rows[i][1].ToString())), new Utility().XuLyNgay(DateTime.Parse( dtHopDong.Rows[i][2].ToString())), dtHopDong.Rows[i][3].ToString(), dtHopDong.Rows[i][4].ToString(), dtHopDong.Rows[i][5].ToString() };
                    dgvHopDong.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hợp đồng phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnHDLamMoi_Click(object sender, EventArgs e)
        {
            cbHDMaHD.Text = cbHDMaSV.Text = cbHDSoPhong.Text = cbHDNhanVienLap.Text = mskHDNgayLapTu.Text = mskHDNgayLapDen.Text = mskHDNHHTu.Text = mskHDNHHDen.Text = "";
        }

        private void tabHDTP_Click(object sender, EventArgs e)
        {
            if (HDTPStatut == 0)
            {
                HDTPStatut = 1;
                PBLL.LoadCB(cbHDTPMaHDTP, "MAHDTP", "HoaDonTienPhong");
                PBLL.LoadCB(cbHDTPKyThu, "KYTHU", "HoaDonTienPhong");
                PBLL.LoadCB(cbHDTPNhanVienLap, "TENNV", "NhanVien");
                PBLL.LoadCB(cbHDTPMaSV, "MASV", "HoaDonTienPhong");
                cbHDTPMaSV.Text = cbHDTPKyThu.Text = cbHDTPMaHDTP.Text = cbHDTPNhanVienLap.Text = "";
            }
        }

        private void cbHDTPMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHDTPTimKiem_Click(object sender, EventArgs e)
        {
            dgvHDTP.Rows.Clear();
            string mahdtp = cbHDTPMaHDTP.Text;
            string kythu = cbHDTPKyThu.Text;
            string masv = cbHDTPMaSV.Text;
            string tennv = cbHDTPNhanVienLap.Text;
            string nltu = XuLyNgayFromTK(mskHDTPNgayLapTu.Text);
            string nlden = XuLyNgayToTK(mskHDTPNgayLapDen.Text);
            dtHoaDonTienPhong = HDTPBLL.TKHoaDon(mahdtp, kythu, masv, tennv, nltu, nlden);
            if (dtHoaDonTienPhong.Rows.Count > 0)
            {
                dgvHDTP.Rows.Clear();
                for (int i = 0; i < dtHoaDonTienPhong.Rows.Count; i++)
                {
                    string[] a = { dtHoaDonTienPhong.Rows[i][0].ToString(), new Utility().XuLyNgay(DateTime.Parse(dtHoaDonTienPhong.Rows[i][1].ToString())), dtHoaDonTienPhong.Rows[i][2].ToString(), dtHoaDonTienPhong.Rows[i][3].ToString(), dtHoaDonTienPhong.Rows[i][4].ToString(), dtHoaDonTienPhong.Rows[i][5].ToString()};
                    dgvHDTP.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnHDTPLamMoi_Click(object sender, EventArgs e)
        {
            cbHDTPMaHDTP.Text = cbHDTPMaSV.Text = cbHDTPKyThu.Text = cbHDTPNhanVienLap.Text = mskHDTPNgayLapTu.Text = mskHDTPNgayLapDen.Text = "";
        }

        private void tabSoGhiDienNuoc_Click(object sender, EventArgs e)
        {
            if (SGStatut == 0)
            {
                SGStatut = 1;
                PBLL.LoadCB(cbSGDNId, "ID", "SoGhiDienNuoc");
                PBLL.LoadCB(cbSGDNThang, "THANG", "SoGhiDienNuoc");
                PBLL.LoadCB(cbSGDNSoPhong, "SOPHONG", "Phong");
                cbSGDNSoPhong.Text = cbSGDNId.Text = cbSGDNThang.Text = "";
            }
        }

        private void cbSGDNId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSGDNSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSGDNTimKiem_Click(object sender, EventArgs e)
        {
            dgvSoGhi.Rows.Clear();
            string id = cbSGDNId.Text;
            string thang = cbSGDNThang.Text;
            string sophong = cbSGDNSoPhong.Text;
            dtSoGhi = SGDNBLL.TKSoGhi(id, thang, sophong);
            if (dtSoGhi.Rows.Count > 0)
            {
                dgvSoGhi.Rows.Clear();
                for (int i = 0; i < dtSoGhi.Rows.Count; i++)
                {
                    string[] a = { dtSoGhi.Rows[i][0].ToString(), dtSoGhi.Rows[i][1].ToString(), dtSoGhi.Rows[i][2].ToString(), dtSoGhi.Rows[i][3].ToString(), dtSoGhi.Rows[i][4].ToString()};
                    dgvSoGhi.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnSGDNLamMoi_Click(object sender, EventArgs e)
        {
            cbSGDNSoPhong.Text = cbSGDNId.Text = cbSGDNThang.Text = "";
        }

        private void tabHDTDN_Click(object sender, EventArgs e)
        {
            if (HDTDNStatut == 0)
            {
                HDTDNStatut = 1;
                PBLL.LoadCB(cbHDTDNMaHDTDN, "MAHDTDN", "HoaDonTienDienNuoc");
                PBLL.LoadCB(cbHDTDNThang, "THANG", "HoaDonTienDienNuoc");
                PBLL.LoadCB(cbHDTDNSoPhong, "SOPHONG", "Phong");
                PBLL.LoadCB(cbHDTDNMaSV, "MASV", "SinhVien");
                PBLL.LoadCB(cbHDTDNNhanVienLap, "TENNV", "NhanVien");
                cbHDTDNMaSV.Text = cbHDTDNNhanVienLap.Text = cbHDTDNSoPhong.Text = cbHDTDNThang.Text = cbHDTDNMaHDTDN.Text = "";
            }
        }

        private void cbHDTDNSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbHDTDNMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHDTDNTimKiem_Click(object sender, EventArgs e)
        {
            dgvHDTDN.Rows.Clear();
            string mahd = cbHDTDNMaHDTDN.Text;
            string thang = cbHDTDNThang.Text;
            string masv = cbHDTDNMaSV.Text;
            string sophong = cbHDTDNSoPhong.Text;
            string tennv = cbHDTDNNhanVienLap.Text;
            string nltu = XuLyNgayFromTK(mskHDTDNNgayLapTu.Text);
            string nlden = XuLyNgayToTK(mskHDTDNNgayLapDen.Text);
            dtHoaDonTienDienNuoc = HDTDNBLL.TKHoaDonTDN(mahd, thang, sophong, masv, tennv, nltu, nlden);
            if (dtHoaDonTienDienNuoc.Rows.Count > 0)
            {
                dgvHDTDN.Rows.Clear();
                for (int i = 0; i < dtHoaDonTienDienNuoc.Rows.Count; i++)
                {
                    string[] a = { dtHoaDonTienDienNuoc.Rows[i][0].ToString(),new Utility().XuLyNgay(DateTime.Parse(dtHoaDonTienDienNuoc.Rows[i][1].ToString())), dtHoaDonTienDienNuoc.Rows[i][2].ToString(), dtHoaDonTienDienNuoc.Rows[i][3].ToString(), dtHoaDonTienDienNuoc.Rows[i][4].ToString(), dtHoaDonTienDienNuoc.Rows[i][5].ToString(), dtHoaDonTienDienNuoc.Rows[i][6].ToString() };
                    dgvHDTDN.Rows.Add(a);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnHDTDNLamMoi_Click(object sender, EventArgs e)
        {
            cbHDTDNMaSV.Text = cbHDTDNNhanVienLap.Text = cbHDTDNSoPhong.Text = cbHDTDNThang.Text = cbHDTDNMaHDTDN.Text = mskHDTDNNgayLapTu.Text = mskHDTDNNgayLapDen.Text = "";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }

        
    }
}
