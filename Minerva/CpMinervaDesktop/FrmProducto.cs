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
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Size = new Size(948, 392);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 571);
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 571);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 392);
        }
    }
}
