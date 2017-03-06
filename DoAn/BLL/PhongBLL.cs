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
    public class PhongBLL
    {
        PhongDAO PDAO = new PhongDAO();

        public DataTable LayDuLieu()
        {
            return PDAO.LayDuLieu();
        }

        public void LoadCB(ComboBox tencb, string tencot, string tenbang)
        {
            tencb.DataSource = PDAO.LoadCB(tencot, tenbang);
            tencb.ValueMember = tencot;
            tencb.DisplayMember = tencot;
        }
        public void LoadCBTrangThai(ComboBox tencb)
        {
            tencb.Items.Add("Hoạt động");
            tencb.Items.Add("Bảo trì");
        }

        public int KiemTraMaTrung(int sophong)
        {
            return PDAO.KiemTraMaTrung(sophong);
        }

        public bool ThemPhong(Phong P)
        {
            return PDAO.ThemPhong(P);
        }

        public bool SuaPhong(Phong P)
        {
            return PDAO.SuaPhong(P);
        }

        public bool XoaPhong(int sophong)
        {
            return PDAO.XoaPhong(sophong);
        }

        public DataTable TKPhongAll(string sophong, string succhua, string ssvht, string maday, string trangthai, string tennv, string loaiphong)
        {
            return PDAO.TKPhongAll(sophong, succhua, ssvht, maday, trangthai, tennv, loaiphong);
        }

        public DataTable TKPhongSV(string sophong, string succhua, string ssvht, string maday, string trangthai, string tennv, string loaiphong, string masv)
        {
            return PDAO.TKPhongSV(sophong, succhua, ssvht, maday, trangthai, tennv, loaiphong, masv);
        }

        public DataTable TongPhong()
        {
            return PDAO.TongPhong();
        }

        public DataTable TongPhongTheoGT(string gt)
        {
            return PDAO.TongPhongTheoGT(gt);
        }

        public DataTable TongPhongHoatDong()
        {
            return PDAO.TongPhongHoatDong();
        }

        public DataTable TongPhongBaoTri()
        {
            return PDAO.TongPhongBaoTri();
        }

        public DataTable TongPhongConTrong()
        {
            return PDAO.TongPhongConTrong();
        }

        public DataTable TongPhongDaDay()
        {
            return PDAO.TongPhongDaDay();
        }

        public DataTable TongPhongChuaNopTienDien()
        {
            return PDAO.TongPhongChuaNopTienDien();
        }

        public DataTable TongSVCoTheThem()
        {
            return PDAO.TongSVCoTheThem();
        }

        public DataTable DanhSachPConTrong()
        {
            return PDAO.DanhSachPConTrong();
        }

        public DataTable DanhSachPDaDay()
        {
            return PDAO.DanhSachPDaDay();
        }

        public DataTable DanhSachPKhongCoSVO()
        {
            return PDAO.DanhSachPKhongCoSVO();
        }

        public DataTable DanhSachPDangHD()
        {
            return PDAO.DanhSachPDangHD();
        }

        public DataTable DanhSachPDangBT()
        {
            return PDAO.DanhSachPDangBT();
        }

        public DataTable DanhSachPChuaNopTien()
        {
            return PDAO.DanhSachPChuaNopTien();
        }
    }
}
