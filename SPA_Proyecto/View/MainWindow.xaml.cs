using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPA_Proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (UserSession.IsLoggedIn())
            {
                // Usar la información del usuario
                lblWelcome.Content = $"Bienvenido, {UserSession.CurrentUser.Nombre}";
            }
            else
            {
                MessageBox.Show("No hay usuario autenticado");
                this.Close();
            }
        }
    }
}