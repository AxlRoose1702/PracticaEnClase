using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos
{
    internal class CDConexion
    {
        private SqlConnection db_conexion = new SqlConnection("Server=tcp:servidorprogramacion2.database.windows.net,1433;Initial Catalog=db_TelcoIngeUmg;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";");

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
