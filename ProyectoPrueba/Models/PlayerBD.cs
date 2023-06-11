using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrueba.Models
{
    class PlayerBD
    {
        private string _stringConnection
             = "Data Source=localhost;Initial Catalog=Players;"+
            "User=sa;Password=root";
        public List<Player> Get()
        {
            List<Player> PlayerList = new List<Player>();
            string query = "SELECT nombre,rol FROM Player";

            using (SqlConnection connection = new SqlConnection(_stringConnection))
            {
               SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string Name = reader.GetString(0);
                    string Rol = reader.GetString(1);
                    Player player = new Player(Name,Rol);
                    PlayerList.Add(player);
                }
                reader.Close();
                connection.Close();

            }
                return PlayerList;
        }

        public void Add(Player player)
        {
            string query
                = "INSERT INTO Player (nombre,rol)"+
                "VALUES(@nombre,@rol)";
            using (var connection = new SqlConnection(_stringConnection))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre",player.nombre);
                command.Parameters.AddWithValue("@rol",player.rol);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }   
        
        public void Edit(Player player,int Id)
        {
            string query
               = "UPDATE Player SET nombre=@nombre,"+
               "rol=@rol WHERE id=@id";
            using (var connection = new SqlConnection(_stringConnection))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", player.nombre);
                command.Parameters.AddWithValue("@rol", player.rol);
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        public void Delete(int Id)
        {
            string query
               = "DELETE FROM Player WHERE id=@id";
            using (var connection = new SqlConnection(_stringConnection))
            {
                var command = new SqlCommand(query, connection);                
                command.Parameters.AddWithValue("@id", Id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
