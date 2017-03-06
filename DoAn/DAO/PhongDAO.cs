using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class PhongDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayDuLieu()
        {
            string query = "SELECT * FROM Phong";
            return Connec.LayDuLieu(query);
        }

        public DataTable LoadCB(string tencot, string tenbang)
        {
            string query = "SELECT DISTINCT " + tencot + " FROM "+tenbang;
            return Connec.LayDuLieu(query);
        }

        public int KiemTraMaTrung(int sophong)
        {
            string query = "SELECT * FROM Phong WHERE SOPHONG = " + sophong;
            return Connec.SoLuongBanGhiTonTai(query);
        }

        public bool ThemPhong(Phong P)
        {
            string query = "INSERT INTO Phong VALUES(" + P.SoPhong + "," + P.SucChua + "," + P.SoSVHT + ",'" + P.MaDay + "',N'" + P.TrangThai + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaPhong(Phong P)
        {
            string query = "UPDATE Phong SET SUCCHUA = " + P.SucChua + ",SOSVHT = " + P.SoSVHT + ", MADAY = '" + P.MaDay + "',TRANGTHAI = N'" + P.TrangThai + "' WHERE SOPHONG = "+P.SoPhong;
            return Connec.ThucThi(query);
        }

        public bool XoaPhong(int sophong)
        {
            string query = "DELETE FROM Phong WHERE SOPHONG = " + sophong;
            return Connec.ThucThi(query);
        }

        public DataTable TKPhongAll(string sophong, string succhua, string ssvht, string maday, string trangthai, string tennv, string loaiphong)
        {
            string query = "SELECT * FROM Phong WHERE SOPHONG IN (SELECT SOPHONG FROM (SELECT SOPHONG, MADAY FROM Phong WHERE (SOPHONG LIKE '%"+sophong+"%') AND (SUCCHUA LIKE '%"+succhua+"%') AND (SOSVHT LIKE '%"+ssvht+"%') AND (TRANGTHAI LIKE N'%"+trangthai+"%')) AS P1, (SELECT MADAY FROM DayPhong WHERE (MADAY LIKE '%"+maday+"%') AND (LOAIPHONG LIKE N'%"+loaiphong+"%') AND (MANV IN (SELECT MANV FROM NhanVien WHERE TENNV LIKE N'%"+tennv+"%'))) AS DP1 WHERE P1.MADAY = DP1.MADAY)";
            return Connec.LayDuLieu(query);
        }

        public DataTable TKPhongSV(string sophong, string succhua, string ssvht, string maday, string trangthai, string tennv, string loaiphong, string masv)
        {
            string query = "SELECT * FROM Phong WHERE SOPHONG IN (SELECT P1.SOPHONG FROM (SELECT SOPHONG, MADAY FROM Phong WHERE (SOPHONG LIKE '%" + sophong + "%') AND (SUCCHUA LIKE '%" + succhua + "%') AND (SOSVHT LIKE '%" + ssvht + "%') AND (TRANGTHAI LIKE N'%" + trangthai + "%')) AS P1, (SELECT MADAY FROM DayPhong WHERE (MADAY LIKE '%" + maday + "%') AND (LOAIPHONG LIKE N'%" + loaiphong + "%') AND (MANV IN (SELECT MANV FROM NhanVien WHERE TENNV LIKE N'%" + tennv + "%'))) AS DP1 WHERE (P1.MADAY = DP1.MADAY) AND (P1.SOPHONG IN (SELECT SOPHONG FROM HopDong WHERE MASV LIKE '%"+masv+"%')))";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhong()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhongTheoGT(string gt)
        {
            string query = "SELECT COUNT(Phong.SOPHONG) FROM Phong, DayPhong WHERE (Phong.MADAY = DayPhong.MADAY) AND (LOAIPHONG LIKE N'%"+gt+"%')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhongHoatDong()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong WHERE TRANGTHAI = N'Hoạt Động'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhongBaoTri()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong WHERE TRANGTHAI = N'Bảo Trì'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhongConTrong()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong WHERE (SUCCHUA > SOSVHT) AND (TRANGTHAI = N'Hoạt Động')";
            return Connec.LayDuLieu(query);
        }
        public DataTable TongPhongDaDay()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong WHERE (SUCCHUA = SOSVHT) AND (TRANGTHAI = N'Hoạt Động')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongPhongChuaNopTienDien()
        {
            string query = "SELECT COUNT(SOPHONG) FROM Phong WHERE SOPHONG IN (select sg.SOPHONG from SoGhiDienNuoc sg left join HoaDonTienDienNuoc hd on ((sg.SOPHONG = hd.SOPHONG) and (sg.THANG = hd.THANG)) where hd.SOPHONG is null)";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongSVCoTheThem()
        {
            string query = "SELECT SUM(SUCCHUA - SOSVHT) FROM Phong WHERE TRANGTHAI = N'Hoạt Động'";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPConTrong()
        {
            string query = "SELECT * FROM Phong WHERE SOSVHT < SUCCHUA";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPDaDay()
        {
            string query = "SELECT * FROM Phong WHERE SOSVHT = SUCCHUA";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPKhongCoSVO()
        {
            string query = "SELECT * FROM Phong WHERE SOSVHT = 0";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPDangHD()
        {
            string query = "SELECT * FROM Phong WHERE TRANGTHAI = N'Hoạt Động'";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPDangBT()
        {
            string query = "SELECT * FROM Phong WHERE TRANGTHAI = N'Bảo Trì'";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachPChuaNopTien()
        {
            string query = "SELECT * FROM Phong WHERE SOPHONG IN (select sg.SOPHONG from SoGhiDienNuoc sg left join HoaDonTienDienNuoc hd on ((sg.SOPHONG = hd.SOPHONG) and (sg.THANG = hd.THANG)) where hd.SOPHONG is null)";
            return Connec.LayDuLieu(query);
        }
    }
}
