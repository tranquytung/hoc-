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
    public partial class frmTraPhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmTraPhong()
        {
            InitializeComponent();
        }
        HopDongBLL HDBLL = new HopDongBLL();
        DataTable dtSinhVienDangO = new DataTable();

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            dtSinhVienDangO = HDBLL.LaySinhVienDangO();
            cbMaSinhVien.DataSource = dtSinhVienDangO;
            cbMaSinhVien.ValueMember = "MASV";
            cbMaSinhVien.DisplayMember = "MASV";

            cbHoTen.DataSource = dtSinhVienDangO;
            cbHoTen.ValueMember = "MASV";
            cbHoTen.DisplayMember = "TENSV";
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (dtSinhVienDangO.Rows.Count > 0)
            {
                dtSinhVienDangO.PrimaryKey = new DataColumn[] { dtSinhVienDangO.Columns[0] };
                DataRow r = dtSinhVienDangO.Rows.Find(cbMaSinhVien.Text);
                if (r != null)
                {
                    if (MessageBox.Show("Xác nhận sinh viên trả phòng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mahd = HDBLL.LayMaHopDongTheoMaSV(cbMaSinhVien.Text).Rows[0][0].ToString();
                        if (HDBLL.CapNhatHopDongHetHan(mahd) == true)
                        {
                            MessageBox.Show("Trả phòng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTraPhong_Load(sender, e);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không ở trong ký túc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();
        }

        private void cbMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void cbMaSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}
