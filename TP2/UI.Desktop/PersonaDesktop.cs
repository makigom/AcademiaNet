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
    public partial class PersonaDesktop : AplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();

            PlanLogic PL = new PlanLogic();
            this.cbIDPlan.DataSource = PL.GetAll();
            this.cbIDPlan.DisplayMember = "descripcion"; 
            this.cbIDPlan.ValueMember = "id_plan";

            this.cbTipoPersona.Items.Add("Docente");
            this.cbTipoPersona.Items.Add("No docente");
            this.cbTipoPersona.Items.Add("Alumno");
          
        }
        private Persona _PersonaActual;

        public Persona PersonaActual
            {
            get { return _PersonaActual; }

            set { _PersonaActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.PersonaActual.ID.ToString();        
            this.txtApellido.Text = this.PersonaActual.Apellido;           
            this.txtNombre.Text = this.PersonaActual.Nombre;           
            this.txtDireccion.Text = this.PersonaActual.Direccion;      
            this.txtEmail.Text = this.PersonaActual.Email;            
            this.mtbLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.mtbTelefono.Text = this.PersonaActual.Telefono;
            this.cbTipoPersona.Text = this.PersonaActual.TiposPersona.ToString();
            this.cbIDPlan.Text = this.PersonaActual.IDPlan.ToString();
            this.mtbFechaNacimiento.Text = this.PersonaActual.FechaNacimiento.ToString();

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.PersonaActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.PersonaActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.PersonaActual.State = BusinessEntity.States.Unmodified;
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
                    Persona per = new Persona();
                    PersonaActual = per;

                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Legajo = Convert.ToInt32(mtbLegajo.Text);
                    this.PersonaActual.IDPlan = ((Plan)cbIDPlan.SelectedValue).ID; 
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Telefono = this.mtbTelefono.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.TiposPersona = this.cbTipoPersona.Text;
                    this.PersonaActual.FechaNacimiento = Convert.ToDateTime(this.mtbFechaNacimiento.Text);
                }
                    
                else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.PersonaActual.ID = Convert.ToInt32(this.txtID.Text);
                    this.PersonaActual.Direccion = this.txtDireccion.Text;
                    this.PersonaActual.Nombre = this.txtNombre.Text;
                    this.PersonaActual.Apellido = this.txtApellido.Text;
                    this.PersonaActual.Legajo = Convert.ToInt32(mtbLegajo.Text);
                    this.PersonaActual.IDPlan = ((Plan)cbIDPlan.SelectedValue).ID;
                    this.PersonaActual.Telefono = this.mtbTelefono.Text;
                    this.PersonaActual.Email = this.txtEmail.Text;
                    this.PersonaActual.TiposPersona = this.cbTipoPersona.Text;
                    this.PersonaActual.FechaNacimiento = Convert.ToDateTime(this.mtbFechaNacimiento.Text);
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            PersonasLogic PL = new PersonasLogic();
            PL.Save(PersonaActual);
            }

         public override bool Validar()
         {
             string mensaje = "";
             bool ok = true;

              foreach(Control c in this.Controls)
              {
                  if ((c is TextBox || c is ComboBox) && (c.Tag.ToString() != "ID") && (!Util.Util.IsComplete(c.Text))) mensaje += " - " + c.Tag.ToString() + "\n";
              }

            if (!(mtbFechaNacimiento.MaskFull || mtbTelefono.MaskFull || mtbLegajo.MaskFull))
            {
              mensaje = "Fecha de nacimiento y/o Telefono y/o Legajo estan vacios.\n" + mensaje;
              ok=false;
            }

          mtbFechaNacimiento.ValidatingType = typeof(System.DateTime);
          mtbFechaNacimiento.TypeValidationCompleted += new TypeValidationEventHandler(mtbFechaNacimiento_TypeValidationCompleted);
          mtbFechaNacimiento.KeyDown += new KeyEventHandler(mtbFechaNacimiento_KeyDown);

          if (!string.IsNullOrEmpty(mensaje))
          {
              mensaje = "Por favor complete los siguientes campos:\n" + mensaje;
              ok = false;
          }
          
          if ((!string.IsNullOrWhiteSpace(this.txtEmail.Text)) && (!Util.Util.IsValidEmail(this.txtEmail.Text)))
          {
              mensaje += "El email ingresado no es válido.\n";
              ok = false;
          }

          if (this.chkUsuario.Checked)
          {
              Usuario user = new Usuario();
              user.ID = _PersonaActual.ID;
              Usuarios u = new Usuarios(user);
              u.ShowDialog();
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

        public PersonaDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public PersonaDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            PersonasLogic PL = new PersonasLogic();
            PersonaActual = PL.GetOne(ID);
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

        private void mtbFechaNacimiento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttFechaNacimiento.ToolTipTitle = "Dato invalido";
                ttFechaNacimiento.Show("Ingrese la fecha en formato un formato valido (DD/MM/AAAA)", mtbFechaNacimiento);
            }

        }
        private void mtbFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            ttFechaNacimiento.Hide(mtbFechaNacimiento);
        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttTelefono.ToolTipTitle = "Tipo de dato no valido";
            ttTelefono.Show("El campo admite solo digitos de longitud máxima 6", mtbTelefono);
        }

        private void mtbLegajo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttLegajo.ToolTipTitle = "Tipo de dato no valido";
            ttLegajo.Show("El campo admite solo digitos de longitud máxima 6", mtbLegajo);
        }
    }
}
