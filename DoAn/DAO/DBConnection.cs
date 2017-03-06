using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    class DBConnection
    {
        //private static string strConn = @"Data Source =.;Initial Catalog = Kytucxa;Integrated Security=True";
        private static string strConn = @"Data Source=DESKTOP-UDR53ET\SQLEXPRESS;Initial Catalog=Kytucxa;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(strConn);
        private static SqlDataAdapter da;
        
        private static DataTable dt;

        public void KetNoi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void NgatKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable LayDuLieu(string query)
        {
            try
            {
                da = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        

        public int SoLuongBanGhiTonTai(string query)
        {
            try
            {
                KetNoi();
                da = new SqlDataAdapter(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                int tongsobanghi = dt.Rows.Count;
                return tongsobanghi;
            }
            catch
            {
                return -1;
            }
            finally
            {
                NgatKetNoi();
            }
        }

        public bool ThucThi(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlTransaction transaction;
            transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                NgatKetNoi();
                cmd.Dispose();
                transaction.Dispose();
            }
            return true;
        }
    }
}
