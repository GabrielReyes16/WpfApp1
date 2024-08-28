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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

            // Crear una lista de conductores con datos ficticios
            List<Conductor> list = new List<Conductor>
            {
                new Conductor() { nombre = "Juan", apellidos = "Pérez", especialidad = "Carga pesada" },
                new Conductor() { nombre = "Ana", apellidos = "García", especialidad = "Transporte rápido" },
                new Conductor() { nombre = "Luis", apellidos = "Martínez", especialidad = "Transporte internacional" },
                new Conductor() { nombre = "María", apellidos = "López", especialidad = "Transporte local" },
                new Conductor() { nombre = "Carlos", apellidos = "Sánchez", especialidad = "Transporte de mercancías peligrosas" }
            };

            // Asignar la lista de conductores al DataGrid
            dgConductores.ItemsSource = list;
        }
        public class Conductor
        {
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string especialidad { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
