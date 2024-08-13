using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace compNominaCFDI
{
    public class Nomina
    {
        public Int64 IdLoteCargaNomina { get; set; }
        public Int64 IdPDOHeader { get; set; }
        public string VersionCFDI { get; set; }

        public string modo
        {
            get; set;
        }

        public string versionEFNomina
        {
            get; set;
        }

        public string serieRecibo
        {
            get; set;
        }

        public string folioRecibo
        {
            get; set;
        }

        public DateTime fechaEmision
        {
            get; set;
        }
    
        public string Exportacion
        {
            get; set;
        }
        

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

        /*** SECCION PATRON ***/
        public string registroPatronal { get; set; }
        public string rfcTenedora { get; set; }     //ASIM
        
       
        /*** SECCION GrupoCorporativo ***/
        public string empresa { get; set; }

        public string RegimenFiscalSAT { get; set; }
        /*** SECCION Empleado ***/
        public string nombre { get; set; }          //ASIM
        public string apellidoPaterno { get; set; }     //ASIM
        public string apellidoMaterno { get; set; }     //ASIM
        public string rfc { get; set; }     //ASIM
        public string curp { get; set; }    //ASIM
        public string numSeguridadSocial { get; set; }
        public string RegimenFiscalSATCliente { get; set; }
        public string CodigoPostalCliente { get; set; }
        public string UsoCFDI { get; set; }
        public string ObjetiImp { get; set; }
        

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

        /*** SECCION Otros ***/
        public decimal totalOtrossGravado      //ASIM
        { get; set; }

        public decimal totalOtrosExento
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

        //Agregados por New CFDI Grabrizz

        public string TipoNominaSAT { get; set; }
        public string RFCEmisor { get; set; }
        public string CURPEmisor { get; set; }
        public string SindicalizadoSAT { get; set; }
        public string IdTipoContratoSAT { get; set; }
        public string IdTipoJornadaSAT { get; set; }
        public string IdRegimenFiscalEmpleadoSAT { get; set; }
        public string EntidadFederativaTrabajo { get; set; }
        public string metodoDePago { get; set; }
        public int anosServicio { get; set; }
        public decimal ultimoSueldoMensOrd { get; set; }
        public int IdClienteAlterno { get; set; }
        public decimal ISRCausadoSAT { get; set; }
        public decimal SubsidioCausadoSAT { get; set; }
        public string IdPeriodicidadPagoSAT { get; set; }
        public string CodigoPostalTenedora { get; set; }

        //Agregados por New CFDI rutas de Acceso Grabrizz

        public byte[] Certificado { get; set; }
        public byte[] CertificadoPen { get; set; }
        public string CertificadoCadena { get; set; }
        public string NoCertificado { get; set; }
        public byte[] Key { get; set; }
        public byte[] KeyPen { get; set; }
        public byte[] KeyEnc { get; set; }
        public string ContrasenaKey { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

        //Reporte
        public int idTenedora { get; set; }
        public int idCliente { get; set; }
        public string folioLoteCargaNomina { get; set; }
        public string xmlCFDI { get; set; }
        public string correoElectronico { get; set; }
        public int iAPPJ { get; set; }


    }

    public class NominaNEW
    {
        public Int64 IdLoteCargaNomina { get; set; }
        public Int64 IdPDOHeader { get; set; }

        public string modo
        {
            get; set;
        }

        public string versionEFNomina
        {
            get; set;
        }

        public string serieRecibo
        {
            get; set;
        }

        public string folioRecibo
        {
            get; set;
        }

        public DateTime fechaEmision
        {
            get; set;
        }

        public string razonSocialTenedora { get; set; }
        public string leyendaRecibo { get; set; }

        /*** SECCION BLOQUE INFORMATIVO ***/
        public string tituloInformativo { get; set; }
        public string textoInformativo { get; set; }
        public string renglon1Informativo { get; set; }     //usado para No. Lote Carga CopyOfNomina
        public string renglon2Informativo { get; set; }
        public string renglon3Informativo { get; set; }
        public string renglon4Informativo { get; set; }
        public string renglon5Informativo { get; set; }

        /*** SECCION PATRON ***/
        public string registroPatronal { get; set; }
        public string rfcTenedora { get; set; }     //ASIM

        /* Agregado porconceptos extras by; Grabrizz ***/
        public string CP { get; set; }



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
        public DateTime fechaInicioRelLaboral { get; set; }
        public int antiguedad { get; set; }
        public int tipoRegimen { get; set; }    //ASIM
        public string tipoContrato { get; set; }
        public string tipoJornada { get; set; }
        public string periodicidadPago { get; set; }    //ASIM
        public decimal salarioBaseCotApor { get; set; }
        public decimal salarioDiarioIntegrado { get; set; }

        /*** By Grabrizz ***/
        public string tiponomina { get; set; }
        public string sindicalizado { get; set; }

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

        public string CLABE
        { get; set; }

        public string banco
        { get; set; }

        /*** SECCION Agregado porconceptos extras by; Grabrizz ***/
        public string ClaveEntFed
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

        /*** SECCION Deducciones ***/
        public decimal totalOtrossGravado      //ASIM
        { get; set; }

        public decimal totalOtrosExento
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
