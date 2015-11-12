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
    public partial class Usuarios : Form
        {
        public Usuarios(Usuario usr)
            {
            InitializeComponent();
            this._UsuarioActual = usr;
            }

        public void Listar()
            {
            UsuarioLogic UL = new UsuarioLogic();
            this.dgvUsuarios.AutoGenerateColumns = true;
            List<Usuario> l = UL.GetAll();
            this.dgvUsuarios.DataSource = l;
            }

        private Usuario _UsuarioActual;

        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            permisos();
        }

        private void permisos()
        {
            bool alta = false;
            bool baja = false;
            bool modificacion = false;
            bool consulta = false;
            try
            {
                ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
                ModuloUsuario md = new ModuloUsuario();
                md = mul.GetOneByUsuario("usuarios", this.UsuarioActual.ID);
                alta = md.PermiteAlta;
                baja = md.PermiteBaja;
                modificacion = md.PermiteModificacion;
                consulta = md.PermiteConsulta;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (alta)
            {
                this.tsbNuevo.Visible = true;
            }
            if (baja)
            {
                this.tsbEliminar.Visible = true;
            }
            if (modificacion)
            {
                this.tsbEditar.Visible = true;
            }
            if (consulta)
            {
                Listar();
            }
        }

        private void btnSalir_Click( object sender, EventArgs e )
            {    
            
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();        

            }

        private void tsbNuevo_Click( object sender, EventArgs e )
            {
            UsuarioDesktop UD = new UsuarioDesktop(AplicationForm.ModoForm.Alta);
            UD.Text = "Alta usuario";
            UD.ShowDialog();
            this.Listar();
            }

        private void tsbEditar_Click( object sender, EventArgs e )
            {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
                {
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;

                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Modificacion);
                UD.Text = "Editar usuario";
                UD.ShowDialog();
                this.Listar();
                }
  
            }

        private void tsbEliminar_Click( object sender, EventArgs e )
            {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
                {
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop UD = new UsuarioDesktop(ID, AplicationForm.ModoForm.Baja);
                UD.Text = "Eliminar usuario";
                UD.ShowDialog();
                this.Listar();
                }
            }
        }
    }
