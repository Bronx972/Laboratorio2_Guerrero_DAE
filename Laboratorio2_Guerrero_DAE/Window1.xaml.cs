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

namespace Laboratorio2_Guerrero_DAE
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button_Operacion(object sender, RoutedEventArgs e)
        {
            Operaciones operacion = new Operaciones();
            operacion.Show();

        }
        private void Button_Camion(object sender, RoutedEventArgs e)
        {
            Camion camion = new Camion();
            camion.Show();
        }
        private void Button_Conductor(object sender, RoutedEventArgs e)
        {
            Conductor conductor = new Conductor();
            conductor.Show();
        }
        
        private void Button_Reporte(object sender, RoutedEventArgs e)
        {
            Reportes reporte = new Reportes();
            reporte.Show();
        }
    }
}
