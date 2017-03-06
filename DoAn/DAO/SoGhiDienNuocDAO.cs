using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class SoGhiDienNuocDAO
    {
        DBConnection Connec = new DBConnection();
        public DataTable LaySoGhi()
        {
            string query = "SELECT * FROM SoGhiDienNuoc";
            return Connec.LayDuLieu(query);
        }

        public bool ThemSoGhi(SoGhiDienNuoc SGDN)
        {
            string query = "INSERT INTO SoGhiDienNuoc VALUES(" + SGDN.Id + ",'" + SGDN.Thang + "'," + SGDN.SoPhong + "," + SGDN.SoDien + "," + SGDN.SoNuoc + ")";
            return Connec.ThucThi(query);
        }

        public bool SuaSoGhi(SoGhiDienNuoc SG)
        {
            string query = "UPDATE SoGhiDienNuoc SET THANG ='" + SG.Thang + "', SOPHONG = " + SG.SoPhong + ", SODIEN = " + SG.SoDien + ", SONUOC = " + SG.SoNuoc + " WHERE ID = " + SG.Id;
            return Connec.ThucThi(query);
        }

        public bool XoaSoGhi(int id)
        {
            string query = "DELETE FROM SoGhiDienNuoc WHERE ID = "+id;
            return Connec.ThucThi(query);
        }

        public DataTable LayPhongChuaGhi(string thang)
        {
            string query = "SELECT Phong.SOPHONG FROM Phong WHERE (SOPHONG NOT IN (SELECT SoGhiDienNuoc.SOPHONG FROM SoGhiDienNuoc WHERE THANG = '" + thang + "')) AND (SOSVHT > 0)";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayPhongChuaGhiSua(string thang, int sophong)
        {
            string query = "SELECT Phong.SOPHONG FROM Phong WHERE (SOPHONG NOT IN (SELECT SOPHONG FROM SoGhiDienNuoc WHERE (THANG = '" + thang + "') )) AND (SOSVHT > 0) OR (SOPHONG = " + sophong + ")";
            return Connec.LayDuLieu(query);
        }

        public DataTable LayChiSoDienNuocCu(int sophong)
        {
            string query = "SELECT TOP 1 SODIEN, SONUOC FROM SoGhiDienNuoc WHERE SOPHONG = " + sophong + " ORDER BY ID DESC ";
            return Connec.LayDuLieu(query);
        }

        public DataTable TKSoGhi(string id, string thang, string sophong)
        {
            string query = "SELECT * FROM SoGhiDienNuoc WHERE (ID LIKE '%" + id + "%') AND (THANG LIKE '%" + thang + "%') AND (SOPHONG LIKE '%" + sophong + "%')";
            return Connec.LayDuLieu(query);
        }

    }
}
