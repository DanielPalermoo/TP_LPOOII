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
    public partial class ABMProveedores : Window
    {
        public ABMProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";

            txtCuit.IsEnabled = true;
            txtRazonSocial.IsEnabled = true;
            txtDomicilio.IsEnabled = true;
            txtTelefono.IsEnabled = true;

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
            MessageBoxResult resultado = MessageBox.Show("¿Está seguro de que desea guardar los datos del proveedor?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resultado == MessageBoxResult.Yes)
            {
                Proveedor oProveedor = new Proveedor();
                oProveedor.Cuit = txtCuit.Text;
                oProveedor.Razon_Social = txtRazonSocial.Text;
                oProveedor.Domicilio = txtDomicilio.Text;
                oProveedor.Telefono = txtTelefono.Text;

                string mensajeObjeto = "Datos guardados en el objeto oProveedor:\n" +
                                       "CUIT: " + oProveedor.Cuit + "\n" +
                                       "Razón Social: " + oProveedor.Razon_Social + "\n" +
                                       "Domicilio: " + oProveedor.Domicilio + "\n" +
                                       "Teléfono: " + oProveedor.Telefono;
                MessageBox.Show(mensajeObjeto, "Objeto Guardado", MessageBoxButton.OK, MessageBoxImage.Information);

                txtCuit.IsEnabled = false;
                txtRazonSocial.IsEnabled = false;
                txtDomicilio.IsEnabled = false;
                txtTelefono.IsEnabled = false;

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
            txtCuit.Text = "";
            txtRazonSocial.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";

            txtCuit.IsEnabled = false;
            txtRazonSocial.IsEnabled = false;
            txtDomicilio.IsEnabled = false;
            txtTelefono.IsEnabled = false;

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
