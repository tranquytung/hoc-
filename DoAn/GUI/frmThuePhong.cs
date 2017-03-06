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
    public partial class frmThuePhong : DevComponents.DotNetBar.Office2007Form
    {
        public frmThuePhong()
        {
            InitializeComponent();
        }
        HopDongBLL HDBLL = new HopDongBLL();
        DataTable dtSinhVienChuaO = new DataTable();
        DataTable dtSinhVienDangO = new DataTable();
        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            dtSinhVienChuaO = HDBLL.LaySinhVien();
            cbMaSV.DataSource = dtSinhVienChuaO;
            cbMaSV.ValueMember = "MASV";
            cbMaSV.DisplayMember = "MASV";
            dtSinhVienDangO = HDBLL.LaySinhVienDangO();
        }

        private void cbMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThuephong_Click(object sender, EventArgs e)
        {
            if (cbMaSV.Text.Trim().Length != 10)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtSinhVienChuaO.Rows.Count > 0)
            {
                dtSinhVienChuaO.PrimaryKey = new DataColumn[] { dtSinhVienChuaO.Columns[0] };
                DataRow r = dtSinhVienChuaO.Rows.Find(cbMaSV.Text);
                if (r != null)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = r[0].ToString();
                    sv.TenSV = r[1].ToString();
                    frmHopDong frm = new frmHopDong(sv,1);
                    this.Dispose();
                    frm.ShowDialog();
                    return;
                }
            }
            if (dtSinhVienDangO.Rows.Count > 0)
            {
                dtSinhVienDangO.PrimaryKey = new DataColumn[] { dtSinhVienDangO.Columns[0] };
                DataRow r = dtSinhVienDangO.Rows.Find(cbMaSV.Text);
                if (r != null)
                {
                    MessageBox.Show("Sinh viên đã thuê phòng rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (MessageBox.Show("Thông tin sinh viên không tồn tại! Bạn muốn thêm thông tin sinh viên không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmSinhVien frm = new frmSinhVien(cbMaSV.Text);
                this.Dispose();
                frm.ShowDialog();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            frmMenuChinh frm = new frmMenuChinh(frmMenuChinh.quyen);
            this.Dispose();
            frm.ShowDialog();
        }

    }
}
