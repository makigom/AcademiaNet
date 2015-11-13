using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class RegistrarAlumnos : BasePage
    {
        protected override void OnLoad(EventArgs e)
        {
            this.usuarioIngresado();

            if (Session["rol_usuario"].ToString().Equals("Alumno") || Session["rol_usuario"].ToString().Equals("Administrador")) base.OnLoad(e);
            else Response.Redirect("/Home.aspx");
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Alta;
                this.ClearForm();
                this.EnableForm(true);
                this.Entity = new AlumnoInscripciones();
                this.LoadForm();            
                this.LoadEntity(this.Entity);
            }
        }

        AlumnoInscripcionLogic _logic;
        private AlumnoInscripcionLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new AlumnoInscripcionLogic();
                return _logic;
            }
        }

        protected int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private AlumnoInscripciones _Entity;

        private AlumnoInscripciones Entity
        {
            get { return _Entity; }
            set { _Entity = value; }
        }


        private void LoadForm()
        {
            CursoLogic cl = new CursoLogic();
            this.idCursoddl.DataSource = cl.GetAll();
            this.idCursoddl.DataBind();
            this.idAlumnoTextBox.Text = this.Entity.IDAlumno.ToString();
            this.idCursoddl.Text = this.Entity.IDCurso.ToString();
            
        }


        private void LoadEntity(AlumnoInscripciones aluins)
        {
            aluins.IDAlumno = Convert.ToInt32(this.idAlumnoTextBox.Text);
            aluins.IDCurso = Convert.ToInt32(this.idCursoddl.Text);
        }

        private void SaveEntity(AlumnoInscripciones aluins)
        {
            this.Logic.Save(aluins);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            this.SaveEntity(this.Entity);
            this.formPanel.Visible = false;
        }

        private void EnableForm(bool enable)
        {
            this.idCursoddl.Enabled = enable;
            this.idAlumnoTextBox.Enabled = enable;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            this.idAlumnoTextBox.Text = string.Empty;
        }

       
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");

        }
    }
}