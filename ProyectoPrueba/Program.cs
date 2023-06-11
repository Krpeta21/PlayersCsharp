
using ProyectoPrueba.Models;
using System;
using System.Linq;
namespace ProyectoPueba
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Gremio> gremios = new List<Gremio>()
            {
                new Gremio("Diamond Mechonics")
                {
                    Players = new List<Player>()
                    {
                        new Player(){id=1,nombre="notwicho",rol="jugador"},
                        new Player(){id = 2, nombre="Faralet",rol="jugador"},
                        new Player(){id = 3,nombre="Carpetsu",rol="admin"},

                    }
                },
                new Gremio("Aincrad")
                {
                    Players = new List<Player>()
                    {
                        new Player(){id=1,nombre="asuna",rol="jugador"},
                        new Player(){id=2,nombre="Carpetsu",rol="jugador"},
                        new Player(){id=3,nombre="kirito",rol="admin"},

                    }
                },
                new Gremio("Nuevo bar")
                {

                }

            };

            var player = (from d in gremios
                          where d.Players.Where(c => c.nombre == "Carpetsu").Count() > 0
                          select new GremioData(d.Nombre)
                          {
                              players = (from p in d.Players
                                         where p.nombre == "Carpetsu" 
                                         select new Prueba(p.nombre,p.rol)
                                         ).ToList()
                          }
                          ).ToList();
            

            List < Player > players = new List<Player>()
            {
                new Player(){nombre="notwicho",rol="jugador"},
                new Player(){nombre="Faralet",rol="jugador"},
                new Player(){nombre="Carpetsu",rol="admin"},

            };
           
            
        }
       
    
    }
}