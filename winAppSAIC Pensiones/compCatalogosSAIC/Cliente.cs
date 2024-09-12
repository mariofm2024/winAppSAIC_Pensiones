using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
        public class Cliente
        {
        //Cliente
        public Int32 IdCliente { get; set; }
        public string CodigoClienteProvedor { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public Int16 IdActividadComercial { get; set; }
        public Int32 IdMatrizCliente { get; set; }
        public Int32 idCategoriaCliente { get; set; }

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

        //Domicilio Operacion
        public string CalleOperacion { get; set; }
        public string NoExteriorOperacion { get; set; }
        public string NoInteriorOperacion { get; set; }
        public string ColoniaOperacion { get; set; }
        public string CodigoPostalOperacion { get; set; }
        public Int16 IdPaisOperacion { get; set; }
        public Int32 IdEstadoOperacion { get; set; }
        public string NombreDelegacionMunicipioOperacion { get; set; }
        public string NombrePoblacionCiudadOperacion { get; set; }

        //Contacto

        public string RepresentanteLegal { get; set; }
        public string Contacto { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string PaginaWeb { get; set; }
        public Int32 IdOperador { get; set; }

        public Int32 idPlazaCliente { get; set; }
        public String sDescPlazaCliente { get; set; }

        //Otros
        public Int16 IdTipoClienteProveedor { get; set; }
        public Int16 IdClaseRiesgo { get; set; }
        public Decimal ISN { get; set; }
        public Boolean TieneSucursales { get; set; }
        public Boolean Confidencial { get; set; }
        public Boolean Seguro { get; set; }
        public Boolean Decreto { get; set; }
        public Boolean Sindicato { get; set; }
        public Decimal PctComisionBPO { get; set; }
        public Decimal PctAsimilados { get; set; }
        public Decimal SaldoAFavor { get; set; }
        public Decimal Financiamiento { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaBaja { get; set; }
        public Byte IdEstatus { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }        
        public int IdRegimenFiscal { get; set; }
        public string RegimenCapital { get; set; }

        //Productos
        public Decimal Tarjeta { get; set; }
        public Decimal Cucas { get; set; }
        public Decimal Efectivos { get; set; }
        public Decimal Seguros { get; set; }
        public Decimal Proveedor { get; set; }
        public Decimal Gasto { get; set; }
        public Decimal Otro { get; set; }

        public Decimal TarjetaP { get; set; }
        public Decimal CucasP { get; set; }
        public Decimal EfectivosP { get; set; }
        public Decimal SegurosP { get; set; }
        public Decimal ProveedorP { get; set; }
        public Decimal GastoP { get; set; }
        public Decimal OtroP { get; set; }

        //Pestaña
        public int IdPestana { get; set; }

    }
}
