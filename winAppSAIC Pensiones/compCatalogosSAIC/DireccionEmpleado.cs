using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class DireccionEmpleado
    {
        public Int64 IdDireccion { get; set; }
        public Int32 IdEmpleado { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string NombreDelegacionMunicipio{ get; set; }
        public string NombrePoblacionCiudad{ get; set; }
        public string Telefono1{ get; set; }
        public string Telefono2{ get; set; }
        public Int32 IdEstado{ get; set; }
        public byte IdTipoDireccion{ get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
