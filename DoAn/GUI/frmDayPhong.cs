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
    public partial class frmDayPhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmDayPhong()
        {
            InitializeComponent();
        }
        DayPhongBLL DPBLL = new DayPhongBLL();
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluongdayphong = 0;
        DataTable dt,dtNhanVien;
        int contro = 0;
        string click = "";
        
        public void CapNhatThongTinTrang()
        {
            dt = DPBLL.LayDuLieu();
            soluongdayphong = dt.Rows.Count;
            tongsotrang = (int)(soluongdayphong / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        public void LoadGridView()
        {

            dgvDayPhong.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongdayphong; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString()};
                    dgvDayPhong.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        public void LoadCBMaNV(string gt)
        {
            cbManv.DataSource = dtNhanVien = DPBLL.DanhSachNhanVien(gt);
            cbManv.DisplayMember = "TENNV";
            cbManv.ValueMember = "MANV";
        }

        private void frmDayPhong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = false;
            txtMaDay.Enabled = cbLoaiphong.Enabled = cbManv.Enabled = false;
            LoadCBMaNV("%%");
            cbLoaiphong.Items.Add("Nam");
            cbLoaiphong.Items.Add("Nữ");
        
            CapNhatThongTinTrang();
            LoadGridView();
        }

        private void dgvDayPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaDay.Text = dgvDayPhong[0, e.RowIndex].Value.ToString();
                cbLoaiphong.Text = dgvDayPhong[1, e.RowIndex].Value.ToString();
                cbManv.Text = dgvDayPhong[2, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void cbLoaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbManv.Text = "";
            LoadCBMaNV(cbLoaiphong.Text);
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnMoi_Click(sender, e);
            click = "Them";
            dgvDayPhong.Enabled = false;
            cbLoaiphong.Enabled = cbManv.Enabled = true;
            txtMaDay.Text = DPBLL.TaoMoiMaDay();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            click = "Sua";
            cbLoaiphong.Enabled = cbManv.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnMoi.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            click = "Xoa";
            btnLuu.Text = "Xóa";
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cbManv.Text = cbLoaiphong.Text = "";
        }

        public bool KiemTraDuLieu()
        {
            
            if (txtMaDay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Day phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbLoaiphong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Loại phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbManv.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Nhân viên quản lý !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DPBLL.KiemTraNV(cbManv.Text, cbLoaiphong.Text) == false)
            {
                MessageBox.Show("Nhân viên không tồn tại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                
                DayPhong DP = new DayPhong(txtMaDay.Text, cbLoaiphong.Text, cbManv.SelectedValue.ToString());
                if (DPBLL.ThemDayPhong(DP) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnMoi_Click(sender, e);
                    txtMaDay.Text = DPBLL.TaoMoiMaDay();
                    CapNhatThongTinTrang();
                    chisotrang = tongsotrang;
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (click == "Sua")
            {
                if (KiemTraDuLieu() == false) return;
                DayPhong DP = new DayPhong(txtMaDay.Text, cbLoaiphong.Text, cbManv.SelectedValue.ToString());
                if (DPBLL.SuaDayPhong(DP) == true)
                {
                    MessageBox.Show("Cập nhật thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatThongTinTrang();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (click == "Xoa")
            {
                if (KiemTraDuLieu() == false) return;
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DPBLL.SoPhongTrongDay(txtMaDay.Text) > 0)
                    {
                        MessageBox.Show("Lỗi ! Vẫn còn phòng tồn tại trong dãy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (DPBLL.XoaDayPhong(txtMaDay.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluongdayphong % sodong == 1) && (chisotrang * sodong >= soluongdayphong) && (chisotrang != 1))
                        {
                            chisotrang--;
                        }
                        CapNhatThongTinTrang();
                        LoadGridView();
                        btnMoi_Click(sender, e);
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
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnMoi.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
            btnMoi_Click(sender, e); txtMaDay.Text = "";
            cbLoaiphong.Enabled = cbManv.Enabled = false;
            if (click == "Xoa") btnLuu.Text = "Lưu";
            if (click == "Them") dgvDayPhong.Enabled = true;
            click = "";
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

      
    }
}
