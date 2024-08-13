using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaTimbreFacil
    {
        public Int64 IdLoteCargaNomina { get; set; }
        public Int64 IdPDOHeader { get; set; }
        public string FolioRecibo { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public string NoCuentaPagoTenedora { get; set; }
        public string RFC { get; set; }
        public string NombreEmpleado { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public string DelegacionMunicipio { get; set; }
        public string Localidad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public string RegistroPatronal { get; set; }
        public string NoEmpleado { get; set; }
        public string CURP { get; set; }
        public string NSS { get; set; }
        public string FechaPago { get; set; }
        public string FechaInicialPago { get; set; }
        public string FechaFinalPago { get; set; }
        public string NoDiasPagados { get; set; }
        public string Departamento { get; set; }
        public string CLABE { get; set; }
        public string Banco { get; set; }
        public string FechaIngreso { get; set; }
        public string Antiguedad { get; set; }
        public string Puesto { get; set; }
        public string TipoContrato { get; set; }
        public string TipoJornada { get; set; }


        /*** SECCION Empleado ***/
        public string nombre { get; set; }          //ASIM
        public string apellidoPaterno { get; set; }     //ASIM
        public string apellidoMaterno { get; set; }     //ASIM
        public string rfc { get; set; }     //ASIM
        public string curp { get; set; }    //ASIM
        public string numSeguridadSocial { get; set; }

        /*** SECCION Empleo ***/
        public string numEmpleado { get; set; }     //ASIM
        public string departamento { get; set; }
        public string puesto { get; set; }
        public string riesgoPuesto { get; set; }
        public DateTime fechaInicioRelLaboral { get; set; }
        public int antiguedad { get; set; }
        public int tipoRegimen { get; set; }    //ASIM
        public string tipoContrato { get; set; }
        public string tipoJornada { get; set; }
        public string periodicidadPago { get; set; }    //ASIM
        public decimal salarioBaseCotApor { get; set; }
        public decimal salarioDiarioIntegrado { get; set; }

        /*** SECCION Pago ***/
        public DateTime fechaPago { get; set; }

        public DateTime fechaInicialPago
        { get; set; }

        public DateTime fechaFinalPago
        { get; set; }

        public decimal numDiasPagados
        { get; set; }

        public decimal montoPagado
        { get; set; }

        public string importeConLetra
        { get; set; }

        public string tipoMoneda
        { get; set; }

        public decimal tipoCambio
        { get; set; }


        /*** SECCION Percepciones ***/
        public decimal totalPercepcionesGravado     //ASIM
        { get; set; }

        public decimal totalPercepcionesExento
        { get; set; }

        /*** SECCION Deducciones ***/
        public decimal totalDeduccionesGravado      //ASIM
        { get; set; }

        public decimal totalDeduccionesExento
        { get; set; }

        /*** SECCION Incapacidades ***/
        public string diasIncapacidad { get; set; }
        public string tipoIncapacidad { get; set; }
        public decimal descuento { get; set; }

        /*** SECCION HorasExtras ***/
        public int diasHrsDobles
        { get; set; }

        public decimal horasDoblesExtra
        { get; set; }

        public decimal importeHrsDoblesPagado
        { get; set; }

        public int diasHrsTriples
        { get; set; }

        public decimal horasTriplesExtra
        { get; set; }

        public decimal importeHrsTriplesPagado
        { get; set; }

        public bool seleccionado { get; set; }
    }
}
