using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ComisionDesktop : AplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();

            PlanLogic PL = new PlanLogic();
            this.cbIDPlan.DataSource = PL.GetAll();
            this.cbIDPlan.DisplayMember = "descripcion";
            this.cbIDPlan.ValueMember = "id_plan";
        }

        private Comision _ComisionActual;

        public Comision ComisionActual
        
            {
            get { return _ComisionActual; }

            set { _ComisionActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.ComisionActual.ID.ToString();          
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;            
            this.mtbAnioEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();           
            this.cbIDPlan.Text = this.ComisionActual.IDPlan.ToString();            
            
            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ComisionActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ComisionActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                            this.btnAceptar.Text = "Eliminar";
                            this.ComisionActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.ComisionActual.State = BusinessEntity.States.Unmodified;
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
                Comision C = new Comision();                
                
                ComisionActual = C;
                 
                this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32(this.mtbAnioEspecialidad.Text);
                this.ComisionActual.IDPlan = ((Plan)this.cbIDPlan.SelectedValue).ID;
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.ComisionActual.ID = Convert.ToInt32(this.txtID.Text);            
                this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                this.ComisionActual.AnioEspecialidad = Convert.ToInt32(this.mtbAnioEspecialidad.Text);
                this.ComisionActual.IDPlan = ((Plan)this.cbIDPlan.SelectedValue).ID;
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            ComisionLogic CL = new ComisionLogic();
            CL.Save(ComisionActual);
            }

        public override bool Validar()
        {
            string mensaje = "";
            bool ok = true;

            foreach (Control c in this.Controls)
            {
                if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
            }

            if (!mtbAnioEspecialidad.MaskFull)
            {
                mensaje = "Año especialidad esta vacio.\n" + mensaje;
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

        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo,mensaje, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }

        public ComisionDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public ComisionDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            
            ComisionLogic CL = new ComisionLogic();

            ComisionActual = CL.GetOne(ID);
            
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
            DialogResult DR = (MessageBox.Show("Seguro que desea cancelar el proceso?", "Cancelar", MessageBoxButtons.YesNo));

            if (DR == DialogResult.Yes) this.Close(); 
        }

        private void mtbAnioEspecialidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttAnioEspecialidad.ToolTipTitle = "Tipo de dato invalido";
            ttAnioEspecialidad.Show("El campo admite solo digitos", mtbAnioEspecialidad);
        }
    }
}
