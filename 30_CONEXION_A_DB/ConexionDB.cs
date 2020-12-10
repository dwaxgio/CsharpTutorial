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

    }
}
