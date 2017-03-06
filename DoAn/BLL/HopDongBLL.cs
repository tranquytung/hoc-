using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Windows.Forms;
namespace BLL
{
    public class HopDongBLL
    {
        HopDongDAO HDDAO = new HopDongDAO();
        public DataTable LayDuLieu()
        {
            return HDDAO.LayDuLieu();
        }

        public string TaoMaHopDongMoi(string mahdcu)
        {
            string MaHD = mahdcu;
            string strstt = "";
            
            int STT = int.Parse(MaHD.Substring(2).ToString()) + 1;
            if (STT < 10)
            {
                strstt = "00000" + STT;
            }
            else if (STT < 100)
            {
                strstt = "0000" + STT;
            }
            else if (STT < 1000)
            {
                strstt = "000" + STT;
            }
            else if (STT < 10000)
            {
                strstt = "00" + STT;
            }
            else if (STT < 100000)
            {
                strstt = "0" + STT;
            }
            return "HD" + strstt;
        }

        public DateTime LayNgayHetHan()
        {
            DateTime NgayHetHan = DateTime.Today;
            NgayHetHan.AddYears(4);
            return NgayHetHan;
        }
        public void LoadCBMaSinhVien(DataTable dt, ComboBox tencb)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = "MASV";
            tencb.DisplayMember = "MASV";
        }

        public void LoadCBTenSinhVien(DataTable dt, ComboBox tencb)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = "MASV";
            tencb.DisplayMember = "TENSV";
        }

        public void LoadCBMaHD(DataTable dt, ComboBox tencb)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = "MAHD";
            tencb.DisplayMember = "MAHD";
        }

        public void LoadPhong(DataTable dt, ComboBox tencb)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = "SOPHONG";
            tencb.DisplayMember = "SOPHONG";
        }

        public DataTable LaySinhVien()
        {
            return HDDAO.LoadSinhVien();
        }
        public DataTable LayPhong(string gt)
        {
            return HDDAO.LoadPhong(gt);
        }

        public DataTable LayTenNV(string manv)
        {
            return HDDAO.LayTenNV(manv);
        }

        public DataTable LayGioiTinh(string masv)
        {
            return HDDAO.LayGioiTinh(masv);
        }
        public bool ThemHopDong(HopDong HD)
        {
            return HDDAO.ThemHopDong(HD);
        }
        public bool SuaHopDong(HopDong HD)
        {
            return HDDAO.SuaHopDong(HD);
        }

        public bool XoaHopDong(string mahd)
        {
            return HDDAO.XoaHopDong(mahd);
        }

        public string LayMaSVPhuHop(string masv)
        {
            string msv = "";
            DataTable dt,dt1,dt2;
            dt = new DataTable();
            dt2 = HDDAO.LayGioiTinh(masv);
            if (dt2.Rows.Count > 0)
            {
                string gt = dt2.Rows[0][0].ToString();
                dt1 = HDDAO.LaySinhVienDangOCungGioiTinh(gt,masv);
                if (dt1.Rows.Count > 0)
                {
                    dt = dt1;
                    dt1 = HDDAO.LaySinhVienPhuHopTheoMa(masv, masv.Substring(0, 2), gt);
                    if (dt1.Rows.Count > 0)
                    {
                        dt = dt1;
                        dt1 = HDDAO.LaySinhVienPhuHopTheoMa(masv, masv.Substring(0, 3), gt);
                        if (dt1.Rows.Count > 0)
                        {
                            dt = dt1;
                            dt1 = HDDAO.LaySinhVienPhuHopTheoMa(masv, masv.Substring(0, 7), gt);
                            if (dt1.Rows.Count > 0)
                            {
                                dt = dt1;
                                dt1 = HDDAO.LaySinhVienPhuHopTheoMa(masv, masv.Substring(0, 8), gt);
                                if (dt1.Rows.Count > 0)
                                {
                                    dt = dt1;
                                    dt1 = HDDAO.LaySinhVienPhuHopTheoMa(masv, masv.Substring(0, 10), gt);
                                    if (dt1.Rows.Count > 0)
                                    {
                                        dt = dt1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(dt.Rows.Count > 0)
            msv = dt.Rows[0][0].ToString();
            return msv;
        }

        public int LaySoPHongPhuHop(string masv)
        {
            int sophong = 0;
            string msv = LayMaSVPhuHop(masv);
            if (msv == "") return sophong;
            sophong = int.Parse(HDDAO.LaySoPhongTheoMaSV(msv).Rows[0][0].ToString());
            return sophong;
        }

        public DataTable LoadSinhVienSuXoa(string masv)
        {
            return HDDAO.LoadSinhVienSuXoa(masv);

        }
        public DataTable LoadPhongSuaXoa(string gioitinh, int sophong)
        {
            return HDDAO.LoadPhongSuaXoa(gioitinh, sophong);
        }

        public DataTable LaySinhVienDangO()
        {
            return HDDAO.LaySinhVienDangO1();
        }

        public DataTable LayMaHopDongTheoMaSV(string masv)
        {
            return HDDAO.LayMaHopDongTheoMaSV(masv);
        }

        public bool CapNhatHopDongHetHan(string mahd)
        {
            return HDDAO.CapNhatHopDongHetHan(mahd);
        }

        public DataTable TKHopDongAll(string mahd, string masv, string sophong, string tennv, string nltu, string nlden, string nhhtu, string nhhden)
        {
            return HDDAO.TKHopDongAll(mahd, masv, sophong, tennv, nltu, nlden, nhhtu, nhhden);
        }

    }
}
