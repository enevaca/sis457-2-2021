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
    public partial class FrmProducto : Form
    {
        bool esNuevo;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(948, 392);
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 571);
            esNuevo = true;
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 571);
            esNuevo = false;
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 392);
            limpiar();
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParamatro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["codigo"].HeaderText = "Código";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvLista.Columns["saldo"].HeaderText = "Saldo";
            dgvLista.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void cargarDatos()
        {
            int index = dgvLista.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var producto = ProductoCln.get(id);
            txtCodigo.Text = producto.codigo;
            txtDescripcion.Text = producto.descripcion;
            cbxUnidadMedida.SelectedItem = producto.unidadMedida;
            txtPrecioVenta.Text = producto.precioVenta.ToString();
            txtSaldo.Text = producto.saldo.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParamatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbxUnidadMedida.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtSaldo.Text = string.Empty;
        }

        private bool validar()
        {
            bool valido = true;
            erpCodigo.SetError(txtCodigo, "");
            erpDescripcion.SetError(txtDescripcion, "");
            erpUnidadMedida.SetError(cbxUnidadMedida, "");
            erpPrecioVenta.SetError(txtPrecioVenta, "");
            erpSaldo.SetError(txtSaldo, "");
            if (string.IsNullOrEmpty(txtCodigo.Text)) { erpCodigo.SetError(txtCodigo, "Introduzca un código"); valido = false; }
            if (string.IsNullOrEmpty(txtDescripcion.Text)) { erpDescripcion.SetError(txtDescripcion, "Introduzca una descripción"); valido = false; }
            if (string.IsNullOrEmpty(cbxUnidadMedida.Text)) { erpUnidadMedida.SetError(cbxUnidadMedida, "Seleccione una unidad de medida"); valido = false; }
            if (string.IsNullOrEmpty(txtPrecioVenta.Text)) { erpPrecioVenta.SetError(txtPrecioVenta, "Introduzca un precio de venta"); valido = false; }
            if (string.IsNullOrEmpty(txtSaldo.Text)) { erpSaldo.SetError(txtSaldo, "Introduzca un saldo o stock"); valido = false; }
            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Producto producto = new Producto();
                producto.codigo = txtCodigo.Text.Trim();
                producto.descripcion = txtDescripcion.Text.Trim();
                producto.unidadMedida = cbxUnidadMedida.Text;
                producto.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                producto.saldo = Convert.ToDecimal(txtSaldo.Text);
                if (esNuevo)
                {
                    producto.usuarioRegistro = Utils.usuario.usuario;
                    producto.fechaRegistro = DateTime.Now;
                    producto.registroActivo = true;
                    ProductoCln.insertar(producto);
                }
                else
                {
                    int index = dgvLista.CurrentRow.Index;
                    producto.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ProductoCln.actualizar(producto);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show("Registro guardado corractamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string descripcion = dgvLista.Rows[index].Cells["descripcion"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el producto {descripcion}?", "::: Mensaje - Minerva :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                ProductoCln.eliminar(id, Utils.usuario.usuario);
                listar();
                MessageBox.Show("Registro eliminado corractamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
