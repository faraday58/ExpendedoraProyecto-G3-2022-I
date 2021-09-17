using System;

namespace ExpendedoraProyecto_G3_2022_I
{
    class Snack:Expendedora
    {

        public override string Marca { 
            get => base.Marca;
            set
            {
                if(value == "")
                {
                    base.Marca = "AMS";
                }else
                {
                    base.Marca = value;
                }
            }
        }


        public Snack()
        {
            Marca = "";
            CantProductos = 430;
            Temperatura = 14;
            Precio = 15;           
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
