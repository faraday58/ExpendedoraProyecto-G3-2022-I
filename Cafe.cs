using System;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Cafe:Expendedora
    {
        public Cafe(string marca)
        {
            this.Marca = marca;
            Console.WriteLine("Marca de Café es: {0}", Marca);

        }

        public override string MostrarCodigo()
        {
            string codigo;
            Console.WriteLine("Ingrese el código: \n   1A) Expreso \n 2B) Latte   ");
            codigo = Console.ReadLine();

            return codigo ;
        }

    }
}
