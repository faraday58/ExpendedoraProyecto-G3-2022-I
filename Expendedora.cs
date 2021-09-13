using System;
using System.Threading;
namespace ExpendedoraProyecto_G3_2022_I
{
    abstract class Expendedora
    {

        #region Atributos (Campos)
        string marca;
        ushort cantProductos;
        byte temperatura;
        float precio;


        #endregion


        #region Propiedades
        public byte Temperatura { 
            get => temperatura;
            set
            {
                if(  value < 14  || value > 20  )
                {
                    temperatura = 14;
                }
                else
                {
                    temperatura = value;
                }
                
            }
        }

        public string Marca { get => marca; set => marca = value; }
        public ushort CantProductos { get => cantProductos; set => cantProductos = value; }
        public float Precio { get => precio; set => precio = value; }
        #endregion


        public Expendedora()
        {
          
        }

        public Expendedora(string marca)
        {
            this.Marca = marca;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}",this.Marca);
        }

        


        public Expendedora(ushort cantProductos)
        {
            Marca = "AMS";
            this.CantProductos = cantProductos;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0} \n Cantidad de Productos: {1}", Marca, this.CantProductos);

        }

        #region Métodos

        public void ElevarTemperatura()
        {
            Temperatura += 1;
        }
        public void MostrarTemperatura()
        {
            Console.WriteLine("Temperatura {0} [°C] ", Temperatura);
        }
        public void Saludar()
        {
            Console.WriteLine("Bienvenido");
        }

        public void TiempoDespliegue()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }


        public string MostrarCodigo()
        {
            //Variable local "codigo"
            string codigo;
            Console.WriteLine(" 1A: Pastillas de Gengibre \n 2B: Pasitas con Chocolate \n 3C: Tostitos");
            Console.WriteLine("Ingrese el código del producto");
            codigo = Console.ReadLine();
            return codigo;

        }

        public void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "1A":
                    Console.WriteLine("Precio: ${0}",Precio);
                    break;
                case "2B":
                    Console.WriteLine("Precio: ${0}", Precio-2);
                    break;
                case "3C":
                    Console.WriteLine("Precio: ${0}", Precio-5);
                    break;
                default:
                    Console.WriteLine("Producto inexistente");
                    break;
            }

        }




        #endregion



    }
}
