using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Usuario _UsuarioActual;
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic user = new UsuarioLogic();
            try
            {
                _UsuarioActual = user.GetUsuarioForLogin(txtUsuario.Text, txtPass.Text);
                if (_UsuarioActual.ID != 0)
                {
                    if (_UsuarioActual.Habilitado) this.DialogResult = DialogResult.OK;
                    else MessageBox.Show("El usuario no está habilitado", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario o contrasenia incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPass.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
