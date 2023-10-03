using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        //atributos
        protected float cilindrada;

        public float GetCilindrada() { return cilindrada; }

        //constructor
        public Moto(string patente, byte cantRuedas, Emarcas marca, float cilindrada)
            : base(patente, cantRuedas, marca, Evehiculos.Moto)
        {
            this.cilindrada = cilindrada;
        }

        //metodos
        public string MostrarMoto()
        {
            return base.Mostrar() + $"\nCilindrada: {this.cilindrada}cc";
        }
    }
}
