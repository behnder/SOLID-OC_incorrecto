using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OC_incorrecto
{
    class Repositorio
    {
        public void Cargar()
        {
            Console.WriteLine("Cargando datos para BD SQL");

        }
        public void Guardar()
        {
            Console.WriteLine("Guardando datos para BD SQL");
        }
        public void Actualizar()
        {
            Console.WriteLine("Actualizando datos para BD SQL");
        }
        public void Quitar()
        {
            Console.WriteLine("Eliminando datos para BD SQL");
        }
    }
}
