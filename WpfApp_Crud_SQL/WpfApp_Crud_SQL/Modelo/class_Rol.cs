using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Crud_SQL.Modelo
{
    public class class_Rol
    {   // Atributos 
        private String nombre;
        private String descripcion;
        //ddd
        // Constructor
        public class_Rol(string NOMBRE, string DESCRIPCION)
        {
            this.nombre = NOMBRE;
            this.descripcion = DESCRIPCION;
        }
        // Métodos utilitarios 
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
