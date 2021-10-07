using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    public class Class1
    {
        SqlConnection cnx = new SqlConnection("server=DIEGO-PC ; database=base1 ; integrated security = true");
        void abrir()
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
        void cerrar()
        {
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
        }
    }
}
}
