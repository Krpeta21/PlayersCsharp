using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    public class GremioData
    {
        public string Nombre { get; set; }
        public List<Prueba> players = new List<Prueba>();
        public GremioData(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
