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
    public partial class frmSinhVien : DevComponents.DotNetBar.Office2007Form
    {
        
        public frmSinhVien()
        {
            InitializeComponent();
        }
        public frmSinhVien(string masv)
        {
            InitializeComponent();
            back = "thuephong";
            ThemTuThuePhong(masv);
        }

        public static string back = "";

        SinhVienBLL SVBLL = new SinhVienBLL();
        Utility Util = new Utility();
        DataTable dt  ; 

        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluongsinhvien = 0;
        int contro = 0;
        string click = "";

        public void ThemTuThuePhong(string masv)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            dgvSinhVien.Enabled = false;
            click = "Them";
            cbMaSinhVien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = true;
            
            cbMaSinhVien.Focus();
            cbMaSinhVien.AutoCompleteMode = AutoCompleteMode.None;
            cbMaSinhVien.AutoCompleteSource = AutoCompleteSource.None;
            cbMaSinhVien.Text = masv;
        }

        public void CapNhatThongTinTrang()
        {
            if (SVBLL.LayDuLieu() != null)
            {
                
                dt = SVBLL.LayDuLieu();
                soluongsinhvien = dt.Rows.Count;
                tongsotrang = (int)(soluongsinhvien / (sodong)) + 1;
                lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }
        }

        public void LoadGridView()
        {
            dgvSinhVien.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongsinhvien; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string ngay = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][2].ToString()));
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), ngay, dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString() };
                    dgvSinhVien.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbMaSinhVien.Text = dgvSinhVien[0, e.RowIndex].Value.ToString();
                txtHoten.Text = dgvSinhVien[1, e.RowIndex].Value.ToString();
                mskNgaysinh.Text = dgvSinhVien[2, e.RowIndex].Value.ToString(); cbGioitinh.DropDownStyle = ComboBoxStyle.DropDown;
                cbGioitinh.Text = dgvSinhVien[3, e.RowIndex].Value.ToString(); 
                cbQueQuan.Text = dgvSinhVien[4, e.RowIndex].Value.ToString();
                txtSocmt.Text = dgvSinhVien[5, e.RowIndex].Value.ToString();
                txtSdt.Text = dgvSinhVien[6, e.RowIndex].Value.ToString();
                cbChinhsach.Text = dgvSinhVien[7, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (back != "thuephong")
            {
                btnLuu.Enabled = btnHuy.Enabled = false;
                cbMaSinhVien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSocmt.Enabled = txtSdt.Enabled = mskNgaysinh.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = false;
            }
            cbChinhsach.Items.Add("Có"); cbChinhsach.Items.Add("Không");
            cbGioitinh.Items.Add("Nam"); cbGioitinh.Items.Add("Nữ");
            SVBLL.LoadCb(cbQueQuan, "QUEQUAN");
            cbChinhsach.Text = cbQueQuan.Text = "";
            CapNhatThongTinTrang();
            LoadGridView();
            
        }

        public bool KiemtraDuLieu()
        {
            if (cbMaSinhVien.Text.Trim() == "")
            {
                MessageBox.Show("Mã Sinh viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSinhVien.Focus();
                return false;
            }
            if (cbMaSinhVien.Text.Trim().Length != 10)
            {
                MessageBox.Show("Mã Sinh viên phải đúng 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSinhVien.Focus();
                return false;
            }
            if (txtHoten.Text.Trim() == "")
            {
                MessageBox.Show("Tên Sinh viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
                return false;
            }
            if (mskNgaysinh.Text == "")
            {
                MessageBox.Show("Ngày sinh Sinh viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
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
            if (cbChinhsach.Text.Trim() == "")
            {
                MessageBox.Show("Chính sách không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbChinhsach.Focus();
                return false;
            }
            if (cbGioitinh.Text.Trim() == "")
            {
                MessageBox.Show("Giới tính không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGioitinh.Focus();
                return false;
            }
            if (Kiemtrangaysinh() == false) return false;
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            dgvSinhVien.Enabled = false;
            click = "Them";
            cbMaSinhVien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = true;
            btnMoi_Click(sender, e);
            cbMaSinhVien.Focus();
            cbMaSinhVien.AutoCompleteMode = AutoCompleteMode.None;
            cbMaSinhVien.AutoCompleteSource = AutoCompleteSource.None;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            cbMaSinhVien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = true;
            click = "Sua";
            cbMaSinhVien.Focus();
            SVBLL.LoadCb(cbMaSinhVien, "MASV");
            cbMaSinhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaSinhVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            cbMaSinhVien.Enabled = true;
            txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = false;
            click = "Xoa";
            cbMaSinhVien.Focus();
            SVBLL.LoadCb(cbMaSinhVien, "MASV");
            cbMaSinhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMaSinhVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            btnLuu.Text = "Xóa";
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cbMaSinhVien.Text = txtHoten.Text = cbQueQuan.Text = txtSdt.Text = txtSocmt.Text = mskNgaysinh.Text = cbChinhsach.Text = cbGioitinh.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemtraDuLieu() == false) return;
                if (SVBLL.KiemTraTrung(dt,"MASV",cbMaSinhVien.Text))
                {
                    MessageBox.Show("Mã sinh viên bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (SVBLL.KiemTraTrung(dt, "CMT", txtSocmt.Text))
                {
                    MessageBox.Show("Số chứng minh thư bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SinhVien SV = new SinhVien(cbMaSinhVien.Text, Util.ChuanHoaXau(txtHoten.Text), DateTime.Parse(mskNgaysinh.Text), cbGioitinh.Text, Util.ChuanHoaXau(cbQueQuan.Text), int.Parse(txtSocmt.Text), txtSdt.Text, cbChinhsach.Text);
                if (SVBLL.ThemSV(SV))
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Bạn muốn lập hợp đồng cho sinh viên không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmHopDong frm = new frmHopDong(SV);
                        this.Dispose();
                        frm.ShowDialog();
                        return;
                    }
                    
                    
                        btnMoi_Click(sender, e);
                        SVBLL.LoadCb(cbQueQuan, "QUEQUAN");
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
                DataRow r = dt.Rows.Find(cbMaSinhVien.Text);
                if (r == null)
                {
                    MessageBox.Show("Mã sinh viên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ;
                }
                if (KiemtraDuLieu() == false) return;
                SinhVien SV = new SinhVien(cbMaSinhVien.Text, Util.ChuanHoaXau(txtHoten.Text), DateTime.Parse(mskNgaysinh.Text), cbGioitinh.Text, cbQueQuan.Text, int.Parse(txtSocmt.Text), txtSdt.Text, cbChinhsach.Text);
                if (SVBLL.SuaSV(SV) == true)
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
                DataRow r = dt.Rows.Find(cbMaSinhVien.Text);
                if (r == null)
                {
                    MessageBox.Show("Mã sinh viên không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (SVBLL.XoaSV(cbMaSinhVien.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluongsinhvien % sodong == 1) && (chisotrang * sodong >= soluongsinhvien) && (chisotrang != 1))
                        {
                            chisotrang--;
                        }
                        CapNhatThongTinTrang();
                        LoadGridView();
                        SVBLL.LoadCb(cbMaSinhVien, "MASV");

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
            cbMaSinhVien.Enabled = txtHoten.Enabled = cbQueQuan.Enabled = txtSdt.Enabled = txtSocmt.Enabled = cbChinhsach.Enabled = cbGioitinh.Enabled = mskNgaysinh.Enabled = false;
            if (click == "Xoa") btnLuu.Text = "Lưu";
            
            btnMoi_Click(sender, e);
            if (click == "Them")
            {
                dgvSinhVien.Enabled = true;
                cbMaSinhVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbMaSinhVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            click = "";
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (back == "thuephong")
            {
                back = "";
                this.Dispose();
                frmThuePhong frm = new frmThuePhong();
                frm.ShowDialog();
                
            }
            else
            {
                back = "";
                this.Dispose();
                frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
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

        private void cbMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       

        private void txtSocmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtSocmt.TextLength >= 9) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }


        public bool Kiemtrangaysinh()
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
                    MessageBox.Show("Sinh viên phải lớn hơn 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void cbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click == "Sua" || click == "Xoa")
            {
                DataRow r = dt.Rows.Find(cbMaSinhVien.Text);
                if (r != null)
                {
                    txtHoten.Text = r["TENSV"].ToString();
                    mskNgaysinh.Text = Util.XuLyNgay(DateTime.Parse(r["NGAYSINH"].ToString()));
                    cbGioitinh.Text = r["GIOITINH"].ToString();
                    cbChinhsach.Text = r["CHINHSACH"].ToString();
                    cbQueQuan.Text = r["QUEQUAN"].ToString();
                    txtSdt.Text = r["SDT"].ToString();
                    txtSocmt.Text = r["CMT"].ToString();
                }
            }
        }

        private void cbGioitinh_MouseDown(object sender, MouseEventArgs e)
        {
            cbGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbGioitinh_MouseHover(object sender, EventArgs e)
        {
            cbGioitinh.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       

       

       
    }
}
