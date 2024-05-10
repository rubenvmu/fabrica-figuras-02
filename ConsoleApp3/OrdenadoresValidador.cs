using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class OrdenadoresValidador
    {

        public static class Validador
        {
            public static InterfazOrdenadores ValidarOrdenador(InterfazOrdenadores ordenador)
            {
                if (ordenador.Precio > 0 && ordenador.Garantia > 0)
                    return ordenador;
                else
                    return null;
            }
        }

    }
}
