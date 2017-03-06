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
    public partial class frmTaiKhoan : DevComponents.DotNetBar.Office2007Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 7;
        int soluongnv = 0;
        DataTable dtChuaCo,dtDaCo,dttg;
        int contro = 0;

        public void CapNhatThongTinTrang()
        {
            dtChuaCo = TKBLL.DanhSachNVChuaCoTaiKhoan();
            dtDaCo = TKBLL.DanhSachNVDaCoTaiKhoan();
            if (radChuaCoTK.Checked == true)
            {
                dttg = dtChuaCo;
            }
            else
            {
                dttg = dtDaCo;
            }
        }

        public void LoadGridView(DataTable dt)
        {
            soluongnv = dt.Rows.Count;
            tongsotrang = (int)(soluongnv / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();

            dgvNhanVien.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongnv; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString() };
                    dgvNhanVien.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        public void LoadBanGhiDauChuaCoTK()
        {
            txtTenDN.Text = "";
            cbPhanQuyen.Text = "";
            if (dtChuaCo.Rows.Count > 0)
            {
                txtTenDN.Text = dtChuaCo.Rows[0][0].ToString();
                cbPhanQuyen.SelectedIndex = 0;
            }
        }

        public void LoadBanGhiDauDaCoTK()
        {
            txtTenDN.Text = "";
            cbPhanQuyen.Text = "";
            if (dtDaCo.Rows.Count > 0)
            {
                txtTenDN.Text = dtDaCo.Rows[0][0].ToString();
                cbPhanQuyen.SelectedText = dtDaCo.Rows[0][3].ToString();
            }
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            radDaCoTK.Checked = true;
            radDaCoTK_Click(sender, e);
            TKBLL.LoadCB(cbPhanQuyen);
        }

        private void radDaCoTK_Click(object sender, EventArgs e)
        {
            chisotrang = 1;
            CapNhatThongTinTrang();
            LoadGridView(dtDaCo);
            
            btnThem.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = btnReset.Enabled = true;
            LoadBanGhiDauDaCoTK();
            
            
        }

        private void radChuaCoTK_Click(object sender, EventArgs e)
        {
            chisotrang = 1;
            CapNhatThongTinTrang();
            LoadGridView(dtChuaCo);
            cbPhanQuyen.Text = "";
            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnReset.Enabled = false;
            LoadBanGhiDauChuaCoTK();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (radDaCoTK.Checked == true)
                {
                    cbPhanQuyen.Text = dtDaCo.Rows[e.RowIndex][3].ToString();
                }
                else
                {
                    cbPhanQuyen.Text = "";
                }
                txtTenDN.Text = dgvNhanVien[0, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        public bool KiemTraDuLieu()
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbPhanQuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn phân quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieu() == false) return;
            TaiKhoan TK = new TaiKhoan(txtTenDN.Text,cbPhanQuyen.Text);
            if (TKBLL.ThemTK(TK) == true)
            {
                MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if ((soluongnv % sodong == 1) && (chisotrang * sodong >= soluongnv) && (chisotrang != 1))
                {
                    chisotrang--;
                }
                CapNhatThongTinTrang();
                LoadGridView(dttg);
                txtTenDN.Text = "";
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false) return;
            TaiKhoan TK = new TaiKhoan(txtTenDN.Text,cbPhanQuyen.Text);
            if (TKBLL.SuaTK(TK) == true)
            {
                MessageBox.Show("Cập nhật thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatThongTinTrang();
                LoadGridView(dttg);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false) return;
            if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TKBLL.XoaTK(txtTenDN.Text) == true)
                {
                    MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatThongTinTrang();
                    LoadGridView(dttg);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false) return;
            TaiKhoan TK = new TaiKhoan(txtTenDN.Text);
            if (TKBLL.ResetMK(TK) == true)
            {
                MessageBox.Show("Thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            LoadGridView(dttg);
        }

        private void btnTangTrang_Click(object sender, EventArgs e)
        {
            chisotrang = chisotrang < tongsotrang ? chisotrang + 1 : 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
            LoadGridView(dttg);
        }

       
    }
}
