namespace Logica
{
    public class CL_Empleado
    {
        public decimal SalarioBase(string tipoEmpleado) {
            if (tipoEmpleado == "Gerente") return 2000;
            if (tipoEmpleado == "Presidente") return 10000;
            if (tipoEmpleado == "Sub-gerente") return 1000;

            return 0;
        }
    }
}
