using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Tienda
    {
        public double TotalFacturado { get; set; } = 0.0;
        public int NumeroOrdenadoresVendidos { get; set; } = 0;
        public double OrdenadorMasBarato { get; set; } = double.MaxValue;
        public double OrdenadorMasCaro { get; set; } = double.MinValue;
        public double PrecioMedioPorOrdenador { get; set; } = 0.0;
        public int NumeroOrdenadoresPrecioSuperior125 { get; set; } = 0;

        public void MostrarTienda()
        {
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine($"Total facturado en el día: {TotalFacturado}");
            Console.WriteLine($"Número de ordenadores vendidos: {NumeroOrdenadoresVendidos}");
            Console.WriteLine($"Ordenador más barato: {OrdenadorMasBarato}");
            Console.WriteLine($"Ordenador más caro: {OrdenadorMasCaro}");
            Console.WriteLine($"Precio Medio por ordenador: {PrecioMedioPorOrdenador}");
            Console.WriteLine($"Número de ordenadores que tienen un precio superior a 125: {NumeroOrdenadoresPrecioSuperior125}");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────");
        }
    }
}
