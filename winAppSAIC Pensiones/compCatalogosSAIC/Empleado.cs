using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compCatalogosSAIC
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string APaternoEmpleado { get; set; }
        public string AMaternoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public decimal SalarioDiarioContrato { get; set; }
        public decimal SalarioBaseCotizacionContrato { get; set; }
        public decimal SalarioDiarioIntegradoContrato { get; set; }
        public string RazonSocialCliente { get; set; }
        public string TenedoraSA { get; set; }
        public string TenedoraSC { get; set; }
        public string IdTipoMovimiento { get; set; }
        public DateTime FechaIngresoContrato { get; set; }
        public byte IdEstatus { get; set; }
        public Int32 IdTenedoraSA { get; set; }
        public Int32 IdTenedoraSC { get; set; }
        public short IdNacionalidad { get; set; }
        public String Nacionalidad { get; set; }
        public byte IdEstadoCivil { get; set; }
        public String EstadoCivil { get; set; }
        public byte IdSexo { get; set; }
        public String Sexo { get; set; }
        public string PuestoCliente { get; set; }
        public string DepartamentoCliente { get; set; }
        public decimal SalarioDiarioCliente { get; set; }
        public DateTime FechaIngresoCliente { get; set; }
        public byte IdTipoPeriodoNomina { get; set; }
        public string FuncionesEmpleado { get; set; }
        public byte IdTurno { get; set; }
        public string DescJornada { get; set; }
        public string HorarioJornada { get; set; }
        public int IdJornadaServicio { get; set; }
        public String descJornadaServicio { get; set; }
        public string TiempoComidaDescanso { get; set; }
        public byte IdTipoContrato { get; set; }
        public string TiempoContrato { get; set; }
        public string UMF { get; set; }
        public string AutorizacionPermanenteIMSS { get; set; }
        public string NoCreditoInfonavit { get; set; }
        public string BancoDepositoNomina { get; set; }
        public string NoCuentaBanco { get; set; }
        public string NoReferenciaEmpleadoBanco { get; set; }
        public string CLABE { get; set; }
        public string Observaciones { get; set; }
        public string PuestoContrato { get; set; }
        public string DepartamentoContrato { get; set; }
        public DateTime FechaBajaContrato { get; set; }
        public byte IdBasePago { get; set; }
        public byte IdFormaPago { get; set; }
        public byte IdZonaSalario { get; set; }
        public byte IdTipoEmpleado { get; set; }
        public string Expediente { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public string NoDocMigratorio { get; set; }
        public string Profesion { get; set; }
        public byte IdEstatusJuridico { get; set; }
        public string CorreoElectronico { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public bool EstatusINFONAVIT { get; set; }
        public Int32 IdParametroPagoInfonavit { get; set; }
        public Int32 IdTipoFactorDescuento { get; set; }
        public Int32 IdTipoUnidadMedidaPago { get; set; }
        public DateTime FechaSalario { get; set; }
        public decimal ValorTipoPago { get; set; }
        public decimal FactorDescuento { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoDescuentoDiario { get; set; }
        public decimal MontoDescuentoPeriodo { get; set; }
        public DateTime FechaInicioDesc { get; set; }
        public DateTime FechaFinDesc { get; set; }
        public decimal MontoRecuperar { get; set; }
        public decimal MontoRecuperado { get; set; }
        public decimal Saldo { get; set; }

        public Int32 IdCliente { get; set; }
        public int IdEmpleadoPoliza { get; set; }
        public Int32 IdTipoSeguro { get; set; }
        public Int32 IdPoliza { get; set; }
        public Int32 IdMatrizCliente { get; set; }

        public int ConDocumentacion { get; set; }
        public DateTime VigenciaContrato { get; set; }
        public int IdConceptoBaja { get; set; }


        public int IdTipoIdentificacion { get; set; }
        public String TipoIdentificacion { get; set; }
        public String AutoridadExpide { get; set; }
        public String NumeroIdentificacion { get; set; }

        public decimal Vacaciones { get; set; }
        public decimal PrimaVacacional { get; set; }
        public decimal Aguinaldo { get; set; }
        public String ConceptoContratacion { get; set; }
        public String HerramientasTrabajo { get; set; }
        public String InformacionConfidencial { get; set; }

        public String ObservacionesBaja { get; set; }

        public DateTime FechaInicioContrato { get; set; }
        public Boolean ContratoFirmado { get; set; }

        public int NumSolicitudAlta { get; set; }

        public int NumSolicitudBaja { get; set; }

        public long idDireccion_CT { get; set; }
        public String Calle_CT { get; set; }
        public String NoExterior_CT { get; set; }
        public String NoInterior_CT { get; set; }
        public String Colonia_CT { get; set; }
        public String CodigoPostal_CT { get; set; }
        public String NombreDelegacionMunicipio_CT { get; set; }
        public String NombrePoblacionCiudad_CT { get; set; }
        public String Telefono1_CT { get; set; }
        public String Telefono2_CT { get; set; }
        public int IdEstado_CT { get; set; }

        public long idDireccion_DP { get; set; }
        public String Calle_DP { get; set; }
        public String NoExterior_DP { get; set; }
        public String NoInterior_DP { get; set; }
        public String Colonia_DP { get; set; }
        public String CodigoPostal_DP { get; set; }
        public String NombreDelegacionMunicipio_DP { get; set; }
        public String NombrePoblacionCiudad_DP { get; set; }
        public String Telefono1_DP { get; set; }
        public String Telefono2_DP { get; set; }
        public int IdEstado_DP { get; set; }
        public String Folio_Poliza { get; set; }

        public int IdMatrizTenedora { get; set; }
        public String CentroDeCosto { get; set; }

        public long idDireccion_Fiscal { get; set; }
        public String CodigoPostal_Fiscal { get; set; }
        public int IdEstadoDomicilioFiscal { get; set; }

        public String Sindicalizado { get; set; }

        public decimal dcParteVariable { get; set; }
        public int idSolicitudParteVariable { get; set; }


        /*Campos para Descuentos*/

        public int IdTipoDescuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal MontoD { get; set; }
        public string ObservacionesD { get; set; }
        public byte IdEstatusD { get; set; }
        public Int64 IdEmpleadoDescuento { get; set; }
    }
}
