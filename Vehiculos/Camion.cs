using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        //atributos
        protected float tara;

        public float GetTara() { return tara; }

        //constructores
        public Camion(string patente, byte cantRuedas, Emarcas marca, float tara)
            : base(patente, cantRuedas, marca, Evehiculos.Camion)
        {
            this.tara = tara;
        }

        //metodos
        public string MostrarCamion()
        {
            return base.Mostrar() + $"\nTara: {this.tara}kg";
        }
    }
}
