using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class InfoCuentaBanco
    {
        public Int32 IdCuentaBanco { get; set; }
        public Int32 IdMatrizTenedora { get; set; }
        public byte IdClasifCuentaBanco { get; set; }
        public string NombreCuentaBanco { get; set; }
        public byte IdBanco { get; set; }
        public string NoCuenta { get; set; }
        public string NoSucursal { get; set; }
        public string NoCliente { get; set; }
        public string NoCLABE { get; set; }
        public Decimal SaldoInicial { get; set; }
        public string IdMoneda { get; set; }
        public string DescMoneda { get; set; }
        public string NombreContacto { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string Observaciones { get; set; }
        public string CuentaContable { get; set; }
        public byte IdEstatus { get; set; }
    }
}
