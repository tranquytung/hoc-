using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class HoaDonTienPhongDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayHoaDon()
        {
            string query = "SELECT MAHDTP, NGAYLAP, KYTHU, HoaDonTienPhong.MASV, HoaDonTienPhong.MANV, TONGTIEN, SinhVien.TENSV, NhanVien.TENNV FROM HoaDonTienPhong, SinhVien, NhanVien WHERE (HoaDonTienPhong.MASV = SinhVien.MASV) AND (HoaDonTienPhong.MANV = NhanVien.MANV)";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySinhVienChuaLapHoaDon(string kythu)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV FROM SinhVien, (SELECT SV1.MASV FROM (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') AS SV1 WHERE SV1.MASV not in (SELECT MASV FROM HoaDonTienPhong WHERE KYTHU LIKE N'%" + kythu + "%')) AS SV2 WHERE SinhVien.MASV = SV2.MASV";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySinhVienChuaLapHaoDonSua(string kythu, string masv)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV FROM SinhVien, (SELECT SV1.MASV FROM (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') AS SV1 WHERE (SV1.MASV not in (SELECT MASV FROM HoaDonTienPhong WHERE KYTHU = N'" + kythu + "')) OR (SV1.MASV ='"+masv+"')) AS SV2 WHERE SinhVien.MASV = SV2.MASV";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayTenNVTheoMa(string manv)
        {
            string query = "SELECT TENNV FROM NhanVien WHERE MANV = '" + manv + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayChinhsachSV(string manv)
        {
            string query = "SELECT CHINHSACH FROM SinhVien WHERE MASV = '" + manv + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayTienPhong()
        {
            string query = "SELECT GIA FROM DichVu WHERE MADV = 'DV01'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayTienPhongUuDai()
        {
            string query = "SELECT GIA FROM DichVu WHERE MADV = 'DV02'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayPhiVeSinh()
        {
            string query = "SELECT GIA FROM DichVu WHERE MADV = 'DV03'";
            return Connec.LayDuLieu(query);
        }

        public bool ThemHoaDonTienPhong(HoaDongTienPhong HDTP)
        {
            string query = "INSERT INTO HoaDonTienPhong VALUES('" + HDTP.MaHDTP + "','" + HDTP.NgayLap + "',N'" + HDTP.KyThu + "','" + HDTP.MaSV + "','" + HDTP.MaNV + "'," + HDTP.TongTien + ")";
            return Connec.ThucThi(query);
        }

        public bool SuaHoaDonTienPhong(HoaDongTienPhong HDTP)
        {
            string query = "UPDATE HoaDonTienPhong SET MASV = '" + HDTP.MaSV + "', TONGTIEN = " + HDTP.TongTien + " WHERE MAHDTP = '" + HDTP.MaHDTP + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaHoaDonTienPhong(string mahd)
        {
            string query = "DELETE FROM HoaDonTienPhong WHERE MAHDTP = '"+mahd+"'";
            return Connec.ThucThi(query);
        }

        public DataTable TKHoaDon(string mahd, string kythu, string masv, string tennv, string nltu, string nlden)
        {
            string query = "SELECT * FROM HoaDonTienPhong WHERE (MANV IN (SELECT MANV FROM NhanVien WHERE TENNV LIKE N'%" + tennv + "%')) AND (MAHDTP LIKE '%" + mahd + "%') AND (MASV LIKE '%" + masv + "%') AND (KYTHU LIKE N'%" + kythu + "%') AND (NGAYLAP BETWEEN '" + nltu + "' AND '" + nlden + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongTienPhongDaTra(string ky, string nam)
        {
            string query = "SELECT SUM(TONGTIEN) FROM HoaDonTienPhong WHERE KYTHU LIKE N'%" + ky + "/%" + nam + "'";
            return Connec.LayDuLieu(query);
        }

        public int KiemTraKy(string ky)
        {
            string query = "SELECT * FROM HoaDonTienPhong WHERE KYTHU LIKE N'" + ky + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }
    }
}
