using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CDClientes
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable ConsultarClientes()
        {
            string Query = "select * from tbl_clientes";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(Query, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
    }
}
