using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmNhanVien : DevComponents.DotNetBar.Office2007Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        NhanVienBLL NVBLL = new NhanVienBLL();
        Utility Util = new Utility();

        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluongnhanvien = 0;
        DataTable dt;
        int contro = 0;
        string click = "";

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            btnLuu.Enabled = btnHuy.Enabled = false;
            txtManhanvien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChucvu.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = cbTrangThai.Enabled = false;
            CapNhatThongTinTrang();
            LoadGridView();

            NVBLL.LoadCB(cbChucvu, "CHUCVU");
            NVBLL.LoadCB(cbQueQuan, "QUEQUAN");
            cbGioitinh.Items.Add("Nam"); cbGioitinh.Items.Add("Nữ");
            cbTrangThai.Items.Add("Đang làm"); cbTrangThai.Items.Add("Đã nghỉ việc");
            cbGioitinh.Text = "";
            cbQueQuan.Text = "";
            cbChucvu.Text = "";

        }

        public void CapNhatThongTinTrang()
        {
            dt = NVBLL.LayDuLieu();
            soluongnhanvien = dt.Rows.Count;
            tongsotrang = (int)(soluongnhanvien / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }
        public void LoadGridView()
        {

            dgvNhanVien.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongnhanvien; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string ngay = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][2].ToString()));
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(),ngay, dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString() };
                    dgvNhanVien.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

  

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgvNhanVien.Rows.Count - 1)
            {
                txtManhanvien.Text = dgvNhanVien[0, e.RowIndex].Value.ToString();
                txtHoten.Text = dgvNhanVien[1, e.RowIndex].Value.ToString(); cbGioitinh.DropDownStyle = ComboBoxStyle.DropDown;
                cbGioitinh.Text = dgvNhanVien[3, e.RowIndex].Value.ToString();
                mskNgaysinh.Text = dgvNhanVien[2, e.RowIndex].Value.ToString();
                cbQueQuan.Text = dgvNhanVien[4, e.RowIndex].Value.ToString();
                txtSdt.Text = dgvNhanVien[5, e.RowIndex].Value.ToString();
                cbChucvu.Text = dgvNhanVien[6, e.RowIndex].Value.ToString();
                txtSocmt.Text = dgvNhanVien[7, e.RowIndex].Value.ToString(); cbTrangThai.DropDownStyle = ComboBoxStyle.DropDown;
                cbTrangThai.Text = dgvNhanVien[8, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
            
        }

        private void txtSocmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
                e.Handled = true;
            
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

   
        public bool KiemTraNgaySinh()
        {
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.Parse(mskNgaysinh.Text);

                if (DateTime.Now.Year < ngaysinh.Year)
                {
                    MessageBox.Show("Ngày sinh không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgaysinh.Focus();
                    return false;
                }
                else if (DateTime.Now.Year - ngaysinh.Year < 18)
                {
                    MessageBox.Show("Nhân viên phải lớn hơn 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgaysinh.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Sai định dang ngày sinh! Định dạng chuẩn là mm/dd/yyyy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return false;
            }
            return true;
        }


        public bool KiemTraDuLieu()
        {
            if (txtManhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return false;
            }
            if (mskNgaysinh.Text == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return false;
            }
            if (KiemTraNgaySinh() == false) return false;
            if (cbGioitinh.Text == "")
            {
                MessageBox.Show("Giới tính nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioitinh.Focus();
                return false;
            }
            if (cbChucvu.Text == "")
            {
                MessageBox.Show("Chức vụ nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbChucvu.Focus();
                return false;
            }
            if (txtSocmt.Text.Trim() == "")
            {
                MessageBox.Show("Số chứng minh thư không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocmt.Focus();
                return false;
            }
            if (txtSocmt.Text.Length != 9)
            {
                MessageBox.Show("Số chứng minh thư phải dài 9 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSocmt.Focus();
                return false;
            }
            if (txtSdt.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return false;
            }
            if ((txtSdt.TextLength > 15) || (txtSdt.TextLength < 9))
            {
                MessageBox.Show("Số điện thoại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return false;
            }
            if (cbQueQuan.Text.Trim() == "")
            {
                MessageBox.Show("Quê quán không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbQueQuan.Focus();
                return false;
            }
            if (cbTrangThai.Text == "")
            {
                MessageBox.Show("Trạng thái nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioitinh.Focus();
                return false;
            }
            
            return true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            dgvNhanVien.Enabled = false;
            click = "Them";
            txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChucvu.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = cbTrangThai.Enabled = true;
            btnMoi_Click(sender, e);
            txtHoten.Focus();
            txtManhanvien.Text = NVBLL.TaoMaNVMoi();
            
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            click = "Sua";
            txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChucvu.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = cbTrangThai.Enabled = true;
            txtHoten.Focus();

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

            txtHoten.Text = cbQueQuan.Text = txtSdt.Text = txtSocmt.Text = mskNgaysinh.Text = cbChucvu.Text = cbGioitinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                NhanVien NV = new NhanVien(txtManhanvien.Text, Util.ChuanHoaXau(txtHoten.Text), DateTime.Parse(mskNgaysinh.Text), cbGioitinh.Text, Util.ChuanHoaXau(cbQueQuan.Text), cbChucvu.Text, int.Parse(txtSocmt.Text), txtSdt.Text, cbTrangThai.Text);
                if (NVBLL.ThemNV(NV) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnMoi_Click(sender, e);
                    txtHoten.Focus();
                    txtManhanvien.Text = NVBLL.TaoMaNVMoi();
                    CapNhatThongTinTrang();
                    chisotrang = tongsotrang;
                    LoadGridView();
                    
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (click == "Sua")
            {
                if (KiemTraDuLieu() == false) return;
                
                    if ((cbTrangThai.Text == "Đã nghỉ việc") && (NVBLL.KiemTraNhanVienQuanLyDay(txtManhanvien.Text) == true))
                    {
                        MessageBox.Show("Lỗi, Nhân viên đang quản lý Dãy phòng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                NhanVien NV = new NhanVien(txtManhanvien.Text, Util.ChuanHoaXau(txtHoten.Text), DateTime.Parse(mskNgaysinh.Text), cbGioitinh.Text, Util.ChuanHoaXau(cbQueQuan.Text), cbChucvu.Text, int.Parse(txtSocmt.Text), txtSdt.Text, cbTrangThai.Text);
                if (NVBLL.SuaNV(NV) == true)
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
                if (txtManhanvien.Text == "")
                {
                    MessageBox.Show("Chưa chọn Nhân Viên cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (NVBLL.KiemTraNhanVienQuanLyDay(txtManhanvien.Text) == true)
                    {
                        MessageBox.Show("Lỗi, Không thể xóa Nhân viên đang quản lý Dãy phòng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        
                        if (NVBLL.XoaNV(txtManhanvien.Text) == true)
                        {
                            MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if ((soluongnhanvien % sodong == 1) && (chisotrang * sodong >= soluongnhanvien) && (chisotrang != 1))
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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnMoi.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
            txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChucvu.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = false;
            if (click == "Xoa") btnLuu.Text = "Lưu";
            click = "";
            btnMoi_Click(sender, e);
            txtManhanvien.Text = "";
            dgvNhanVien.Enabled = true;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thoát khỏi chương trình?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void cbGioitinh_MouseHover(object sender, EventArgs e)
        {
            cbGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbTrangThai_MouseHover(object sender, EventArgs e)
        {
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

      

       
    }
}
