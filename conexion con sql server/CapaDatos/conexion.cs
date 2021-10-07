using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CapaDatos
{
    public class conexion
    {
        
        //public SqlConnection cnx = new SqlConnection("Data Source=10.1.1.100;Initial Catalog=ejemplo1;User ID=sa;Password=probando1;MultipleActiveResultSets=True;Connect Timeout=100;Encrypt=False;Current Language=spanish");
        public SqlConnection cnx = new SqlConnection("Data Source=10.1.1.100;Initial Catalog=ejemplo1C#;User ID=DESKTOP-FD26CHR;Password=;MultipleActiveResultSets=True;Connect Timeout=100;Encrypt=False;Current Language=spanish");
        public void abrir()
        {

            try
            {

                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void cerrar()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
    }
}
