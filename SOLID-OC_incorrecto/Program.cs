using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OC_incorrecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Repositorio repositorio = new Repositorio();

            repositorio.Actualizar();
            repositorio.Cargar();
            repositorio.Guardar();
            repositorio.Quitar();
            Console.ReadKey();

        }
    }
}
