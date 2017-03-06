using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DayPhongDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayDuLieu()
        {
            string query = "SELECT DayPhong.MADAY, DayPhong.LoaiPhong, NhanVien.TENNV FROM DayPhong, NhanVien WHERE DayPhong.MANV = NhanVien.MANV";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachNhanVien(string gioitinh)
        {
            string query = "SELECT MANV, TENNV FROM NhanVien WHERE (GIOITINH = N'" + gioitinh + "' or GIOITINH LIKE '" + gioitinh + "') and TRANGTHAI = N'Đang làm'";
            return Connec.LayDuLieu(query);
        }

        public int KiemTraNV(string tennv, string gioitinh)
        {
            string query = "SELECT * FROM NhanVien WHERE (GIOITINH = N'" + gioitinh + "' or GIOITINH LIKE '" + gioitinh + "') and TENNV = N'" + tennv + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }
        public DataTable LayMaDayCuoi()
        {
            string query = "SELECT TOP 1 MADAY FROM DayPhong ORDER BY MADAY DESC";
            if (Connec.LayDuLieu(query).Rows.Count > 0)
            {
                return Connec.LayDuLieu(query);
            }
            else
            {
                return null;
            }
        }

        public bool ThemDayPhong(DayPhong DP)
        {
            string query = "INSERT INTO DayPhong VALUES('" + DP.MaDay + "',N'" + DP.LoaiPhong + "','" + DP.MaNV + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaDayPhong(DayPhong DP)
        {
            string query = "UPDATE DayPhong SET LOAIPHONG = N'" + DP.LoaiPhong + "', MANV = '" + DP.MaNV + "' WHERE MADAY = '" + DP.MaDay + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaDayPhong(string maday)
        {
            string query = "DELETE FROM DayPhong WHERE MADAY = '" + maday + "'";
            return Connec.ThucThi(query);
        }

        public int SoPhongTrongDay(string maday)
        {
            string query = "SELECT * FROM Phong WHERE MADAY = '" + maday + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }

        public int KiemTraNVTheoMaNV(string manv)
        {
            string query = "SELECT * FROM DayPhong WHERE MANV ='" + manv + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }
    }
}
