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
    public class SinhVienBLL
    {
        SinhVienDAO SVDAO = new SinhVienDAO();
        public DataTable LayDuLieu()
        {
            return SVDAO.LayDuLieu();
        }

        public void LoadCb(ComboBox tencb, string tencot)
        {
            tencb.DataSource = SVDAO.LoadCb(tencot);
            tencb.ValueMember = tencot;
            tencb.DisplayMember = tencot;
        }


        public bool KiemTraTrung(DataTable dt, string tencot, string str)
        {
            dt.PrimaryKey = new DataColumn[] { dt.Columns[tencot] };
            DataRow r = dt.Rows.Find(str);
            if (r != null)
            {
                return true;
            }
            else return false;
        }

        public bool ThemSV(SinhVien SV)
        {
            return SVDAO.ThemSV(SV);
        }

        public bool SuaSV(SinhVien SV)
        {
            return SVDAO.SuaSV(SV);
        }

        public bool XoaSV(string masv)
        {
            return SVDAO.XoaSV(masv);
        }

        public DataTable TKSinhVienAll(SinhVien SV, string ns, string cmt)
        {
            return SVDAO.TKSinhVienAll(SV, ns, cmt);
        }

        public DataTable TKSinhVienKhongO(SinhVien SV, string ns, string cmt)
        {
            return SVDAO.TKSinhVienKhongO(SV, ns, cmt);
        }

        public DataTable TKSinhVienDangO(SinhVien SV, string ns,string cmt, string sophong)
        {
            return SVDAO.TKSinhVienDangO(SV, ns, cmt, sophong);
        }

        public DataTable TongSV()
        {
            return SVDAO.TongSV();
        }

        public DataTable TongSvDangO()
        {
            return SVDAO.TongSvDangO();
        }

        public DataTable TongSvChuaNopTien(string kythu)
        {
            return SVDAO.TongSvChuaNopTien(kythu);
        }

        public DataTable TongSv(string gioitinh)
        {
            return SVDAO.TongSv(gioitinh);
        }

        public DataTable TinhNhieuSvNhat()
        {
            return SVDAO.TinhNhieuSvNhat();
        }

        public DataTable LaySVDangO()
        {
            return SVDAO.LaySVDangO();
        }

        public DataTable LaySVChuaNopTien(string kythu)
        {
            return SVDAO.LaySVChuaNopTien(kythu);
        }
    }
}

