using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class TaiKhoanDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable DanhSachNVChuaCoTaiKhoan()
        {
            string query = "SELECT MANV, TENNV, CHUCVU, GIOITINH FROM NhanVien WHERE MANV NOT IN ( SELECT TENDN FROM TaiKhoan ) and TRANGTHAI = N'Đang làm'";
            return Connec.LayDuLieu(query);
        }

        public DataTable DanhSachNVDaCoTaiKhoan()
        {
            string query = "SELECT NhanVien.MANV, NhanVien.TENNV, NhanVien.CHUCVU, TaiKhoan.PHANQUYEN FROM NhanVien, TaiKhoan WHERE NhanVien.MANV = TaiKhoan.TENDN";
            return Connec.LayDuLieu(query);
        }

        public bool ThemTK(TaiKhoan TK)
        {
            string query = "INSERT INTO TaiKhoan VALUES('" + TK.TenDN + "','" + TK.MatKhau + "',N'" + TK.PhanQuyen + "')";
            return Connec.ThucThi(query);
        }

        public bool SuaTK(TaiKhoan TK)
        {
            string query = "UPDATE TaiKhoan SET PHANQUYEN = N'" + TK.PhanQuyen + "' WHERE TENDN = '" + TK.TenDN + "'";
            return Connec.ThucThi(query);
        }

        public bool XoaTK(string tendn)
        {
            string query = "DELETE FROM TaiKhoan WHERE TENDN = '" + tendn + "'";
            return Connec.ThucThi(query);
        }

        public bool ResetMK(TaiKhoan TK)
        {
            string query = "UPDATE TaiKhoan SET MATKHAU = '"+TK.MatKhau+"' WHERE TENDN = '" + TK.TenDN + "'";
            return Connec.ThucThi(query);
        }

        public int KiemTraTenDN(TaiKhoan TK)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TENDN = '" + TK.TenDN + "'";
            return Connec.SoLuongBanGhiTonTai(query);
        }

        public DataTable KiemTraTaiKhoan(TaiKhoan TK)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TENDN = '" + TK.TenDN + "'AND MATKHAU = '" + TK.MatKhau + "'";
            return Connec.LayDuLieu(query);
        }

        public bool ThayDoiMatKhau(TaiKhoan TK, string mkmoi)
        {
            string query = "UPDATE TaiKhoan SET MATKHAU = '" + mkmoi + "' WHERE TENDN = '" + TK.TenDN + "'";
            return Connec.ThucThi(query);
        }
       
    }
}
