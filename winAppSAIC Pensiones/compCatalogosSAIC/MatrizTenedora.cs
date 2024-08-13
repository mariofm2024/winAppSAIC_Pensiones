using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class MatrizTenedora
    {
        //MatrizTenedora
        public Int32 IdMatrizTenedora { get; set; }
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
        public string IdRegimenFiscal { get; set; }

        //Contacto

        public string RepresentanteLegal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string CorreoElectronico { get; set; }
        public Int16 IdClasifTenedora { get; set; }

        //Otros
        public string IdRegion { get; set; }
        public Boolean Subcontratacion { get; set; }
        public Boolean ASimilados { get; set; }
        public Boolean IVA8 { get; set; }

        public string IdRFSAT { get; set; }
        public byte IdEstatus { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public string RegimenCapital { get; set; }
        public string VersionCFDI { get; set; }
        public Int32 IdAsimilados { get; set; }
        
    }
}
