using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenuChinh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMenuChinh()
        {
            InitializeComponent();
        }

        public static string quyen = "";
        public static string TenDN;

        public frmMenuChinh(string phanquyen)
        {
            quyen = phanquyen;
            InitializeComponent();
        }

        public void MoDieuKhien(string phanquyen)
        {
            if (phanquyen.Equals(""))
            {
                btnDangxuat.Enabled = false;
                ribPhong.Enabled = false;
                ribSinhVien.Enabled = false;
                ribDienNuoc.Enabled = false;
                ribMoRong.Enabled = false;
                ribThueTraPhong.Enabled = false;
                ribNangCao.Enabled = false;
            }

            if (phanquyen.Equals("Nhân Viên"))
            {
                btnDangnhap.Enabled = false;
                btnDangxuat.Enabled = true;

                ribPhong.Enabled = true;
                ribSinhVien.Enabled = true;
                ribDienNuoc.Enabled = true;
                ribMoRong.Enabled = true;
                ribThueTraPhong.Enabled = true;
                ribNangCao.Enabled = false;
            }

            if (phanquyen.Equals("Quản Lý"))
            {
                btnDangnhap.Enabled = false;
                btnDangxuat.Enabled = true;

                ribPhong.Enabled = false;
                ribSinhVien.Enabled = false;
                ribDienNuoc.Enabled = false;
                ribMoRong.Enabled = false;
                ribThueTraPhong.Enabled = false;

                ribNangCao.Enabled = true;
            }

        }

        private void frmMenuChinh_Load(object sender, EventArgs e)
        {
            MoDieuKhien(quyen);
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmMenuChinh.quyen = "";
            frmMenuChinh.TenDN = "";
            frmMenuChinh frm = new frmMenuChinh(quyen);
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhong frm = new frmPhong();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnDayPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDayPhong frm = new frmDayPhong();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVien frm = new frmSinhVien();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHopDong frm = new frmHopDong();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHoaDonTienPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonTienPhong frm = new frmHoaDonTienPhong();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnSoGhiDienNuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSoGhiDienNuoc frm = new frmSoGhiDienNuoc();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnHoaDonTienDienNuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHoaDonTienDienNuoc frm = new frmHoaDonTienDienNuoc();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDichVu frm = new frmDichVu();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTimKiem frm = new frmTimKiem();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frm = new frmNhanVien();
            frm.ShowDialog();
            this.Dispose();
            
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            frm.ShowDialog();
            this.Dispose();
        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThuePhong frm = new frmThuePhong();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTraPhong frm = new frmTraPhong();
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
