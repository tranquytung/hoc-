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
    public partial class frmPhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        PhongBLL PBLL = new PhongBLL();
        int chisotrang = 1;
        int tongsotrang = 0;
        int sodong = 10;
        int soluongphong = 0;
        DataTable dt;
        int contro = 0;
        string click = "";

        public void CapNhatThongTinTrang()
        {
            dt =PBLL.LayDuLieu();
            soluongphong = dt.Rows.Count;
            tongsotrang = (int)(soluongphong / (sodong)) + 1;
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        public void LoadGridView()
        {

            dgvPhong.Rows.Clear();
            for (int i = (chisotrang - 1) * sodong; i < soluongphong; i++)
            {
                if (i < chisotrang * sodong)
                {
                    string[] a = { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString()};
                    dgvPhong.Rows.Add(a);
                }
                else
                    break;
            }
            lblTrangHienTai.Text = chisotrang.ToString() + '/' + tongsotrang.ToString();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSoPhong.Text = dgvPhong[0, e.RowIndex].Value.ToString();
                cbSucChua.Text = dgvPhong[1, e.RowIndex].Value.ToString();
                txtSoSVHT.Text = dgvPhong[2, e.RowIndex].Value.ToString();
                cbMaDay.Text = dgvPhong[3, e.RowIndex].Value.ToString();
                cbTrangThai.Text = dgvPhong[4, e.RowIndex].Value.ToString();
                contro = e.RowIndex;
            }
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = false;
            txtSoPhong.Enabled = txtSoSVHT.Enabled = cbSucChua.Enabled = cbMaDay.Enabled = cbTrangThai.Enabled = false;
            txtSoSVHT.Text = "0";
            CapNhatThongTinTrang();
            LoadGridView();
            PBLL.LoadCBTrangThai(cbTrangThai);
            PBLL.LoadCB(cbSucChua, "SUCCHUA", "Phong");
            PBLL.LoadCB(cbMaDay, "MADAY", "DayPhong");

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtSoPhong.Enabled  = cbSucChua.Enabled = cbMaDay.Enabled = cbTrangThai.Enabled = true;
            btnMoi_Click(sender, e);
            txtSoPhong.Focus();
            click = "Them";
            dgvPhong.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            cbSucChua.Enabled = cbMaDay.Enabled = cbTrangThai.Enabled = true;
            click = "Sua";
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
            if (click == "Them") txtSoPhong.Text = "";
            cbMaDay.Text = cbSucChua.Text = cbTrangThai.Text = "";
            txtSoSVHT.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (click == "Them")
            {
                if (KiemTraDuLieu() == false) return;
                if (dt.Rows.Count == 0) return;
                dt.PrimaryKey = new DataColumn[] {dt.Columns[0] };
                DataRow r = dt.Rows.Find(txtSoPhong.Text);
                if (r != null)
                {
                    MessageBox.Show("Lỗi! Phòng đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoPhong.Focus();
                    return;
                }
                
            
                Phong P = new Phong(int.Parse(txtSoPhong.Text), int.Parse(cbSucChua.Text), 0, cbMaDay.Text, cbTrangThai.Text);
                if (PBLL.ThemPhong(P) == true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnMoi_Click(sender, e);
                    txtSoPhong.Focus();
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
                if (int.Parse(cbSucChua.Text) < int.Parse(txtSoSVHT.Text))
                {
                    MessageBox.Show("Lỗi! Số sinh viên hiện tại vượt quá Sức chứa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbSucChua.Focus();
                    return;
                }

                if ((cbTrangThai.Text == "Bảo trì") && (int.Parse(txtSoSVHT.Text) > 0))
                {
                    MessageBox.Show("Lỗi! Không thể Bảo trì khi phòng vẫn còn sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbTrangThai.Focus();
                    return;
                }

                Phong P = new Phong(int.Parse(txtSoPhong.Text), int.Parse(cbSucChua.Text), 0, cbMaDay.Text, cbTrangThai.Text);
                if (PBLL.SuaPhong(P) == true)
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
                if (int.Parse(txtSoSVHT.Text) > 0)
                {
                    MessageBox.Show("Lỗi! Không thể xóa phòng có sinh viên ở ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Xác nhận xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (PBLL.XoaPhong(int.Parse(txtSoPhong.Text)) == true)
                    {
                        MessageBox.Show("Xóa thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if ((soluongphong % sodong == 1) && (chisotrang * sodong >= soluongphong) && (chisotrang != 1))
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
            btnLuu.Enabled = btnHuy.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnMoi.Enabled = true;
            txtSoPhong.Enabled = txtSoSVHT.Enabled = cbSucChua.Enabled = cbMaDay.Enabled = cbTrangThai.Enabled = false;
            if (click == "Xoa") btnLuu.Text = "Lưu";
            if (click == "Them") dgvPhong.Enabled = true;
            click = "";
            btnMoi_Click(sender, e);
     
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

        private void txtSoPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || txtSoPhong.TextLength >=3) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void cbSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) || cbSucChua.Text.Length >= 2) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        public bool KiemTraDuLieu()
        {
            if (txtSoPhong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập Số phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return false;
            }

            if (cbSucChua.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Sức chứa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSucChua.Focus();
                return false;
            }

            if (cbMaDay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Mã dãy phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbTrangThai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn Trạng thái của phòng !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        
        
    }
}
