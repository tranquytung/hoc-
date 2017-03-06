using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class SinhVienDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LayDuLieu()
        {
            string query = "SELECT * FROM SinhVien";
            return Connec.LayDuLieu(query);
        }

        public bool KiemTraMaSV(string masv)
        {
            string query = "SELECT * FROM SinhVien WHERE MASV ='" + masv + "'";
            if (Connec.SoLuongBanGhiTonTai(query) > 0)
            {
                return true;
            }
            return false;         

        }

        public DataTable LoadCb(string tencot)
        {
            string query = "SELECT DISTINCT " + tencot + " FROM SinhVien";
            return Connec.LayDuLieu(query);
        }

        public bool ThemSV(SinhVien SV)
        {
            string query = "INSERT INTO SinhVien VALUES('" + SV.MaSV + "',N'" + SV.TenSV + "','" + SV.NgaySinh + "',N'" + SV.GioiTinh + "',N'" + SV.QueQuan + "'," + SV.CMT + ",'" + SV.SoDT + "','" + SV.ChinhSach + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaSV(SinhVien SV)
        {
            string query = "UPDATE SinhVien SET TENSV = N'" + SV.TenSV + "', NGAYSINH = '" + SV.NgaySinh + "', GIOITINH = N'" + SV.GioiTinh + "', QUEQUAN = N'" + SV.QueQuan + "', SDT = '" + SV.SoDT + "', CMT = " + SV.CMT + ", CHINHSACH = N'"+SV.ChinhSach +"' WHERE MASV = '" + SV.MaSV + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaSV(string masv)
        {
            string query = "DELETE FROM SinhVien WHERE MASV = '" + masv + "'";
            return Connec.ThucThi(query);
        }

        public DataTable TKSinhVienAll(SinhVien SV, string ns, string cmt)
        {
            string query = "SELECT * FROM SinhVien WHERE (MASV LIKE '%" + SV.MaSV + "%') AND (TENSV LIKE N'%" + SV.TenSV + "%') AND (GIOITINH LIKE N'%" + SV.GioiTinh + "%') AND (QUEQUAN LIKE N'%" + SV.QueQuan + "%') AND (CMT LIKE '%" + cmt + "%') AND (SDT LIKE '%" + SV.SoDT + "%') AND (CHINHSACH LIKE N'%" + SV.ChinhSach + "%') AND (NGAYSINH LIKE '"+ns+"')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TKSinhVienKhongO(SinhVien SV, string ns, string cmt)
        {
            string query = "SELECT * FROM SinhVien WHERE (MASV NOT IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')) AND (MASV LIKE '%" + SV.MaSV + "%') AND (TENSV LIKE N'%" + SV.TenSV + "%') AND (GIOITINH LIKE N'%" + SV.GioiTinh + "%') AND (QUEQUAN LIKE N'%" + SV.QueQuan + "%') AND (CMT LIKE '%" + cmt + "%') AND (SDT LIKE '%" + SV.SoDT + "%') AND (CHINHSACH LIKE N'%" + SV.ChinhSach + "%') AND (NGAYSINH LIKE '" + ns + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TKSinhVienDangO(SinhVien SV, string ns,string cmt, string sophong)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV, SinhVien.NGAYSINH, SinhVien.GIOITINH, SinhVien.QUEQUAN, SinhVien.CMT, SinhVien.SDT, SinhVien.CHINHSACH FROM SinhVien, (SELECT MASV, SOPHONG FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') AS SV1 WHERE (SinhVien.MASV = SV1.MASV) AND (SV1.SOPHONG LIKE '%" + sophong + "%') AND (SinhVien.MASV LIKE '%" + SV.MaSV + "%') AND (TENSV LIKE N'%" + SV.TenSV + "%') AND (GIOITINH LIKE N'%" + SV.GioiTinh + "%') AND (QUEQUAN LIKE N'%" + SV.QueQuan + "%') AND (CMT LIKE '%" + cmt + "%') AND (SDT LIKE '%" + SV.SoDT + "%') AND (CHINHSACH LIKE N'%" + SV.ChinhSach + "%') AND (NGAYSINH LIKE '" + ns + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongSV()
        {
            string query = "SELECT COUNT(MASV) FROM SinhVien";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongSvDangO()
        {
            string query = "SELECT COUNT(MAHD) FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongSvChuaNopTien(string kythu)
        {
            string query = "SELECT COUNT(SinhVien.MASV) FROM SinhVien, (SELECT SV1.MASV FROM (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') AS SV1 WHERE SV1.MASV not in (SELECT MASV FROM HoaDonTienPhong WHERE KYTHU = N'" + kythu + "')) AS SV2 WHERE SinhVien.MASV = SV2.MASV";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongSv(string gioitinh)
        {
            string query = "SELECT COUNT(MASV) FROM SinhVien WHERE (GIOITINH LIKE N'%" + gioitinh + "%') AND MASV IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TinhNhieuSvNhat()
        {
            string query = "SELECT TOP 1 QUEQUAN FROM SinhVien WHERE MASV IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') group by QUEQUAN order by COUNT(MASV) desc";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySVDangO()
        {
            string query = "SELECT * FROM SinhVien WHERE MASV IN (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable LaySVChuaNopTien(string kythu)
        {
            string query = "SELECT SinhVien.MASV, SinhVien.TENSV, SinhVien.NGAYSINH, SinhVien.GIOITINH, SinhVien.QUEQUAN, SinhVien.CMT, SinhVien.SDT, SinhVien.CHINHSACH FROM SinhVien, (SELECT SV1.MASV FROM (SELECT MASV FROM HopDong WHERE NGAYHETHAN > '" + DateTime.Today + "') AS SV1 WHERE SV1.MASV not in (SELECT MASV FROM HoaDonTienPhong WHERE KYTHU = N'" + kythu + "')) AS SV2 WHERE SinhVien.MASV = SV2.MASV";
            return Connec.LayDuLieu(query);
        }
    }
}
