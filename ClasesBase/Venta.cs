using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int nro_Factura;

        public int Nro_Factura
        {
            get { return nro_Factura; }
            set { nro_Factura = value; }
        }
        private DateTime fecha_Factura;

        public DateTime Fecha_Factura
        {
            get { return fecha_Factura; }
            set { fecha_Factura = value; }
        }
        private string legajo;

        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string cod_Producto;

        public string Cod_Producto
        {
            get { return cod_Producto; }
            set { cod_Producto = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
    }
}
