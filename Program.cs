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
            /*
            Console.WriteLine("**************************");
            Console.WriteLine("Ingrese la cantidad de productos de la expendedora que desea probar");
            ushort cantProductos = ushort.Parse(Console.ReadLine());
            Expendedora miExpendedoraPruebaDos = new Expendedora(cantProductos);
            for ( int i=0; i < 2; i++)
            {
                miExpendedoraPruebaDos.ElevarTemperatura();
            }
                        
            miExpendedoraPruebaDos.MostrarTemperatura();
            */

            //Snack miExpendedora = new Snack();
            /*
            Console.WriteLine("Elige la marca de expendedora de Café");
            string marca = Console.ReadLine();
            Cafe miExpenCafe = new Cafe(marca);
            miExpenCafe.MostrarCodigo();
            */
            Refresco miExpendedoraResfresco = new Refresco();
            for(int i=0; i < 15; i++)
            {
                miExpendedoraResfresco.ElevarTemperatura();
            }
            miExpendedoraResfresco.MostrarTemperatura();

            Console.ReadLine();
        }
    }
}
