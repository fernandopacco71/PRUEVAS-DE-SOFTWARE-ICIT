using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class operaciones
    {
        conexion cn = new conexion();
        public DataTable ListSP(string sp, string periodo, string variable) {
            DataTable dtSP = new DataTable();
            try{
                SqlDataAdapter da = new SqlDataAdapter(sp, cn.cnx);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.Add(periodo, SqlDbType.Int);
                //da.SelectCommand.Parameters[variable].Value =;
                da.Fill(dtSP);
                return dtSP;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
