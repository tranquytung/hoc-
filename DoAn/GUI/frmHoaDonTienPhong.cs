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
    public partial class frmHoaDonTienPhong : DevComponents.DotNetBar.Office2007Form
    {
        public static string back = "";
        public frmHoaDonTienPhong()
        {
            InitializeComponent();
        }
        public frmHoaDonTienPhong(SinhVien SV)
        {
            InitializeComponent();
            back = "hopdong";
            ThemTuHopDong(SV);
        }

        public void ThemTuHopDong(SinhVien SV)
        {
            dt = HDTPBLL.LayHoaDon();
            cbMaSV.Enabled = cbTenSV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            cbMaHoaDon.Text = dt.Rows.Count > 0 ? HDTPBLL.TaoMaHoaDonMoi(dt.Rows[dt.Rows.Count - 1][0].ToString()) : "HDTP000001";
            mskNgayLap.Text = Util.XuLyNgay(DateTime.Today);
            txtKyThu.Text = HDTPBLL.LayKyThu();
            txtTenNV.Text = HDTPBLL.LayTenNVTheoMa(frmMenuChinh.TenDN);
            click = "Them";
            btnLuu.Text = "Lập hóa đơn";
            dgvHoaDonTienPhong.Enabled = false;
            CapNhatSinhVienThem();
            cbMaSV.Text = SV.MaSV;
            cbTenSV.Text = SV.TenSV;
        }

        HoaDonTienPhongBLL HDTPBLL = new HoaDonTienPhongBLL();
        Utility Util = new Utility();

        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluonghoadon = 0;
        int contro = 0;
        string click = "";

        DataTable dt = new DataTable();
        DataTable dtSV = new DataTable();

        public void CapNhatSinhVienThem()
        {
            dtSV = HDTPBLL.LaySinhVienChuaLapHoaDon(txtKyThu.Text);
            HDTPBLL.LoadCB(cbMaSV, dtSV, "MASV", "MASV");
            HDTPBLL.LoadCB(cbTenSV, dtSV, "MASV", "TENSV");
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns[0] };
        }

        public void CapNhatSinhVienSua()
        {
            dtSV = HDTPBLL.LaySinhVienChuaLapHaoDonSua(txtKyThu.Text, cbMaSV.Text);
            HDTPBLL.LoadCB(cbMaSV, dtSV, "MASV", "MASV");
            HDTPBLL.LoadCB(cbTenSV, dtSV, "MASV", "TENSV");
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns[0] };
        }

        public void CapNhatThongTinTrang()
        {
            dt = HDTPBLL.LayHoaDon();
            if (click == "Sua" || click == "Xoa")
                HDTPBLL.LoadCB(cbMaHoaDon, dt, "MAHDTP", "MAHDTP");
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            soluonghoadon = dt.Rows.Count;
            tongsotrang = (int)(soluonghoadon / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }
        public void LoadGridView()
        {

            dgvHoaDonTienPhong.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluonghoadon; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string ngaylap = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][1].ToString()));

                    string[] a = { dt.Rows[i][0].ToString(), ngaylap, dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString() };
                    dgvHoaDonTienPhong.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void frmHoaDonTienPhong_Load(object sender, EventArgs e)
        {
            if (back != "hopdong")
            {
                cbMaHoaDon.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = mskNgayLap.Enabled = txtKyThu.Enabled = txtTenNV.Enabled = txtTongTien.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = true;
                btnLuu.Enabled = btnHuy.Enabled = false;
            }
            CapNhatThongTinTrang();
            LoadGridView();
        }

        private void dgvHoaDonTienPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbMaHoaDon.Text = dgvHoaDonTienPhong[0, e.RowIndex].Value.ToString();
                mskNgayLap.Text = dgvHoaDonTienPhong[1, e.RowIndex].Value.ToString();
                txtKyThu.Text = dgvHoaDonTienPhong[2, e.RowIndex].Value.ToString();
                cbMaSV.Text = dgvHoaDonTienPhong[3, e.RowIndex].Value.ToString();
                if(click == "Sua")
                CapNhatSinhVienSua();

                cbTenSV.Text = dt.Rows[e.RowIndex + (chisotrang - 1)* sodong][6].ToString();
                txtTenNV.Text = dt.Rows[e.RowIndex + (chisotrang - 1) * sodong][7].ToString();
                txtTongTien.Text = dgvHoaDonTienPhong[5, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void cbMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool KiemTraDuLieu()
        {
            if (cbMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Mã hóa đơn không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaHoaDon.Focus();
                return false;
            }
            if (cbMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaHoaDon.Focus();
                return false;
            }
            DataRow r = dtSV.Rows.Find(cbMaSV.Text);
            if (r == null)
            {
                MessageBox.Show("Mã sinh viên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSV.Focus();
                return false;
            }
            DataRow r2 = dtSV.Rows.Find(cbTenSV.SelectedValue);
            if (r == null)
            {
                MessageBox.Show("Mã sinh viên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTenSV.Focus();
                return false;
            }
            return true;
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns[0] };
            DataRow r = dtSV.Rows.Find(cbMaSV.Text);
            if (r != null)
            {
                txtTongTien.Text = HDTPBLL.LayTongTien(cbMaSV.Text).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            cbMaSV.Enabled = cbTenSV.Enabled  = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            cbMaHoaDon.Text = dt.Rows.Count > 0 ? HDTPBLL.TaoMaHoaDonMoi(dt.Rows[dt.Rows.Count - 1][0].ToString()) : "HDTP000001";
            mskNgayLap.Text = Util.XuLyNgay(DateTime.Today);
            txtKyThu.Text = HDTPBLL.LayKyThu();
            txtTenNV.Text = HDTPBLL.LayTenNVTheoMa(frmMenuChinh.TenDN);
            click = "Them";
            btnLuu.Text = "Lập hóa đơn";
            dgvHoaDonTienPhong.Enabled = false;
            CapNhatSinhVienThem();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cbMaSV.Enabled = cbTenSV.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            click = "Sua";
            cbMaHoaDon.Enabled = true;
            CapNhatThongTinTrang();
            
            CapNhatSinhVienSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            click = "Xoa";
            btnLuu.Text = "Xóa";
            cbMaHoaDon.Enabled = true;
            CapNhatThongTinTrang();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cbMaHoaDon.Text.Trim() != "")
            {
                rpHoaDonTienPhong rpHDTP = new rpHoaDonTienPhong(cbMaHoaDon.Text);
                rpHDTP.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                HoaDongTienPhong HDTP = new HoaDongTienPhong(cbMaHoaDon.Text, DateTime.Parse(mskNgayLap.Text), txtKyThu.Text, cbMaSV.Text, frmMenuChinh.TenDN, int.Parse(txtTongTien.Text));
                if (HDTPBLL.ThemHoaDonTienPhong(HDTP) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    CapNhatThongTinTrang();
                    CapNhatSinhVienThem();
                    chisotrang = tongsotrang;
                    cbMaHoaDon.Text = HDTPBLL.TaoMaHoaDonMoi(dt.Rows[dt.Rows.Count - 1][0].ToString());
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            if (click == "Sua")
            {
                DataRow r = dt.Rows.Find(cbMaHoaDon.Text);
                if(r == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaHoaDon.Focus();
                    return;
                }
                if(KiemTraDuLieu() == false) return;
                HoaDongTienPhong HDTP = new HoaDongTienPhong(cbMaHoaDon.Text, DateTime.Parse(mskNgayLap.Text), txtKyThu.Text, cbMaSV.Text, frmMenuChinh.TenDN, int.Parse(txtTongTien.Text));
                if(HDTPBLL.SuaHoaDonTienPhong(HDTP) == true)
                {
                    MessageBox.Show("Sửa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatThongTinTrang();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (click == "Xoa")
            {
                DataRow r = dt.Rows.Find(cbMaHoaDon.Text);
                if (r == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaHoaDon.Focus();
                    return;
                }
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (HDTPBLL.XoaHoaDonTienPhong(cbMaHoaDon.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluonghoadon % sodong == 1) && (chisotrang * sodong >= soluonghoadon) && (chisotrang != 1))
                        {
                            chisotrang--;
                        }
                        CapNhatThongTinTrang();
                        LoadGridView();


                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbMaHoaDon.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = mskNgayLap.Enabled = txtKyThu.Enabled = txtTenNV.Enabled = txtTongTien.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
            click = "";
            dgvHoaDonTienPhong.Enabled = true;
            btnLuu.Text = "Lưu";

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (back == "hopdong")
            {
                back = "";
                frmHopDong frm = new frmHopDong();
                this.Dispose();
                frm.ShowDialog();
            }
            else
            {
                back = "";
                frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
                this.Dispose();
                frm.ShowDialog();
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }

        private void btnLuiTrang_Click(object sender, EventArgs e)
        {
            chisotrang = chisotrang > 1 ? chisotrang - 1 : tongsotrang;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
            LoadGridView();
        }

        private void btnTangTrang_Click(object sender, EventArgs e)
        {
            chisotrang = chisotrang < tongsotrang ? chisotrang + 1 : 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
            LoadGridView();
        }

        private void cbMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click == "Sua" || click == "Xoa")
            {
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                DataRow r = dt.Rows.Find(cbMaHoaDon.Text);
                if (r != null)
                {
                    mskNgayLap.Text = Util.XuLyNgay(DateTime.Parse(r[1].ToString()));
                    txtKyThu.Text = r[2].ToString();
                    cbMaSV.Text = r[3].ToString();
                    cbTenSV.Text = r[6].ToString();
                    txtTenNV.Text = r[7].ToString();
                    txtTongTien.Text = r[5].ToString();
                }
            }
        }
    }
}
