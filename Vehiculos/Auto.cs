using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        //atributos
        protected int cantAsientos;

        public int GetCantAsientos()
        {
            return cantAsientos;
        }

        //constructor
        public Auto(string patente, byte cantRuedas, Emarcas marca, int cantAsientos) 
            : base(patente, cantRuedas, marca, Evehiculos.Auto)
        {
            this.cantAsientos = cantAsientos;
        }

        //metodos
        public string MostrarAuto()
        {
            return base.Mostrar() + $"\nCantidad de asientos: {this.cantAsientos}";
        }

    }
}
