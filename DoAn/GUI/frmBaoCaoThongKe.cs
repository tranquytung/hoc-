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
    public partial class frmBaoCaoThongKe : DevComponents.DotNetBar.Office2007Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        int SvStatus = 0;
        int NvStatus = 0;
        int PStatus = 0;
        int DTStatus = 0;

        SinhVienBLL SVBLL = new SinhVienBLL();
        NhanVienBLL NVBLL = new NhanVienBLL();
        PhongBLL PBLL = new PhongBLL();
        HopDongBLL HDBLL = new HopDongBLL();
        HoaDonTienPhongBLL HDTPBLL = new HoaDonTienPhongBLL();
        HoaDonTienDienNuocBLL HDTDNBLL = new HoaDonTienDienNuocBLL();

        DataTable dtSV;
        DataTable dtNV;
        DataTable dtPhong;

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            tabNhanVien_Click(sender, e);
        }

        private void tabSinhVien_Click(object sender, EventArgs e)
        {
            if (SvStatus == 0)
            {
                SvStatus = 1;
                string tongsv = SVBLL.TongSV().Rows[0][0].ToString();
                string tongsvdango = SVBLL.TongSvDangO().Rows[0][0].ToString();
                string tongsvchuanoptien = SVBLL.TongSvChuaNopTien(new HoaDonTienPhongBLL().LayKyThu()).Rows[0][0].ToString();
                string tongsvnam = SVBLL.TongSv("Nam").Rows[0][0].ToString();
                string tongsvnu = SVBLL.TongSv("Nữ").Rows[0][0].ToString();
                string tinhnhieusvnhat = SVBLL.TinhNhieuSvNhat().Rows[0][0].ToString();
                txtSVTong.Text = tongsv;
                txtSVSoSVDangO.Text = tongsvdango;
                txtSoSVChuaNopTien.Text = tongsvchuanoptien;
                txtSvNamNu.Text = tongsvnam + "/" + tongsvnu;
                txtSVTinh.Text = tinhnhieusvnhat;

                cbSVKieuThongKe.Items.Add("Danh sách sinh viên đang ở trong ký túc xá");
                cbSVKieuThongKe.Items.Add("Danh sách sinh viên chưa nộp tiền phòng");
                cbSVKieuThongKe.SelectedIndex = 0;

                dtSV = new DataTable();
            }
        }

        private void btnSVTimKiem_Click(object sender, EventArgs e)
        {
            dgvSinhVien.Rows.Clear();
            if (cbSVKieuThongKe.SelectedIndex == 0)
            {
                dtSV = SVBLL.LaySVDangO();
            }
            else
            {
                dtSV = SVBLL.LaySVChuaNopTien(new HoaDonTienPhongBLL().LayKyThu());
            }

            if (dtSV.Rows.Count > 0)
            {
                dgvSinhVien.Rows.Clear();
                for (int i = 0; i < dtSV.Rows.Count; i++)
                {
                    string[] a = { dtSV.Rows[i][0].ToString(), dtSV.Rows[i][1].ToString(), new Utility().XuLyNgay(DateTime.Parse(dtSV.Rows[i][2].ToString())), dtSV.Rows[i][3].ToString(), dtSV.Rows[i][4].ToString(), dtSV.Rows[i][5].ToString(), dtSV.Rows[i][6].ToString(), dtSV.Rows[i][7].ToString() };
                    dgvSinhVien.Rows.Add(a);
                }
            }
        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {
            if (NvStatus == 0)
            {
                NvStatus = 1;
                dtNV = new DataTable();
                string tonnv = NVBLL.TongNV().Rows[0][0].ToString();
                string nvdanglam = NVBLL.TongNvDangLam().Rows[0][0].ToString();
                string nvdanghi = (int.Parse(tonnv) - int.Parse(nvdanglam)).ToString();
                string sonvnam = NVBLL.TongNVTheoGT("Nam").Rows[0][0].ToString();
                string sonvnu = NVBLL.TongNVTheoGT("Nữ").Rows[0][0].ToString();
                string tuoitb = NVBLL.TuoiTB().Rows[0][0].ToString();
                string tinhnhieunvnhat = NVBLL.TinhNhieuNVNhat().Rows[0][0].ToString();

                txtNVTong.Text = tonnv;
                txtNVDangLamDaNghi.Text = nvdanglam + "/" + nvdanghi;
                txtNVNamNu.Text = sonvnam + "/" + sonvnu;
                txtNVTuoiTB.Text = tuoitb;
                txtNVTinh.Text = tinhnhieunvnhat;

                cbNVKieuThongKe.Items.Add("Danh sách nhân viên đang làm");
                cbNVKieuThongKe.Items.Add("Danh sách nhân viên đã nghỉ việc");
                cbNVKieuThongKe.SelectedIndex = 0;
            }
        }

        private void btnNVXem_Click(object sender, EventArgs e)
        {
            dgvSinhVien.Rows.Clear();
            if (cbNVKieuThongKe.SelectedIndex == 0)
            {
                dtNV = NVBLL.NhanVienDangLam();
            }
            else
            {
                dtNV = NVBLL.NhanVienDaNghi();
            }
            if (dtNV.Rows.Count > 0)
            {
                dgvNhanVien.Rows.Clear();
                for (int i = 0; i < dtNV.Rows.Count; i++)
                {
                    string[] a = { dtNV.Rows[i][0].ToString(), dtNV.Rows[i][1].ToString(), new Utility().XuLyNgay(DateTime.Parse(dtNV.Rows[i][2].ToString())), dtNV.Rows[i][3].ToString(), dtNV.Rows[i][4].ToString(), dtNV.Rows[i][5].ToString(), dtNV.Rows[i][6].ToString(), dtNV.Rows[i][7].ToString(), dtNV.Rows[i][8].ToString() };
                    dgvNhanVien.Rows.Add(a);
                }
            }
        }

        private void tabPhong_Click(object sender, EventArgs e)
        {
            if (PStatus == 0)
            {
                PStatus = 1;
                string tongp = PBLL.TongPhong().Rows[0][0].ToString();
                string tongpnam = PBLL.TongPhongTheoGT("Nam").Rows[0][0].ToString();
                string tongpnu = PBLL.TongPhongTheoGT("Nữ").Rows[0][0].ToString();
                string tongphoatdong = PBLL.TongPhongHoatDong().Rows[0][0].ToString();
                string tongpbaotri = PBLL.TongPhongBaoTri().Rows[0][0].ToString();
                string tongpcontrong = PBLL.TongPhongConTrong().Rows[0][0].ToString();
                string tongpdaday = PBLL.TongPhongDaDay().Rows[0][0].ToString();
                string tongpchuanoptien = PBLL.TongPhongChuaNopTienDien().Rows[0][0].ToString();
                string tongsvcothethem = PBLL.TongSVCoTheThem().Rows[0][0].ToString();

                txtPTongPhong.Text = tongp;
                txtPTongNamNu.Text = tongpnam + "/" + tongpnu;
                txtPHoatDongBT.Text = tongphoatdong + "/" + tongpbaotri;
                txtPConTrongDD.Text = tongpcontrong + "/" + tongpdaday;
                txtPChuaNopTien.Text = tongpchuanoptien;
                txtPSvThem.Text = tongsvcothethem;

                dtPhong = new DataTable();

                cbPKieuThongKe.Items.Add("Danh sách phòng còn trống");
                cbPKieuThongKe.Items.Add("Danh sách phòng đã đầy");
                cbPKieuThongKe.Items.Add("Danh sách phòng không có sinh viên ở");
                cbPKieuThongKe.Items.Add("Danh sách phòng đang hoạt động");
                cbPKieuThongKe.Items.Add("Danh sách phòng đang bảo trì");
                cbPKieuThongKe.Items.Add("Danh sách phòng chưa nộp tiền điện nước");
                cbPKieuThongKe.SelectedIndex = 0;
            }
        }

        private void btnPXem_Click(object sender, EventArgs e)
        {
            dgvPhong.Rows.Clear();
            if (cbPKieuThongKe.SelectedIndex == 0)
            {
                dtPhong = PBLL.DanhSachPConTrong();
            }
            if (cbPKieuThongKe.SelectedIndex == 1)
            {
                dtPhong = PBLL.DanhSachPDaDay();
            }
            if (cbPKieuThongKe.SelectedIndex == 2)
            {
                dtPhong = PBLL.DanhSachPKhongCoSVO();
            }
            if (cbPKieuThongKe.SelectedIndex == 3)
            {
                dtPhong = PBLL.DanhSachPDangHD();
            }
            if (cbPKieuThongKe.SelectedIndex == 4)
            {
                dtPhong = PBLL.DanhSachPDangBT();
            }
            if (cbPKieuThongKe.SelectedIndex == 5)
            {
                dtPhong = PBLL.DanhSachPChuaNopTien();
            }

            if (dtPhong.Rows.Count > 0)
            {
                dgvPhong.Rows.Clear();
                for (int i = 0; i < dtPhong.Rows.Count; i++)
                {
                    string[] a = { dtPhong.Rows[i][0].ToString(), dtPhong.Rows[i][1].ToString(), dtPhong.Rows[i][2].ToString(), dtPhong.Rows[i][3].ToString(), dtPhong.Rows[i][4].ToString() };
                    dgvPhong.Rows.Add(a);
                }
            }
        }

        private void tabDoanhThu_Click(object sender, EventArgs e)
        {
            if (DTStatus == 0)
            {
                DTStatus = 1;
                cbDTThang.Enabled = cbDTKy.Enabled = cbDTNam.Enabled = false;
                cbDTKieuThongKe.Items.Add("Thống kê tất cả");
                cbDTKieuThongKe.Items.Add("Thống kê tiền phòng");
                cbDTKieuThongKe.Items.Add("Thống kê tiền điện - nước");
                cbDTKieuThongKe.SelectedIndex = 0;
                
                cbDTThang.Items.Add("1");
                cbDTThang.Items.Add("2");
                cbDTThang.Items.Add("3");
                cbDTThang.Items.Add("4");
                cbDTThang.Items.Add("5");
                cbDTThang.Items.Add("6");
                cbDTThang.Items.Add("7");
                cbDTThang.Items.Add("8");
                cbDTThang.Items.Add("9");
                cbDTThang.Items.Add("10");
                cbDTThang.Items.Add("11");
                cbDTThang.Items.Add("12");
                //cbDTThang.SelectedIndex = 0;

                cbDTKy.Items.Add("Kỳ 1");
                cbDTKy.Items.Add("Kỳ 2");
                //cbDTKy.SelectedIndex = 0;
                DataTable dt = new DataTable();
                dt = HDTDNBLL.LayDanhSachNam();
                cbDTNam.DataSource = dt;
                cbDTNam.ValueMember = "HDYEAR";
                cbDTNam.DisplayMember = "HDYEAR";
                cbDTNam.Text = "";

            }
        }

        private void cbDTKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbDTKieuThongKe.SelectedIndex == 0) || (cbDTKieuThongKe.SelectedIndex == 1))
            {
                cbDTThang.Enabled = false;
                cbDTKy.Enabled = cbDTNam.Enabled = true;
                cbDTThang.Text = "";
            }
            else if (cbDTKieuThongKe.SelectedIndex == 2)
            {
                cbDTKy.Enabled = true;
                cbDTThang.Enabled = true;
                cbDTNam.Enabled = true;
            }
        }

        private void cbDTKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbDTKieuThongKe.SelectedIndex == 2) && (cbDTThang.Text != ""))
            {
                cbDTThang.Text = "";
            }
        }

        private void cbDTThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbDTKieuThongKe.SelectedIndex == 2) && (cbDTKy.Text != ""))
            {
                cbDTKy.Text = "";
            }
        }

        public string[] TienPhong(string ky, string nam)
        {
            if (ky == "") ky = "%";
            if (nam == "") nam = "%";
            string datra = HDTPBLL.TongTienPhongDaTra(ky, nam).Rows[0][0].ToString();
            string chuatra = HDTPBLL.TongTienPhongChuaTra(ky, nam).ToString();
            if (datra == "") datra = "0";
            if (chuatra == "") chuatra = "0";
            try
            {
                string tt = (int.Parse(datra) + int.Parse(chuatra)).ToString();
                string[] a = { tt, datra, chuatra };
                return a;
            }
            catch
            {
                string[] b = { "0", "0", "0" };
                return b;
            }
        }

        public string[] TienDienNuocTheoThang(string thang, string nam)
        {
            if (thang == "") thang = "%";
            if (nam == "") nam = "%";
            string datra = HDTDNBLL.TongTienDNDaTra(thang, nam).Rows[0][0].ToString();
            string chuatra = HDTDNBLL.TongTienDNChuaTra(thang, nam).ToString();
            if (datra == "") datra = "0";
            if (chuatra == "") chuatra = "0";
            try
            {
                string tt = (int.Parse(datra) + int.Parse(chuatra)).ToString();
                string[] a = { tt, datra, chuatra };
                return a;
            }
            catch
            {
                string[] b = {"0","0","0"};
                return b;
            }
            
        }

        public string[] TienDienNuocTheoKy(string ky, string nam)
        {
            if (ky == "") ky = "%";
            if (nam == "") nam = "%";
            string datra = HDTDNBLL.TongTienDNDaTraTheoKy(ky, nam).Rows[0][0].ToString();
            string chuatra = HDTDNBLL.TongTienDNChuaTraTheoKy(ky, nam).ToString();
            if (datra == "") datra = "0";
            if (chuatra == "") chuatra = "0";
            try
            {
                string tt = (int.Parse(datra) + int.Parse(chuatra)).ToString();
                string[] a = { tt, datra, chuatra };
                return a;
            }
            catch
            {
                string[] b = { "0", "0", "0" };
                return b;
            }

        }

        private void btnDTXem_Click(object sender, EventArgs e)
        {
            string[] kq = new string[3];
            string ky = cbDTKy.Text;
            string thang = cbDTThang.Text;
            string nam = cbDTNam.Text;
            if (cbDTKieuThongKe.SelectedIndex == 1)
            {
                if ((ky != "") && (nam != ""))
                {
                    int kt = HDTPBLL.KiemTraKy(ky + "/" + nam);
                    if (kt == 0)
                    {
                        kq = new string[] { "0", "0", "0" };
                    }
                    else
                    {
                        kq = TienPhong(cbDTKy.Text, cbDTNam.Text);
                    }
                }
                else
                {
                    kq = TienPhong(cbDTKy.Text, cbDTNam.Text);
                }
            }
            if ((cbDTKieuThongKe.SelectedIndex == 2) && cbDTKy.Text == "")
            {
                if ((thang != "") && (nam != ""))
                {
                    int kt = HDTDNBLL.KiemTraThang(thang + "/" + nam);
                    if (kt == 0)
                    {
                        kq = new string[] { "0", "0", "0" };
                    }
                    else
                    {
                        kq = TienDienNuocTheoThang(cbDTThang.Text, cbDTNam.Text);
                    }
                }
                else
                {
                    kq = TienDienNuocTheoThang(cbDTThang.Text, cbDTNam.Text);
                }
            }
            else
            if ((cbDTKieuThongKe.SelectedIndex == 2) && cbDTThang.Text == "")
            {
                kq = TienDienNuocTheoKy(cbDTKy.Text, cbDTNam.Text);
            }
            if (cbDTKieuThongKe.SelectedIndex == 0)
            {
                string[] kq1 = new string[3];
                string[] kq2 = new string[3];
                kq1 = TienPhong(cbDTKy.Text, cbDTNam.Text);
                kq2 = kq = TienDienNuocTheoKy(cbDTKy.Text, cbDTNam.Text);
                kq[0] = (int.Parse(kq1[0]) + int.Parse(kq2[0])).ToString();
                kq[1] = (int.Parse(kq1[1]) + int.Parse(kq2[1])).ToString();
                kq[2] = (int.Parse(kq1[2]) + int.Parse(kq2[2])).ToString(); 
            }
            txtDTTongTien.Text = kq[0].ToString();
            txtDTDaTra.Text = kq[1].ToString();
            txtDTConNo.Text = kq[2].ToString();
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

        private void cbDTThang_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Back)
            {
                cbDTThang.Text = "";
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbDTKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                cbDTKy.Text = "";
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbDTNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                cbDTNam.Text = "";
            }
            else
            {
                e.Handled = true;
            }
        }

        
    }
}
