using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Windows.Forms;
using System.Data;
namespace BLL
{
    public class SoGhiDienNuocBLL
    {
        SoGhiDienNuocDAO SGDNDAO = new SoGhiDienNuocDAO();
        public DataTable LaySoGhi()
        {
            return SGDNDAO.LaySoGhi();
        }

        public bool ThemSoGhi(SoGhiDienNuoc SGDN)
        {
            return SGDNDAO.ThemSoGhi(SGDN);
        }

        public bool SuaSoGhi(SoGhiDienNuoc SG)
        {
            return SGDNDAO.SuaSoGhi(SG);
        }

        public bool XoaSoGhi(int id)
        {
            return SGDNDAO.XoaSoGhi(id);
        }

        public DataTable LayPhongChuaGhi(string thang)
        {
            return SGDNDAO.LayPhongChuaGhi(thang);
        }

        public DataTable LayPhongChuaGhiSua(string thang, int sophong)
        {
            return SGDNDAO.LayPhongChuaGhiSua(thang, sophong);
        }

        public int TaoIDMoi(int idcu)
        {
            return idcu + 1;
        }

        public string LayThang()
        {
            int m = DateTime.Today.Month;
            int y = DateTime.Today.Year;
            return m + "/" + y;
        }

        public void LoadCB(ComboBox tencb, DataTable dt, string value, string display)
        {
            tencb.DataSource = dt;
            tencb.ValueMember = value;
            tencb.DisplayMember = display;
        }

        public DataTable LayChiSoDienNuocCu(int sophong)
        {
            return SGDNDAO.LayChiSoDienNuocCu(sophong);
        }

        public DataTable TKSoGhi(string id, string thang, string sophong)
        {
            return SGDNDAO.TKSoGhi(id, thang, sophong);
        }
    }
}
