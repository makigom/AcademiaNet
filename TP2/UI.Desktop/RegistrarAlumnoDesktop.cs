using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
    public partial class RegistrarAlumnoDesktop : AplicationForm
    {
        public RegistrarAlumnoDesktop()
        {
            InitializeComponent();
            CursoLogic cl = new CursoLogic();
            this.cbIDCurso.DataSource = cl.GetAll();
            this.cbIDCurso.DisplayMember = "id_materia";
            this.cbIDCurso.ValueMember = "id_curso";
        }

        private AlumnoInscripciones _AluInscActual;
        public AlumnoInscripciones AluInscActual
        {
            get { return _AluInscActual; }
            set { _AluInscActual = value; }
        }

        public override void MapearADatos()
        {
            this.AluInscActual.IDAlumno = Convert.ToInt32(this.mtbIDAlumno.Text);
            this.AluInscActual.IDCurso = ((Curso)this.cbIDCurso.SelectedValue).ID;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic AIL = new AlumnoInscripcionLogic();
            AIL.InsertRegistroAlumno(AluInscActual);          
        }

        public override bool Validar()
        {
            string mensaje = "";
            bool ok = true;

            foreach (Control c in this.Controls)
            {
                if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
            }

            if (!(mtbIDAlumno.MaskFull))
            {
                mensaje = "ID Alumno vacio \n" + mensaje;
                ok = false;
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
            MessageBox.Show(titulo, mensaje, botones, icono);
        }

        public new void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar() == true) //falta validar que vea que si ya se encuentra registrado
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

        private void mtbIDAlumno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           // ttIDAlumno.ToolTipTitle = "Tipo de dato invalido";              //preg a mai como se agrega esto
           // ttIDAlumno.Show("El campo admite solo digitos",mtbIDAlumno);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Siempre se deben ingresar 5 numeros, de lo contrario tira error. Buscar como hacer que se complete con ceros
            int id = int.Parse(this.mtbIDAlumno.Text);
            PersonasLogic PL = new PersonasLogic();
            Persona p;
            p = PL.GetOne(id);

            DialogResult DR;

            if (p.ID == id)
            {
                DR = (MessageBox.Show("ID encontrado", "Busqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None));
                this.btnAceptar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                DR = (MessageBox.Show("ID no existe,por favor vuelva a ingresarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));
                this.btnAceptar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
    }
}
