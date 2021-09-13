using System;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Snack:Expendedora
    {
        public Snack()
        {
            Marca = "AMS";
            CantProductos = 430;
            Temperatura = 14;
            Precio = 15;

            Saludar();
            TiempoDespliegue();
            Console.WriteLine("Marca: {1}, CantProductos {0}", CantProductos, Marca);
            TiempoDespliegue();
            Console.WriteLine("La temperatura interna es: {0} [°C]", Temperatura);
            TiempoDespliegue();
            string codigo = MostrarCodigo();
            TiempoDespliegue();
            MostrarPrecio(codigo);
        }

    }
}
