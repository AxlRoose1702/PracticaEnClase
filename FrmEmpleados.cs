using System.Data;
using System.Windows.Forms;

namespace PracticaEnClase
{
    public partial class FrmEmpleados : Form
    {
        
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void MtdConsultar()
        {
            DataTable DtEmpleados = ;
            dgvEmpleados.DataSource = DtEmpleados;
        }

        private void FrmEmpleados_Load(object sender, System.EventArgs e)
        {
            MtdConsultar();
        }
    }
}
