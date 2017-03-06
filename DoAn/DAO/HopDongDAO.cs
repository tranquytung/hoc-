using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class HopDongDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayDuLieu()
        {
            string query = "SELECT HopDong.MAHD, HopDong.NGAYLAP, HopDong.NGAYHETHAN, HopDong.MASV, HopDong.SOPHONG, HopDong.MANV, SinhVien.TENSV, NhanVien.TENNV FROM HopDong, SinhVien, NhanVien WHERE (SinhVien.MASV = HopDong.MASV) AND (NhanVien.MANV = HopDong.MANV)";
            return Connec.LayDuLieu(query);
        }

        public DataTable LoadSinhVien()
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV, SinhVien.GIOITINH FROM SinhVien WHERE MASV NOT IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LoadSinhVienSuXoa(string masv)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV, SinhVien.GIOITINH FROM SinhVien WHERE (MASV NOT IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')) or (MASV ='" + masv + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LoadPhong(string gioitinh)
        {
            string query = "SELECT DISTINCT Phong1.SOPHONG FROM (SELECT SOPHONG, MADAY FROM Phong WHERE (SUCCHUA > SOSVHT) AND (TRANGTHAI = N'Hoạt động')) AS Phong1, DayPhong WHERE (DayPhong.MADAY = Phong1.MADAY) AND ((DayPhong.LOAIPHONG = N'" + gioitinh + "') or (DayPhong.LOAIPHONG LIKE '" + gioitinh + "'))";
            return Connec.LayDuLieu(query);
        }
        public DataTable LoadPhongSuaXoa(string gioitinh, int sophong)
        {
            string query = "SELECT DISTINCT Phong1.SOPHONG FROM (SELECT SOPHONG, MADAY FROM Phong WHERE ((SUCCHUA > SOSVHT) AND (TRANGTHAI = N'Hoạt động')) or (SOPHONG = " + sophong + ")) AS Phong1, DayPhong WHERE (DayPhong.MADAY = Phong1.MADAY) AND ((DayPhong.LOAIPHONG = N'" + gioitinh + "') or (DayPhong.LOAIPHONG LIKE '" + gioitinh + "'))";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayTenNV(string manv)
        {
            string query = "SELECT TENNV FROM NhanVien WHERE MANV = '" + manv + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayGioiTinh(string masv)
        {
            string query = "SELECT GIOITINH FROM SinhVien WHERE MASV = '" + masv + "'";
            return Connec.LayDuLieu(query);
        }

        public bool ThemHopDong(HopDong HD)
        {
            string query = "INSERT INTO HopDong VALUES('" + HD.MaHD + "', '" + HD.NgayLap + "', '" + HD.NgayHetHan + "', '" + HD.MaSV + "', " + HD.SoPhong + ",'" + HD.MaNV + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaHopDong(HopDong HD)
        {
            string query = "UPDATE HopDong SET NGAYLAP = '" + HD.NgayLap + "', NGAYHETHAN = '" + HD.NgayHetHan + "', MASV = '" + HD.MaSV + "', SOPHONG = " + HD.SoPhong + " WHERE MAHD = '" + HD.MaHD + "'";
            return Connec.ThucThi(query);
        }
        public bool XoaHopDong(string mahd)
        {
            string query = "DELETE FROM HopDong WHERE MAHD ='" + mahd + "'";
            return Connec.ThucThi(query);
        }
        public DataTable LaySinhVienDangO()
        {

            string query1 = "SELECT MASV FROM HopDong, Phong WHERE (HopDong.SOPHONG = Phong.SOPHONG) and (NGAYHETHAN > '" + DateTime.Today + "') and (SOSVHT < SUCCHUA)";
            return Connec.LayDuLieu(query1);
        }

        public DataTable LaySinhVienDangOCungGioiTinh(string gt, string masv)
        {
            string query = "SELECT MASV FROM SinhVien WHERE (MASV IN (SELECT MASV FROM HopDong, Phong WHERE (HopDong.SOPHONG = Phong.SOPHONG) and (NGAYHETHAN > '" + DateTime.Today + "') and (SOSVHT < SUCCHUA))) AND (GIOITINH = N'" + gt + "') AND (MASV != '" + masv + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySinhVienPhuHopTheoMa(string masv, string strmasv, string gt)
        {
            string query = "SELECT MASV FROM SinhVien WHERE ((MASV IN (SELECT MASV FROM HopDong, Phong WHERE (HopDong.SOPHONG = Phong.SOPHONG) and (NGAYHETHAN > '" + DateTime.Today + "') and (SOSVHT < SUCCHUA))) AND (GIOITINH = N'" + gt + "') AND (MASV LIKE '" + strmasv + "%')) AND (MASV != '" + masv + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySoPhongTheoMaSV(string masv)
        {
            string query = "SELECT SOPHONG FROM HopDong WHERE (MASV = '" + masv + "') and (NGAYHETHAN > '" + DateTime.Today + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySinhVienDangO1()
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV FROM SinhVien WHERE SinhVien.MASV IN (SELECT DISTINCT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayMaHopDongTheoMaSV(string masv)
        {
            string query = "SELECT MAHD FROM HopDong WHERE (NGAYHETHAN > '" + DateTime.Today + "') AND (MASV = '" + masv + "')";
            return Connec.LayDuLieu(query);
        }

        public bool CapNhatHopDongHetHan(string mahd)
        {
            string query = "UPDATE HopDong SET NGAYHETHAN = '" + DateTime.Today + "' WHERE MAHD ='" + mahd + "'";
            return Connec.ThucThi(query);
        }

        public DataTable TKHopDongAll(string mahd, string masv, string sophong, string tennv, string nltu, string nlden, string nhhtu, string nhhden)
        {
            string query = "SELECT * FROM HopDong WHERE (MANV IN (SELECT MANV FROM NhanVien WHERE TENNV LIKE N'%" + tennv + "%')) AND (MAHD LIKE '%" + mahd + "%') AND (MASV LIKE '%" + masv + "%') AND (SOPHONG LIKE '%" + sophong + "%') AND (NGAYLAP BETWEEN '" + nltu + "' AND '" + nlden + "') AND (NGAYHETHAN BETWEEN '" + nhhtu + "' AND '" + nhhden + "')";
            return Connec.LayDuLieu(query);
        }

    }
}
