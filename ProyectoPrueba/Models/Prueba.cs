using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    public class Prueba
    {
        string nombre { get; set; }
        string rol { get; set; }
        public Prueba(string nombre,string rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }
    }
}
