using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace winAppSAIC.tools
{
    public partial class xtFormSelectItem : DevExpress.XtraEditors.XtraForm
    {
        public string stValorSeleccioando { get; set; }
        String stTitulos = String.Empty;
        List<String> listaItems;

        public xtFormSelectItem(String stTitulos, List<String> listaItems)
        {
            this.stTitulos = stTitulos;
            this.listaItems = listaItems;
            InitializeComponent();
            lblTitulo.Text = stTitulos;
            cargaItems(listaItems);
            this.Name = stTitulos;
        }

        private void xtFormSelectItem_Load(object sender, EventArgs e)
        {
            this.Text = "Seleccionar Hoja";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            stValorSeleccioando = lblItemSeleccionado.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cargaItems(List<String> listaItems)
        {
            for (int i = 0; i < listaItems.Count; i++)
                cbListaItems.Properties.Items.Add(listaItems[i].ToString());
        }

        private void cbListaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItemSeleccionado.Text = cbListaItems.SelectedText;
        }
    }
}