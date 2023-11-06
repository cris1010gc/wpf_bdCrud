using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Crud_SQL.Modelo
{
    public class class_Rol_BD
    {   // Atributos
        private sql_Acceso conexion;
        // Constructor
        public class_Rol_BD()
        {
            // Inicializa la conexión
            conexion = new sql_Acceso();
        }
        // Método capa entre interfaz gráfica y la capa de datos 
        public DataTable LlenarTabla_Rol()
        {
            DataTable dt = new DataTable();

            try
            {
                // Abre la conexión
                conexion.OpenConnection();

                if (conexion.Estado)
                {
                    string consulta = "SELECT * FROM Clientes";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.Connection);

                    adaptador.Fill(dt);

                    // Cierra la conexión
                    conexion.CloseConnection();
                }
                else
                {
                   // MessageBox.Show("Atención: No se pudo establecer conexión con la BD");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al cargar datos de la base de datos: " + ex.Message);
                //MessageBox.Show("Atención: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error desconocido: " + ex.Message);
                //MessageBox.Show("Atención: " + ex.Message);
            }

            return dt;
        }
    }
}
