using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Datoss
{
    internal class CDClientes
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable ConsultarEmpleados()
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
