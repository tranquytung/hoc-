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
    public partial class frmSoGhiDienNuoc : DevComponents.DotNetBar.Office2007Form
    {
        public frmSoGhiDienNuoc()
        {
            InitializeComponent();
        }

        SoGhiDienNuocBLL SGDNBLL = new SoGhiDienNuocBLL();
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluongsoghi = 0;
        int contro = 0;
        string click = "";

        DataTable dt = new DataTable();
        DataTable dtPhong = new DataTable();

        public void CapNhatSoPhongThem()
        {
            dtPhong = SGDNBLL.LayPhongChuaGhi(txtThang.Text);
            dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
            SGDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
        }

        public void CapNhatSoPhongSua()
        {
            dtPhong = SGDNBLL.LayPhongChuaGhiSua(txtThang.Text, int.Parse(cbSoPhong.Text.Trim()));
            dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
            SGDNBLL.LoadCB(cbSoPhong, dtPhong, "SOPHONG", "SOPHONG");
        }

        public void CapNhatThongTinTrang()
        {
            dt = SGDNBLL.LaySoGhi();
            if (click == "Sua" || click == "Xoa")
                SGDNBLL.LoadCB(cbId, dt, "ID", "ID");
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            soluongsoghi = dt.Rows.Count;
            tongsotrang = (int)(soluongsoghi / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }
        public void LoadGridView()
        {

            dgvSoGhi.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongsoghi; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString() };
                    dgvSoGhi.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void frmSoGhiDienNuoc_Load(object sender, EventArgs e)
        {
            cbId.Enabled = txtThang.Enabled = cbSoPhong.Enabled = txtSoDien.Enabled = txtSoNuoc.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = false;
            CapNhatThongTinTrang();
            LoadGridView();
        }

        private void dgvSoGhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbId.Text = dgvSoGhi[0, e.RowIndex].Value.ToString();
                txtThang.Text = dgvSoGhi[1, e.RowIndex].Value.ToString();
                cbSoPhong.Text = dgvSoGhi[2, e.RowIndex].Value.ToString();
                if(click == "Sua")
                CapNhatSoPhongSua();
                cbSoPhong.Text = dgvSoGhi[2, e.RowIndex].Value.ToString();
                txtSoDien.Text = dgvSoGhi[3, e.RowIndex].Value.ToString();
                txtSoNuoc.Text = dgvSoGhi[4, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void cbSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool KiemTraDuLieu()
        {
            if (cbId.Text.Trim() == "")
            {
                MessageBox.Show("Id không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbId.Focus();
                return false;
            }
            if (cbSoPhong.Text.Trim() == "")
            {
                MessageBox.Show("Số phòng không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoPhong.Focus();
                return false;
            }
            if (txtSoDien.Text.Trim() == "")
            {
                MessageBox.Show("Số điện không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDien.Focus();
                return false;
            }
            if (txtSoNuoc.Text.Trim() == "")
            {
                MessageBox.Show("Số nước không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNuoc.Focus();
                return false;
            }
            dtPhong.PrimaryKey = new DataColumn[] { dtPhong.Columns[0] };
            DataRow r = dtPhong.Rows.Find(cbSoPhong.Text);
            if (r == null)
            {
                MessageBox.Show("Số phòng không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSoPhong.Focus();
                return false;
            }
            DataTable ktsdn = SGDNBLL.LayChiSoDienNuocCu(int.Parse(cbSoPhong.Text));
            if (ktsdn.Rows.Count > 0 && click == "Them")
            {
                int sodiencu = int.Parse(ktsdn.Rows[0][0].ToString());
                if (int.Parse(txtSoDien.Text) < sodiencu)
                {
                    MessageBox.Show("Số điện mới không được nhỏ hơn số điện cũ ("+sodiencu+")!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoDien.Focus();
                    return false;
                }
                int sonuoccu = int.Parse(ktsdn.Rows[0][1].ToString());
                if (int.Parse(txtSoNuoc.Text) < sonuoccu)
                {
                    MessageBox.Show("Số nước mới không được nhỏ hơn số nước cũ (" + sonuoccu + ")!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSoPhong.Focus();
                    return false;
                }
            }
            return true;
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (click == "Sua" || click == "Xoa")
            {
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                int id = 1;
                try
                {
                    id = int.Parse(cbId.Text);
                }
                catch
                {
                    id = 1;   
                }
                DataRow r = dt.Rows.Find(id);
                if (r != null)
                {
                    txtThang.Text = r[1].ToString();
                    cbSoPhong.Text = r[2].ToString();
                    txtSoDien.Text = r[3].ToString();
                    txtSoNuoc.Text = r[4].ToString();

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            cbSoPhong.Enabled = txtSoNuoc.Enabled = txtSoDien.Enabled = true;
            cbId.Text = dt.Rows.Count > 0 ? SGDNBLL.TaoIDMoi(int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString())).ToString() : "1";
            txtThang.Text = SGDNBLL.LayThang();
            CapNhatSoPhongThem();
            click = "Them";
            dgvSoGhi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            cbId.Enabled = cbSoPhong.Enabled = txtSoNuoc.Enabled = txtSoDien.Enabled = true;
            click = "Sua";
            CapNhatThongTinTrang();
            CapNhatSoPhongSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            click = "Xoa";
            btnLuu.Text = "Xóa";
            cbId.Enabled = true;
            CapNhatThongTinTrang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                SoGhiDienNuoc SGDN = new SoGhiDienNuoc(int.Parse(cbId.Text), txtThang.Text, int.Parse(cbSoPhong.Text), int.Parse(txtSoDien.Text), int.Parse(txtSoNuoc.Text));
                if (SGDNBLL.ThemSoGhi(SGDN) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    CapNhatThongTinTrang();
                    CapNhatSoPhongThem();
                    chisotrang = tongsotrang;
                    cbId.Text = SGDNBLL.TaoIDMoi(int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString())).ToString();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (click == "Sua")
            {
                DataRow r = dt.Rows.Find(cbId.Text);
                if (r == null)
                {
                    MessageBox.Show("Sổ ghi không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbId.Focus();
                    return;
                }
                if (KiemTraDuLieu() == false) return;
                SoGhiDienNuoc SGDN = new SoGhiDienNuoc(int.Parse(cbId.Text), txtThang.Text, int.Parse(cbSoPhong.Text), int.Parse(txtSoDien.Text), int.Parse(txtSoNuoc.Text));
                if (SGDNBLL.SuaSoGhi(SGDN) == true)
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
                DataRow r = dt.Rows.Find(cbId.Text);
                if (r == null)
                {
                    MessageBox.Show("Sổ ghi không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbId.Focus();
                    return;
                }
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (SGDNBLL.XoaSoGhi(int.Parse(cbId.Text)) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluongsoghi % sodong == 1) && (chisotrang * sodong >= soluongsoghi) && (chisotrang != 1))
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
            btnLuu.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            cbSoPhong.Enabled = txtSoNuoc.Enabled = txtSoDien.Enabled = false;
            click = "";
            dgvSoGhi.Enabled = true;
            btnLuu.Text = "Lưu";
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
