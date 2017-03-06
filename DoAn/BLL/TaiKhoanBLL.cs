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
    public class TaiKhoanBLL
    {
        TaiKhoanDAO TKDAO = new TaiKhoanDAO();
        public DataTable DanhSachNVChuaCoTaiKhoan()
        {
            return TKDAO.DanhSachNVChuaCoTaiKhoan();
        }

        public DataTable DanhSachNVDaCoTaiKhoan()
        {
            return TKDAO.DanhSachNVDaCoTaiKhoan();
        }

        public void LoadCB(ComboBox tencb)
        {
            tencb.Items.Add("Quản Lý");
            tencb.Items.Add("Nhân Viên");
        }

        public bool ThemTK(TaiKhoan TK)
        {
            TK.MatKhau = Utility.md5(TK.MatKhau);
            return TKDAO.ThemTK(TK);
        }

        public bool SuaTK(TaiKhoan TK)
        {
            return TKDAO.SuaTK(TK);
        }

        public bool XoaTK(string tendn)
        {
            return TKDAO.XoaTK(tendn);
        }

        public bool ResetMK(TaiKhoan TK)
        {
            TK.MatKhau = Utility.md5(TK.MatKhau);
            return TKDAO.ResetMK(TK);
        }

        public int KiemTraTenDN(TaiKhoan TK)
        {
            return TKDAO.KiemTraTenDN(TK);
        }

        public DataTable KiemTraTaiKhoan(TaiKhoan TK)
        {
            //TK.MatKhau = Utility.md5(TK.MatKhau);
            return TKDAO.KiemTraTaiKhoan(TK);
        }

        public bool ThayDoiMatKhau(TaiKhoan TK, string mkmoi)
        {
            mkmoi = Utility.md5(mkmoi);
            return TKDAO.ThayDoiMatKhau(TK, mkmoi);
        }
    }
}
