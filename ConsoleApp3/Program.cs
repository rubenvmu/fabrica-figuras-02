using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
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
                    Console.WriteLine("0. Volver al menú principal");
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
                        Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                        Console.WriteLine("Total facturado en el día: (precio)");
                        Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
                    }
                    else if (opcionRegistro == 0)
                    {
                        volverMenuPrincipal = true;
                    }
                }
            }
            else if (opcion == 3)
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

