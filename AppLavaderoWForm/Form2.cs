using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehiculos;

namespace AppLavaderoWForm
{
    public partial class FrmIngreso : Form
    {
        private FrmLavadero formularioPrincipal;
        public FrmIngreso(FrmLavadero principal)
        {
            InitializeComponent();
            formularioPrincipal = principal;
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAsientos.Enabled = false;
            txtCilindrada.Enabled = false;
            txtTara.Enabled = false;
            switch (cmbVehiculo.SelectedItem.ToString())
            {
                case "Auto":
                    txtAsientos.Enabled = true;
                    break;
                case "Camion":
                    txtTara.Enabled = true;
                    break;
                case "Moto":
                    txtCilindrada.Enabled = true;
                    break;
            }
        }

        private void btnIngresarVehiculo_Click(object sender, EventArgs e)
        {
            // Obtener el tipo de vehículo seleccionado en el ComboBox
            string tipoStr = this.cmbVehiculo.SelectedItem.ToString();
            Evehiculos tipo;
            // Intentar convertir el tipo seleccionado a un valor enum Evehiculos
            if (Enum.TryParse(tipoStr, out tipo))
            {
                // Obtener la marca seleccionada en el ComboBox
                string marcaStr = this.cmbMarcas.SelectedItem.ToString();
                Emarcas marca;

                // Intentar convertir la marca seleccionada a un valor enum Emarcas
                if (Enum.TryParse(marcaStr, out marca))
                {
                    // Obtener otros datos como la patente y la cantidad de ruedas
                    string patente = this.txtPatente.Text;
                    byte cantRuedas = byte.Parse(txtCantRuedas.Text);

                    // Crear una instancia de Vehiculo con los datos obtenidos
                    Vehiculo vehiculo = new Vehiculo(patente, cantRuedas, marca, tipo);
                    formularioPrincipal.vehiculosIngresados.Add(vehiculo);
                    MessageBox.Show("Vehículo ingresado con éxito.");
                    this.Close();

                    // Hacer algo con la instancia del vehículo, por ejemplo, almacenarla o mostrarla
                    // Aquí deberías tener la lógica para manejar el objeto "vehiculo" creado.
                }
                else
                {
                    MessageBox.Show("La marca seleccionada no es válida.");
                }
            }
            else
            {
                MessageBox.Show("El tipo de vehículo seleccionado no es válido.");
            }
        }


        private void FrmIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}
