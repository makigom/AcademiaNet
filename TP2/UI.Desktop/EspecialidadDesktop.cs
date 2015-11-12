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
    public partial class EspecialidadDesktop : AplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

       private Especialidad _EspecialidadActual;

       public Especialidad EspecialidadActual      
            {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
            }

        public override void MapearDeDatos()
            {
            
            this.txtID.Text = this.EspecialidadActual.ID.ToString();            
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
            
            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.EspecialidadActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.EspecialidadActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {                    
                        this.btnAceptar.Text = "Eliminar";
                        this.EspecialidadActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.EspecialidadActual.State = BusinessEntity.States.Unmodified;
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
                Especialidad esp = new Especialidad();               
                EspecialidadActual = esp;                
                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                               
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.EspecialidadActual.ID = Convert.ToInt32(this.txtID.Text);                
                this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;

                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            EspecialidadLogic EL = new EspecialidadLogic();            
            EL.Save(EspecialidadActual);
            }

        public override bool Validar()
            { 
            string mensaje = "";
            bool ok = true;

            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
            }
            if (!string.IsNullOrEmpty(mensaje))
            {
                mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
                ok = false;
            }

            if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ok;

            }


        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo,mensaje, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }


        public EspecialidadDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public EspecialidadDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            EspecialidadLogic EL = new EspecialidadLogic();
            EspecialidadActual = EL.GetOne(ID);
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
