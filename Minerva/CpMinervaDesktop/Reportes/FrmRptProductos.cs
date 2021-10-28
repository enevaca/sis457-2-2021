using ClnMinerva;
using System;
using System.Windows.Forms;

namespace CpMinervaDesktop.Reportes
{
    public partial class FrmRptProductos : Form
    {
        CrProductos reporte;
        public FrmRptProductos()
        {
            InitializeComponent();
            reporte = new CrProductos();
        }

        private void cargarReporte()
        {
            var productos = ProductoCln.listarPa("");
            reporte.SetDataSource(productos);
            reporte.SetParameterValue("usuario", Utils.usuario.usuario);
            crvReporte.ReportSource = reporte;
        }

        private void FrmRptProductos_Load(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
