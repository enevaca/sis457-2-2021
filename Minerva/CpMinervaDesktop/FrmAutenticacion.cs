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
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string clave = Utils.Encrypt(txtClave.Text);
                var usuario = UsuarioCln.validar(txtUsuario.Text.Trim(), clave);
                if (usuario != null)
                {
                    Utils.usuario = usuario;
                    Utils.empleado = EmpleadoCln.get(usuario.idEmpleado);

                    txtClave.Text = string.Empty;
                    Visible = false;
                    new FrmPrincipal(this).ShowDialog();
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "::: Mensaje - Minerva :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool validar()
        {
            bool valido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text)) { erpUsuario.SetError(txtUsuario, "Introduzca un usuario"); valido = false; }
            if (string.IsNullOrEmpty(txtClave.Text)) { erpClave.SetError(txtClave, "Introduzca una contraseña"); valido = false; }
            return valido;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnAceptar.PerformClick();
        }
    }
}
