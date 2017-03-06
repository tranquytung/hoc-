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
    public partial class frmDichVu : DevComponents.DotNetBar.Office2007Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        DataTable dt;
        DichVuBLL DVBLL = new DichVuBLL();

        public void LoadDL(DataTable dt)
        {
            if (dt != null)
            {
                txtGiaPhong.Text = dt.Rows[0][1].ToString();
                txtGiaPhongUuDai.Text = dt.Rows[1][1].ToString();
                txtPhiVeSinh.Text = dt.Rows[2][1].ToString();
                txtGiaDien.Text = dt.Rows[3][1].ToString();
                txtGiaNuoc.Text = dt.Rows[4][1].ToString();
            }
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dt = DVBLL.LayDuLieu();
            LoadDL(dt);
        }

        public bool KiemTraDuLieu()
        {
            if (txtGiaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Giá phòng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaPhong.Focus();
                return false;
            }
            if (txtGiaPhongUuDai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Giá phòng ưu đãi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaPhongUuDai.Focus();
                return false;
            }
            if (txtPhiVeSinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Phí vệ sinh!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiVeSinh.Focus();
                return false;
            }
            if (txtGiaDien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Giá điện!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaDien.Focus();
                return false;
            }
            if (txtGiaNuoc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Giá nước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNuoc.Focus();
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu() == false) return;
            DichVu DV1 = new DichVu("DV01", int.Parse(txtGiaPhong.Text));
            DichVu DV2 = new DichVu("DV02", int.Parse(txtGiaPhongUuDai.Text));
            DichVu DV3 = new DichVu("DV03", int.Parse(txtPhiVeSinh.Text));
            DichVu DV4 = new DichVu("DV04", int.Parse(txtGiaDien.Text));
            DichVu DV5 = new DichVu("DV05", int.Parse(txtGiaNuoc.Text));
            if (DVBLL.CapNhatDV(DV1) && DVBLL.CapNhatDV(DV2) && DVBLL.CapNhatDV(DV3) && DVBLL.CapNhatDV(DV4) && DVBLL.CapNhatDV(DV5))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmDichVu_Load(sender, e);
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

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)|| txtGiaPhong.TextLength >=7) && e.KeyChar != (char)Keys.Back )
                e.Handled = true;
        }

        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtGiaPhongUuDai.TextLength >= 7) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtPhiVeSinh.TextLength >= 7) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxX4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtGiaDien.TextLength >= 7) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void textBoxX5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtGiaNuoc.TextLength >= 7) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }


        
    }
}
