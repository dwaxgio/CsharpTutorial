using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_CONEXION_A_DB
{
    public class ConexionDB
    {
        private string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Pruebas;User=sa;Pwd=Unemamad249";

        public List<Ejercicio> Get()
        {
            List<Ejercicio> Ejercicios = new List<Ejercicio>();

            string query = "SELECT nombre, kilos FROM ejercicios";

            using(SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conexion);

                conexion.Open();
                SqlDataReader reader = command.ExecuteReader(); // se ejecuta el query
                while(reader.Read())
                {
                    string nombre = reader.GetString(0);
                    int kilos = reader.GetInt32(1);
                    Ejercicio ejercicio = new Ejercicio(nombre, kilos); // Llena objeto cerveza
                    Ejercicios.Add(ejercicio);                    
                }
                reader.Close();

                conexion.Close();
            }

            return Ejercicios;
        }

        // Insercion
        public void Add(Ejercicio ejercicio)
        {
            string query = "INSERT INTO ejercicios (nombre, kilos) " +
                "VALUES (@nombre, @kilos)";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", ejercicio.nombre);
                command.Parameters.AddWithValue("@kilos", ejercicio.kilos);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Edicion
        public void Edit(Ejercicio ejercicio, int Id)
        {
            string query = "UPDATE ejercicios SET nombre = @nombre, kilos = @kilos "+
                "WHERE id = @Id";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", ejercicio.nombre);
                command.Parameters.AddWithValue("@kilos", ejercicio.kilos);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Eliminación
        public void Delete(int Id)
        {
            string query = "DELETE FROM ejercicios " +
                "WHERE id = @Id";

            using(var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}
