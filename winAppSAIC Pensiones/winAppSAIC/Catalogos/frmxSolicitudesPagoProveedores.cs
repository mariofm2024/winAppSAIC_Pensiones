using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static winAppSAIC.tools.dsc;
//using DevExpress.XtraEditors;
using winAppSAIC.UtileriasLocal;
using compCatalogosSAIC;
using compLibreriaSAIC;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;



namespace winAppSAIC.Catalogos
{
    public partial class frmxSolicitudesPagoProveedores : Form
    {
        private int IdOperador = OperadorBD.OperadorGlobal.IdOperador;
        private int IdAreaOperativa = OperadorBD.OperadorGlobal.IdAreaOperativa;
        private String Usuario = OperadorBD.OperadorGlobal.NombreUsuario;
        private int ProcesoMN = 0; // 1 N 0 M
        private int ProcesoDN = 0; // 1 N 0 M
        private int Nueva = 0;

        public frmxSolicitudesPagoProveedores()
        {
            InitializeComponent();



        }

        private DataTable FiltraArea(DataTable dtMaestroSolicitudes)
        {
            //int AreaOperativa;
            //int.TryParse(IdAreaOperativa, out AreaOperativa);

            //if (dtMaestroSolicitudes != null)

            //{
            
                DataTable dtMaestroSolicitudes_temp = dtMaestroSolicitudes.Clone();
            
                
            //var query = from x in dtMaestroSolicitudes.AsEnumerable()
            //            where x.Field<Int32>("IdAreaOperativa").Equals(IdAreaOperativa)
            //            select x;

            if (IdAreaOperativa != 4 && IdAreaOperativa != 1)
            {


                //////var query = (from x in dtMaestroSolicitudes.AsEnumerable()
                //////             where x.Field<Int32>("IdAreaOperativa").Equals(IdAreaOperativa)
                //////             select x).CopyToDataTable();

                var query = from x in dtMaestroSolicitudes.AsEnumerable()
                            where x.Field<Int32>("IdAreaOperativa").Equals(IdAreaOperativa)
                            select x;



                ////DataTable dtTemp = (DataTable)query;
                ////return dtTemp;

                if (query.Count() == 0)
                {
                    dtMaestroSolicitudes_temp.Clear();
                    return dtMaestroSolicitudes_temp;
                }
                else
                {
                    //DataTable orderTable = query.CopyToDataTable();

                    DataTable dtTemp = query.CopyToDataTable();
                    return dtTemp;
                }

                   //return dtMaestroSolicitudes_temp;



            }
            else {
                return dtMaestroSolicitudes;
            }
            


            //    if (dtTemp.Rows.Count > 0)
            //    {
            //        dtMaestroSolicitudes_temp = query.CopyToDataTable();
            //    }
            //    return dtMaestroSolicitudes_temp;
            //}
            //else
            //{
            
            //}

        }


        private void CargaEstatusSolicitud()
        {
            DataTable EstatusSolicitudes = stpSelEstatusTableAdapter1.GetData();

            //gdEstatusSolicitud.Properties.DataSource = FiltraEstatus(EstatusSolicitudes);
            //gdSolicitudesHead.DataSource = FiltraArea(DTHeaderSolicitudes);



        }

        public class EstatusPagos
        {
            public int IdEstatus { get; set; }
            public string DescEstatus { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gdEstatusSolicitud.Properties.DisplayMember = "DescEstatus";
            gdEstatusSolicitud.Properties.ValueMember = "IdEstatus";
            gdEstatusSolicitud.Properties.DataSource = CargaEstatus("15");
            var firstValue1 = gdEstatusSolicitud.Properties.GetKeyValue(0);
            gdEstatusSolicitud.EditValue = firstValue1;
        }

        //private DataTable FiltraEstatus(DataTable dtEstatusSolicitudes)
        //{
        //    //int AreaOperativa;
        //    //AreaOperativa = 2;
        //    //int.TryParse(IdAreaOperativa, out AreaOperativa);

        //    //var myInClause = new int[] {1,2};

        //    List<EstatusPagos> EstatusPagos = new List<EstatusPagos>();

        //    EstatusPagos estatuspagos = new EstatusPagos();
        //    estatuspagos.IdEstatus = 1; //Convert.ToInt32(row["Id"]);
        //    estatuspagos.DescEstatus = "N/D"; // row["Name"].ToString();
        //    EstatusPagos.Add(estatuspagos);

        //    //EstatusPagos estatuspagos = new EstatusPagos();
        //    estatuspagos.IdEstatus = 2; //Convert.ToInt32(row["Id"]);
        //    estatuspagos.DescEstatus = "ACTIVO"; // row["Name"].ToString();
        //    EstatusPagos.Add(estatuspagos);

        //    estatuspagos.IdEstatus = 2; //Convert.ToInt32(row["Id"]);
        //    estatuspagos.DescEstatus = "INACTIVO"; // row["Name"].ToString();
        //    EstatusPagos.Add(estatuspagos);

        //    //DataTable dtEstatus = new DataTable();
        //    //dtEstatus.Columns.Add("IdEstatus", typeof(int));
        //    //dtEstatus.Columns.Add("DescEstatus", typeof(string));



        //    var myInClause = new List<int> {1};


        //    //var myInClause = new string[] { "CHEQUE CANCELADO", "CHEQUE COBRADO" };

        //    //if (dtEstatusSolicitudes != null)
        //    //{
        //        DataTable dtEstatusSolicitudes_temp = dtEstatusSolicitudes.Clone();


        //    var filteredResults = from employee in EstatusPagos
        //                          where employee.IdEstatus  1
        //                          select employee.IdEstatus;


        //    //if (dtEstatusSolicitudes != null)
        //    //{
        //    //DataTable dtEstatusSolicitudes_temp = dtEstatusSolicitudes.Clone();

        //    //var query = (from d in EstatusPagos
        //    //            select d.IdEstatus).Contains(tinyintComparison);

        //    //DataTable DtTemp = query.CopyToDataTable();

        //    //DataTable boundTable = query.CopyToDataTable<DataRow>();


