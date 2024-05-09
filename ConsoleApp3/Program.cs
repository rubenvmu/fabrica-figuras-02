class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione una figura:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Círculo");
            Console.WriteLine("0. Salir");

            int figuraSeleccionada = int.Parse(Console.ReadLine());

            switch (figuraSeleccionada)
            {
                case 1:
                case 2:
                    TipoDeFigura tipoDeFigura = figuraSeleccionada switch
                    {
                        1 => TipoDeFigura.Cuadrado,
                        2 => TipoDeFigura.Círculo,
                        _ => throw new ArgumentException("Opción no válida")
                    };

                    Console.Write("Tamaño de la figura: ");
                    int valor = int.Parse(Console.ReadLine());

                    var fábrica = new FábricaDeFiguras();
                    var figura = fábrica.CrearFigura(tipoDeFigura, valor);

                    Console.WriteLine($"{figura}");
                    Console.WriteLine($"Superficie de la figura: {figura.ObtenerÁreaDeSuperficie():F2}");
                    Console.WriteLine($"Perímetro de la figura: {figura.ObtenerPerímetro():F2}");
                    break;
                case 0:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, inténtelo de nuevo.");
                    break;
            }
        }
    }
}

/*

bool continuar = true; This line declares a boolean variable continuar and initializes it to true. This variable is used to control the loop that runs the program.

while (continuar) { ... } This line starts a while loop that continues as long as continuar is true.

Console.WriteLine("Seleccione una figura:"); Console.WriteLine("1. Cuadrado"); Console.WriteLine("2. Círculo"); Console.WriteLine("0. Salir"); These lines display the available options to the user: selecting a figure (Square or Circle) or exiting the program (Salir).

int figuraSeleccionada = int.Parse(Console.ReadLine()); This line reads the user's input as a string and converts it to an integer, storing it in the figuraSeleccionada variable.

switch (figuraSeleccionada) { ... } This line starts a switch statement that checks the value of figuraSeleccionada and performs different actions based on its value.

case 1: case 2: These lines specify the actions to perform when the user selects either Square (1) or Circle (2).

TipoDeFigura tipoDeFigura = figuraSeleccionada switch { ... }; This line uses the switch expression (available since C# 8.0) to determine the TipoDeFigura based on the user's input.

Console.Write("Tamaño de la figura: "); int valor = int.Parse(Console.ReadLine()); These lines display a message asking the user to input the size of the figure and read the user's input as an integer, storing it in the valor variable.

var fábrica = new FábricaDeFiguras(); var figura = fábrica.CrearFigura(tipoDeFigura, valor); These lines create a new instance of the FábricaDeFiguras class and use it to create a figure based on the selected type and size.

Console.WriteLine($"{figura}"); Console.WriteLine($"Superficie {figura.ObtenerÁreaDeSuperficie():F2}"); Console.WriteLine($"Perímetro {figura.ObtenerPerímetro():F2}"); These lines display the figure's information, such as its type, size, surface area, and perimeter.

case 0: This line specifies the action to perform when the user selects the option to exit (0).

continuar = false; This line sets continuar to false to exit the while loop.

default: This line specifies the action to perform when the user's input is not valid (not 0, 1, or 2).

Console.WriteLine("Opción no válida, inténtelo de nuevo."); This line displays a message asking the user to input a valid option.

The Main method contains a while loop that continues until the user decides to exit (0). Inside the loop, the program displays the available options, reads the user's input, creates a figure based on the selected type and size, and displays the figure's information. If the user's input is not valid, the program displays an error message and continues the loop.
*/