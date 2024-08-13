using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace compNominaCFDI
{
    public static class NominaBD
    {
        public static Decimal ImporteDetalleGravado { get; set; }
        public static Decimal ImporteDetalleExento { get; set; }
        public static Decimal ImporteDetalleGravadoPercepcion { get; set; }
        public static Decimal ImporteDetalleExentoPercepcion { get; set; }
        public static Decimal ImporteDetalleGravadoDeduccion { get; set; }
        public static Decimal ImporteDetalleExentoDeduccion { get; set; }
        public static Decimal ImporteDetalleGravadoJubil { get; set; }
        public static Decimal  ImporteDetalleExentoJubil { get; set; }
        public static Decimal ImporteDetalleGravadoOtro { get; set; }
        public static Decimal ImporteDetalleExentoOtro { get; set; }
        public static Decimal ImporteDetalleGravadoSeparacionIn { get; set; }
        public static Decimal ImporteDetalleExentoSeparacionIn { get; set; }
        public static Decimal ImporteDetalleGravadoDeduccionSAT { get; set; }
        public static Decimal ImporteDetalleExentoDeduccionSAT { get; set; }

        /// <summary>
        /// Método para obtener la información Encabezado del Lote de Nómina
        /// seleccionado
        /// </summary>
        /// <param name="objTable">Objeto de Tipo DataTable</param>
        /// <returns>Objeto List Nomina</returns>
        public static List<Nomina> ObtenerEncabezadoNominas2XML(DataTable objTable)
        {
            List<Nomina> objNominaList = new List<Nomina>();
            Nomina objNomina = null;
            ImporteDetalleGravado = 0;
            ImporteDetalleExento = 0;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objNomina = new Nomina();
                    objNomina.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                    objNomina.IdPDOHeader = (long)row["IdPDOHeader"];
                    objNomina.modo = row["modo"].ToString();
                    objNomina.versionEFNomina = row["versionEFNomina"].ToString();
                    objNomina.serieRecibo = row["SerieRecibo"].ToString();
                    objNomina.folioRecibo = row["IdPDOHeader"].ToString();
                    objNomina.fechaEmision = Convert.ToDateTime(row["FechaEmision"]); 
                    objNomina.registroPatronal = row["RegistroPatronal"].ToString(); 
                    objNomina.rfcTenedora = row["RFCTenedora"].ToString(); 
                    objNomina.empresa = row["EmpresaCliente"].ToString();
                    objNomina.nombre = row["Nombre"].ToString();
                    objNomina.apellidoPaterno = row["ApellidoPaterno"].ToString();
                    objNomina.apellidoMaterno = row["ApellidoMaterno"].ToString();
                    objNomina.rfc = row["RFCEmpleado"].ToString();
                    objNomina.curp = row["CURPEmpleado"].ToString();
                    objNomina.numSeguridadSocial = row["NSSEmpleado"].ToString();
                    objNomina.numEmpleado = row["NoEmpleado"].ToString();
                    objNomina.departamento = row["Departamento"].ToString();
                    objNomina.puesto = row["Puesto"].ToString();
                    objNomina.riesgoPuesto = row["RiesgoIMSS"].ToString();
                    objNomina.fechaInicioRelLaboral = Convert.ToDateTime(row["FechaInicioRelLaboral"]);
                    objNomina.antiguedad = Convert.ToInt32(row["AntiguedadSemanas"]);
                    objNomina.tipoRegimen = Convert.ToInt32(row["TipoRegimen"]);
                    objNomina.tipoContrato = row["TipoContrato"].ToString();
                    objNomina.tipoJornada = row["TipoJornada"].ToString();
                    objNomina.periodicidadPago = row["TipoNomina"].ToString();
                    objNomina.salarioBaseCotApor = (decimal)row["SBC"];
                    objNomina.salarioDiarioIntegrado = (decimal)row["SDI"];
                    objNomina.fechaPago = Convert.ToDateTime(row["FechaPago"]);
                    objNomina.fechaInicialPago = Convert.ToDateTime(row["FechaInicialPago"]);
                    objNomina.fechaFinalPago = Convert.ToDateTime(row["FechaFinalPago"]);
                    objNomina.numDiasPagados = (decimal)row["NoDiasPagados"];
                    objNomina.numDiasFaltasJus =Convert.ToDecimal(row["NoFaltaJustificada"].ToString());
                    objNomina.numDiasFaltasInJus = Convert.ToDecimal(row["NoFaltaInjustificada"].ToString());
                    objNomina.montoPagado = (decimal)row["MontoPagado"];
                    objNomina.importeConLetra = row["ImporteConLetra"].ToString();
                    objNomina.tipoMoneda = row["TipoMoneda"].ToString();
                    objNomina.tipoCambio = (decimal)row["TipoCambio"];
                    objNomina.CLABE = row["CLABE"].ToString();
                    objNomina.banco = row["Banco"].ToString();
                    objNomina.diasIncapacidad = row["NoDiasIncapacidad"].ToString();
                    objNomina.tipoIncapacidad = row["TipoIncapacidad"].ToString();
                    objNomina.descuento = (decimal)row["DescuentoIncapacidad"];
                    objNomina.diasHrsDobles = Convert.ToInt32(row["NoDiasHrsDobles"]);
                    objNomina.horasDoblesExtra = (decimal)row["NoHrsDobles"];
                    objNomina.importeHrsDoblesPagado = (decimal)row["ImporteHrsDobles"];
                    objNomina.diasHrsTriples = Convert.ToInt32(row["NoDiasHrsTriples"]);
                    objNomina.horasTriplesExtra = (decimal)row["NoHrsTriples"];
                    objNomina.importeHrsTriplesPagado = (decimal)row["ImporteHrsTriples"];
                    objNomina.razonSocialTenedora = row["RazonSocialTenedora"].ToString();
                    objNomina.leyendaRecibo = row["LeyendaRecibo"].ToString();
                    objNomina.totalPercepcionesGravado = 0.00M;
                    objNomina.totalPercepcionesExento = 0.00M;
                    objNomina.totalDeduccionesGravado = 0.00M;
                    objNomina.totalDeduccionesExento = 0.00M;                    
                    objNomina.totalOtrosExento = 0.00M;
                    objNomina.totalOtrossGravado = 0.00M;
                    objNomina.TipoNominaSAT = row["TipoNominaSAT"].ToString();
                    objNomina.RFCEmisor = row["RFCEmisor"].ToString();
                    objNomina.CURPEmisor = row["CURPEmisor"].ToString();
                    objNomina.SindicalizadoSAT = row["SindicalizadoSAT"].ToString();
                    objNomina.IdTipoContratoSAT =row["IdTipoContratoSAT"].ToString();
                    objNomina.IdTipoJornadaSAT = row["IdTipoJornadaSAT"].ToString();
                    objNomina.IdRegimenFiscalEmpleadoSAT =row["IdRegimenFiscalEmpleadoSAT"].ToString();
                    objNomina.EntidadFederativaTrabajo = row["EntidadFederativaTrabajo"].ToString();
                    objNomina.metodoDePago = row["metodoDePago"].ToString();
                    objNomina.anosServicio = Convert.ToInt32(row["anosServicio"].ToString());
                    objNomina.ultimoSueldoMensOrd = (decimal)row["ultimoSueldoMensOrd"];
                    objNomina.IdClienteAlterno = Convert.ToInt32(row["IdClienteAlterno"].ToString());
                    objNomina.ISRCausadoSAT = (decimal)row["ISRCausadoSAT"];
                    objNomina.SubsidioCausadoSAT = (decimal)row["SubsidioCausadoSAT"];
                    objNomina.IdPeriodicidadPagoSAT = row["IdPeriodicidadPagoSAT"].ToString();
                    objNomina.CodigoPostalTenedora = row["CodigoPostalTenedora"].ToString();
                    //***********RUTAS CERTIFICADO Y KEY
                    objNomina.Certificado = (byte[])row["Certificado"];
                    objNomina.CertificadoPen = (byte[])row["CertificadoPen"];
                    objNomina.CertificadoCadena = row["CertificadoCadena"].ToString();
                    objNomina.NoCertificado = row["NoCertificado"].ToString();
                    objNomina.Key = (byte[])row["Key"];
                    objNomina.KeyPen = (byte[])row["KeyPen"];
                    objNomina.KeyEnc = (byte[])row["KeyEnc"];
                    objNomina.ContrasenaKey = row["ContrasenaKey"].ToString();
                    objNomina.Usuario = row["Usuario"].ToString();
                    objNomina.Password = row["Password"].ToString();
                    objNomina.RegimenFiscalSAT = row["IdRegimenFiscalSAT"].ToString();
                    //**********************************

                    objNomina.CodigoPostalCliente = row["CodigoPostalCliente"].ToString();
                    objNomina.RegimenFiscalSATCliente = row["IdRegimenFiscalSATCliente"].ToString();
                    objNomina.UsoCFDI = row["UsoCFDI"].ToString();
                    objNomina.ObjetiImp = row["ObjetoImp"].ToString();
                    objNomina.Exportacion = row["Exportacion"].ToString();                    

                    objNominaList.Add(objNomina);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNominaList;
        }

        /// <summary>
        /// Método para obtener la información Encabezado del Lote de Nómina
        /// seleccionado para Cancelacion XML CFDI
        /// </summary>
        /// <param name="objTable">Objeto de Tipo DataTable</param>
        /// <returns>Objeto List NominaCancelacion</returns>
        public static List<NominaCancelacion> ObtenerEncabezadoNominasCancelacion2XML(DataTable objTable)
        {
            List<NominaCancelacion> objNominaList = new List<NominaCancelacion>();
            NominaCancelacion objNomina = null;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objNomina = new NominaCancelacion();
                    objNomina.IdLoteCargaNomina = (long)row["IdLoteCargaNomina"];
                    objNomina.FolioLoteCargaNomina = row["FolioLoteCargaNomina"].ToString();
                    objNomina.IdPDOHeaderCFDI = (long)row["IdPDOHeaderCFDI"];
                    objNomina.IdPDOHeader = (long)row["IdPDOHeader"];
                    objNomina.accion = row["accion"].ToString();
                    objNomina.modo = row["modo"].ToString();
                    objNomina.justificacion = row["justificacion"].ToString();
                    objNomina.serieRecibo = row["SerieRecibo"].ToString();
                    objNomina.folioRecibo = row["FolioRecibo"].ToString();
                    objNomina.fechaEmision = Convert.ToDateTime(row["FechaEmision"]);
                    objNomina.registroPatronal = row["RegistroPatronal"].ToString();
                    objNomina.rfcTenedora = row["RFCTenedora"].ToString();
                    objNomina.apellidoPaterno = row["APaternoEmpleado"].ToString();
                    objNomina.apellidoMaterno = row["AMaternoEmpleado"].ToString();
                    objNomina.nombre = row["NombreEmpleado"].ToString();
                    objNomina.rfc = row["RFC"].ToString();
                    objNomina.curp = row["CURP"].ToString();
                    objNomina.numSeguridadSocial = row["NSS"].ToString();
                    objNomina.numEmpleado = row["NoEmpleado"].ToString();
                    objNomina.departamento = row["Departamento"].ToString();
                    objNomina.puesto = row["Puesto"].ToString();
                    objNomina.riesgoPuesto = row["RiesgoIMSS"].ToString();
                    objNomina.fechaInicioRelLaboral = Convert.ToDateTime(row["FechaInicioRelLaboral"]);
                    objNomina.antiguedad = Convert.ToInt32(row["AntiguedadSemanas"]);
                    objNomina.tipoRegimen = Convert.ToInt32(row["TipoRegimen"]);
                    objNomina.tipoContrato = row["TipoContrato"].ToString();
                    objNomina.tipoJornada = row["TipoJornada"].ToString();
                    objNomina.periodicidadPago = row["TipoNomina"].ToString();
                    objNomina.salarioBaseCotApor = (decimal)row["SBC"];
                    objNomina.salarioDiarioIntegrado = (decimal)row["SDI"];
                    objNomina.fechaPago = Convert.ToDateTime(row["FechaPago"]);
                    objNomina.fechaInicialPago = Convert.ToDateTime(row["FechaInicialPago"]);
                    objNomina.fechaFinalPago = Convert.ToDateTime(row["FechaFinalPago"]);
                    objNomina.numDiasPagados = (decimal)row["NoDiasPagados"];
                    objNomina.montoPagado = (decimal)row["MontoPagado"];
                    objNomina.importeConLetra = row["ImporteConLetra"].ToString();
                    objNomina.tipoMoneda = row["TipoMoneda"].ToString();
                    objNomina.tipoCambio = (decimal)row["TipoCambio"];
                    objNomina.CLABE = row["CLABE"].ToString();
                    objNomina.banco = row["Banco"].ToString();
                    objNomina.estatusDocumento = row["EstatusDocumento"].ToString();
                    objNomina.folioFiscalUUID = row["FolioFiscalUUID"].ToString();
                    objNomina.fechaGeneracionCFDI = Convert.ToDateTime(row["FechaGeneracionCFDI"]);
                    objNomina.fechaTFD = Convert.ToDateTime(row["FechaTFD"]);
                    objNomina.estadoCFDI = row["EstadoCFDI"].ToString();
                    objNomina.Motivo = row["Motivo"].ToString();
                    objNominaList.Add(objNomina);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNominaList;
        }

        
        /// <summary>
        /// Método que obtiene una lista con los registros de Percepciones/Deducciones
        /// </summary>
        /// <param name="objTable">Objeto DataTable</param>
        /// <returns>Lista de Objetos Percepcion/Deduccion</returns>
        public static List<PercepcionDeduccion> ObtenerDetallePercepciones2XML(DataTable objTable, string pIdTipoMovimiento)
        {
            List<PercepcionDeduccion> objPercepcionDeduccionList = new List<PercepcionDeduccion>();
            PercepcionDeduccion objPercepcionDeduccion = null;
            ImporteDetalleGravadoPercepcion = 0;
            ImporteDetalleExentoPercepcion = 0;
            ImporteDetalleGravadoDeduccion = 0;
            ImporteDetalleExentoDeduccion = 0;
            ImporteDetalleGravadoOtro = 0;
            ImporteDetalleExentoOtro = 0;
            ImporteDetalleGravadoJubil = 0;
            ImporteDetalleExentoJubil = 0;
            ImporteDetalleGravadoSeparacionIn = 0;
            ImporteDetalleExentoSeparacionIn = 0;
            ImporteDetalleGravadoDeduccionSAT = 0;
            ImporteDetalleExentoDeduccionSAT = 0;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objPercepcionDeduccion = new PercepcionDeduccion();
                    objPercepcionDeduccion.IdPDODetail = (long)row["IdPDODetail"];
                    objPercepcionDeduccion.tipoPercepcionDeduccion = row["ClaveConceptoCFDI"].ToString();
                    objPercepcionDeduccion.IdConcepto = Convert.ToInt32(row["IdConcepto"]);
                    
                    if (pIdTipoMovimiento.Equals("D"))
                        objPercepcionDeduccion.clave = row["CuentaContableSueldos"].ToString();     //cuenta Sueldos y Salarios
                    else
                        objPercepcionDeduccion.clave = row["CuentaContableAsimilados"].ToString();  //cuenta Asimilados

                    objPercepcionDeduccion.concepto= row["DescConcepto"].ToString();
                    objPercepcionDeduccion.importePDO = (decimal)row["MontoPDO"];
                    objPercepcionDeduccion.importeGravado = (decimal)row["MontoPDOGravado"];
                    objPercepcionDeduccion.importeExento = (decimal)row["MontoPDOExento"];
                    objPercepcionDeduccion.IdPDOHeader = (long)row["IdPDOHeader"];
                    objPercepcionDeduccion.ClasifConcepto = row["ClasifConcepto"].ToString();
                    objPercepcionDeduccion.AplicaOtrosPagosSAT = Convert.ToInt32(row["AplicaOtrosPagosSAT"]);
                    //si es percepcion acumular monto
                    if (objPercepcionDeduccion.ClasifConcepto.Equals("P") && objPercepcionDeduccion.AplicaOtrosPagosSAT == 0 && (objPercepcionDeduccion.tipoPercepcionDeduccion.Equals("022") || objPercepcionDeduccion.tipoPercepcionDeduccion.Equals("023") || objPercepcionDeduccion.tipoPercepcionDeduccion.Equals("025")))
                    {
                        ImporteDetalleGravadoSeparacionIn += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoSeparacionIn += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }
                    else if(objPercepcionDeduccion.ClasifConcepto.Equals("P") && objPercepcionDeduccion.AplicaOtrosPagosSAT == 0)
                    {
                        ImporteDetalleGravadoPercepcion += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoPercepcion += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }else if (objPercepcionDeduccion.ClasifConcepto.Equals("P") && objPercepcionDeduccion.AplicaOtrosPagosSAT == 1)
                    {
                        ImporteDetalleGravadoOtro += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoOtro += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }
                    else if (objPercepcionDeduccion.ClasifConcepto.Equals("AP"))
                    {
                        ImporteDetalleGravadoJubil += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoJubil += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }
                    else if(objPercepcionDeduccion.ClasifConcepto.Equals("D") && objPercepcionDeduccion.tipoPercepcionDeduccion.Equals("002"))
                    {
                        ImporteDetalleGravadoDeduccionSAT += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoDeduccionSAT += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }
                    else  //si es deduccion acumular monto
                    {
                        ImporteDetalleGravadoDeduccion += (decimal)row["MontoPDOGravado"];  //acumula importe Gravado
                        ImporteDetalleExentoDeduccion += (decimal)row["MontoPDOExento"];  //acumula importe Exento
                    }
                    objPercepcionDeduccionList.Add(objPercepcionDeduccion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objPercepcionDeduccionList;
        }

        /// <summary>
        /// Método que obtiene una lista con los registros de Deducciones
        /// </summary>
        /// <param name="objTable">Objeto DataTable</param>
        /// <returns>Lista de Objetos Deduccion</returns>
        public static List<Deduccion> ObtenerDetalleDeducciones(DataTable objTable)
        {
            List<Deduccion> objDeduccionList = new List<Deduccion>();
            Deduccion objDeduccion = null;
            ImporteDetalleGravado = 0;
            ImporteDetalleExento = 0;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objDeduccion = new Deduccion();
                    objDeduccion.tipoDeduccion = row[0].ToString();
                    objDeduccion.clave = row[1].ToString();
                    objDeduccion.concepto = row[2].ToString();
                    objDeduccion.importeGravado = (decimal)row[3];
                    objDeduccion.importeExento = (decimal)row[4];
                    ImporteDetalleGravado += (decimal)row[3];  //acumula importe Gravado
                    ImporteDetalleExento += (decimal)row[4];  //acumula importe Exento
                    objDeduccionList.Add(objDeduccion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDeduccionList;
        }


        /// <summary>
        /// Método para obtener el Estatus Nómina del Lote de Nómina seleccionado
        /// </summary>
        /// <param name="objTable">Objeto de Tipo DataTable</param>
        /// <returns>Objeto List EstatusNomina</returns>
        public static EstatusNomina ObtenerEstatusNominaSueldosVsTimbrado(DataTable objTable)
        {
            EstatusNomina objNomina = null;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objNomina = new EstatusNomina();
                    objNomina.noEmpleadosNomina = (decimal)row["NoEmpleadosNomina"];
                    objNomina.noEmpleadosTimbrados = (decimal)row["NoEmpleadosTimbrados"];
                    objNomina.noEmpleadosPorTimbrar = (decimal)row["noEmpleadosPorTimbrar"];
                    objNomina.noEmpleadosCancelados = (decimal)row["NoEmpleadosCancelados"];
                    objNomina.pctEmpleadosTimbrados = (decimal)row["PctEmpleadosTimbrados"];
                    objNomina.pctEmpleadosPorTimbrar = (decimal)row["PctEmpleadosPorTimbrar"];
                    objNomina.leyendaEstatusNominaSueldosVsTimbrado = row["LeyendaEstatusNominaSueldosVsTimbrado"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNomina;
        }

        /// <summary>
        /// Método para mostrar Resumen de la Nómina Vs Timbrados, de un Lote de Nomina seleccionado
        /// </summary>
        ///  <param name = "pIdLoteCargaNomina" > No.Lote de Nómina</param>
        public static EstatusNominaOperador ObtenerEstatusNominaSueldosVsTimbradoOperador(DataTable objTable)
        {
            EstatusNominaOperador objNomina = null;

            try
            {
                foreach (DataRow row in objTable.Rows)
                {
                    objNomina = new EstatusNominaOperador();
                    objNomina.NoEmpleadosNomina = Convert.ToDecimal(row["NoEmpleadosNomina"].ToString());
                    objNomina.NoEmpleadosATimbrar = Convert.ToDecimal(row["NoEmpleadosATimbrar"].ToString());
                    objNomina.NoEmpleadosTimbrados = Convert.ToDecimal(row["NoEmpleadosTimbrados"].ToString());
                    objNomina.NoEmpleadosXTimbrar = Convert.ToDecimal(row["NoEmpleadosXTimbrar"].ToString());
                    objNomina.pctEmpleadosTimbrar = Convert.ToDecimal(row["pctEmpleadosTimbrar"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objNomina;
        }

    }
}
