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
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    public partial class ABMVendedores : Window
    {
        public ABMVendedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";

            txtLegajo.IsEnabled = true;
            txtApellido.IsEnabled = true;
            txtNombre.IsEnabled = true;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            btnNuevo.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnPrimero.IsEnabled = false;
            btnAnterior.IsEnabled = false;
            btnSiguiente.IsEnabled = false;
            btnUltimo.IsEnabled = false;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Está seguro de que desea guardar los datos del vendedor?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resultado == MessageBoxResult.Yes)
            {
                Vendedor oVendedor = new Vendedor();
                oVendedor.Legajo = txtLegajo.Text;
                oVendedor.Apellido = txtApellido.Text;
                oVendedor.Nombre = txtNombre.Text;

                string mensajeObjeto = "Datos guardados en el objeto oVendedor:\n" +
                                       "Legajo: " + oVendedor.Legajo + "\n" +
                                       "Apellido: " + oVendedor.Apellido + "\n" +
                                       "Nombre: " + oVendedor.Nombre;
                MessageBox.Show(mensajeObjeto, "Objeto Guardado", MessageBoxButton.OK, MessageBoxImage.Information);

                txtLegajo.IsEnabled = false;
                txtApellido.IsEnabled = false;
                txtNombre.IsEnabled = false;

                btnGuardar.IsEnabled = false;
                btnCancelar.IsEnabled = false;

                btnNuevo.IsEnabled = true;
                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;
                btnPrimero.IsEnabled = true;
                btnAnterior.IsEnabled = true;
                btnSiguiente.IsEnabled = true;
                btnUltimo.IsEnabled = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";

            txtLegajo.IsEnabled = false;
            txtApellido.IsEnabled = false;
            txtNombre.IsEnabled = false;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            btnNuevo.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnPrimero.IsEnabled = true;
            btnAnterior.IsEnabled = true;
            btnSiguiente.IsEnabled = true;
            btnUltimo.IsEnabled = true;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
