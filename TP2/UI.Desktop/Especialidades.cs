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
    public partial class Especialidades : Form
    {
        public Especialidades(Usuario usr)
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
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidades.AutoGenerateColumns = true;
            List<Especialidad> l = el.GetAll();
            this.dgvEspecialidades.DataSource = l;
        }

        private void Especialidades_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("especialidades", this.UsuarioActual.ID);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DR == DialogResult.Yes) this.Close();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop ed = new EspecialidadDesktop(AplicationForm.ModoForm.Alta);
            ed.Text = "Alta especialidad";
            ed.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop ed = new EspecialidadDesktop(ID, AplicationForm.ModoForm.Modificacion);
                ed.Text = "Editar especialidad";
                ed.ShowDialog();
                this.Listar();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop ed = new EspecialidadDesktop(ID, AplicationForm.ModoForm.Baja);
                ed.Text = "Eliminar especialidad";
                ed.ShowDialog();
                this.Listar();
            }
        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
