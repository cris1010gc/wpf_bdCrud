using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Crud_SQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; // Centrar la ventana
        }

        // Manejador de evento para el botón "Agregar"
        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para la funcionalidad de "Agregar"
            MessageBox.Show("Funcionalidad de Agregar");
        }

        // Manejador de evento para el botón "Modificar"
        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para la funcionalidad de "Modificar"
            MessageBox.Show("Funcionalidad de Modificar");
        }

        // Manejador de evento para el botón "Mostrar"
        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para la funcionalidad de "Mostrar"
            MessageBox.Show("Funcionalidad de Mostrar");
        }

        // Manejador de evento para el botón "Salir"
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para la funcionalidad de "Salir"
            Close(); // Cierra la ventana
        }
    }
}
