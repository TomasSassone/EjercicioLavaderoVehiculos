using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Lavadero
    {
        //atributos
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        private string detalle;

        //constructores
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        //propiedades
        public string _detalle //reutiliazr codigo
        { 
            get
            {
                return ObtenerDetalles();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        //metodos

        private string ObtenerDetalles()
        {
            StringBuilder detalles = new StringBuilder("---------------------------------------------------------------------\n");
            detalles.AppendLine("--- PRECIOS VIGENTES ---");
            detalles.AppendLine($"AUTOS: ${precioAuto}");
            detalles.AppendLine($"CAMIONES: ${precioCamion}");
            detalles.AppendLine($"MOTOS: ${precioMoto}");
            detalles.AppendLine("");
            detalles.AppendLine("--- VEHÍCULOS INGRESADOS ---");
            detalles.AppendLine("---------------------");
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo is Auto)
                {
                    Auto auto = (Auto)vehiculo; // Realizar una conversión explícita a Auto
                    detalles.AppendLine(auto.MostrarAuto());
                }
                else if (vehiculo is Moto)
                {
                    Moto moto = (Moto)vehiculo; // Realizar una conversión explícita a Moto
                    detalles.AppendLine(moto.MostrarMoto());
                }
                else if (vehiculo is Camion)
                {
                    Camion camion = (Camion)vehiculo; // Realizar una conversión explícita a Camion
                    detalles.AppendLine(camion.MostrarCamion());
                }
                detalles.AppendLine("---------------------");
            }
            detalles.AppendLine("---------------------------------------------------------------------");
            return detalles.ToString();
        }

        public double MostrarTotalFacturado()
        {
            double total = 0;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                total += ObtenerPrecioPorTipo(vehiculo.tipo);
            }
            return total;
        }


        public double MostrarTotalFacturado(Evehiculos vehiculoListado)
        {
            double totalEspecificoVehiculo = 0;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.tipo == vehiculoListado)
                {
                    switch (vehiculo.tipo)
                    {
                        case Evehiculos.Auto:
                            totalEspecificoVehiculo += precioAuto;
                            break;
                        case Evehiculos.Moto:
                            totalEspecificoVehiculo += precioMoto;
                            break;
                        case Evehiculos.Camion:
                            totalEspecificoVehiculo += precioCamion;
                            break;
                    }
                }
            }
            return totalEspecificoVehiculo;
        }

        private float ObtenerPrecioPorTipo(Evehiculos tipo)
        {
            switch (tipo)
            {
                case Evehiculos.Auto:
                    return precioAuto;
                case Evehiculos.Camion:
                    return precioCamion;
                case Evehiculos.Moto:
                    return precioMoto;
                default:
                    return 0; // Manejar caso desconocido o error
            }
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int resultado = v1.Patente.CompareTo(v2.Patente);
            if (resultado < 0)
            {
                return -1;
            }
            else if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            int resultado = v1.Marcas.CompareTo(v2.Marcas);
            if (resultado < 0)
            {
                return -1;
            }
            else if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        //operadores
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            return lavadero.vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
            }
            return lavadero;
        }


        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }
    }
}
