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

namespace Laboratorio2_Guerrero_DAE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string usuario = Username.Text;
            string contraseña = Contraseña.Password;

            if (usuario == "Ricardo" && contraseña == "123456")
            {
                Window1 window = new Window1();
                this.Close();
                window.Show();
            }
            else
            {
                // Inicio de sesión fallido, muestra un mensaje de error.
                MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.");
            }


            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
