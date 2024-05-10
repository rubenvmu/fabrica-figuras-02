using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface InterfazOrdenadores
    {
        double Precio { get; }
        double Garantia { get; }
        double ObsolescenciaProgramada { get; }
    }

    public class Ordenadores : InterfazOrdenadores
    {
        public double Precio { get; }
        public double Garantia { get; }
        public double ObsolescenciaProgramada => Precio / Garantia;

        protected Ordenadores(double precio, double garantia)
        {
            Precio = precio;
            Garantia = garantia;
        }
    }

    public class OrdenadorLento : Ordenadores
    {
        public OrdenadorLento() : base(100, 2) { }
    }

    public class OrdenadorNormal : Ordenadores
    {
        public OrdenadorNormal() : base(300, 3) { }
    }

    public class OrdenadorGamer : Ordenadores
    {
        public OrdenadorGamer() : base(1000, 4) { }
    }
}