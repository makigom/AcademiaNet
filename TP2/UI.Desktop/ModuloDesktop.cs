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
    public partial class ModuloDesktop : AplicationForm
    {
        public ModuloDesktop()
        {
            InitializeComponent();
        }

        private Modulo _ModuloActual;

        public Modulo ModuloActual
        
            {
            get { return _ModuloActual; }

            set { _ModuloActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.ModuloActual.ID.ToString();        
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;           
            this.txtEjecuta.Text = this.ModuloActual.Ejecuta;      

            switch (Modo)
                {
                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ModuloActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.ModuloActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.ModuloActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.ModuloActual.State = BusinessEntity.States.Unmodified;
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
                Modulo m = new Modulo();

                ModuloActual = m;
                 
                this.txtDescripcion.Text = this.ModuloActual.Descripcion;           
                this.txtEjecuta.Text = this.ModuloActual.Ejecuta;  
                 
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.ModuloActual.ID = Convert.ToInt32(this.txtID.Text);            
                this.ModuloActual.Descripcion = this.txtDescripcion.Text;
                this.ModuloActual.Ejecuta = this.txtEjecuta.Text;                 
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            ModuloLogic ML = new ModuloLogic();
            ML.Save(ModuloActual);
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
            MessageBox.Show(mensaje,titulo, botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }

        public ModuloDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public ModuloDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            ModuloLogic ML = new ModuloLogic();
            ModuloActual = ML.GetOne(ID);
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
    }
}
