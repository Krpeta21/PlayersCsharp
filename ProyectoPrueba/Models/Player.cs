using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    public class Player
    {
        public string nombre { get; set; }
        public string rol { get; set; }
        public int id { get; set; }

        public Player(string nombre, string rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }
        public Player() { }
    }
}
