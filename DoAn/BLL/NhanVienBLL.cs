using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Windows.Forms;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAO NVDAO = new NhanVienDAO();
        public DataTable LayDuLieu()
        {
            return NVDAO.LayDuLieu();
        }

        public string TaoMaNVMoi()
        {
            string MaNV = "";
            string strstt = "";
            MaNV = NVDAO.LayMaNVCuoi() != null ? NVDAO.LayMaNVCuoi().Rows[0][0].ToString(): "NV000";
            int STT = int.Parse(MaNV.Substring(2).ToString()) + 1;
            if (STT < 10)
            {
                strstt = "00" + STT;
            }
            else if(STT < 100){
                strstt = "0" + STT;
            }
            return "NV" + strstt;
        }

        public void LoadCB(ComboBox tencb, string tencot)
        {
            tencb.DataSource = NVDAO.LoadCB(tencot);
            tencb.DisplayMember = tencot;
            tencb.ValueMember = tencot;
        }

        public bool ThemNV(NhanVien NV)
        {
            return NVDAO.ThemNV(NV);
        }
        public bool SuaNV(NhanVien NV)
        {
            return NVDAO.SuaNV(NV);
        }
        public bool XoaNV(string manv)
        {
            return NVDAO.XoaNV(manv);
        }
        DayPhongDAO DPDAO = new DayPhongDAO();

        public bool KiemTraNhanVienQuanLyDay(string manv)
        {
            if (DPDAO.KiemTraNVTheoMaNV(manv) == 0)
            {
                return false;
            }
            return true;
        }

        public DataTable TKNhanVienAll(NhanVien NV, string ns, string cmt)
        {
            return NVDAO.TKNhanVienAll(NV, ns, cmt);
        }

        public DataTable TongNV()
        {
            return NVDAO.TongNV();
        }

        public DataTable TongNvDangLam()
        {
            return NVDAO.TongNvDangLam();
        }

        public DataTable TongNVTheoGT(string gt)
        {
            return NVDAO.TongNVTheoGT(gt);
        }

        public DataTable TinhNhieuNVNhat()
        {
            return NVDAO.TinhNhieuNVNhat();
        }

        public DataTable TuoiTB()
        {
            return NVDAO.TuoiTB();
        }

        public DataTable NhanVienDangLam()
        {
            return NVDAO.NhanVienDangLam();
        }

        public DataTable NhanVienDaNghi()
        {
            return NVDAO.NhanVienDaNghi();
        }
    }
}
