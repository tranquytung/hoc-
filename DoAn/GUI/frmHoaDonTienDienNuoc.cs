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
    public partial class frmHoaDonTienDienNuoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmHoaDonTienDienNuoc()
        {
            InitializeComponent();
        }

        HoaDonTienDienNuocBLL HDTDNBLL = new HoaDonTienDienNuocBLL();
        Utility Util = new Utility();
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluonghoadon = 0;
        int contro = 0;
        string click = "";

        DataTable dt = new DataTable();
        DataTable dtSV = new DataTable();
        DataTable dtPhong = new DataTable();

        public void CapNhatPhongThem()
        {
            dtPhong = HDTDNBLL.LayPhongChuaCoHoaDon(cbThang.Text);
            HDTDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
            //dtSV = HDTDNBLL.LaySinhVienTrongPhong(int.Parse(cbSoPhong.Text));
            //HDTDNBLL.LoadCB(cbMaSV, dtSV, "MASV", "TENSV");
        }

        public void CapNhatPhongSua()
        {
            dtPhong = HDTDNBLL.LayPhongChuaCoHoaDonSua(cbThang.Text, int.Parse(cbSoPhong.Text));
            HDTDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
        }

        public void CapNhatThongTinTrang()
        {
            dt = HDTDNBLL.LayHoaDon();
            if (click != "Them")
                HDTDNBLL.LoadCB(cbMaHDTDN, dt, "MAHDTDN", "MAHDTDN");
            
            soluonghoadon = dt.Rows.Count;
            tongsotrang = (int)(soluonghoadon / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }
        public void LoadGridView()
        {

            dgvHoaDonTienDienNuoc.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluonghoadon; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string ngaylap = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][1].ToString()));

                    string[] a = { dt.Rows[i][0].ToString(), ngaylap, dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString() };
                    dgvHoaDonTienDienNuoc.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void frmHoaDonTienDienNuoc_Load(object sender, EventArgs e)
        {
            cbMaHDTDN.Enabled = mskNgayLap.Enabled = cbThang.Enabled = cbSoPhong.Enabled = cbMaSV.Enabled = txtTenNV.Enabled = txtTongTien.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = false;
            CapNhatThongTinTrang();
            LoadGridView();
        }

        private void dgvHoaDonTienDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbMaHDTDN.Text = dgvHoaDonTienDienNuoc[0, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void cbMaHDTDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click != "Them")
            {
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                DataRow r = dt.Rows.Find(cbMaHDTDN.Text);
                if (r != null)
                {
                    mskNgayLap.Text = Util.XuLyNgay(DateTime.Parse(r[1].ToString()));
                    cbThang.DropDownStyle = ComboBoxStyle.DropDown;
                    cbThang.Text = r[2].ToString();
                    cbSoPhong.Text = r[3].ToString();
                    cbThang_SelectedIndexChanged(sender, e);
                    cbSoPhong.Text = r[3].ToString();
                    cbMaSV.DropDownStyle = ComboBoxStyle.DropDown;
                    cbMaSV.Text = r[7].ToString();
                    txtTenNV.Text = r[8].ToString(); 
                    txtTongTien.Text = r[6].ToString();
                }
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                
                dtPhong = HDTDNBLL.LayPhongChuaCoHoaDon(cbThang.Text);
                HDTDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
            }
            else if (click == "Sua")
            {
                dtPhong = HDTDNBLL.LayPhongChuaCoHoaDonSua(cbThang.Text, int.Parse(cbSoPhong.Text));
                HDTDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
            }
         }

        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (click == "Them" || click == "Sua")
            {
                try
                {
                    
                    dtSV = HDTDNBLL.LaySinhVienTrongPhong(int.Parse(cbSoPhong.Text));
                    HDTDNBLL.LoadCB(cbMaSV, dtSV, "MASV", "TENSV");
                    txtTongTien.Text = HDTDNBLL.LayTongTien(int.Parse(cbSoPhong.Text)).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void cbSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool KiemTraDuLieu()
        {
            if (dtPhong.Rows.Count != 0)
            {
                dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
                DataRow r = dtPhong.Rows.Find(cbSoPhong.Text);
                if (r == null)
                {
                    MessageBox.Show("Số phòng không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSoPhong.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbThang.Enabled = cbSoPhong.Enabled = cbMaSV.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Text = "Lập hóa đơn";
            click = "Them";
            dgvHoaDonTienDienNuoc.Enabled = false;
            cbMaHDTDN.Text = dt.Rows.Count > 0 ? HDTDNBLL.TaoMaHoaDonMoi(dt.Rows[dt.Rows.Count - 1][0].ToString()) : "HDTDN000001";
            mskNgayLap.Text = Util.XuLyNgay(DateTime.Today);
            HDTDNBLL.LoadCBThang(cbThang); cbThang_SelectedIndexChanged(sender, e);
            txtTenNV.Text = HDTDNBLL.LayTenNV(frmMenuChinh.TenDN).Rows[0][0].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cbSoPhong.Enabled = cbMaSV.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            click = "Sua";
            cbMaHDTDN.Enabled = true;
            HDTDNBLL.LoadCBThang(cbThang);
            CapNhatThongTinTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            click = "Xoa";
            cbMaHDTDN.Enabled = true;
            btnLuu.Text = "Xóa";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cbMaHDTDN.Text.Trim() != "")
            {
                rpHoaDonTienDienNuoc rpHDTDN = new rpHoaDonTienDienNuoc(cbMaHDTDN.Text);
                rpHDTDN.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                HoaDonTienDienNuoc HDTDN = new HoaDonTienDienNuoc(cbMaHDTDN.Text, DateTime.Parse(mskNgayLap.Text), cbThang.Text, int.Parse(cbSoPhong.Text), cbMaSV.SelectedValue.ToString(), frmMenuChinh.TenDN, int.Parse(txtTongTien.Text));
                if (HDTDNBLL.ThemHoaDon(HDTDN) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    CapNhatThongTinTrang();
                    cbThang_SelectedIndexChanged(sender,e);
                    chisotrang = tongsotrang;
                    cbMaHDTDN.Text = HDTDNBLL.TaoMaHoaDonMoi(dt.Rows[dt.Rows.Count - 1][0].ToString());
                    LoadGridView();
                }
            }
            if (click == "Sua")
            {
                DataRow r = dt.Rows.Find(cbMaHDTDN.Text);
                if (r == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaHDTDN.Focus();
                    return;
                }
                if (KiemTraDuLieu() == false) return;
                HoaDonTienDienNuoc HDTDN = new HoaDonTienDienNuoc(cbMaHDTDN.Text, DateTime.Parse(mskNgayLap.Text), cbThang.Text, int.Parse(cbSoPhong.Text), cbMaSV.SelectedValue.ToString(), frmMenuChinh.TenDN, int.Parse(txtTongTien.Text));
                if (HDTDNBLL.SuaHoaDon(HDTDN) == true)
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
                if (dt.Rows.Count == 0) return;
                DataRow r = dt.Rows.Find(cbMaHDTDN.Text);
                if (r == null)
                {
                    MessageBox.Show("Hóa đơn không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaHDTDN.Focus();
                    return;
                }
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (HDTDNBLL.XoaHoaDon(cbMaHDTDN.Text) == true)
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
            cbMaHDTDN.Enabled = mskNgayLap.Enabled = cbThang.Enabled = cbSoPhong.Enabled = cbMaSV.Enabled = txtTenNV.Enabled = txtTongTien.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = true;
            click = "";
            dgvHoaDonTienDienNuoc.Enabled = true;
            btnLuu.Text = "Lưu";
            CapNhatThongTinTrang();
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

    

        private void cbMaSV_MouseHover(object sender, EventArgs e)
        {
            cbMaSV.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbThang_MouseHover(object sender, EventArgs e)
        {
            cbThang.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
