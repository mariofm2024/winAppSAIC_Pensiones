using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaControlCFDI
    {
        public Int64 IdLoteCargaNomina { get; set; }
        public Int64 IdPDOHeader { get; set; }
        public string FolioLoteCargaNomina { get; set; }
        public string modo { get; set; }
        public string versionEFNomina { get; set; }
        public string versionCFDI { get; set; }
        public string serieRecibo { get; set; }
        public string folioRecibo { get; set; }
        public string fechaEmision { get; set; }

        public string razonSocialTenedora { get; set; }
        public string leyendaRecibo { get; set; }

        /*** SECCION BLOQUE INFORMATIVO ***/
        public string tituloInformativo { get; set; }
        public string textoInformativo { get; set; }
        public string renglon1Informativo { get; set; }     //usado para No. Lote Carga Nomina
        public string renglon2Informativo { get; set; }
        public string renglon3Informativo { get; set; }
        public string renglon4Informativo { get; set; }
        public string renglon5Informativo { get; set; }
        public string SoftwareNombre { get; set; }
        public string SoftwareVersion { get; set; }

        /*** SECCION PATRON ***/
        public string registroPatronal { get; set; }
        public string rfcTenedora { get; set; }     //ASIM

        /*** SECCION GrupoCorporativo ***/
        public string empresa { get; set; }

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
        public string fechaInicioRelLaboral { get; set; }
        public int antiguedad { get; set; }
        public int tipoRegimen { get; set; }    //ASIM
        public string tipoContrato { get; set; }
        public string tipoJornada { get; set; }
        public string periodicidadPago { get; set; }    //ASIM
        public decimal salarioBaseCotApor { get; set; }
        public decimal salarioDiarioIntegrado { get; set; }

        /*** SECCION Pago ***/
        public string fechaPago { get; set; }

        public string fechaInicialPago
        { get; set; }

        public string fechaFinalPago
        { get; set; }

        public decimal numDiasPagados
        { get; set; }

        public decimal numDiasFaltasJus
        { get; set; }

        public decimal numDiasFaltasInJus
        { get; set; }

        public decimal montoPagado
        { get; set; }

        public string importeConLetra
        { get; set; }

        public string tipoMoneda
        { get; set; }

        public decimal tipoCambio
        { get; set; }

        public string CLABE
        { get; set; }

        public string banco
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
