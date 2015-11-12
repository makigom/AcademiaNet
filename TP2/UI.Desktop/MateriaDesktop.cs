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
    public partial class MateriaDesktop : AplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();

            PlanLogic PL = new PlanLogic();
            this.cbIDPlan.DataSource = PL.GetAll();
            this.cbIDPlan.DisplayMember = "descripcion";
            this.cbIDPlan.ValueMember = "id_plan";
        }

        private Materia _MateriaActual;

        public Materia MateriaActual    
            {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.MateriaActual.ID.ToString();        
            this.cbIDPlan.Text = this.MateriaActual.IDPlan.ToString();           
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;           
            this.txtHorasSemanales.Text = this.MateriaActual.HsSemanales.ToString();      
            this.txtHorasTotales.Text = this.MateriaActual.HsTotales.ToString();       

            switch (Modo)
                {
                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.MateriaActual.State = BusinessEntity.States.New;
                        
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.MateriaActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.MateriaActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.MateriaActual.State = BusinessEntity.States.Unmodified;
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
                Materia mat = new Materia();                
                MateriaActual = mat;
                 
                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                this.MateriaActual.IDPlan = ((Plan)this.cbIDPlan.SelectedValue).ID;                
                this.MateriaActual.HsSemanales = Convert.ToInt32(this.txtHorasSemanales.Text);                
                this.MateriaActual.HsTotales = Convert.ToInt32(this.txtHorasTotales.Text);           
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.MateriaActual.ID = Convert.ToInt32(this.txtID.Text);                
                this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                this.MateriaActual.IDPlan = ((Plan)this.cbIDPlan.SelectedValue).ID;
                this.MateriaActual.HsSemanales = Convert.ToInt32(this.txtHorasSemanales.Text);                
                this.MateriaActual.HsTotales = Convert.ToInt32(this.txtHorasTotales.Text);  
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            MateriaLogic ML = new MateriaLogic();
            ML.Save(MateriaActual);
            }

      public override bool Validar()
      {
          string mensaje = "";
          bool ok = true;

          foreach(Control c in this.Controls)
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
        //Agregandole new a los metodos void damos por sabido que el miembro que modificamos oculta el miembro que se hereda de la clase base.
        
        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo,mensaje, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }

        public MateriaDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public MateriaDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            MateriaLogic ML = new MateriaLogic();
            MateriaActual = ML.GetOne(ID);
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
