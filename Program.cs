using System;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Prueba
    {
        static void Main()
        {
            /*Expendedora miExpendedora = new Expendedora();
            Console.WriteLine("**************************");
            Console.WriteLine("Ingrese la marca de la expendedora que desea probar");
            string marca = Console.ReadLine();
            Expendedora miExpendedoraPrueba = new Expendedora(marca);*/
            Console.WriteLine("**************************");
            Console.WriteLine("Ingrese la cantidad de productos de la expendedora que desea probar");
            ushort cantProductos =ushort.Parse(Console.ReadLine());
            Expendedora miExpendedoraPruebaDos = new Expendedora(cantProductos);

            Console.ReadLine();
        }
    }
}
