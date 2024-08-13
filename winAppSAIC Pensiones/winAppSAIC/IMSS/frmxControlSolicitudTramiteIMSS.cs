using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Principal;
using compIMSS;
using compEmail;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;

namespace winAppSAIC.IMSS
{
    public partial class frmxControlSolicitudTramiteIMSS : DevExpress.XtraEditors.XtraForm
    {
        public frmxControlSolicitudTramiteIMSS()
        {
            InitializeComponent();
        }

        #region "Propiedades Publicas"

        #region "Metodos Propios"

        /// <summary>
        /// Método para mostrar los valores en los controles del Objeto Solicitud Tramite IMSS
        /// </summary>
        /// <param name="objSolicitudTramiteIMSS">Objeto del tipo SolicitudTramite</param>
        private void AsignarInformacionSolicitudTramiteIMSS(SolicitudTramite objSolicitudTramiteIMSS)
        {
            lblFolioSolicitudTramiteIMSS.Text = objSolicitudTramiteIMSS.IdSolicitudTramiteIMSS.ToString();
            txtNoEmpleado.Text = objSolicitudTramiteIMSS.IdEmpleado.ToString();
            txtNSS.Text = objSolicitudTramiteIMSS.NSS;
            txtNombreEmpleado.Text = objSolicitudTramiteIMSS.NombreEmpleadoCompleto;
            txtTipoMovimiento.Text = objSolicitudTramiteIMSS.DescTipoMovimientoSolicitud;
            txtFechaMovimiento.Text = objSolicitudTramiteIMSS.FechaMovimiento.ToShortDateString();
            txtTenedora.Text = objSolicitudTramiteIMSS.NombreComercialTenedora;
            txtCliente.Text = objSolicitudTramiteIMSS.NombreComercialCliente;
            txtOperador.Text = objSolicitudTramiteIMSS.Operador;
            txtSDActual.Value = objSolicitudTramiteIMSS.SalarioDiarioAnterior;
            txtSDNuevo.Value = objSolicitudTramiteIMSS.SalarioDiarioNuevo;
            txtSDAsignado.Value = objSolicitudTramiteIMSS.SalarioDiarioNuevo;
            txtCausaBajaIMSS.Text = objSolicitudTramiteIMSS.DescCausaBajaIMSS;
            txtObservaciones.Text = objSolicitudTramiteIMSS.Observaciones;
            cboEstatusTramiteIMSS.EditValue = objSolicitudTramiteIMSS.IdEstatusMovimientoIMSS;
            calFechaMovimientoNueva.EditValue = objSolicitudTramiteIMSS.FechaMovimiento;    //asignar misma fecha movimiento
        }

        #endregion


        public SolicitudTramite objSolicitudTramiteIMSS { get; set; }

        #endregion

        private void frmxControlSolicitudTramiteIMSS_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dbSAICBPOCatalogosDataSet.vwCatEstatusSolicitudTramiteIMSS' table. You can move, or remove it, as needed.
                this.vwCatEstatusSolicitudTramiteIMSSTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatEstatusSolicitudTramiteIMSS);
                //asignar los valores de la Solicitud en los controles visuales
                AsignarInformacionSolicitudTramiteIMSS(objSolicitudTramiteIMSS);

