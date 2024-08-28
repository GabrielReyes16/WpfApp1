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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            // Crear una lista de salidas con datos ficticios
            List<Salida> list = new List<Salida>
            {
                new Salida
                {
                    Fecha = new DateTime(2024, 1, 10),
                    Peso = 1500.5,
                    TipoAuto = "Sedán",
                    NombreTransportista = "Juan Pérez",
                    PesoIngreso = 1450.0,
                    PesoSalida = 1550.0,
                    FechaHora = DateTime.Now
                },
                new Salida
                {
                    Fecha = new DateTime(2024, 2, 15),
                    Peso = 2000.0,
                    TipoAuto = "SUV",
                    NombreTransportista = "Ana García",
                    PesoIngreso = 1950.0,
                    PesoSalida = 2050.0,
                    FechaHora = DateTime.Now
                },
                new Salida
                {
                    Fecha = new DateTime(2024, 3, 20),
                    Peso = 1800.0,
                    TipoAuto = "Camión",
                    NombreTransportista = "Luis Martínez",
                    PesoIngreso = 1750.0,
                    PesoSalida = 1850.0,
                    FechaHora = DateTime.Now
                },
                new Salida
                {
                    Fecha = new DateTime(2024, 4, 25),
                    Peso = 1600.0,
                    TipoAuto = "Hatchback",
                    NombreTransportista = "María López",
                    PesoIngreso = 1550.0,
                    PesoSalida = 1650.0,
                    FechaHora = DateTime.Now
                },
                new Salida
                {
                    Fecha = new DateTime(2024, 5, 30),
                    Peso = 1700.0,
                    TipoAuto = "Pickup",
                    NombreTransportista = "Carlos Sánchez",
                    PesoIngreso = 1650.0,
                    PesoSalida = 1750.0,
                    FechaHora = DateTime.Now
                }
            };

            // Asignar la lista de salidas al DataGrid
            dgSalidas.ItemsSource = list;
        }
        public class Salida
        {
            public DateTime Fecha { get; set; }
            public double Peso { get; set; }
            public string TipoAuto { get; set; }
            public string NombreTransportista { get; set; }
            public double PesoIngreso { get; set; }
            public double PesoSalida { get; set; }
            public DateTime FechaHora { get; set; }
        }


    }
}
