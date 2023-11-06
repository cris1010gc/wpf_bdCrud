using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp_Crud_SQL.Modelo
{
    public class sql_Acceso
    {   // Variables para llamar a la conexión
        private SqlConnection connection;
        private string server, database;
        private string connectionString;
        private bool estado;
        // Métodos utilitarios 
        private string test;
        public SqlConnection Connection { get => connection; }
        public bool Estado { get => estado; }
        // Constructor
        public sql_Acceso()
        {
            // Define la información de conexión
            this.server = "LEAS-LA21";
            this.database = "bd_crud";

            // Configura la cadena de conexión
            connectionString = $"Data Source={server};Initial Catalog={database};Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    estado = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                MessageBox.Show("Atención: " + ex.Message);
                estado = false;
            }
        }
        // Método para cerrar la conexión
        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
                MessageBox.Show("Atención: " + ex.Message);
            }
        }

    }
}
