using Vehiculos;
namespace AppLavaderoConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Lavadero miLavadero = new Lavadero(500f, 900f, 350f); // Precios de vehículos

                // Agregar vehículos al lavadero
                Auto auto1 = new Auto("ABC123", 4, Emarcas.Honda, 5);
                Auto auto2 = new Auto("AGC150", 4, Emarcas.Ford, 5);
                Camion camion1 = new Camion("XYZ789", 6, Emarcas.Scania, 8000.0f);
                Moto moto1 = new Moto("DEF456", 2, Emarcas.Zanella, 150.0f);

                miLavadero += auto1;
                miLavadero += auto2;
                miLavadero += camion1;
                miLavadero += moto1;

                Console.WriteLine(camion1.tipo);

                // Mostrar detalles del lavadero
                Console.WriteLine("Detalles del Lavadero:");
                Console.WriteLine(miLavadero._detalle);

                // Mostrar ganancia total del lavadero
                double gananciaTotal = miLavadero.MostrarTotalFacturado();
                Console.WriteLine($"Ganancia total del lavadero: ${gananciaTotal}");

                // Mostrar ganancia por tipo de vehículo
                double gananciaAutos = miLavadero.MostrarTotalFacturado(Evehiculos.Auto);
                double gananciaCamiones = miLavadero.MostrarTotalFacturado(Evehiculos.Camion);
                double gananciaMotos = miLavadero.MostrarTotalFacturado(Evehiculos.Moto);

                Console.WriteLine($"Ganancia por Autos: ${gananciaAutos}");
                Console.WriteLine($"Ganancia por Camiones: ${gananciaCamiones}");
                Console.WriteLine($"Ganancia por Motos: ${gananciaMotos}");

                // Pruebas de comparación
                bool esIgual = auto1 == camion1;
                Console.WriteLine($"¿El auto y el camión son iguales?: {esIgual}");

                // Pruebas de eliminación de vehículos
                miLavadero -= auto1; // Eliminar el auto del lavadero
                Console.WriteLine("Detalles del Lavadero después de eliminar el auto:");
                Console.WriteLine(miLavadero._detalle);

                Console.WriteLine("\n/////////////////////////////////////////////////////\n");

                // Ordenar vehículos por patente
                List<Vehiculo> vehiculosOrdenadosPorPatente = new List<Vehiculo>
                {
                    moto1, camion1, auto1
                };
                vehiculosOrdenadosPorPatente.Sort(Lavadero.OrdenarVehiculosPorPatente);

                Console.WriteLine("Vehículos ordenados por patente:");
                foreach (var vehiculo in vehiculosOrdenadosPorPatente)
                {
                    if (vehiculo is Auto)
                    {
                        Console.WriteLine(((Auto)vehiculo).MostrarAuto());
                    }
                    else if (vehiculo is Camion)
                    {
                        Console.WriteLine(((Camion)vehiculo).MostrarCamion());
                    }
                    else if (vehiculo is Moto)
                    {
                        Console.WriteLine(((Moto)vehiculo).MostrarMoto());
                    }
                    Console.WriteLine("--------------------------------------------");
                }

                // Ordenar vehículos por marca
                List<Vehiculo> vehiculosOrdenadosPorMarca = new List<Vehiculo>
                {
                    moto1, camion1, auto1
                };
                vehiculosOrdenadosPorMarca.Sort(Lavadero.OrdenarVehiculosPorMarca);

                Console.WriteLine("\n/////////////////////////////////////////////////////\n");

                Console.WriteLine("Vehículos ordenados por marca:");
                foreach (var vehiculo in vehiculosOrdenadosPorMarca)
                {
                    if (vehiculo is Auto)
                    {
                        Console.WriteLine(((Auto)vehiculo).MostrarAuto());
                    }
                    else if (vehiculo is Camion)
                    {
                        Console.WriteLine(((Camion)vehiculo).MostrarCamion());
                    }
                    else if (vehiculo is Moto)
                    {
                        Console.WriteLine(((Moto)vehiculo).MostrarMoto());
                    }
                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}