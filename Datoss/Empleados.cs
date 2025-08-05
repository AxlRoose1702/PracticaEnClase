using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Empleados
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable ConsultarEmpleados()
        {
            string Query = "select * from tbl_empleado";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(Query, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void AgregarEmpleado(string nombre, int dpi, string direccion, DateTime fechaingreso, float salarioBase, string tipoEmpleado, string Estado)
        {
            string QueryAgregar = "Insert into tbl_empleado (nombre, dpi, direccion, fechaIngreso, salariobase, tipoempleado, estado) values (@nombre, @dpi, @direccion, @fechaIngreso, @salariobase, @tipoempleado, @estado)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@dpi", dpi);
            cmd.Parameters.AddWithValue("@direccion", direccion);
            cmd.Parameters.AddWithValue("@fechaIngreso", fechaingreso);
            cmd.Parameters.AddWithValue("@salariobase", salarioBase);
            cmd.Parameters.AddWithValue("@tipoempleado", tipoEmpleado);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
