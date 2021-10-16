using CadMinerva;
using ClnMinerva;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CpMinervaDesktop
{
    public partial class FrmEmpleado : Form
    {
        bool esNuevo;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
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
            txtCI.Enabled = true;
            txtCI.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 571);
            esNuevo = false;
            txtCI.Enabled = false;
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(948, 392);
            limpiar();
        }

        private void listar()
        {
            var lista = EmpleadoCln.listarPa(txtParamatro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["registroActivo"].Visible = false;
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cédula de Identidad";
            dgvLista.Columns["nombres"].HeaderText = "Nombres";
            dgvLista.Columns["paterno"].HeaderText = "Paterno";
            dgvLista.Columns["materno"].HeaderText = "Materno";
            dgvLista.Columns["fechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["celular"].HeaderText = "Celular";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
            if (lista.Count > 0) dgvLista.Rows[0].Cells["cedulaIdentidad"].Selected = true;
        }

        private void cargarDatos()
        {
            int index = dgvLista.CurrentRow.Index;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var empleado = EmpleadoCln.get(id);
            txtCI.Text = empleado.cedulaIdentidad;
            txtNombres.Text = empleado.nombres;
            txtPaterno.Text = empleado.paterno;
            txtMaterno.Text = empleado.materno;
            dtpFechaNacimiento.Value = empleado.fechaNacimiento.Date;
            txtDirección.Text = empleado.direccion;
            nudCelular.Value = empleado.celular;
            cbxCargo.SelectedItem = empleado.cargo;
            txtNombres.Focus();
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
            txtCI.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtPaterno.Text = string.Empty;
            txtMaterno.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now.Date;
            txtDirección.Text = string.Empty;
            nudCelular.Text = string.Empty;
            cbxCargo.SelectedItem = string.Empty;
        }

        private bool validar()
        {
            bool valido = true;
            erpCI.SetError(txtCI, "");
            erpNombres.SetError(txtNombres, "");
            erpCelular.SetError(nudCelular, "");
            erpDireccion.SetError(txtDirección, "");
            erpCargo.SetError(cbxCargo, "");
            erpFechaNacimiento.SetError(dtpFechaNacimiento, "");
            erpApellido.SetError(txtPaterno, "");
            erpApellido.SetError(txtMaterno, "");

            //var edad = DateTime.Now.Date.Subtract(dtpFechaNacimiento.Value.Date).TotalDays / 365;
            var edad = DateTime.Today.AddTicks(-dtpFechaNacimiento.Value.Date.Ticks).Year - 1;
            var existeEmpleado = false;
            if (esNuevo) existeEmpleado = EmpleadoCln.validar(txtCI.Text.Trim()) != null;

            if (string.IsNullOrEmpty(txtCI.Text)) { erpCI.SetError(txtCI, "Introduzca una cédula de identidad"); valido = false; }
            if (existeEmpleado) { erpCI.SetError(txtCI, $"El empleado con CI {txtCI.Text} ya existe"); valido = false; }
            if (string.IsNullOrEmpty(txtNombres.Text)) { erpNombres.SetError(txtNombres, "Introduzca un nombre"); valido = false; }
            if (string.IsNullOrEmpty(nudCelular.Text)) { erpCelular.SetError(nudCelular, "Intrduzca un número de celular"); valido = false; }
            if (string.IsNullOrEmpty(txtDirección.Text)) { erpDireccion.SetError(txtDirección, "Introduzca una dirección"); valido = false; }
            if (string.IsNullOrEmpty(cbxCargo.Text)) { erpCargo.SetError(cbxCargo, "Seleccione un cargo"); valido = false; }
            if (edad < 18 ) { erpFechaNacimiento.SetError(dtpFechaNacimiento, "El empleado debe ser mayor de edad"); valido = false; }
            if (string.IsNullOrEmpty(txtPaterno.Text) && string.IsNullOrEmpty(txtMaterno.Text)) {
                erpApellido.SetError(txtPaterno, "Introduzca al menos un apellido");
                erpApellido.SetError(txtMaterno, "Introduzca al menos un apellido");
                valido = false; 
            }
            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Empleado empleado = new Empleado();
                empleado.cedulaIdentidad = txtCI.Text.Trim();
                empleado.nombres = txtNombres.Text.Trim();
                empleado.paterno = txtPaterno.Text.Trim();
                empleado.materno = txtMaterno.Text.Trim();
                empleado.fechaNacimiento = dtpFechaNacimiento.Value.Date;
                empleado.direccion = txtDirección.Text.Trim();
                empleado.celular = (long)nudCelular.Value;
                empleado.cargo = cbxCargo.Text;
                if (esNuevo)
                {
                    empleado.usuarioRegistro = Utils.usuario.usuario;
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.registroActivo = true;
                    EmpleadoCln.insertar(empleado);
                }
                else
                {
                    int index = dgvLista.CurrentRow.Index;
                    empleado.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    EmpleadoCln.actualizar(empleado);
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
            string cedulaIdentidad = dgvLista.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea eliminar el empleado con CI {cedulaIdentidad}?", "::: Mensaje - Minerva :::", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                EmpleadoCln.eliminar(id, Utils.usuario.usuario);
                listar();
                MessageBox.Show("Registro eliminado corractamente", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
