using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    internal class CDConexion
    {
        //private SqlConnection db_conexion = new SqlConnection("Server=tcp:servidorprogramacion2.database.windows.net,1433;Initial Catalog=db_TelcoIngeUmg;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");
        private SqlConnection db_conexion = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=db_TelcoIngeUmg;Integrated Security=True;");

        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
            {
                db_conexion.Open();
            }
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open)
            {
                db_conexion.Close();
            }
            return db_conexion;
        }
    }
}