        //    //    if (query.Count() > 0)
        //    //    {
        //    //        //dtEstatusSolicitudes_temp = query.CopyToDataTable();
        //    //        return dtEstatusSolicitudes_temp;
        //    //    }
        //    //    return dtEstatusSolicitudes_temp;
        //    //}
        //    //else
        //    //{
        //    return dtEstatusSolicitudes;
        //        //}

        //        //var myInClause = new string[] { "CHEQUE CANCELADO", "CHEQUE COBRADO" };

        //        //if (dtEstatusSolicitudes != null)
        //        //{
        //        //    DataTable dtEstatusSolicitudes_temp = dtEstatusSolicitudes.Clone();

        //        //    var query = dtEstatusSolicitudes.AsEnumerable()
        //        //    .Where(p => myInClause.Contains(p.Field<string>("DescEstatus")))
        //        //       .ToList();

        //        //    if (query.Count() > 0)
        //        //    {
        //        //        dtEstatusSolicitudes_temp = query.CopyToDataTable();
        //        //    }
        //        //    return dtEstatusSolicitudes_temp;
        //        //}
        //        //else
        //        //{
        //        //    return dtEstatusSolicitudes;
        //        //}

        //    }


        private void CargarAreaCmb(int lIdArea)
        {
            cmbArea.Properties.DataSource = stpAreaOpTipoPagoProvTableAdapter1.GetData(1, lIdArea);
            cmbArea.Properties.DisplayMember = "Descripcion";
            cmbArea.Properties.ValueMember = "Id";
            var firstValue1 = cmbArea.Properties.GetKeyValue(0);
            cmbArea.EditValue = firstValue1;
        }
        private void frmxSolicitudesPagoProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbSAIC_Catalogos.stpSelSolicitudPagoProveedHeader' Puede moverla o quitarla según sea necesario.
            this.stpSelSolicitudPagoProveedHeaderTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelSolicitudPagoProveedHeader);
            // TODO: esta línea de código carga datos en la tabla 'dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor' Puede moverla o quitarla según sea necesario.
            this.vwHeadSolicitudPagoProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor);
            // TODO: esta línea de código carga datos en la tabla 'dbSAICBPOCatalogosDataSet.vwCatTenedoraMatriz' Puede moverla o quitarla según sea necesario.
            //////this.vwCatTenedoraMatrizTableAdapter.Fill(this.dbSAICBPOCatalogosDataSet.vwCatTenedoraMatriz);

