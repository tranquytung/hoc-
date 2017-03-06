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
    public partial class frmHopDong : DevComponents.DotNetBar.Office2007Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        public frmHopDong(SinhVien SV)
        {
            InitializeComponent();
            back = "qlsv";
            ThemTuSV(SV);
        }
        public frmHopDong(SinhVien SV, int key)
        {
            InitializeComponent();
            back = "thuephong";
            ThemTuSV(SV);
        }

        public void ThemTuSV(SinhVien SV)
        {
            mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = true;
            cbMaSV.Text = cbTenSV.Text = cbSoPhong.Text = "";
            click = "Them";
            btnLuu.Text = "Lập hợp đồng";
            dgvHopDong.Enabled = false;
            mskNgayLap.Text = Util.XuLyNgay(DateTime.Today);
            mskNgayHetHan.Text = Util.XuLyNgay(DateTime.Today.AddYears(4));
            txtTenNV.Text = HDBLL.LayTenNV(frmMenuChinh.TenDN).Rows[0][0].ToString();
            CapNhatThem();
            cbMaHopDong.Text = dt.Rows.Count > 0 ? HDBLL.TaoMaHopDongMoi(dt.Rows[dt.Rows.Count - 1][0].ToString()) : "HD000001";
            cbMaSV.Text = SV.MaSV;
            cbTenSV.Text = SV.TenSV;
        }
        public static string back = "";
        HopDongBLL HDBLL = new HopDongBLL();
        Utility Util = new Utility();
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluonghopdong = 0;
        
        DataTable dt = new DataTable();
        DataTable dtSV = new DataTable();
        DataTable dtPhong = new DataTable();
        int contro = 0;
        string click = "";


        public void CapNhatThem()
        {
            dtSV = HDBLL.LaySinhVien();
            dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns[0] };
            DataRow r = dtSV.Rows.Find(cbMaSV.Text);
            if (r != null) dtPhong = HDBLL.LayPhong(r["GIOITINH"].ToString());
            else dtPhong = HDBLL.LayPhong("%");
            dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
            HDBLL.LoadCBMaSinhVien(dtSV, cbMaSV);
            HDBLL.LoadCBTenSinhVien(dtSV, cbTenSV);
            HDBLL.LoadPhong(dtPhong, cbSoPhong);
            dt = HDBLL.LayDuLieu();
            
        }

        public void CapNhatSuaXoa()
        {
            if (cbMaSV.Text != "")
            {
                dtSV = HDBLL.LoadSinhVienSuXoa(cbMaSV.Text);
                dtSV.PrimaryKey = new DataColumn[] { dtSV.Columns[0] };
                DataRow r = dtSV.Rows.Find(cbMaSV.Text);
                if (r != null) dtPhong = HDBLL.LoadPhongSuaXoa(r["GIOITINH"].ToString(),int.Parse(cbSoPhong.Text));
                else dtPhong = HDBLL.LoadPhongSuaXoa("%", int.Parse(cbSoPhong.Text));
                dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
                HDBLL.LoadCBMaSinhVien(dtSV, cbMaSV);
                HDBLL.LoadCBTenSinhVien(dtSV, cbTenSV);
                HDBLL.LoadPhong(dtPhong, cbSoPhong);
            }
            
        }
        public void CapNhatThongTinTrang()
        {
            dt = HDBLL.LayDuLieu();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            if(click == "Sua" || click == "Xoa")
            HDBLL.LoadCBMaHD(dt, cbMaHopDong);
            
            soluonghopdong = dt.Rows.Count;
            tongsotrang = (int)(soluonghopdong / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }
        public void LoadGridView()
        {

            dgvHopDong.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluonghopdong; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string ngaylap = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][1].ToString()));
                    string ngayhethan = Util.XuLyNgay(DateTime.Parse(dt.Rows[i][2].ToString()));
                    string[] a = { dt.Rows[i][0].ToString(),ngaylap, ngayhethan, dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString()};
                    dgvHopDong.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            if ((back != "qlsv") && (back != "thuephong"))
            {
                cbMaHopDong.Enabled = mskNgayLap.Enabled = mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = false;
            }
            CapNhatThongTinTrang();
            LoadGridView();
            

        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                cbMaHopDong.Text = dgvHopDong[0, e.RowIndex].Value.ToString();
                mskNgayLap.Text = dgvHopDong[1, e.RowIndex].Value.ToString();
                mskNgayHetHan.Text = dgvHopDong[2, e.RowIndex].Value.ToString();
                cbMaSV.Text = dgvHopDong[3, e.RowIndex].Value.ToString();
                cbSoPhong.Text = dgvHopDong[4, e.RowIndex].Value.ToString();
                if (click == "Sua" || click == "Xoa")
                    CapNhatSuaXoa();
                cbTenSV.Text = dt.Rows[e.RowIndex + (chisotrang - 1) * sodong][6].ToString();
                cbSoPhong.Text = dgvHopDong[4, e.RowIndex].Value.ToString();
                txtTenNV.Text = dt.Rows[e.RowIndex + (chisotrang - 1) * sodong][7].ToString();
                contro = e.RowIndex;
                

            }
        }

        public bool Kiemtrangayhethan()
        {
            DateTime ngay;
            try
            {
                ngay = DateTime.Parse(mskNgayHetHan.Text);

                if (DateTime.Parse(mskNgayLap.Text) > ngay)
                {
                    MessageBox.Show("Ngày hết hạn phải lớn hơn ngày lập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskNgayHetHan.Focus();
                    return false;
                }

            }
            catch
            {
                MessageBox.Show("Sai định dang ngày! Định dạng chuẩn là mm/dd/yyyy ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgayHetHan.Focus();
                return false;
            }
            return true;
        }

        

        private void cbMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbMaSV_Leave(object sender, EventArgs e)
        {
            
            if (cbMaSV.Text.Length != 10)
            {
                MessageBox.Show("Mã sinh viên phải dài 10 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //cbMaSV.Focus();
                return;
            }
            
        }

        private void cbTenSV_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRow r = dtSV.Rows.Find(cbMaSV.Text);
            if (click == "Them")
            {
                if (r != null) dtPhong = HDBLL.LayPhong(r["GIOITINH"].ToString());
                else dtPhong = HDBLL.LayPhong("%");
            }
            else if (cbSoPhong.Text != "")
            {
                {
                    if (r != null) dtPhong = HDBLL.LoadPhongSuaXoa(r["GIOITINH"].ToString(), int.Parse(cbSoPhong.Text));
                    else dtPhong = HDBLL.LoadPhongSuaXoa("%", int.Parse(cbSoPhong.Text));
                }
            }
            dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
            HDBLL.LoadPhong(dtPhong, cbSoPhong);
        }

      

        private void cbSoPhong_Leave(object sender, EventArgs e)
        {
            if (cbSoPhong.Text.Length != 3)
            {
                MessageBox.Show("Số phòng phải dài 3 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoPhong.Focus();
            }
        }

        public bool KiemTraDuLieu()
        {
            if (cbMaHopDong.Text == "")
            {
                MessageBox.Show("Mã hợp đồng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaHopDong.Focus();
                return false;
            }

            DataRow r = dtSV.Rows.Find(cbMaSV.Text);
            if (r == null)
            {
                MessageBox.Show("Sinh viên không đúng tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSV.Focus();
                return false;
            }

            DataRow r1 = dtSV.Rows.Find(cbTenSV.SelectedValue);
            if (r1 == null)
            {
                MessageBox.Show("Sinh viên không đúng tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTenSV.Focus();
                return false;
            }

            if (cbMaSV.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSV.Focus();
                return false;
            }
            if (cbSoPhong.Text == "")
            {
                MessageBox.Show("Số phòng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoPhong.Focus();
                return false;
            }
            DataRow r2 = dtPhong.Rows.Find(cbSoPhong.Text);
            if (r2 == null)
            {
                MessageBox.Show("Phòng không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoPhong.Focus();
                return false;
            }
            if (Kiemtrangayhethan() == false) return false;

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = true;
            cbMaSV.Text = cbTenSV.Text = cbSoPhong.Text = "";
            click = "Them";
            btnLuu.Text = "Lập hợp đồng";
            dgvHopDong.Enabled = false;
            mskNgayLap.Text = Util.XuLyNgay(DateTime.Today);
            mskNgayHetHan.Text = Util.XuLyNgay(DateTime.Today.AddYears(4));
            txtTenNV.Text = HDBLL.LayTenNV(frmMenuChinh.TenDN).Rows[0][0].ToString();
            CapNhatThem();
            cbMaHopDong.Text = dt.Rows.Count > 0 ? HDBLL.TaoMaHopDongMoi(dt.Rows[dt.Rows.Count - 1][0].ToString()) : "HD000001";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = true;
            click = "Sua";
            cbMaHopDong.Enabled = true;
            CapNhatThongTinTrang();
            CapNhatThem();
            CapNhatSuaXoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            mskNgayLap.Enabled = mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = true;
            click = "Xoa";
            btnLuu.Text = "Xóa";
            cbMaHopDong.Enabled = true;
            CapNhatThongTinTrang();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(cbMaHopDong.Text.Trim() != "")
            {
                rpHopDong rpHD = new rpHopDong(cbMaHopDong.Text);
                rpHD.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                HopDong HD = new HopDong(cbMaHopDong.Text,DateTime.Parse(mskNgayLap.Text), DateTime.Parse(mskNgayHetHan.Text), cbMaSV.Text, int.Parse(cbSoPhong.Text),frmMenuChinh.TenDN);
                if (HDBLL.ThemHopDong(HD))
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Bạn muốn lập hóa đơn tiền phòng cho sinh viên không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SinhVien sv = new SinhVien(); sv.MaSV = cbMaSV.Text; sv.TenSV = cbTenSV.Text;
                        frmHoaDonTienPhong frm = new frmHoaDonTienPhong(sv);
                        this.Dispose();
                        frm.ShowDialog();
                    }
                    else
                    {
                        cbMaSV.Text = cbTenSV.Text = cbSoPhong.Text = "";
                        CapNhatThongTinTrang();
                        CapNhatThem();
                        chisotrang = tongsotrang;
                        cbMaHopDong.Text = HDBLL.TaoMaHopDongMoi(dt.Rows[dt.Rows.Count - 1][0].ToString());
                        LoadGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (click == "Sua")
            {
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                DataRow r = dt.Rows.Find(cbMaHopDong.Text);
                if (r == null)
                {
                    MessageBox.Show("Hợp đồng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbMaHopDong.Focus();
                    return;
                }
                if (KiemTraDuLieu() == false) return;
                HopDong HD = new HopDong(cbMaHopDong.Text, DateTime.Parse(mskNgayLap.Text), DateTime.Parse(mskNgayHetHan.Text), cbMaSV.Text, int.Parse(cbSoPhong.Text), frmMenuChinh.TenDN);
                if (HDBLL.SuaHopDong(HD) == true)
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
                DataRow r = dt.Rows.Find(cbMaHopDong.Text);
                if (r == null)
                {
                    MessageBox.Show("Hợp đồng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbTenSV.Focus();
                    return;
                }

                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (HDBLL.XoaHopDong(cbMaHopDong.Text) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluonghopdong % sodong == 1) && (chisotrang * sodong >= soluonghopdong) && (chisotrang != 1))
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
            mskNgayHetHan.Enabled = cbMaSV.Enabled = cbTenSV.Enabled = cbSoPhong.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnIn.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = btnTimPhong.Enabled = false;
            click = "";
            dgvHopDong.Enabled = true;
            btnLuu.Text = "Lưu";
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (back == "qlsv")
            {
                back = "";
                frmSinhVien frm = new frmSinhVien();
                this.Dispose();
                frm.ShowDialog();
            }
                else if(back == "thuephong")
            {
                back = "";
                frmThuePhong frm = new frmThuePhong();
                this.Dispose();
                frm.ShowDialog();
            }
            else
            {
                back = "";
                frmMenuChinh frm1 = new frmMenuChinh(frmMenuChinh.quyen);
                this.Dispose();
                frm1.ShowDialog();
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            string sop = HDBLL.LaySoPHongPhuHop(cbMaSV.Text).ToString();
            if(sop != "0")
            cbSoPhong.Text = sop;
        }

        private void cbMaHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click == "Sua" || click == "Xoa")
            {
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                DataRow r = dt.Rows.Find(cbMaHopDong.Text);
                if (r != null)
                {
                    mskNgayLap.Text = Util.XuLyNgay(DateTime.Parse(r[1].ToString()));
                    mskNgayHetHan.Text = Util.XuLyNgay(DateTime.Parse(r[2].ToString()));
                    cbMaSV.Text = r[3].ToString();
                    cbTenSV.Text = r[6].ToString();
                    cbSoPhong.Text = r[4].ToString();
                    txtTenNV.Text = r[7].ToString();
                }
            }
        }

        

       

       


    }
}
