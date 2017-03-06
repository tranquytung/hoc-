using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Windows.Forms;
using System.Data;
namespace BLL
{
    public class HoaDonTienPhongBLL
    {
        HoaDonTienPhongDAO HDTPDAO = new HoaDonTienPhongDAO();
        public DataTable LayHoaDon()
        {
            return HDTPDAO.LayHoaDon();
        }

        public void LoadCB(ComboBox tencb, DataTable dt, string value, string display)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = value;
            tencb.DisplayMember = display;
        }

        public DataTable LaySinhVienChuaLapHoaDon(string kythu)
        {
            return HDTPDAO.LaySinhVienChuaLapHoaDon(kythu);
        }

        public DataTable LaySinhVienChuaLapHaoDonSua(string kythu, string masv)
        {
            return HDTPDAO.LaySinhVienChuaLapHaoDonSua(kythu, masv);
        }

        public string TaoMaHoaDonMoi(string mahdcu)
        {
            string MaHD = mahdcu;
            string strstt = "";

            int STT = int.Parse(MaHD.Substring(4).ToString()) + 1;
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
            return "HDTP" + strstt;
        }

        public string LayKyThu()
        {
            string kythu = "";
            kythu = ((DateTime.Today.Month >= 1) && (DateTime.Today.Month <= 6)) ? "Kỳ 1" : "Kỳ 2";
            return kythu + "/" + DateTime.Today.Year;
        }

        public string LayKyThu(DateTime kt)
        {
            string kythu = "";
            kythu = ((kt.Month >= 1) && (kt.Month <= 6)) ? "Kỳ 1" : "Kỳ 2";
            return kythu + "/" + kt.Year;
        }

        public string LayKy(DateTime kt)
        {
            string kythu = "";
            kythu = ((kt.Month >= 1) && (kt.Month <= 6)) ? "Kỳ 1" : "Kỳ 2";
            return kythu;
        }

        public string LayTenNVTheoMa(string manv)
        {
            DataTable dt = new DataTable();
            dt = HDTPDAO.LayTenNVTheoMa(manv);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "";
        }

        public int LayTongTien(string masv)
        {
            int Tongtien = 0;
            int Tienphong = 0;
            int Phivesinh = 0;
            DataTable dt = HDTPDAO.LayChinhsachSV(masv);
            if (dt.Rows[0][0].ToString() == "Không")
            {
                Tienphong = int.Parse(HDTPDAO.LayTienPhong().Rows[0][0].ToString());
            }
            else
            {
                Tienphong = int.Parse(HDTPDAO.LayTienPhongUuDai().Rows[0][0].ToString());
            }
            Phivesinh = int.Parse(HDTPDAO.LayPhiVeSinh().Rows[0][0].ToString());
            Tongtien = Tienphong + Phivesinh;
            return Tongtien;
        }

        public bool ThemHoaDonTienPhong(HoaDongTienPhong HDTP)
        {
            return HDTPDAO.ThemHoaDonTienPhong(HDTP);
        }

        public bool SuaHoaDonTienPhong(HoaDongTienPhong HDTP)
        {
            return HDTPDAO.SuaHoaDonTienPhong(HDTP);
        }

        public bool XoaHoaDonTienPhong(string mahd)
        {
            return HDTPDAO.XoaHoaDonTienPhong(mahd);
        }

        public DataTable TKHoaDon(string mahd, string kythu, string masv, string tennv, string nltu, string nlden)
        {
            return HDTPDAO.TKHoaDon(mahd, kythu, masv, tennv, nltu, nlden);
        }

        public DataTable TongTienPhongDaTra(string ky, string nam)
        {
            return HDTPDAO.TongTienPhongDaTra(ky, nam);
        }

        public int TongTienPhongChuaTra(string ky, string nam)
        {
            int tongtien = 0;
            DataTable dt = new DataTable();
            string k = ky + "/" + nam;
            string kht = LayKyThu(DateTime.Today);
            if (((ky == "%") && (nam == "%")) || ((nam == "%") && (ky == LayKy(DateTime.Today))) || ((ky == "%") && (nam == DateTime.Today.Year.ToString())))
            {
                k = kht;
            }
            
            if (k != kht)
            {
                return tongtien;
            }
            dt = LaySinhVienChuaLapHoaDon(k);
            
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tongtien = tongtien + LayTongTien(dt.Rows[i][0].ToString());
                }
            }
            return tongtien;
        }

        public int KiemTraKy(string ky)
        {
            return HDTPDAO.KiemTraKy(ky);
        }
    }
}
