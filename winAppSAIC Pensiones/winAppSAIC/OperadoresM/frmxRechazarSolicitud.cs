using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using compCatalogosSAIC;

namespace winAppSAIC.OperadoresM
{
    public partial class frmxRechazarSolicitud : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtEmpleados;
        OperadoresM.Solicitud miSolicid;
        tools.dsc dsc = new tools.dsc();
        public frmxRechazarSolicitud(OperadoresM.Solicitud miSolicid, DataTable dtEmpleados)
        {
            InitializeComponent();
            this.dtEmpleados = dtEmpleados;
            this.miSolicid = miSolicid;
        }

        private void frmxRechazarSolicitud_Load(object sender, EventArgs e)
        {
            txtbxSolicitud.Text = miSolicid.idSolicitud.ToString();
            txtbxfechaAlta.Text = miSolicid.FechaCreacion.ToShortDateString();
            txtbxOperador.Text = miSolicid.Operador;
            txtbxTenedoraSA.Text = miSolicid.TenedoraSA;
            txtbxRPatronal.Text = miSolicid.RegistroPatronal;
            dtEmpleados = FiltarDataTable(dtEmpleados);

            controlEmpleados.DataSource = dtEmpleados;


        }

        private void btnRechazoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable FiltarDataTable(DataTable dtEmpleados)
        {
            DataTable dtEmpleadosRechazo = new DataTable();
            dtEmpleadosRechazo.Columns.Add("IdEmpleado", typeof(int));
            dtEmpleadosRechazo.Columns.Add("Apellido Paterno", typeof(String));
            dtEmpleadosRechazo.Columns.Add("Apellido Materno", typeof(String));
            dtEmpleadosRechazo.Columns.Add("Nombre", typeof(String));
            dtEmpleadosRechazo.Columns.Add("Rechazo", typeof(String));

            var query = from x in dtEmpleados.AsEnumerable()
                        select new
                        {
                            idempleado = x.Field<String>("IdEmpleado"),
                            paterno = x.Field<String>("Apellido Paterno"),
                            materno = x.Field<String>("Apellido Materno"),
                            nombre = x.Field<String>("Nombre"),
                            rechazo = x.Field<String>("Rechazo")
                        };

            foreach (var item in query)
            {
                DataRow unRow = dtEmpleadosRechazo.NewRow();
                unRow["IdEmpleado"] = item.idempleado;
                unRow["Apellido Paterno"] = item.paterno;
                unRow["Apellido Materno"] = item.materno;
                unRow["Nombre"] = item.nombre;
                unRow["Rechazo"] = item.rechazo;
                dtEmpleadosRechazo.Rows.Add(unRow);
            }

            return dtEmpleadosRechazo;
        }

        private void gridViewEmpleados_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //GridView view = sender as GridView;
            //view.SetRowCellValue(e.RowHandle, gridViewEmpleados.Columns[0], 1);
            //view.SetRowCellValue(e.RowHandle, gridViewEmpleados.Columns[1], 2);
            //view.SetRowCellValue(e.RowHandle, gridViewEmpleados.Columns[2], 3);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DataTable dtEmpleados = dsc.deGridViewaDataTable(gridViewEmpleados);
            int iConta = 0;
            int iContaNoSubidos = 0;
            foreach (DataRow unRow in dtEmpleados.Rows)
            {
                int idEmpleado;
                String stRechazo = String.Empty;

                int.TryParse(unRow["IdEmpleado"].ToString(), out idEmpleado);
                stRechazo = unRow["Rechazo"].ToString().ToUpper().Trim();

                if (!String.IsNullOrEmpty(stRechazo))
                {
                    queriesTableAdapter1.stpUpdAltaEmpleadosGenerarRechazo("IMSS", miSolicid.idSolicitud, idEmpleado, stRechazo, OperadorBD.OperadorGlobal.NombreUsuario,
                        OperadorBD.OperadorGlobal.NombreOperador);
                    iConta++;
                }
                else
                {
                    iContaNoSubidos++;
                }
            }

            XtraMessageBox.Show("Rechazo Solicitud:" + Environment.NewLine +
                "Empleados Rechazados: " + iConta + Environment.NewLine +
               (iContaNoSubidos > 0 ? "Empleados no SUbidos: " + iContaNoSubidos : String.Empty)
                , "SAIC", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}