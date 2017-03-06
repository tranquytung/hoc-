using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BLL
{
    public class DichVuBLL
    {
        DichVuDAO DVDAO = new DichVuDAO();
        public DataTable LayDuLieu()
        {
            return DVDAO.LayDuLieu();
        }
        public bool CapNhatDV(DichVu DV)
        {
            return DVDAO.CapNhatDV(DV);
        }
    }
}
