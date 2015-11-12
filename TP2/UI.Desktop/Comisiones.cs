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
    public partial class Comisiones : Form
    {
        public Comisiones(Usuario usr)
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
            ComisionLogic CL = new ComisionLogic();
            List<Comision> l = CL.GetAll();
            this.dvgComisiones.DataSource = l;
        }

        private void Comisiones_Load(object sender, EventArgs e)
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
                md = mul.GetOneByUsuario("comisiones", this.UsuarioActual.ID);
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
            ComisionDesktop CD = new ComisionDesktop(AplicationForm.ModoForm.Alta);
            CD.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dvgComisiones.SelectedRows.Count != 0)
            {
                int ID = ((Comision)this.dvgComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop CD = new ComisionDesktop(ID, AplicationForm.ModoForm.Modificacion);
                CD.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dvgComisiones.SelectedRows.Count != 0)
            {
                int ID = ((Comision)this.dvgComisiones.SelectedRows[0].DataBoundItem).ID;
                ComisionDesktop CD = new ComisionDesktop(ID, AplicationForm.ModoForm.Baja);
                CD.ShowDialog();
                this.Listar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close();
        }

    }
}
