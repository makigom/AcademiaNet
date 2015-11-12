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
    public partial class DocenteCursoDesktop : AplicationForm
    {
        public DocenteCursoDesktop()
            {
            InitializeComponent();

            CursoLogic CL = new CursoLogic();
            this.cbIDCurso.DataSource = CL.GetAll(); // no funciona, preguntarle al profesor antes de entregar
            this.cbIDCurso.DisplayMember = Convert.ToString("id_curso");// el displaymember no esta tomando ningun valor
            this.cbIDCurso.ValueMember = "id_curso";
         
            this.cbTipoCargo.Items.Add("Auxiliar");
            this.cbTipoCargo.Items.Add("Titular");
            this.cbTipoCargo.Items.Add("Ayudante");
            }

        private DocenteCurso _DocenteCursoActual;

        public DocenteCurso DocenteCursoActual
        
            {
                get { return _DocenteCursoActual; }

                set { _DocenteCursoActual = value; }
            }

        public override void MapearDeDatos()
            {
            this.txtIDDictado.Text = this.DocenteCursoActual.ID.ToString();
            this.mtbIDDocente.Text = this.DocenteCursoActual.IDDocente.ToString();
            this.cbIDCurso.Text = this.DocenteCursoActual.IDCurso.ToString();
            this.cbTipoCargo.Text = this.DocenteCursoActual.TipoCargo.ToString();

            switch (Modo)
                {

                case ModoForm.Alta:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.DocenteCursoActual.State = BusinessEntity.States.New;
                        }
                    break;

                case ModoForm.Modificacion:
                        {
                        this.btnAceptar.Text = "Guardar";
                        this.DocenteCursoActual.State = BusinessEntity.States.Modified;                        
                        }
                    break;

                case ModoForm.Baja:
                        {
                        this.btnAceptar.Text = "Eliminar";
                        this.DocenteCursoActual.State = BusinessEntity.States.Deleted;
                        } 
                    break;

                case ModoForm.Consulta:
                        {
                        this.btnAceptar.Text = "Aceptar";
                        this.DocenteCursoActual.State = BusinessEntity.States.Unmodified;
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
                DocenteCurso dca = new DocenteCurso();
                DocenteCursoActual = dca;

                this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.mtbIDDocente.Text);
                this.DocenteCursoActual.IDCurso = ((Curso)this.cbIDCurso.SelectedValue).ID;
                this.DocenteCursoActual.TipoCargo = ((Persona)this.cbTipoCargo.SelectedValue).TiposPersona;                
                }
            else if (Modo == AplicationForm.ModoForm.Modificacion)
                {
                    this.DocenteCursoActual.ID = Convert.ToInt32(this.txtIDDictado.Text);
                    this.DocenteCursoActual.IDDocente = Convert.ToInt32(this.mtbIDDocente.Text);
                    this.DocenteCursoActual.IDCurso = ((Curso)this.cbIDCurso.SelectedValue).ID;
                    this.DocenteCursoActual.TipoCargo = ((Persona)this.cbTipoCargo.SelectedValue).TiposPersona; 
                }
            }

        public override void GuardarCambios() 
            {
            MapearADatos();
            DocenteCursoLogic DCL = new DocenteCursoLogic();
            DCL.Save(DocenteCursoActual);
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

                if (!mtbIDDocente.MaskFull)
                {
                    mensaje = "IDDocente esta vacio.\n" + mensaje;
                    ok = false;
                }

                if (!string.IsNullOrEmpty(mensaje)) Notificar(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ok;
            }

        public new  void Notificar(string titulo,string mensaje,MessageBoxButtons botones,MessageBoxIcon icono)
            {
            MessageBox.Show(titulo, mensaje,botones, icono);
            }

        public new void Notificar( string mensaje, MessageBoxButtons botones, MessageBoxIcon icono )
            {
            this.Notificar(this.Text, mensaje, botones, icono);
            }


        public DocenteCursoDesktop(ModoForm modo):this()
            {
            this.Modo = modo;   
            }

        public DocenteCursoDesktop(int ID, ModoForm modo): this()
            {
            this.Modo = modo;
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DocenteCursoActual = dcl.GetOne(ID);
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

        private void mtbCupo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttIDDocente.ToolTipTitle = "Tipo de dato invalido";
            ttIDDocente.Show("El campo admite solo digitos", mtbIDDocente);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Siempre se deben ingresar 5 numeros, de lo contrario tira error. Buscar como hacer que se complete con ceros
            int id = int.Parse(this.mtbIDDocente.Text);
            PersonasLogic PL = new PersonasLogic();
            Persona p;
            p = PL.GetOne(id);

            DialogResult DR;

            if (p.ID == id)
            {
                DR = (MessageBox.Show("ID encontrado", "Busqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.None));

                this.cbIDCurso.Enabled = true;
                this.cbTipoCargo.Enabled = true;
                this.btnAceptar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                DR = (MessageBox.Show("ID no existe,por favor vuelva a ingresarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error));

                this.cbIDCurso.Enabled = false;
                this.cbTipoCargo.Enabled = false;
                this.btnAceptar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
    }
}
