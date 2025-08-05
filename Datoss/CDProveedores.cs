using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Datoss
{
    public class CDProveedores
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable ConsultarEmpleados()
        {
            string Query = "select * from tbl_proveedores";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(Query, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
    }
}
