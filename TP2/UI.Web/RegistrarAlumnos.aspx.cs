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

            if (Session["rol_usuario"] != "Administrador" || Session["rol_usuario"] != "Alumno") { Response.Redirect("/Home.aspx"); }

            base.OnLoad(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
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

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
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
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new AlumnoInscripciones();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        }

        private void EnableForm(bool enable)
        {
            this.idCursoddl.Enabled = enable;
            this.idAlumnoTextBox.Enabled = enable;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
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