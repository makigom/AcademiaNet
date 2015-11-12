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
    public partial class ModulosUsuarios : Form
    {
        public ModulosUsuarios(Usuario usr)
        {
            InitializeComponent();
            this._UsuarioActual = usr;
        }

        private Usuario _UsuarioActual;

        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
        }
         
        public void Listar()
        {
            ModuloUsuarioLogic MUL = new ModuloUsuarioLogic();
            this.dgvModuloUsuario.DataSource = MUL.GetAll();
        }


        private void ModuloUsuario_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("modulosusuarios", this.UsuarioActual.ID);
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(AplicationForm.ModoForm.Alta);
            MUD.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvModuloUsuario.SelectedRows.Count != 0)
            {
                int ID = ((ModuloUsuario)this.dgvModuloUsuario.SelectedRows[0].DataBoundItem).ID;
                ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(ID, AplicationForm.ModoForm.Modificacion);
                MUD.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvModuloUsuario.SelectedRows.Count != 0)
            {
                int ID = ((ModuloUsuario)this.dgvModuloUsuario.SelectedRows[0].DataBoundItem).ID;
                ModuloUsuarioDesktop MUD = new ModuloUsuarioDesktop(ID, AplicationForm.ModoForm.Baja);
                MUD.ShowDialog();
                this.Listar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();
        }
    }
}

    
