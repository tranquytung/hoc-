using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BLL
{
    public class DayPhongBLL
    {
        DayPhongDAO DPDAO = new DayPhongDAO();
        public DataTable LayDuLieu()
        {
            return DPDAO.LayDuLieu();
        }

        public DataTable DanhSachNhanVien(string gioitinh)
        {
            return DPDAO.DanhSachNhanVien(gioitinh);
        }
        public string TaoMoiMaDay()
        {
            string MaDay = "";
            string strstt = "";
            MaDay = DPDAO.LayMaDayCuoi() != null ? DPDAO.LayMaDayCuoi().Rows[0][0].ToString() : "DP00";
            int STT = int.Parse(MaDay.Substring(2).ToString()) + 1;
            if (STT < 10)
            {
                strstt = "0" + STT;
            }
            else if (STT < 100)
            {
                strstt = "" + STT;
            }
            return "DP" + strstt;
        }

        public bool KiemTraNV(string tennv, string gt)
        {
            if (DPDAO.KiemTraNV(tennv, gt) > 0)
            {
                return true;
            }
            return false;
        }


        public bool ThemDayPhong(DayPhong DP)
        {
            return DPDAO.ThemDayPhong(DP);
        }

        public bool SuaDayPhong(DayPhong DP)
        {
            return DPDAO.SuaDayPhong(DP);
        }

        public bool XoaDayPhong(string maday)
        {
            return DPDAO.XoaDayPhong(maday);
        }

        public int SoPhongTrongDay(string maday)
        {
            return DPDAO.SoPhongTrongDay(maday);
        }
    }
}
