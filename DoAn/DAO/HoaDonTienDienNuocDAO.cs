using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class HoaDonTienDienNuocDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayHoaDon()
        {
            string query = "SELECT HoaDonTienDienNuoc.MAHDTDN, HoaDonTienDienNuoc.NGAYLAP, HoaDonTienDienNuoc.THANG, HoaDonTienDienNuoc.SOPHONG, HoaDonTienDienNuoc.MASV, HoaDonTienDienNuoc.MANV, HoaDonTienDienNuoc.TONGTIEN, SinhVien.TENSV, NhanVien.TENNV FROM HoaDonTienDienNuoc, SinhVien, NhanVien WHERE (SinhVien.MASV = HoaDonTienDienNuoc.MASV) AND (HoaDonTienDienNuoc.MANV = NhanVien.MANV)";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayPhongChuaCoHoaDon(string thang)
        {
            string query = "SELECT SG.SOPHONG FROM SoGhiDienNuoc SG LEFT JOIN HoaDonTienDienNuoc HD ON (SG.SOPHONG = HD.SOPHONG)AND (SG.THANG = HD.THANG) WHERE (SG.THANG LIKE '"+thang+"') AND (HD.SOPHONG IS NULL)";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayPhongChuaCoHoaDonSua(string thang, int sophong)
        {
            string query = "SELECT DISTINCT SG.SOPHONG FROM SoGhiDienNuoc SG LEFT JOIN HoaDonTienDienNuoc HD ON (SG.SOPHONG = HD.SOPHONG) AND (SG.THANG = HD.THANG) WHERE ((SG.THANG LIKE '"+thang+"') AND (HD.SOPHONG IS NULL)) OR (SG.SOPHONG = " + sophong + ")";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySinhVienTrongPhong(int sophong)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV FROM SinhVien, (SELECT MASV FROM HopDong WHERE (SOPHONG = " + sophong + ") AND (NGAYHETHAN > '" + DateTime.Today + "')) AS SV1 WHERE SinhVien.MASV = SV1.MASV";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayTenNV(string manv)
        {
            string query = "SELECT TENNV FROM NhanVien WHERE MANV = '" + manv + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayChiSoDienNuocMoiCu(int sophong)
        {
            string query = "SELECT TOP 2 SODIEN, SONUOC FROM SoGhiDienNuoc WHERE SOPHONG = " + sophong + " ORDER BY ID DESC ";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayGiaDien()
        {
            string query = "SELECT GIA FROM DichVu WHERE MADV ='DV04'";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayGiaNuoc()
        {
            string query = "SELECT GIA FROM DichVu WHERE MADV ='DV05'";
            return Connec.LayDuLieu(query);
        }

        public bool ThemHoaDon(HoaDonTienDienNuoc HD)
        {
            string query = "INSERT INTO HoaDonTienDienNuoc VALUES('" + HD.MaHDTDN + "','" + HD.NgayLap + "','" + HD.Thang + "'," + HD.SoPhong + ",'" + HD.MaSV + "','" + HD.MaNV + "'," + HD.TongTien + ")";
            return Connec.ThucThi(query);
        }

        public bool SuaHoaDon(HoaDonTienDienNuoc HD)
        {
            string query = "UPDATE HoaDonTienDienNuoc SET NGAYLAP = '" + HD.NgayLap + "', THANG = '" + HD.Thang + "', SOPHONG = " + HD.SoPhong + ", MASV = '" + HD.MaSV + "', MANV = '" + HD.MaNV + "', TONGTIEN = " + HD.TongTien + " WHERE MAHDTDN = '" + HD.MaHDTDN + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaHoaDon(string mahd)
        {
            string query = "DELETE FROM HoaDonTienDienNuoc WHERE MAHDTDN = '" + mahd + "'";
            return Connec.ThucThi(query);
        }

        public DataTable TKHoaDonTDN(string mahd, string thang, string sophong, string masv, string tennv, string nltu, string nlden)
        {
            string query = "SELECT * FROM HoaDonTienDienNuoc WHERE (MANV IN (SELECT MANV FROM NhanVien WHERE TENNV LIKE N'%" + tennv + "%')) AND (MAHDTDN LIKE '%" + mahd + "%') AND (THANG LIKE '%" + thang + "%') AND (SOPHONG LIKE '%" + sophong + "%') AND (MASV LIKE '%" + masv + "%') AND (NGAYLAP BETWEEN '" + nltu + "' AND '" + nlden + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongTienDNDaTra(string thang, string nam)
        {
            string query = "SELECT SUM(TONGTIEN) FROM HoaDonTienDienNuoc WHERE THANG LIKE '" + thang + "/" + nam + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongTienDNDaTraTheoKy(string ky, string nam)
        {
            string query = "";
            if(ky == "%")
                query = "SELECT SUM(TONGTIEN) FROM HoaDonTienDienNuoc WHERE THANG LIKE '" + ky + "/" + nam + "'";
            else if(ky == "Kỳ 1")
                query = "SELECT SUM(TONGTIEN) FROM HoaDonTienDienNuoc WHERE (THANG LIKE '1/" + nam + "') OR (THANG LIKE '2/" + nam + "') OR (THANG LIKE '3/" + nam + "') OR (THANG LIKE '4/" + nam + "') OR (THANG LIKE '5/" + nam + "') OR (THANG LIKE '6/" + nam + "')";
            else if(ky == "Kỳ 2")
                query = "SELECT SUM(TONGTIEN) FROM HoaDonTienDienNuoc WHERE (THANG LIKE '7/" + nam + "') OR (THANG LIKE '8/" + nam + "') OR (THANG LIKE '9/" + nam + "') OR (THANG LIKE '10/" + nam + "') OR (THANG LIKE '11/" + nam + "') OR (THANG LIKE '12/" + nam + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayDanhSachNam()
        {
            string query = "SELECT DISTINCT  YEAR(HoaDonTienDienNuoc.NGAYLAP) AS HDYEAR FROM HoaDonTienDienNuoc";
            return Connec.LayDuLieu(query);
        }

        public int KiemTraThang(string thang)
        {
            string query = "SELECT * FROM HoaDonTienDienNuoc WHERE THANG LIKE '" + thang + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }
    }
}
