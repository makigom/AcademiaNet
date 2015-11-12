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
    public partial class PlanDesktop : AplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
            
            EspecialidadLogic EL = new EspecialidadLogic();
            this.cbIDEspecialidad.DataSource = EL.GetAll();
            this.cbIDEspecialidad.DisplayMember = "descripcion"; 
            this.cbIDEspecialidad.ValueMember = "id_especialidad";
        }

        private Plan _PlanActual;

        public Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;
            this.cbIDEspecialidad.Text = this.PlanActual.IDEspecialidad.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        this.PlanActual.State = BusinessEntity.States.New;
                    }
                    break;
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        this.PlanActual.State = BusinessEntity.States.Modified;
                    }
                    break;
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        this.PlanActual.State = BusinessEntity.States.Deleted;
                    }
                    break;

                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        this.PlanActual.State = BusinessEntity.States.Unmodified;
                    }
                    break;

                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == AplicationForm.ModoForm.Alta)
            {   
                Plan p = new Plan();
                PlanActual = p;

                this.PlanActual.IDEspecialidad = ((Especialidad)cbIDEspecialidad.SelectedValue).ID;
                this.PlanActual.Descripcion = this.txtDescripcion.Text;
            }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
            {
                this.PlanActual.ID = Convert.ToInt32(this.txtID.Text);
                this.PlanActual.Descripcion = this.txtDescripcion.Text;
                this.PlanActual.IDEspecialidad = ((Especialidad)cbIDEspecialidad.SelectedValue).ID;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic PL = new PlanLogic();
            PL.Save(PlanActual);
        }

        public override bool Validar()
        {
            string mensaje = "";
            bool ok = true;

            foreach (Control c in this.Controls)
            {
                if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
                ok = false;
            }

            if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ok;
        }

        public new void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(titulo,mensaje, botones, icono);
        }

        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }


        public PlanDesktop(ModoForm modo): this()
        {
            this.Modo = modo;
        }

        public PlanDesktop(int ID, ModoForm modo): this()
        {
            this.Modo = modo;
            PlanLogic PL = new PlanLogic();
            PlanActual = PL.GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (DR == DialogResult.Yes) this.Close();
        }

    }
}