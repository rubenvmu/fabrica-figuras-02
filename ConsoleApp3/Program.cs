using ConsoleApp3;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<InterfazOrdenadores> ordenadores = new List<InterfazOrdenadores>();

        ordenadores.Add(new OrdenadorLento());
        ordenadores.Add(new OrdenadorNormal());
        ordenadores.Add(new OrdenadorGamer());

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular superficies geométricas");
            Console.WriteLine("2. Acceder al panel de negocio de Ordenadores Obdulio S.L.");
            Console.WriteLine("3. Salir");
            Console.WriteLine("");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                bool continuarFabricar = true;

                while (continuarFabricar)
                {
                    Console.WriteLine("Seleccione una figura:");
                    Console.WriteLine("1. Cuadrado");
                    Console.WriteLine("2. Círculo");
                    Console.WriteLine("0. Salir");

                    int figuraSeleccionada = int.Parse(Console.ReadLine());

                    if (figuraSeleccionada == 1)
                    {
                        Console.Write("Ingrese el tamaño de la figura: ");
                        int valor = int.Parse(Console.ReadLine());
                        var figura = new FábricaDeOrdenadores().CrearFigura(TipoDeFigura.Cuadrado, valor);
                        Console.WriteLine(figura);
                        Console.WriteLine($"Área: {figura.ObtenerÁreaDeSuperficie():F2}");
                        Console.WriteLine($"Perímetro: {figura.ObtenerPerímetro():F2}");
                    }
                    else if (figuraSeleccionada == 2)
                    {
                        Console.Write("Ingrese el radio del círculo: ");
                        int radio = int.Parse(Console.ReadLine());
                        var figura = new FábricaDeOrdenadores().CrearFigura(TipoDeFigura.Círculo, radio);
                        Console.WriteLine(figura);
                        Console.WriteLine($"Área: {figura.ObtenerÁreaDeSuperficie():F2}");
                        Console.WriteLine($"Circunferencia: {figura.ObtenerPerímetro():F2}");
                    }
                    else if (figuraSeleccionada == 0)
                    {
                        continuarFabricar = false;
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida, inténtelo de nuevo.");
                    }
                }
            }
            if (opcion == 2)
            {
                bool volverMenuPrincipal = false;

                while (!volverMenuPrincipal)
                {
                    Console.WriteLine("Panel de negocio de Ordenadores Obdulio S.L.:");
                    Console.WriteLine("1. (PRINT) Ver las características de los ordenadores:");
                    Console.WriteLine("2. (PRINT) Ver total facturado en el día");
                    Console.WriteLine("3. (INTRO) Registrar una venta");
                    Console.WriteLine("0. Salir");
                    Console.WriteLine("");

                    int opcionRegistro = int.Parse(Console.ReadLine());

                    if (opcionRegistro == 1)
                    {
                        Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine(" Características de los ordenadores:");
                        Console.WriteLine(" Lento: Precio " + new OrdenadorLento().Precio + "$, " + new OrdenadorLento().Garantia + " Años de garantía " + new OrdenadorLento().ObsolescenciaProgramada + " años de obsolescencia programada.");
                        Console.WriteLine(" Normal: Precio " + new OrdenadorNormal().Precio + "$, " + new OrdenadorNormal().Garantia + " Años de garantía " + new OrdenadorNormal().ObsolescenciaProgramada + " años de obsolescencia programada.");
                        Console.WriteLine(" Gamer: Precio " + new OrdenadorGamer().Precio + "$, " + new OrdenadorGamer().Garantia + " Años de garantía " + new OrdenadorGamer().ObsolescenciaProgramada + " años de obsolescencia programada.");
                        Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                    }
                    if (opcionRegistro == 2)
                    {
                        while (true)
                        {
                            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                            Console.WriteLine("Menú de opciones:");
                            Console.WriteLine("1. Total facturado en el día" + new Tienda().TotalFacturado);
                            Console.WriteLine("2. Número de ordenadores vendidos" + new Tienda().NumeroOrdenadoresVendidos);
                            Console.WriteLine("3. Ordenador más barato" + new Tienda().OrdenadorMasBarato);
                            Console.WriteLine("4. Ordenador más caro" + new Tienda().OrdenadorMasCaro);
                            Console.WriteLine("5. Precio Medio por ordenador" + new Tienda().PrecioMedioPorOrdenador);
                            Console.WriteLine("6. Número de ordenadores que tienen un precio superior a 125" + new Tienda().NumeroOrdenadoresPrecioSuperior125);
                            Console.WriteLine("7. Salir");
                            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                        }
                    }
                    if (opcionRegistro == 3)
                    {
                        while (continuar)
                        {
                            Console.WriteLine("1. Registrar una venta");
                        }
                    }
                    else if (opcion == 4)
                    {
                        continuar = false;
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida, inténtelo de nuevo.");
                    }
                }
            }
        }
    }
}



