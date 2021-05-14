using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresApp
{
    public partial class Program
    {
        static void IngresarLectura()
        {

        }

        static void MostrarLecturas()
        {

        }

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Testing");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    IngresarLectura();
                    break;
                case "2":
                    MostrarLecturas();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese opcion Válida");
                    break;
            }
            return continuar;
        }


    }
}
