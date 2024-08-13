using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
        public class ClienteMatriz
        {
            //Cliente
            public Int32 IdCliente { get; set; }
            public string CodigoClienteProvedor { get; set; }
            public string RazonSocial { get; set; }
            public string NombreComercial { get; set; }
            public string RFC { get; set; }
            public Int16 IdActividadComercial { get; set; }
            
            //Domicilio Fiscal
            public string Calle { get; set; }
            public string NoExterior { get; set; }
            public string NoInterior { get; set; }
            public string Colonia { get; set; }
            public string CodigoPostal { get; set; }
            public Int16 IdPais { get; set; }
            public Int32 IdEstado { get; set; }
            public string NombreDelegacionMunicipio { get; set; }
            public string NombrePoblacionCiudad { get; set; }
            
            //Contacto
            public string RepresentanteLegal { get; set; }
            public string Contacto { get; set; }
            public string Telefono1 { get; set; }
            public string Telefono2 { get; set; }
            public string CorreoElectronico { get; set; }
            public string PaginaWeb { get; set; }

            //
            public DateTime FechaBaja { get; set; }
            public Byte IdEstatus { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaModificacion { get; set; }
            public string UsuarioCreacion { get; set; }
            public string UsuarioModificacion { get; set; }

        }
}
