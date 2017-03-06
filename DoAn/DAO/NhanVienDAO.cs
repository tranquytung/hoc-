using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO
    {
        DBConnection Connec = new DBConnection();

        public DataTable LayDuLieu()
        {
            string query = "SELECT * FROM NhanVien";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayMaNVCuoi()
        {
            string query = "SELECT TOP 1 MANV FROM NhanVien ORDER BY MANV DESC";
            if (Connec.LayDuLieu(query).Rows.Count > 0)
            {
                return Connec.LayDuLieu(query);
            }
            else
            {
                return null;
            }

        }

        public DataTable LoadCB(string tencot)
        {
            string query = "SELECT DISTINCT "+tencot+" FROM NhanVien";
            return Connec.LayDuLieu(query);
        }

        public bool ThemNV(NhanVien NV)
        {
            string query = "INSERT INTO NhanVien VALUES('" + NV.MaNV + "',N'" + NV.TenNV + "','" + NV.NgaySinh + "',N'" + NV.GioiTinh + "',N'" + NV.QueQuan + "','" + NV.SDT + "',N'" + NV.ChucVu + "'," + NV.CMT + ",N'" + NV.TrangThai + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaNV(NhanVien NV)
        {
            string query = "UPDATE NhanVien SET TENNV = N'" + NV.TenNV + "', NGAYSINH = '" + NV.NgaySinh + "', GIOITINH = N'" + NV.GioiTinh + "', QUEQUAN = N'" + NV.QueQuan + "', SDT = '" + NV.SDT + "', CHUCVU = N'" + NV.ChucVu + "', CMT = " + NV.CMT + " ,TRANGTHAI = N'" + NV.TrangThai + "' WHERE MANV = '" + NV.MaNV + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaNV(string manv)
        {
            string query = "DELETE FROM NhanVien WHERE MANV = '" + manv+"'";
            return Connec.ThucThi(query);
        }

        public DataTable TKNhanVienAll(NhanVien NV, string ns, string cmt)
        {
            string query = "SELECT * FROM NhanVien WHERE (MANV LIKE '%" + NV.MaNV + "%') AND (TENNV LIKE N'%" + NV.TenNV + "%') AND (GIOITINH LIKE N'%" + NV.GioiTinh + "%') AND (QUEQUAN LIKE N'%" + NV.QueQuan + "%') AND (CMT LIKE '%" + cmt + "%') AND (SDT LIKE '%" + NV.SDT + "%') AND (CHUCVU LIKE N'%" + NV.ChucVu + "%') AND (TRANGTHAI LIKE N'%"+NV.TrangThai+"%') AND (NGAYSINH LIKE '" + ns + "')";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongNV()
        {
            string query = "SELECT COUNT(MANV) FROM NhanVien";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongNvDangLam()
        {
            string query = "SELECT COUNT(MANV) FROM NhanVien WHERE TRANGTHAI = N'Đang làm'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TongNVTheoGT(string gt)
        {
            string query = "SELECT COUNT(MANV) FROM NhanVien WHERE GIOITINH LIKE N'%"+gt+"%'";
            return Connec.LayDuLieu(query);
        }

        public DataTable TinhNhieuNVNhat()
        {
            string query = "SELECT TOP 1 QUEQUAN FROM NhanVien  group by QUEQUAN order by COUNT(MANV) desc";
            return Connec.LayDuLieu(query);
        }

        public DataTable TuoiTB()
        {
            string query = "select AVG(DATEDIFF(year,NGAYSINH, getdate())) FROM NhanVien";
            return Connec.LayDuLieu(query);
        }

        public DataTable NhanVienDangLam()
        {
            string query = "SELECT * FROM NhanVien WHERE TRANGTHAI = N'Đang làm'";
            return Connec.LayDuLieu(query);
        }

        public DataTable NhanVienDaNghi()
        {
            string query = "SELECT * FROM NhanVien WHERE TRANGTHAI = N'Đã nghỉ việc'";
            return Connec.LayDuLieu(query);
        }
      
    }
}
