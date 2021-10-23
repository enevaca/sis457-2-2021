using CadMinerva;
using ClnMinerva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpMinervaDesktop
{
    public partial class FrmBuscarProducto : Form
    {
        public static Producto producto;
        public FrmBuscarProducto()
        {
            InitializeComponent();
            producto = null;
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            producto = ProductoCln.get(id);
            Close();
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParamatro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["usuarioRegistro"].Visible = false;
            dgvLista.Columns["fechaRegistro"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            btnSeleccionar.Enabled = lista.Count > 0;
            if (lista.Count > 0) dgvLista.Rows[0].Cells["codigo"].Selected = true;
        }

        private void txtParamatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
    }
}
