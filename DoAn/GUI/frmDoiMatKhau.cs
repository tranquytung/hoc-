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
    public partial class frmDoiMatKhau : DevComponents.DotNetBar.Office2007Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        TaiKhoanBLL TKBLL = new TaiKhoanBLL();
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTendangnhap.Focus();
        }

        private void btnThaydoi_Click(object sender, EventArgs e)
        {
            TaiKhoan TK = new TaiKhoan(txtTendangnhap.Text, txtMakhaucu.Text, "");
            if (TKBLL.KiemTraTenDN(TK) <= 0)
            {
                MessageBox.Show("Tên đăng nhập không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus();
                return;
            }
            DataTable dt = TKBLL.KiemTraTaiKhoan(TK);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Sai mật khẩu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhaucu.Text = txtMatkhaumoi.Text = txtReMK.Text = "";
                txtMakhaucu.Focus();
                return;
            }

            if (txtMatkhaumoi.Text != txtReMK.Text)
            {
                MessageBox.Show("Mật khẩu mới không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReMK.Text = "";
                txtMatkhaumoi.Text = "";
                txtMatkhaumoi.Focus();
                return;
            }

            if (TKBLL.ThayDoiMatKhau(TK, txtMatkhaumoi.Text) == true)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhaucu.Text = txtMatkhaumoi.Text = txtReMK.Text = "";
                txtTendangnhap.Focus();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhaucu.Text = txtMatkhaumoi.Text = txtReMK.Text = "";
                txtTendangnhap.Focus();
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();
        }

        private void txtTendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMakhaucu.Focus();
            }
        }

        private void txtMakhaucu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatkhaumoi.Focus();
            }
        }

        private void txtMatkhaumoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtReMK.Focus();
            }
        }

        private void txtReMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThaydoi_Click(sender, e);
            }
        }
    }
}
