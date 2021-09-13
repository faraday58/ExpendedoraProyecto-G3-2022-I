using System;
using System.Threading;
namespace ExpendedoraProyecto_G3_2022_I
{
    class Expendedora
    {

        #region Atributos (Campos)
        string marca;
        ushort cantProductos;
        byte temperatura;
        float precio;
        #endregion

        public Expendedora()
        {
            marca = "AMS";
            cantProductos = 430;
            temperatura = 14;
            precio = 15;

            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {1}, CantProductos {0}", cantProductos,marca);
            TiempoDespliegue();
            Console.WriteLine("La temperatura interna es: {0} [°C]", temperatura);
            TiempoDespliegue();
            string codigo= MostrarCodigo();
            TiempoDespliegue();
            MostrarPrecio(codigo);
        }

        public Expendedora(string marca)
        {
            this.marca = marca;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0}",this.marca);
        }

        public Expendedora(ushort cantProductos)
        {
            marca = "AMS";
            this.cantProductos = cantProductos;
            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {0} \n Cantidad de Productos: {1}", marca, this.cantProductos);

        }

        #region Métodos
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
                    Console.WriteLine("Precio: ${0}",precio);
                    break;
                case "2B":
                    Console.WriteLine("Precio: ${0}", precio-2);
                    break;
                case "3C":
                    Console.WriteLine("Precio: ${0}", precio-5);
                    break;
                default:
                    Console.WriteLine("Producto inexistente");
                    break;
            }

        }




        #endregion



    }
}