            this.stpSelEstatusTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstatus);


            DataTable DTHeaderSolicitudes = stpSelSolicitudPagoProveedHeaderTableAdapter.GetData();



                if (OperadorBD.OperadorGlobal.IdAreaOperativa != 4 && OperadorBD.OperadorGlobal.IdAreaOperativa != 1)
                {
                    gdSolicitudesHead.DataSource = FiltraArea(DTHeaderSolicitudes);
                }
                else
                {
                    gdSolicitudesHead.DataSource = DTHeaderSolicitudes;
                }



            //gdSolicitudesHead.DataSource = DTHeaderSolicitudes;

            txtIdAreaOperativa.Text = OperadorBD.OperadorGlobal.NombreUsuario;

            txtDato.Text = OperadorBD.OperadorGlobal.IdAreaOperativa.ToString();

            CargarAreaCmb(IdAreaOperativa);


            dtFechaSolicitud.EditValue = DateTime.Now.Date;

            gdTipoPagoProveedor.Properties.DataSource = stpAreaOpTipoPagoProvTableAdapter1.GetData(2, IdAreaOperativa);
            gdTipoPagoProveedor.Properties.DisplayMember = "Descripcion";
            gdTipoPagoProveedor.Properties.ValueMember = "Id";
            var firstValue2 = gdTipoPagoProveedor.Properties.GetKeyValue(0);
            gdTipoPagoProveedor.EditValue = firstValue2;

            gdEmpresaDPago.Properties.DataSource = stpAreaOpTipoPagoProvTableAdapter1.GetData(3, 0);
            gdEmpresaDPago.Properties.DisplayMember = "Descripcion";
            gdEmpresaDPago.Properties.ValueMember = "Id";
            var firstValue3 = gdEmpresaDPago.Properties.GetKeyValue(0);
            gdEmpresaDPago.EditValue = firstValue3;

            gdCliente.Properties.DataSource = stpAreaOpTipoPagoProvTableAdapter1.GetData(4, 0);
            gdCliente.Properties.DisplayMember = "Descripcion";
            gdCliente.Properties.ValueMember = "Id";
            var firstValue4 = gdCliente.Properties.GetKeyValue(0);
            gdCliente.EditValue = firstValue4;

            //MAFM






            //GpoDetControlGasto.Enabled = false;
            btnGuardarSol.Enabled = false;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Limpiar combos

            //Habilitar
            //gpoSolicitud.Enabled = true;
            string lIdSolicitudInicial;
            lIdSolicitudInicial = "15";
            LimpiaGpoSolicitud();
            LimpiaDetSolicitud();

            ProcesoMN = 1;
            btnGuardarSol.Enabled = true;
            //GpoDetControlGasto.Enabled = false;
            //gdSolicitudesDetail = Null;
            int IdSolicitud = 0;
            //IdSolicitud = objDetSolicitudPagoProveedores.IdSolicitud;
            ActualizarGridDetalleSol(IdSolicitud, lIdSolicitudInicial);

            CargarEstatusSolicitud(lIdSolicitudInicial);
            CargarEstatusDetallePagos(lIdSolicitudInicial);

            gdEstatusSolicitud.Enabled = false;
            gdEstatusPago.Enabled = false;
            CmdGuardaPago.Enabled = false;


            btnGuardarSol.Focus();

        }
        private void CargarEstatusSolicitud(string Ids)
        {
            gdEstatusSolicitud.Properties.DisplayMember = "DescEstatus";
            gdEstatusSolicitud.Properties.ValueMember = "IdEstatus";
            gdEstatusSolicitud.Properties.DataSource = CargaEstatus(Ids);
            var firstValue1 = gdEstatusSolicitud.Properties.GetKeyValue(0);
            gdEstatusSolicitud.EditValue = firstValue1;
        }

        private void CargarEstatusDetallePagos(string Ids)
        {
            gdEstatusPago.Properties.DisplayMember = "DescEstatus";
            gdEstatusPago.Properties.ValueMember = "IdEstatus";
            gdEstatusPago.Properties.DataSource = CargaEstatus(Ids);
            var firstValue1 = gdEstatusPago.Properties.GetKeyValue(0);
            gdEstatusPago.EditValue = firstValue1;
        }

        private void habilitaCompSolicitud(bool Activo)
        {
            //TxtSolicitud.Enabled = Activo;
            //cmbArea.Enabled = Activo;
            //dtFechaSolicitud.Enabled = Activo;
            if (OperadorBD.OperadorGlobal.IdAreaOperativa == 4 || OperadorBD.OperadorGlobal.IdAreaOperativa == 1)
            {
                gdEstatusSolicitud.Properties.Enabled = true;
            }
        }

        private void habilitarCampDetalleDBCSol(bool Activo, string IdsStatus)
        {
            //gpoSolicitud.Enabled = Activo;
            GpoDetControlGasto.Enabled = Activo;
            gdTipoPagoProveedor.Enabled = Activo;
            gdEmpresaDPago.Enabled = Activo;
            gdCliente.Enabled = Activo;
            spiMontoConcepto.Enabled = Activo;
            if (OperadorBD.OperadorGlobal.IdAreaOperativa == 4 || OperadorBD.OperadorGlobal.IdAreaOperativa == 1)
            {
                if (IdsStatus == "17" || IdsStatus == "24")
                {
                    GpoDetControlGasto.Enabled = false;
                    CmdGuardaPago.Enabled = false;
                    gdEstatusPago.Enabled = false;
                }
                else
                {
                    if (IdsStatus == "34")
                    {
                        GpoDetControlGasto.Enabled = true;
                        CmdGuardaPago.Enabled = false;
                        gdEstatusPago.Enabled = false;
                    }
                    else
                    {
                        GpoDetControlGasto.Enabled = true;
                        CmdGuardaPago.Enabled = true;
                        gdEstatusPago.Enabled = true;
                    }
                }
            }
            else
            {
                CmdGuardaPago.Enabled = false;
                gdEstatusPago.Enabled = false;
            }

        }

        

        private void habilitarCampDetalleDBCDet(bool Activo,int RegDet)
        {
            
            GpoDetControlGasto.Enabled = Activo;
            gdTipoPagoProveedor.Enabled = Activo;
            gdEmpresaDPago.Enabled = Activo;
            gdCliente.Enabled = Activo;
            spiMontoConcepto.Enabled = Activo;
            if (OperadorBD.OperadorGlobal.IdAreaOperativa == 4 || OperadorBD.OperadorGlobal.IdAreaOperativa == 1 && RegDet > 0)
            {
                gpoSolicitud.Enabled = true;
                GpoDetControlGasto.Enabled = true;
                CmdGuardaPago.Enabled = true;
                gdEstatusPago.Enabled = true;
            }
            else
            {
                GpoDetControlGasto.Enabled = true;
                CmdGuardaPago.Enabled = false;
                gdEstatusPago.Enabled = false;
            }

        }

        private void habilitarCampDetalleSaveSol(bool Activo)
        {
            gpoSolicitud.Enabled = Activo;
            GpoDetControlGasto.Enabled = Activo;
            gdTipoPagoProveedor.Enabled = Activo;
            gdEmpresaDPago.Enabled = Activo;
            gdCliente.Enabled = Activo;
            spiMontoConcepto.Enabled = Activo;
            CmdGuardaPago.Enabled = Activo;
        }

        private DataTable CargaEstatus(string Ids)
        {
            this.stpSelEstatusIdTableAdapter1.Fill(this.dbSAICBPOCatalogosDataSet.stpSelEstatusId, Ids);
            DataTable DtEstatusFilter = stpSelEstatusIdTableAdapter1.GetData(Ids);
            return DtEstatusFilter;
        }


        private void LimpiaGpoSolicitud()
        {
            TxtSolicitud.Text = "-1";
            dtFechaSolicitud.EditValue = DateTime.Now.Date;
            dtFechaSolicitud.Enabled = false;
        }


        private void LimpiaDetSolicitud()
        {
            txtIdPago.Text = "-1";

            var firstValue2 = gdTipoPagoProveedor.Properties.GetKeyValue(0);
            gdTipoPagoProveedor.EditValue = firstValue2;

            var firstValue3 = gdEmpresaDPago.Properties.GetKeyValue(0);
            gdEmpresaDPago.EditValue = firstValue3;

            var firstValue4 = gdCliente.Properties.GetKeyValue(0);
            gdCliente.EditValue = firstValue4;
            
            var firstValue5 = gdEstatusPago.Properties.GetKeyValue(0);
            gdEstatusPago.EditValue = firstValue5;

            spiMontoConcepto.Text = "";
        }

        private void dtFechaSolicitud_EditValueChanged(object sender, EventArgs e)
        {
            btnGuardarSol.Focus();
        }

        private void CmdGuardaPago_Click(object sender, EventArgs e)
        {
            if (spiMontoConcepto.Text != "0")
            {

            if (Nueva == 1)
            {
                if (cmbArea.Text.Trim() == "")
            { XtraMessageBox.Show("Seleccione el Área indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                if (gdTipoPagoProveedor.Text.Trim() == "")
                { XtraMessageBox.Show("Seleccione el Tipo de pago al proveedor indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if (gdEmpresaDPago.Text.Trim() == "")
                    { XtraMessageBox.Show("Seleccione la Empresa de pago indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (gdCliente.Text.Trim() == "")
                        { XtraMessageBox.Show("Seleccione el Cliente indicado.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {

                            if (Validator.IsPresent(cmbArea) &&
                                Validator.IsPresent(gdTipoPagoProveedor) &&
                                Validator.IsPresent(gdEmpresaDPago) &&
                                Validator.IsPresent(gdCliente))
                            {
                                InfoDetalleSolPagoProveedores objDetSolicitudPagoProveedores = AsignaSolicitudPagoProveedoresMod();
                                string pOk = "";
                                int? pIdReturn = 0;

                                if (objDetSolicitudPagoProveedores != null)
                                {

                                    this.validacionesGeneralTableAdapter1.stpTesInsUpdDetailPagProv(1,
                                                                                                    0,
                                                                                                    objDetSolicitudPagoProveedores.IdSolicitud
                                                                                                    , objDetSolicitudPagoProveedores.IdTipoPagoProveedor
                                                                                                    , objDetSolicitudPagoProveedores.IdMatrizTenedora
                                                                                                    , objDetSolicitudPagoProveedores.IdCliente
                                                                                                    , objDetSolicitudPagoProveedores.Monto
                                                                                                    , 15
                                                                                                    , objDetSolicitudPagoProveedores.IdOperador
                                                                                                    //, objDetSolicitudPagoProveedores.FechaSolicitud
                                                                                                    //, objDetSolicitudPagoProveedores.FechaSolicitud
                                                                                                    , objDetSolicitudPagoProveedores.UsuarioCreacion
                                                                                                    , objDetSolicitudPagoProveedores.UsuarioModificacion
                                                                                                    , ref pOk, ref pIdReturn);
                                    
                                    }
                                    if (pOk == "Ok")
                                    {
                                        XtraMessageBox.Show("¡Se agregó el pago: " + pIdReturn + " a la solicitud: #" + objDetSolicitudPagoProveedores.IdSolicitud.ToString() + " Ha sido guardada exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        int IdSolicitud = 0;
                                        txtIdPago.Enabled = true;
                                        txtIdPago.Text = pIdReturn.ToString();
                                        txtIdPago.Enabled = false;
                                        IdSolicitud = objDetSolicitudPagoProveedores.IdSolicitud;
                                        ActualizarGridDetalleSol(IdSolicitud, objDetSolicitudPagoProveedores.IdStatus.ToString());


                                        ActualizarGridSolicitudes();
                                        LimpiaDetSolicitud();
                                        //gdTipoPagoProveedor.Focus();

                                        habilitaCompSolicitud(true);

                                        habilitarCampDetalleSaveSol(true);
                                        CargarEstatusDetallePagos("15");
                                        gdTipoPagoProveedor.Focus();
                                        

                                        // TODO: Crea una funcion para limpiar el detalle que fue agregado
                                        //LimpiarControlesSolicitud();
                                    }
                                    else if (pOk.ToString().Trim() != "2001")
                                    {
                                        XtraMessageBox.Show("El pagao no fue agregado..", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }
                        }
                        }
                    }
                }
            }

            if (Nueva == 2)
            {
                if (cmbArea.Text.Trim() == "")
                { XtraMessageBox.Show("Seleccione el Área indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if (gdTipoPagoProveedor.Text.Trim() == "")
                    { XtraMessageBox.Show("Seleccione el Tipo de pago al proveedor indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if (gdEmpresaDPago.Text.Trim() == "")
                        { XtraMessageBox.Show("Seleccione la Empresa de pago indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else
                        {
                            if (gdCliente.Text.Trim() == "")
                            { XtraMessageBox.Show("Seleccione el Cliente indicado.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            else
                            {

                                if (Validator.IsPresent(cmbArea) &&
                                    Validator.IsPresent(gdTipoPagoProveedor) &&
                                    Validator.IsPresent(gdEmpresaDPago) &&
                                    Validator.IsPresent(gdCliente))
                                {
                                    InfoDetalleSolPagoProveedores objDetSolicitudPagoProveedores = AsignaSolicitudPagoProveedoresMod();
                                    string pOk = "";
                                    int? pIdReturn = 0;

                                    if (objDetSolicitudPagoProveedores != null)
                                    {


                                        this.validacionesGeneralTableAdapter1.stpTesUpdSolPagProv(2
                                                                                                    , objDetSolicitudPagoProveedores.IdSolicitud
                                                                                                    , objDetSolicitudPagoProveedores.IdSolicitudDetallePagoProv
                                                                                                    , objDetSolicitudPagoProveedores.IdStatusPago
                                                                                                    , objDetSolicitudPagoProveedores.UsuarioModificacion
                                                                                                    , ref pOk);

                                    }
                                    if (pOk == "2000")
                                    {
                                        XtraMessageBox.Show("¡Se modificó el pago: " + pIdReturn + " de la solicitud: #" + objDetSolicitudPagoProveedores.IdSolicitud.ToString() + " Ha sido guardada exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        int IdSolicitud = 0;
                                        txtIdPago.Enabled = true;
                                        txtIdPago.Text = pIdReturn.ToString();
                                        txtIdPago.Enabled = false;
                                        IdSolicitud = objDetSolicitudPagoProveedores.IdSolicitud;
                                        ActualizarGridDetalleSol(IdSolicitud, objDetSolicitudPagoProveedores.IdStatus.ToString());


                                        ActualizarGridSolicitudes();
                                        LimpiaDetSolicitud();
                                        //gdTipoPagoProveedor.Focus();

                                        habilitaCompSolicitud(true);

                                        habilitarCampDetalleSaveSol(true);
                                        CargarEstatusDetallePagos("15");
                                        gdTipoPagoProveedor.Focus();


                                        // TODO: Crea una funcion para limpiar el detalle que fue agregado
                                        //LimpiarControlesSolicitud();
                                    }
                                    else if (pOk.ToString().Trim() != "2001")
                                    {
                                        XtraMessageBox.Show("El pagao no fue modificado..", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }


  
                                }
                            }
                        }
                    }
                }
            }
            }


        }


        private void ActualizarGridSolicitudes()
        {
            this.stpSelSolicitudPagoProveedHeaderTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelSolicitudPagoProveedHeader);
            DataTable DTHeaderSolicitudes = stpSelSolicitudPagoProveedHeaderTableAdapter.GetData();

            gdSolicitudesHead.DataSource = FiltraArea(DTHeaderSolicitudes);

            //this.vwHeadSolicitudPagoProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor);
            //DataTable DTHeaderSolicitudes = vwHeadSolicitudPagoProveedorTableAdapter.GetData();
            //gdSolicitudesHead.DataSource = FiltraArea(DTHeaderSolicitudes);
        }


        private void btnGuardarSol_Click(object sender, EventArgs e)
        {
            try
            {

                string pOk = "";
                int? pIdReturn = 0;

                int IdEstatusSol;
                Nueva = 1;

                int.TryParse(gdEstatusSolicitud.EditValue.ToString(), out IdEstatusSol);


                // SOLICITUD
                //if (ProcesoMN == 1)
                //{
                if (cmbArea.Text.Trim() == "")
                {
                    XtraMessageBox.Show("Seleccione el Área indicada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else
                {
                    if (Validator.IsPresent(cmbArea) &&
                        Validator.IsPresent(dtFechaSolicitud) &&
                        Validator.IsPresent(gdEstatusSolicitud))
                    {
                        //Emitida    
                        if (IdEstatusSol == 15)
                        {
                            //INI 15
                            //InfoSolicitudPagoProveedores objSolicitudPagoProveedores = AsignaSolicitudPagoProveedores(IdEstatusSol);
                            InfoSolicitudPagoProveedores objSolicitudPagoProveedores = AsignaSolicitudPagoProveedores();
                            pOk = "";
                            pIdReturn = 0;

                             
                            if (objSolicitudPagoProveedores != null)
                            {
                                this.validacionesGeneralTableAdapter1.stpTesInsUpdHeaderSolPagProv(objSolicitudPagoProveedores.IdOpcion
                                                                                                , objSolicitudPagoProveedores.IdSolicitud
                                                                                                , objSolicitudPagoProveedores.IdAreaOperativa
                                                                                                , objSolicitudPagoProveedores.IdOperador
                                                                                                , objSolicitudPagoProveedores.IdStatus
                                                                                                , objSolicitudPagoProveedores.FechaSolicitud
                                                                                                , objSolicitudPagoProveedores.FechaSolicitud
                                                                                                , objSolicitudPagoProveedores.UsuarioCreacion
                                                                                                , objSolicitudPagoProveedores.UsuarioModificacion
                                                                                                , ref pOk, ref pIdReturn);

                                if (pOk == "Ok")
                                {


                                    TxtSolicitud.Text = pIdReturn.ToString();
                                    XtraMessageBox.Show("¡Se agregó la solicitud: " + pIdReturn + "  Ha sido guardada exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //TODO: Filtrar por área con LinQ el llenado de las solicitudes
                                    //this.vwHeadSolicitudPagoProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor);
                                    ActualizarGridSolicitudes();
                                    //LimpiarControlesSolicitud();
                                   
                                    habilitaCompSolicitud(true);

                                    habilitarCampDetalleSaveSol(true);
                                    CargarEstatusDetallePagos("15");
                                    gdTipoPagoProveedor.Focus();

                                }
                                else if (pOk == "")
                                {
                                    XtraMessageBox.Show("La solicitud no fue agregada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            
                        }
                        //FIN 15
                        if (IdEstatusSol == 24)
                        {
                            //INI 15
                            //InfoSolicitudPagoProveedores objSolicitudPagoProveedores = AsignaSolicitudPagoProveedores(IdEstatusSol); 
                            InfoSolicitudPagoProveedores objSolicitudPagoProveedores = AsignaSolicitudPagoProveedores();
                            pOk = "";
                            pIdReturn = 0;
                            string slIdSolicitud;
                            slIdSolicitud = objSolicitudPagoProveedores.IdSolicitud.ToString();

                            if (objSolicitudPagoProveedores != null)
                            {
                                this.validacionesGeneralTableAdapter1.stpTesInsUpdHeaderSolPagProv(2
                                                                                                , objSolicitudPagoProveedores.IdSolicitud
                                                                                                , objSolicitudPagoProveedores.IdAreaOperativa
                                                                                                , objSolicitudPagoProveedores.IdOperador
                                                                                                , objSolicitudPagoProveedores.IdStatus
                                                                                                , objSolicitudPagoProveedores.FechaSolicitud
                                                                                                , objSolicitudPagoProveedores.FechaSolicitud
                                                                                                , objSolicitudPagoProveedores.UsuarioCreacion
                                                                                                , objSolicitudPagoProveedores.UsuarioModificacion
                                                                                                , ref pOk, ref pIdReturn);

                                if (pOk == "1000")
                                {
                                    TxtSolicitud.Text = objSolicitudPagoProveedores.IdSolicitud.ToString();
                                    XtraMessageBox.Show("¡Se modificó la solicitud: " + slIdSolicitud + "  Ha sido RECHAZADA exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //TODO: Filtrar por área con LinQ el llenado de las solicitudes
                                    //this.vwHeadSolicitudPagoProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor);
                                    ActualizarGridSolicitudes();
                                    LimpiarControlesSolicitud();
                                    //habilitaCompSolicitud();

                                    habilitarCampDetalleSaveSol(false);
                                    //CargarEstatusDetallePagos("15");
                                    //gdTipoPagoProveedor.Focus();

                                }
                                else if (pOk == "1001")
                                {
                                    XtraMessageBox.Show("La solicitud no pudo ser Rechazada. Existen pagos ya generados.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }


                    }
                }
                
                // PAGOS
                /*
                if (ProcesoMN == 2)
                {
                    if (TxtSolicitud.Text.Trim() == "")
                    {
                        XtraMessageBox.Show("Debe seleccionar la solicitud a modificar", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        //this.validacionesGeneralTableAdapter1.stpTesUpdSolPagProv(objSolicitudPagoProveedores.IdOpcion
                        //                                                 , objSolicitudPagoProveedores.IdSolicitud
                        //                                                 , objSolicitudPagoProveedores.IdAreaOperativa
                        //                                                 , objSolicitudPagoProveedores.IdOperador
                        //                                                 , objSolicitudPagoProveedores.IdStatus
                        //                                                 , objSolicitudPagoProveedores.FechaSolicitud
                        //                                                 , objSolicitudPagoProveedores.FechaSolicitud
                        //                                                 , objSolicitudPagoProveedores.UsuarioCreacion
                        //                                                 , objSolicitudPagoProveedores.UsuarioModificacion
                        //                                                 , ref pOk, ref pIdReturn);

                    if (Validator.IsPresent(cmbArea) &&
                        Validator.IsPresent(dtFechaSolicitud))
                    {
                        pOk = "";
                        pIdReturn = 0;
                        InfoSolicitudPagoProveedores objSolicitudPagoProveedores = AsignaSolicitudPagoProveedoresMod();

                        if (objSolicitudPagoProveedores != null)
                        {

                            //Rechazar
                            if (objSolicitudPagoProveedores.IdStatus.ToString() == "24")
                                {


                                    if (pOk == "1000")
                                    {
                                        TxtSolicitud.Text = objSolicitudPagoProveedores.IdSolicitud.ToString();
                                        XtraMessageBox.Show("¡Se actualizó la solicitud: #" + objSolicitudPagoProveedores.IdSolicitud + "  Ha sido guardada exitosamente!", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //TODO: Filtrar por área con LinQ el llenado de las solicitudes
                                        //this.vwHeadSolicitudPagoProveedorTableAdapter.Fill(this.dbSAIC_Catalogos.vwHeadSolicitudPagoProveedor);
                                        ActualizarGridSolicitudes();
                                        LimpiarControlesSolicitud();
                                        //habilitaCompSolicitud();

                                        habilitarCampDetalleSaveSol(false);
                                        //CargarEstatusDetallePagos("15");
                                        //gdTipoPagoProveedor.Focus();

                                    }
                                    else if (pOk == "1001")
                                    {
                                        XtraMessageBox.Show("La solicitud no fue actualizada.", "Consulte con el administrador.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            // OTRO ESTATUS
                        }



                    }
                    */

                        





                //}


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al almacenar la solicitud deseada: " + Environment.NewLine
                        + ex, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void LimpiarControlesSolicitud()
        {

            //dtFechaSolicitud.EditValue = DateTime.Now.Date;
            btnGuardarSol.Enabled = false;
            //gpoSolicitud.Enabled = false;
            //GpoDetControlGasto.Enabled = true;
        }

        private InfoDetalleSolPagoProveedores AsignaDetalleSolicitudPagoProveedores()
        {
            InfoDetalleSolPagoProveedores objDetalleSolicitudPagoProveedores = null;
            try
            {
                objDetalleSolicitudPagoProveedores = new InfoDetalleSolPagoProveedores();
                //Modicar cuando sea nuevo y modificacion
                objDetalleSolicitudPagoProveedores.IdOpcion = 1;
                objDetalleSolicitudPagoProveedores.IdSolicitudDetallePagoProv = 0;
                objDetalleSolicitudPagoProveedores.IdSolicitud = Convert.ToInt16(TxtSolicitud.Text);
                objDetalleSolicitudPagoProveedores.IdTipoPagoProveedor = Convert.ToInt16(gdTipoPagoProveedor.EditValue);
                objDetalleSolicitudPagoProveedores.IdMatrizTenedora = Convert.ToInt16(gdEmpresaDPago.EditValue);
                objDetalleSolicitudPagoProveedores.IdCliente = Convert.ToInt16(gdCliente.EditValue);
                objDetalleSolicitudPagoProveedores.Monto = Convert.ToDecimal(spiMontoConcepto.EditValue);
                objDetalleSolicitudPagoProveedores.IdStatus = 15;
                objDetalleSolicitudPagoProveedores.IdOperador = IdOperador;
                objDetalleSolicitudPagoProveedores.FechaSolicitud = DateTime.Now.Date;
                objDetalleSolicitudPagoProveedores.UsuarioCreacion = Usuario;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignaDetalleSolicitudPagoProveedores" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return objDetalleSolicitudPagoProveedores;

        }


        
        private InfoDetalleSolPagoProveedores AsignaSolicitudPagoProveedoresMod()
        {
            InfoDetalleSolPagoProveedores objDetalleSolicitudPagoProveedoresMod = null;
            try
            {
                objDetalleSolicitudPagoProveedoresMod = new InfoDetalleSolPagoProveedores();
                //Modicar cuando sea nuevo y modificacion
                objDetalleSolicitudPagoProveedoresMod.IdOpcion = 1; //SOL
                objDetalleSolicitudPagoProveedoresMod.IdSolicitud = Convert.ToInt16(TxtSolicitud.Text);
                objDetalleSolicitudPagoProveedoresMod.IdSolicitudDetallePagoProv = Convert.ToInt16(txtIdPago.Text);
                objDetalleSolicitudPagoProveedoresMod.IdStatusPago = Convert.ToInt16(gdEstatusPago.EditValue);
                objDetalleSolicitudPagoProveedoresMod.UsuarioModificacion = Usuario;

                objDetalleSolicitudPagoProveedoresMod.IdTipoPagoProveedor = Convert.ToInt16(gdTipoPagoProveedor.EditValue);
                objDetalleSolicitudPagoProveedoresMod.IdMatrizTenedora = Convert.ToInt16(gdEmpresaDPago.EditValue);
                objDetalleSolicitudPagoProveedoresMod.IdCliente = Convert.ToInt16(gdCliente.EditValue);
                objDetalleSolicitudPagoProveedoresMod.Monto = Convert.ToDecimal(spiMontoConcepto.EditValue);
                objDetalleSolicitudPagoProveedoresMod.IdOperador = IdOperador;
                objDetalleSolicitudPagoProveedoresMod.FechaSolicitud = DateTime.Now.Date;
                objDetalleSolicitudPagoProveedoresMod.UsuarioCreacion = Usuario;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignaSolicitudPagoProveedoresMod" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return objDetalleSolicitudPagoProveedoresMod;

        }


        //private InfoSolicitudPagoProveedores AsignaSolicitudPagoProveedores(int IdEstatusSol)
        private InfoSolicitudPagoProveedores AsignaSolicitudPagoProveedores()
        {
            InfoSolicitudPagoProveedores objSolicitudPagoProveedores = null;
            try
            {
                objSolicitudPagoProveedores = new InfoSolicitudPagoProveedores();

                //if (ProcesoMN > 0)
                //{
                //    if (ProcesoMN == 1)
                //    {
                        objSolicitudPagoProveedores.IdOpcion = ProcesoMN;
                        objSolicitudPagoProveedores.IdSolicitud = Convert.ToInt16(TxtSolicitud.Text); 
                        objSolicitudPagoProveedores.IdAreaOperativa = IdAreaOperativa;
                        objSolicitudPagoProveedores.IdOperador = IdOperador;
                        objSolicitudPagoProveedores.IdStatus = Convert.ToInt16(gdEstatusSolicitud.EditValue); ;
                        objSolicitudPagoProveedores.FechaSolicitud = Convert.ToDateTime(dtFechaSolicitud.EditValue);
                        objSolicitudPagoProveedores.UsuarioCreacion = Usuario;
                    //}
                    //else
                    //{
                    //}
                //}


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignarInfoEmpresaSaldoNvo" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return objSolicitudPagoProveedores;

        }



        private void gdSolicitudesHead_Click(object sender, EventArgs e)
        {

        }

        private void gdSolicitudesHead_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProcesoMN = 2;
                int IdStatus;
                string IdStatusBase;
                LimpiaGpoSolicitud();
                LimpiaDetSolicitud();
                int[] selRows = ((GridView)gdSolicitudesHead.MainView).GetSelectedRows();
                DataRowView selRow = (DataRowView)(((GridView)gdSolicitudesHead.MainView).GetRow(selRows[0]));
                TxtSolicitud.Text = selRow["SOLICITUD"].ToString();


                //int IdAreaDCli;

                //int.TryParse(selRow["IdAreaOperativa"].ToString(), out IdAreaDCli);



                // int.TryParse(selRow["IdStatus"].ToString(), out IdStatus);
                //CargaEstatusSolicitud(selRow["IdAreaOperativa"]);
                String IdsStatus;
                IdsStatus = selRow["IdStatus"].ToString();
                if (IdAreaOperativa == 4 || IdAreaOperativa == 1)
                {
                    //if ()
                    //{
                    //IdsStatus = selRow["IdStatus"].ToString() + "," + "24";
                    //CargarEstatusSolicitud(IdsStatus);
                    //gdEstatusSolicitud.EditValue = selRow["IdStatus"];
                    //}



                    gpoSolicitud.Enabled = true;
                    habilitaCompSolicitud(true);
                    btnGuardarSol.Enabled = true;
                }
                else
                {
                    CargarEstatusSolicitud(IdsStatus);
                    gdEstatusSolicitud.EditValue = selRow["IdStatus"];
                    gpoSolicitud.Enabled = false;
                    btnGuardarSol.Enabled = false;
                }


                int lAreaOperativaSelec;
                int.TryParse(selRow["IdAreaOperativa"].ToString(), out lAreaOperativaSelec);
                CargarAreaCmb(lAreaOperativaSelec);
                //gdEmpresaDPago.EditValue = selRow["IdAreaOperativa"];
                dtFechaSolicitud.EditValue = selRow["FECHA_SOLICITUD"];

                int IdSolicitud = 0;
                int.TryParse(TxtSolicitud.Text, out IdSolicitud);


                ActualizarGridDetalleSol(IdSolicitud, IdsStatus);
                //LimpiaGpoSolicitud();

                //selRow["SOLICITUD"].ToString();
                //////if (IdStatus == 17)
                //////{
                //////    XtraMessageBox.Show("Solicitud " + TxtSolicitud.Text + " con estatus  " + Environment.NewLine +
                //////       "SOLICITUD ATENDIDA AL 100%", "No se puede modificar la solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //////}
                //////if (IdStatus == 16)
                //////{
                //////    XtraMessageBox.Show("Solicitud " + TxtSolicitud.Text + " con estatus  " + Environment.NewLine +
                //////        "SOLICITUD EN PROCESO", "No se puede modificar la solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //////}
                //////if (IdStatus == 23)
                //////{
                //////    XtraMessageBox.Show("Solicitud " + TxtSolicitud.Text + " con estatus  " + Environment.NewLine +
                //////        "SOLICITUD CANCELADA", "No se puede modificar la solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //////}

                //////if (IdStatus == 15)
                //////{
                //////    XtraMessageBox.Show("Solicitud " + TxtSolicitud.Text + " con estatus  " + Environment.NewLine +
                //////        "SOLICITUD EMITIDA" + Environment.NewLine +
                //////        "Si desea modificarla pída a Tesorería cambiar el estatus a RECHAZADA"
                //////        , "No se puede modificar la solicitud - ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //////}



                
                LimpiaDetSolicitud();

                if (selRow["IdStatus"].ToString() == "24" || selRow["IdStatus"].ToString() == "17")
                {
                    gdEstatusSolicitud.Enabled = false;
                    btnGuardarSol.Enabled = false;
                }

                //habilitarCampDetalleDBCSol(false, IdsStatus);

                    //habilitarCampDetalleDBCSol()


                    //gdEstatusSolicitud.Properties.Enabled = true;
                    //GpoDetControlGasto.Enabled = false;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error en AsignarInfoEmpresaSaldoNvo" + Environment.NewLine +
                       ex.Message, "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return null;
            }

        }

        private void ActualizarGridDetalleSol(int IdSolicitud, string IdStatusSolicitud)
        {

            this.stpSelSolicitudPagoProveedDetailTableAdapter1.Fill(this.dbSAIC_Catalogos.stpSelSolicitudPagoProveedDetail, IdSolicitud);

            //this.stpSelSolicitudPagoProveedHeaderTableAdapter.Fill(this.dbSAIC_Catalogos.stpSelSolicitudPagoProveedHeader);
            



            int iIdsStatus;
            string lsIdsStatus;

            //try.parse(IdStatusSolicitud, out iIdsStatud);

            int.TryParse(IdStatusSolicitud, out iIdsStatus);

            if (IdAreaOperativa == 4 || IdAreaOperativa == 1)
            {
                if (IdStatusSolicitud == "17" || IdStatusSolicitud == "24")
                {
                    CargarEstatusSolicitud(IdStatusSolicitud);
                    gdEstatusSolicitud.EditValue = iIdsStatus;
                    habilitarCampDetalleDBCDet(false, 0);

                }
                else
                {
                    DataTable DTDetailSolicitudes = stpSelSolicitudPagoProveedDetailTableAdapter1.GetData(IdSolicitud);

                    if (DTDetailSolicitudes.Rows.Count == 0)
                    {
                        CargarEstatusSolicitud("24");
                        gdEstatusSolicitud.EditValue = 24;
                        gdEstatusPago.Enabled = false;
                        //CmdGuardaPago.Enabled = false;
                        habilitarCampDetalleDBCDet(false, DTDetailSolicitudes.Rows.Count);

                    }
                    else {

                        //var query = (from x in DTDetailSolicitudes.AsEnumerable()
                        //             where x.Field<Int32>("IdEstatus").Equals(34)
                        //             select x).CopyToDataTable();

                        //DataTable dtTempDet = (DataTable)query;

                        //if (dtTempDet.Rows.Count == 0)
                        //{
                        //    lsIdsStatus = IdStatusSolicitud + "," + "24";
                        //    CargarEstatusSolicitud(lsIdsStatus);
                        //    gdEstatusSolicitud.EditValue = iIdsStatus;
                        //}
                        //else
                        //{
                        //    ////IdStatusSolicitud = selRow["IdStatus"].ToString() + "," + "24";
                        //    CargarEstatusSolicitud(IdStatusSolicitud);
                        //    gdEstatusSolicitud.EditValue = iIdsStatus;
                        //}

                        //var query = from Detalle in DTDetailSolicitudes .AsEnumerable()
                        //            where Detalle.Field<Int32>("IdEstatus") == 34
                        //            select new
                        //            {
                        //                Detalle.Field("Pago"),
                        //                Detalle.Estatus
                        //            }
                        //            ;
                        //foreach (var c in query)
                        //{
                        //    su
                        //}

                        var query = DTDetailSolicitudes.AsEnumerable().Where(x => x.Field<Int32>("IdEstatus") == 34).AsDataView();

                        if (query.Count == 0)
                        {
                            //lsIdsStatus = IdStatusSolicitud + "," + "24";
                            lsIdsStatus = "24";

                            int.TryParse(lsIdsStatus , out iIdsStatus);
                            CargarEstatusSolicitud(lsIdsStatus);
                            gdEstatusSolicitud.EditValue = iIdsStatus;
                            habilitarCampDetalleDBCSol(false, lsIdsStatus);
                        }
                        else
                            {
                            lsIdsStatus = IdStatusSolicitud ;
                            CargarEstatusSolicitud(lsIdsStatus);
                            gdEstatusSolicitud.EditValue = iIdsStatus;
                        }

                        //XtraMessageBox.Show("Error en AsignarInfoEmpresaSaldoNvo" + Environment.NewLine +
                        //"","SAIC", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        //////DataTable dtTempDet = (DataTable)query;

                        //////if (dtTempDet.Rows.Count == 0)
                        //////{
                        //////    lsIdsStatus = IdStatusSolicitud + "," + "24";
                        //////    CargarEstatusSolicitud(lsIdsStatus);
                        //////    gdEstatusSolicitud.EditValue = iIdsStatus;
                        //////}
                        //////else
                        //////{
                        //////    ////IdStatusSolicitud = selRow["IdStatus"].ToString() + "," + "24";
                        //////    CargarEstatusSolicitud(IdStatusSolicitud);
                        //////    gdEstatusSolicitud.EditValue = iIdsStatus;
                        //////}


                    }
                }


            }
        }

        private void gdSolicitudesDetail_DoubleClick(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gdSolicitudesDetail.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gdSolicitudesDetail.MainView).GetRow(selRows[0]));

            

            if (selRow["PAGO"].ToString() != "")
            {

                txtIdPago.Text = selRow["PAGO"].ToString();
                gdTipoPagoProveedor.EditValue = selRow["IdTipoPagoProveedor"];
                gdEmpresaDPago.EditValue = selRow["IdMatrizTenedora"];
                gdCliente.EditValue = selRow["IdCliente"];
                //
                spiMontoConcepto.Text = selRow["MONTO_A_PAGAR"].ToString();


                String IdsStatus;
                habilitarCampDetalleDBCDet(false,1);

                if (IdAreaOperativa == 4 || IdAreaOperativa == 1)
                {
                    if (selRow["IdEstatus"].ToString() == "15")
                    {
                        IdsStatus = "34";
                        CargarEstatusDetallePagos(IdsStatus);
                    }

                    if (selRow["IdEstatus"].ToString() == "34")
                    {
                        IdsStatus = "34";
                        //CargarEstatusDetallePagos(IdsStatus);
                        CargarEstatusDetallePagos(IdsStatus);

                        habilitarCampDetalleDBCSol(false, IdsStatus);

                    }
                    Nueva = 2;
                    //IdsStatus = "34,23";
                   

                    //gdEstatusPago.Properties.DisplayMember = "DescEstatus";
                    //gdEstatusPago.Properties.ValueMember = "IdEstatus";
                    //gdEstatusPago.Properties.DataSource = CargaEstatus(Ids);
                    //var firstValue1 = gdEstatusPago.Properties.GetKeyValue(0);
                    //gdEstatusPago.EditValue = firstValue1;
                }
                else
                {
                    CargarEstatusDetallePagos(selRow["IdEstatus"].ToString());
                }

            }


        }

        private void cargaAccionTeso()
        {
            if (IdAreaOperativa ==  4)
            { 
            CargarEstatusDetallePagos("17,24");
            btnGuardarSol.Enabled = true;
            }
        }


        private void gdSolicitudesDetail_Click(object sender, EventArgs e)
        {

        }

        private void txtIdPago_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gdCliente_EditValueChanged(object sender, EventArgs e)
        {

        }


    }
}