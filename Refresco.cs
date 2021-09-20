using System;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Refresco:Expendedora
    {
        public override string Marca { 
            get => base.Marca; 
            set
            {
                if( value == "" )
                {
                   base.Marca = "Jarritos";
                }
                else
                {
                    base.Marca = value;
                }                               

            }

        }

        public override byte Temperatura
        {
            get => base.Temperatura;
            set
            {
                if( value < 5 || value > 10  )
                {
                  temperatura= 5;
                }
                else
                {
                  temperatura = value;
                    
                }
                
            }
        }
                


        public Refresco()
        {
            
            Marca = "";
            Temperatura = 14;
            Console.WriteLine("Marca: {0}", Marca);
            Console.WriteLine("Temperatura: {0} °C", Temperatura);
            MostrarCodigo();
             
        }


        public override string MostrarCodigo()
        {
            Console.WriteLine("Ingrese el código \n 45a)Mazana \n 62b)Coca de piña    ");
            string codigo = Console.ReadLine();

            return codigo;
        }
    }
}
