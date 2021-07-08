using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
    public class Conexion
    {
        public static String SQLServer()
        {
            
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            
            builder.DataSource = @"DESKTOP-V4S0B1K";
            //builder.UserID
            //builder.Password
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "SanMarcos";
            return builder.ToString();
        }

        
        public static string conexion = @"Data source=DESKTOP-V4S0B1K; Initial Catalog=SanMarcos; Integrated Security=True";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
