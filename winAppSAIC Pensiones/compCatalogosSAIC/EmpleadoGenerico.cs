using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class EmpleadoGenerico
    {
        public int IdEmpleado { get; set; }
        public string APaternoEmpleado { get; set; }
        public string AMaternoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreEmpleadoCompleto { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string RazonSocialCliente { get; set; }
        public Int32 IdTenedoraSA { get; set; }
        public string TenedoraSA { get; set; }
        public string IdTipoMovimiento { get; set; }
        public byte IdEstatus { get; set; }
        public string DescEstatus { get; set; }
        public string CorreoElectronico { get; set; }
    }
}
