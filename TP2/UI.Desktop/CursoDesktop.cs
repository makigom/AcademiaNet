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
    public partial class CursoDesktop : AplicationForm
    {   
        public CursoDesktop()
            {
            InitializeComponent();

            ComisionLogic CL = new ComisionLogic();
            this.cbIDComision.DataSource = CL.GetAll();
            this.cbIDComision.DisplayMember = "desc_comision";
            this.cbIDComision.ValueMember = "id_comision";

            MateriaLogic ML = new MateriaLogic();
            this.cbIDMateria.DataSource = ML.GetAll();
            this.cbIDMateria.DisplayMember = "desc_materia";
            this.cbIDMateria.ValueMember = "id_materia";
            }

        private Curso _CursoActual;

        public Curso CursoActual
        
            {
            get { return _CursoActual; }

            set { _CursoActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtID.Text = this.CursoActual.ID.ToString();     
            this.cbIDComision.Text = this.CursoActual.IDComision.ToString();           
            this.mtbCupo.Text = this.CursoActual.Cupo.ToString();    
            this.cbIDMateria.Text = this.CursoActual.IDMateria.ToString();
            this.mtbAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.CursoActual.State = BusinessEntity.States.New;
                        }
                    break;
                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.CursoActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;
                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.CursoActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;
                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.CursoActual.State = BusinessEntity.States.Unmodified;
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
                Curso cur = new Curso();             
                CursoActual = cur;

                this.CursoActual.Cupo = Convert.ToInt32(this.mtbCupo.Text);
                this.CursoActual.AnioCalendario = Convert.ToInt32(mtbAnioCalendario.Text);
                this.CursoActual.IDComision = ((Comision)this.cbIDComision.SelectedValue).ID;
                this.CursoActual.IDMateria = ((Materia)this.cbIDMateria.SelectedValue).ID;
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                this.CursoActual.ID = Convert.ToInt32(this.txtID.Text);             
                this.CursoActual.AnioCalendario=Convert.ToInt32(this.mtbAnioCalendario.Text);
                this.CursoActual.Cupo = Convert.ToInt32(this.mtbCupo.Text);
                this.CursoActual.IDComision = ((Comision)this.cbIDComision.SelectedValue).ID;
                this.CursoActual.IDMateria = ((Materia)this.cbIDMateria.SelectedValue).ID;
                }
            }

        public override void GuardarCambios() 
            {

            MapearADatos();
            CursoLogic CL = new CursoLogic();
            CL.Save(CursoActual);

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

                if (!(mtbAnioCalendario.MaskFull || mtbCupo.MaskFull))
                {
                    mensaje = "Año Calendario y/o Cupo estan vacios.\n" + mensaje;
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


        public CursoDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public CursoDesktop(int ID, ModoForm modo):this()
            {
            this.Modo = modo;
            CursoLogic CL = new CursoLogic();
            CursoActual = CL.GetOne(ID);
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

        private void mtbAnioCalendario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttAnioCalendario.ToolTipTitle = "Tipo de dato invalido";
            ttAnioCalendario.Show("El campo admite solo digitos", mtbAnioCalendario);
        }

        private void mtbCupo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttCupo.ToolTipTitle = "Tipo de dato invalido";
            ttCupo.Show("El campo admite solo digitos", mtbCupo);
        }
    }
}
