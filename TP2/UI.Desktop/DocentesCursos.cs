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
    public partial class DocentesCursos : AplicationForm
    {
        public DocentesCursos(Usuario usr)
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
            DocenteCursoLogic DCL = new DocenteCursoLogic();
            this.dgvDocenteCurso.DataSource = DCL.GetAll();
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("docentescursos", this.UsuarioActual.ID);
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
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));
            if (DR == DialogResult.Yes) this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop DCD = new DocenteCursoDesktop(AplicationForm.ModoForm.Alta);
            DCD.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteCurso.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop DCD = new DocenteCursoDesktop(ID, AplicationForm.ModoForm.Modificacion);
                DCD.ShowDialog();
                this.Listar();
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvDocenteCurso.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocenteCurso.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop DCD = new DocenteCursoDesktop(ID, AplicationForm.ModoForm.Baja);
                DCD.ShowDialog();
                this.Listar();
            }
        }
    }
}
