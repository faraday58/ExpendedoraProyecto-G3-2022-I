﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Cafe:Expendedora
    {
        public Cafe(string marca)
        {
            this.Marca = marca;
            Console.WriteLine("Marca de Café es: {0}", Marca);

        }


    }
}
