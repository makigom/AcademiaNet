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
    public partial class Materias : AplicationForm
    {
        public Materias(Usuario usr)
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
            MateriaLogic ML = new MateriaLogic();
            this.dgvMateria.AutoGenerateColumns = true;
            this.dgvMateria.DataSource = ML.GetAll();            
        }

        private void Materias_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("materias", this.UsuarioActual.ID);
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
            MateriaDesktop md = new MateriaDesktop(AplicationForm.ModoForm.Alta);
            md.Text = "Alta materia";
            md.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMateria.SelectedRows.Count != 0)
            {
                int ID = ((Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop MD = new MateriaDesktop(ID, AplicationForm.ModoForm.Modificacion);
                MD.Text = "Editar materia";
                MD.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvMateria.SelectedRows.Count != 0)
            {
                int ID = ((Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop MD = new MateriaDesktop(ID, AplicationForm.ModoForm.Baja);
                MD.Text = "Eliminar materia";
                MD.ShowDialog();
                this.Listar();
            }
        }
        
    }
}
