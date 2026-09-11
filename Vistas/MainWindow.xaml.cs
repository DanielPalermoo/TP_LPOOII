using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Vistas
{
    public partial class MainWindow : Window
    {
        private string usuarioRol;

        public MainWindow() : this("Vendedor")
        {
        }

        public MainWindow(string rol)
        {
            InitializeComponent();
            this.usuarioRol = rol;
            
            lblRolUsuario.Text = "Rol: " + rol;

            if (rol != "Admin")
            {
                btnVendedores.IsEnabled = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }

        private void btnProveedores_Click(object sender, RoutedEventArgs e)
        {
            ABMProveedores wnd = new ABMProveedores();
            this.Hide();
            wnd.ShowDialog();
            this.Show();
        }

        private void btnClientes_Click(object sender, RoutedEventArgs e)
        {
            ABMClientes wnd = new ABMClientes();
            this.Hide();
            wnd.ShowDialog();
            this.Show();
        }

        private void btnProductos_Click(object sender, RoutedEventArgs e)
        {
            ABMProductos wnd = new ABMProductos();
            this.Hide();
            wnd.ShowDialog();
            this.Show();
        }

        private void btnVendedores_Click(object sender, RoutedEventArgs e)
        {
            ABMVendedores wnd = new ABMVendedores();
            this.Hide();
            wnd.ShowDialog();
            this.Show();
        }
    }
}
