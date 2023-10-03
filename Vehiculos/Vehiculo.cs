namespace Vehiculos
{
    public class Vehiculo
    {
        //atributos
        protected string patente;
        protected byte cantRuedas;
        protected Emarcas marca;
        public Evehiculos tipo;

        //props
        public string Patente { get { return this.patente; } }

        public Emarcas Marcas
        { get { return this.marca; } }

        //constructor
        public Vehiculo(string patente, byte cantRuedas, Emarcas marca, Evehiculos tipo)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
            this.tipo = tipo;
        }

        //metodos
        protected string Mostrar()
        {
            return $"Patente: {this.patente}\nCantidad de ruedas: {this.cantRuedas}\nMarca: {this.marca}";
        }

        //sobrecarga operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.patente == v2.patente) && (v1.marca == v2.marca); 
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

    }
}