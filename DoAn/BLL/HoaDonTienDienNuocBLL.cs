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
    public class HoaDonTienDienNuocBLL
    {
        HoaDonTienDienNuocDAO HDTDNDAO = new HoaDonTienDienNuocDAO();

        public DataTable LayHoaDon()
        {
            return HDTDNDAO.LayHoaDon();
        }

        public DataTable LayPhongChuaCoHoaDon(string thang)
        {
            return HDTDNDAO.LayPhongChuaCoHoaDon(thang);
        }

        public DataTable LayPhongChuaCoHoaDonSua(string thang, int sophong)
        {
            return HDTDNDAO.LayPhongChuaCoHoaDonSua(thang, sophong);
        }

        public DataTable LaySinhVienTrongPhong(int sophong)
        {
            return HDTDNDAO.LaySinhVienTrongPhong(sophong);
        }

        public DataTable LayTenNV(string manv)
        {
            return HDTDNDAO.LayTenNV(manv);
        }

        public void LoadCB(ComboBox tencb, DataTable dt, string value, string display)
        {
            
            tencb.DataSource = dt;
            tencb.ValueMember = value;
            tencb.DisplayMember = display;
        }

        public int LayTongTien(int sophong)
        {
            DataTable dt = new DataTable();
            dt = HDTDNDAO.LayChiSoDienNuocMoiCu(sophong);
            int tongtien = 0;
            int giadien = int.Parse(HDTDNDAO.LayGiaDien().Rows[0][0].ToString());
            int gianuoc = int.Parse(HDTDNDAO.LayGiaNuoc().Rows[0][0].ToString());
            int sodienmoi = int.Parse(dt.Rows[0][0].ToString());
            int sonuocmoi = int.Parse(dt.Rows[0][1].ToString());
            int sodiencu = 0; int sonuoccu = 0;
            if (dt.Rows.Count > 1)
            {
                sodiencu = int.Parse(dt.Rows[1][0].ToString());
                sonuoccu = int.Parse(dt.Rows[1][1].ToString());
            }
            tongtien = (sodienmoi - sodiencu) * giadien + (sonuocmoi - sonuoccu) * gianuoc;
            return tongtien;
        }

        public string TaoMaHoaDonMoi(string mahdcu)
        {
            string MaHD = mahdcu;
            string strstt = "";

            int STT = int.Parse(MaHD.Substring(5).ToString()) + 1;
            if (STT < 10)
            {
                strstt = "00000" + STT;
            }
            else if (STT < 100)
            {
                strstt = "0000" + STT;
            }
            else if (STT < 1000)
            {
                strstt = "000" + STT;
            }
            else if (STT < 10000)
            {
                strstt = "00" + STT;
            }
            else if (STT < 100000)
            {
                strstt = "0" + STT;
            }
            return "HDTDN" + strstt;
        }

        public void LoadCBThang(ComboBox tencb)
        {
            if (tencb.Items.Count == 0)
            {
                int thang1 = DateTime.Today.Month;
                int nam1 = DateTime.Today.Year;
                int thang2 = thang1;
                int nam2 = nam1;
                if (thang1 == 1)
                {
                    thang2 = 12; nam2 = nam2 - 1;
                }
                else thang2 = thang2 - 1;
                tencb.Items.Add(thang1 + "/" + nam1);
                tencb.Items.Add(thang2 + "/" + nam2);
            }
            tencb.SelectedIndex = 0;
        }
        public bool ThemHoaDon(HoaDonTienDienNuoc HD)
        {
            return HDTDNDAO.ThemHoaDon(HD);
        }

        public bool SuaHoaDon(HoaDonTienDienNuoc HD)
        {
            return HDTDNDAO.SuaHoaDon(HD);
        }

        public bool XoaHoaDon(string mahd)
        {
            return HDTDNDAO.XoaHoaDon(mahd);
        }

        public DataTable TKHoaDonTDN(string mahd, string thang, string sophong, string masv, string tennv, string nltu, string nlden)
        {
            return HDTDNDAO.TKHoaDonTDN(mahd, thang, sophong, masv, tennv, nltu, nlden);
        }

        public DataTable TongTienDNDaTra(string thang, string nam)
        {
            return HDTDNDAO.TongTienDNDaTra(thang, nam);
        }

        public int TongTienDNChuaTra(string thang, string nam)
        {
            DataTable dt = new DataTable();
            
            dt = LayPhongChuaCoHoaDon(thang + "/" + nam);
            int tongtien = 0;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tongtien = tongtien + LayTongTien(int.Parse(dt.Rows[i][0].ToString()));
                }
            }
            return tongtien;
        }

        public DataTable TongTienDNDaTraTheoKy(string ky, string nam)
        {
            return HDTDNDAO.TongTienDNDaTraTheoKy(ky, nam);
        }

        public int TongTienDNChuaTraTheoKy(string ky, string nam)
        {
            int tongtien = 0;
            DataTable dt = new DataTable();
          
            if (ky == "%")
            {
                dt = LayPhongChuaCoHoaDon(ky + "/" + nam);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tongtien = tongtien + LayTongTien(int.Parse(dt.Rows[i][0].ToString()));
                    }
                }
            }
            else if (ky == "Kỳ 1")
            {
                for (int j = 1; j < 7; ++j)
                {
                    dt = LayPhongChuaCoHoaDon(j + "/" + nam);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tongtien = tongtien + LayTongTien(int.Parse(dt.Rows[i][0].ToString()));
                        }
                    }
                }
            }
            else if (ky == "Kỳ 2")
            {
                for (int j = 7; j <= 12; j++)
                {
                    dt = LayPhongChuaCoHoaDon(j + "/" + nam);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tongtien = tongtien + LayTongTien(int.Parse(dt.Rows[i][0].ToString()));
                        }
                    }
                }
            }
            return tongtien;
        }

        public DataTable LayDanhSachNam()
        {
            return HDTDNDAO.LayDanhSachNam();
        }

        public int KiemTraThang(string thang)
        {
            return HDTDNDAO.KiemTraThang(thang);
        }
    }
}
