using Vehiculos;

namespace AppLavaderoWForm
{
    public partial class FrmLavadero : Form
    {
        public List<Vehiculo> vehiculosIngresados = new List<Vehiculo>();
        public FrmLavadero()
        {
            InitializeComponent();
        }

        private void FrmLavadero_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmIngreso frmIngreso = new FrmIngreso(this);
            frmIngreso.Show();

        }

        private void BtnVerIngresados_Click(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }

        private void ActualizarVisor()
        {
            lstVisor.Items.Clear();

            foreach (Vehiculo vehiculo in vehiculosIngresados)
            {
                lstVisor.Items.Add($"{vehiculo.tipo} - {vehiculo.Marcas} - Patente '{vehiculo.Patente}'");
            }
        }
    }
}