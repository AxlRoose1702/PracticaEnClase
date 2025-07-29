using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Empleados
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable MtdConsultarProveedores()
        {
            string Query = "sp_ObtenerEmpleados";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(Query, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
    }
}
