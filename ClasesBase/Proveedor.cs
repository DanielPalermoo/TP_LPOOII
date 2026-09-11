using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proveedor
    {
        private string cuit;

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        private string razon_Social;

        public string Razon_Social
        {
            get { return razon_Social; }
            set { razon_Social = value; }
        }
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
