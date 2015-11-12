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
    public partial class Modulos :  Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            ModuloLogic ML = new ModuloLogic();
            List<Business.Entities.Modulo> l = ML.GetAll();
        }

        private void Modulo_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloDesktop MD = new ModuloDesktop(AplicationForm.ModoForm.Alta);
            MD.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
                ModuloDesktop UD = new ModuloDesktop(ID, AplicationForm.ModoForm.Modificacion);
                UD.ShowDialog();
                this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
                ModuloDesktop MD = new ModuloDesktop(ID, AplicationForm.ModoForm.Baja);
                MD.ShowDialog();
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
