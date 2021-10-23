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
    public partial class FrmCompra : Form
    {
        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = DateTime.Now.Date;
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            cbxProveedores.DataSource = ProveedorCln.listar("");
            cbxProveedores.DisplayMember = "razonSocial";
            cbxProveedores.ValueMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            new FrmBuscarProducto().ShowDialog();
            var producto = FrmBuscarProducto.producto;
            if (producto != null)
            {
                if (!existeEnDgv(producto))
                {
                    int rowId = dgvLista.Rows.Add();
                    DataGridViewRow row = dgvLista.Rows[rowId];
                    row.Cells["id"].Value = producto.id.ToString();
                    row.Cells["codigo"].Value = producto.codigo;
                    row.Cells["descripcion"].Value = producto.descripcion;
                    row.Cells["unidadMedida"].Value = producto.unidadMedida;
                    row.Cells["saldo"].Value = producto.saldo.ToString();
                    row.Cells["cantidad"].Value = string.Empty;
                    row.Cells["precioUnitario"].Value = string.Empty;
                    row.Cells["total"].Value = string.Empty;
                    dgvLista.Rows[rowId].Cells["codigo"].Selected = true;
                }
                else MessageBox.Show($"El producto {producto.descripcion} ya se encuentra en la lista", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool existeEnDgv(Producto producto) 
        {
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                if (Convert.ToInt32(row.Cells["id"].Value) == producto.id) return true;
            }
            return false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var compra = new Compra();
            //compra.transaccion = CompraCln.getSgteTransaccion();
            compra.fecha = dtpFecha.Value;
            compra.idProveedor = Convert.ToInt32(cbxProveedores.SelectedValue);
            compra.usuarioRegistro = Utils.usuario.usuario;
            compra.fechaRegistro = DateTime.Now;
            compra.registroActivo = true;
            //int idCompra = CompraCln.insertar(compra);
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["id"].Value);
                var compraDetalle = new CompraDetalle();
                //compraDetalle.idCompra = idCompra;
                compraDetalle.idProducto = idProducto;
                compraDetalle.cantidad = Convert.ToDecimal(row.Cells["cantidad"].Value);
                compraDetalle.precioUnitario = Convert.ToDecimal(row.Cells["precioUnitario"].Value);
                compraDetalle.total = Convert.ToDecimal(row.Cells["total"].Value);
                compraDetalle.usuarioRegistro = Utils.usuario.usuario;
                compraDetalle.fechaRegistro = DateTime.Now;
                compraDetalle.registroActivo = true;
                //CompraDetalleCln.insertar(compraDetalle);
            }
        }
    }
}
