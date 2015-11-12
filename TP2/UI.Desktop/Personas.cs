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
    public partial class Personas : AplicationForm
    {
        public Personas(Usuario usr)
        {
            InitializeComponent();
            this._UsuarioActual = usr;
        }

        private Usuario _UsuarioActual;
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
        }

        private void Personas_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("personas", this.UsuarioActual.ID);
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

        public void Listar()
        {
            PersonasLogic PL = new PersonasLogic();
            this.dgvPersona.AutoGenerateColumns = true;
            List<Persona> personas = PL.GetAll();
            this.dgvPersona.DataSource = personas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PersonaDesktop PD = new PersonaDesktop(AplicationForm.ModoForm.Alta);
            PD.Text = "Alta persona";
            PD.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count != 0)
            {

                int ID = ((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
                PersonaDesktop PD = new PersonaDesktop(ID, AplicationForm.ModoForm.Modificacion);
                PD.Text = "Editar persona";
                PD.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPersona.SelectedRows.Count != 0)
            {
                int ID = ((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
                PersonaDesktop PD = new PersonaDesktop(ID, AplicationForm.ModoForm.Baja);
                PD.Text = "Eliminar persona";
                PD.ShowDialog();
                this.Listar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DR == DialogResult.Yes) this.Close();
        }
    }
}
   