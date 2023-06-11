using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    public class Gremio
    {
        public string Nombre { get; set; }
        public List<Player> Players = new List<Player>();
        public Gremio(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
