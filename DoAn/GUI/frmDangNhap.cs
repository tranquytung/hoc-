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
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        TaiKhoanBLL TKBLL = new TaiKhoanBLL();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTendangnhap.Focus();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan TK = new TaiKhoan(txtTendangnhap.Text, txtMatkhau.Text ,"");
            if (TKBLL.KiemTraTenDN(TK) <= 0)
            {
                MessageBox.Show("Tên đăng nhập không đúng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendangnhap.Focus();
                return;
            }
            DataTable dt = TKBLL.KiemTraTaiKhoan(TK);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Mật khẩu sai!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return;
            }
            Utility Util = new Utility();
            frmMenuChinh.quyen = dt.Rows[0][2].ToString();
            frmMenuChinh.TenDN = Util.ChuanHoaXau(txtTendangnhap.Text);
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();

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
                txtMatkhau.Focus();
            }
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap_Click(sender, e);
            }
        }
    }
}
