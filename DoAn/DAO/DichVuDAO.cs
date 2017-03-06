using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DichVuDAO
    {
        DBConnection Connec = new DBConnection();

        public DataTable LayDuLieu()
        {
            string query = "SELECT MADV, GIA FROM DichVu";
            return Connec.LayDuLieu(query);
        }

        public bool CapNhatDV(DichVu DV)
        {
            string query = "UPDATE DichVu SET GIA = " + DV.Gia + " WHERE MADV = '" + DV.MaDV + "'";
            return Connec.ThucThi(query);
        }
    }
}
