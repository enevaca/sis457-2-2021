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
    public partial class FrmPrincipal : Form
    {
        FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }

        private void btnCaProducto_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tabAdministracion.Visible = Utils.empleado.cargo == "Administrador";
        }

        private void btnAdEmpleado_Click(object sender, EventArgs e)
        {
            new FrmEmpleado().ShowDialog();
        }

        private void btnMoCompra_Click(object sender, EventArgs e)
        {
            new FrmCompra().ShowDialog();
        }

        private void btnReProductos_Click(object sender, EventArgs e)
        {
            new Reportes.FrmRptProductos().ShowDialog();
        }
    }
}