                switch (objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud)
                {
                    case 8:     //BAJA
                        this.actualizacionesIMSSTableAdapter1.stpInsABREmpleadoCFDI(objSolicitudTramiteIMSS.IdEmpleado, objSolicitudTramiteIMSS.FechaMovimiento, objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud, OperadorBD.OperadorGlobal.NombreUsuario);
                        break;

                    case 9:    //REINGRESO
                        this.actualizacionesIMSSTableAdapter1.stpInsABREmpleadoCFDI(objSolicitudTramiteIMSS.IdEmpleado, objSolicitudTramiteIMSS.FechaMovimiento, objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud, OperadorBD.OperadorGlobal.NombreUsuario);
                        break;

                    case 10:    //ASIGNACION NSS
                        txtSDAsignado.Text = "0";
                        txtSDAsignado.Enabled = false;
                        txtSBCAsignado.Text = "0";
                        txtSBCAsignado.Enabled = false;
                        txtNSSNuevo.BackColor = Color.LightGoldenrodYellow;
                        txtNSSNuevo.Focus();    //colocar cursor en control
                        //calFechaMovimientoNueva.Focus();        
                        break;

                    case 11:    //MODIFICACION SALARIO
                        txtNSSNuevo.Text = "";
                        txtNSSNuevo.Enabled = false;
                        //txtSDAsignado.BackColor = Color.LightGoldenrodYellow;
                        txtSBCAsignado.Value = 0;
                        txtSBCAsignado.BackColor = Color.LightGoldenrodYellow;
                        txtSBCAsignado.Focus();     //colocar cursor en control
                        break;

                }

            }
            catch
            {
            
            }
        }

         private void btnGuardarSolicitud_Click(object sender, EventArgs e)
        {
            //actualiza los cambios
            bool bFlagValido = ActualizarEstatusSolicitudTramite();
 
            //si el cambio fue correcto entonces enviar correo de notificacion
            if (bFlagValido)
            {
                string msjSubject = "Estatus Solicitud Trámite IMSS # " + lblFolioSolicitudTramiteIMSS.Text;
                DateTime dtFechaNueva = Convert.ToDateTime(calFechaMovimientoNueva.EditValue);

                StringBuilder msjHTML = new StringBuilder();
                msjHTML.Append("<HTML>");
                msjHTML.Append("<HEAD>");
                msjHTML.Append("</HEAD>");
                msjHTML.Append("<BODY>");
                msjHTML.Append("<H2>");
                msjHTML.AppendFormat("Reporte Solicitud de Tramite IMSS # {0}",lblFolioSolicitudTramiteIMSS.Text);
                msjHTML.Append("</H2>");
                msjHTML.AppendFormat("<p>La solicitud del empleado No.{0}, {1} ", txtNoEmpleado.Text, txtNombreEmpleado.Text);
                msjHTML.Append("fue procesado y enviamos el siguiente resumen:</p>");
                msjHTML.Append("<p>");
                msjHTML.AppendFormat("-) Tipo de Movimiento: {0}<br>", txtTipoMovimiento.Text);
                msjHTML.AppendFormat("-) Fecha asignada: {0}<br>", dtFechaNueva.ToShortDateString());
                msjHTML.AppendFormat("-) Estatus Trámite IMSS: <b>{0}</b><br>", cboEstatusTramiteIMSS.Text);
                
                if (txtObservacionesNuevo.Text.Trim().Length > 0)
                    msjHTML.AppendFormat("-) Observaciones: {0}", txtObservacionesNuevo.Text);
 
                msjHTML.Append("</p>");
                msjHTML.Append("</BODY>");
                msjHTML.Append("</HTML>");

                winAppSAIC.dbSAICBPOCatalogosDataContext infoNotificacion = new dbSAICBPOCatalogosDataContext();

                //LINQ para Obtener el primer registro
                var objInfo = (from info in infoNotificacion.stpSelInfoConfiguracionNotificaciones("Email Notificacion")
                              select new { info.EmailUser, info.EmailPassword, info.SMTPServer, 
                                  info.Puerto, info.FormatoHTML, info.SSL }).FirstOrDefault();

                if (objInfo != null)        //validar que existan valores del Servidor SMTP
                {
                    splashSMProcesando.ShowWaitForm();  //mostrar pantalla procensando...

                    bool bFlagEnvio = Notificacion.EnviarNotificacionCorreoElectronico(objInfo.SMTPServer, objInfo.EmailUser, objInfo.EmailPassword,
                        objInfo.Puerto, objInfo.FormatoHTML, objInfo.SSL, "oliver.blanco@bpo.mx", msjSubject, 
                        msjHTML.ToString());

                    splashSMProcesando.CloseWaitForm(); //cerrar pantalla procensando...
                    
                    if (bFlagEnvio)
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    else
                        XtraMessageBox.Show("¡No fue posible enviar la notificación por Correo Electrónico al Operador!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    XtraMessageBox.Show("¡No existe información para realizar las Notificaciones por Correo Electrónico!", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);            
                }
            }
        }

         private bool ActualizarEstatusSolicitudTramite()
         {
             bool bFlagValido = false;
             try
             {
                 //en base al tipo de movimiento solicitado, insertar o actualizar informacion en tablas
                 //his.ABREmpleadoCFDI o cat.EmpleadoCFDI
                 if (objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud == 8)    //BAJA
                 {
                     this.actualizacionesIMSSTableAdapter1.stpInsABREmpleadoCFDI(objSolicitudTramiteIMSS.IdEmpleado, objSolicitudTramiteIMSS.FechaMovimiento, objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud, OperadorBD.OperadorGlobal.NombreUsuario);
                    bFlagValido = true;
                 }
                 else if (objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud == 9)    //REINGRESO
                 {
                     this.actualizacionesIMSSTableAdapter1.stpInsABREmpleadoCFDI(objSolicitudTramiteIMSS.IdEmpleado, objSolicitudTramiteIMSS.FechaMovimiento, objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud, OperadorBD.OperadorGlobal.NombreUsuario);
                    bFlagValido = true;
                 }
                 else if (objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud == 10)    //ASIGNACION NSS
                 {
                     //validar el NSS
                    if (Validator.IsValidNSS(txtNSSNuevo, "El NSS", Validator.PatternNNS))
                    {
                        this.actualizacionesIMSSTableAdapter1.stpUpdNSSSolicitudTramiteIMSS(Convert.ToInt32(txtNoEmpleado.Text), txtNSSNuevo.Text.Trim(), Convert.ToDateTime(calFechaMovimientoNueva.EditValue), OperadorBD.OperadorGlobal.NombreUsuario);
                        bFlagValido = true;
                    }
                    else
                        bFlagValido = false;
                 }
                 else if (objSolicitudTramiteIMSS.IdTipoMovimientoSolicitud == 11)      //MODIFICACION DE SALARIO
                 {
                     bFlagValido = true;
                 }

                 //si la actualizacion de los procesos previos
                 //es válido, entonces cambiar estatus de la Solicitud
                 //Tramite IMSS
                 if (bFlagValido)
                 {
                     //actualizar Estatus Solicitud Tramite IMSS
                     this.actualizacionesIMSSTableAdapter1.stpUpdEstatusSolicitudTramiteIMSS(objSolicitudTramiteIMSS.IdSolicitudTramiteIMSS, Convert.ToByte(cboEstatusTramiteIMSS.EditValue), Convert.ToDateTime(calFechaMovimientoNueva.EditValue), txtNSSNuevo.Text.Trim(), Convert.ToDecimal(txtSDAsignado.Value), Convert.ToDecimal(txtSBCAsignado.Value), txtFolioConstanciaIMSS.Text.Trim(), txtObservacionesNuevo.Text.Trim(), OperadorBD.OperadorGlobal.NombreUsuario);
                 }
             }
             catch
             {
                 bFlagValido = false;
             }
             return bFlagValido;
         }
    }
}