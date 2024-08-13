using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaControlCancelacionCFDI
    {
        public Int64 idLoteCargaNomina { get; set; }
        public string folioLoteCargaNomina { get; set; }
        public Int64 idPDOHeaderCFDI { get; set; }
        public Int64 idPDOHeader { get; set; }

        public string accion { get; set; }
        public string modo { get; set; }
        public string justificacion { get; set; }

        /*** SECCION BLOQUE INFORMATIVO ***/
        public string softwareNombre { get; set; }
        public string softwareVersion { get; set; }

        /*** SECCION PATRON ***/
        public string registroPatronal { get; set; }
        public string rfcTenedora { get; set; }

        public string serieRecibo { get; set; }
        public string folioRecibo { get; set; }
        public string fechaEmision { get; set; }

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
        public string fechaInicialPago { get; set; }
        public string fechaFinalPago { get; set; }
        public decimal numDiasPagados { get; set; }
        public decimal montoPagado { get; set; }
        public string importeConLetra { get; set; }
        public string tipoMoneda { get; set; }
        public decimal tipoCambio { get; set; }
        public string CLABE { get; set; }
        public string banco { get; set; }

        /*** SECCION SAT ***/
        public string estatusDocumento { get; set; }
        public string folioFiscalUUID { get; set; }
        public string fechaGeneracionCFDI { get; set; }
        public string fechaTFD { get; set; }
        public string estadoCFDI { get; set; }
        public string Motivo { get; set; }

        public bool seleccionado { get; set; }
    }
}
