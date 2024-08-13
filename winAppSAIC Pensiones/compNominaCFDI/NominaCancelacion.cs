using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compNominaCFDI
{
    public class NominaCancelacion
    {
        public Int64 IdLoteCargaNomina { get; set; }
        public string FolioLoteCargaNomina { get; set; }
        public Int64 IdPDOHeaderCFDI { get; set; }
        public Int64 IdPDOHeader { get; set; }
        public string accion { get; set; }
        public string modo { get; set; }
        public string justificacion { get; set; }
        public string serieRecibo { get; set; }
        public string folioRecibo { get; set; }
        public DateTime fechaEmision { get; set; }
        /*** SECCION PATRON ***/
        public string registroPatronal { get; set; }
        public string rfcTenedora { get; set; }     
        /*** SECCION Empleado ***/
        public string nombre { get; set; }          
        public string apellidoPaterno { get; set; }     
        public string apellidoMaterno { get; set; }     
        public string rfc { get; set; }     
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
        public DateTime fechaInicialPago { get; set; }
        public DateTime fechaFinalPago { get; set; }
        public decimal numDiasPagados { get; set; }
        public decimal montoPagado { get; set; }
        public string importeConLetra { get; set; }
        public string tipoMoneda { get; set; }
        public decimal tipoCambio { get; set; }
        public string CLABE { get; set; }
        public string banco { get; set; }

        public string estatusDocumento { get; set; }
        public string folioFiscalUUID { get; set; }
        public DateTime fechaGeneracionCFDI { get; set; }
        public DateTime fechaTFD { get; set; }
        public string estadoCFDI { get; set; }
        public string Motivo { get; set; }
    }
}
