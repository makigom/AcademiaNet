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
    public partial class AlumnosInscripciones : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
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

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView1.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.idAlumnoTextBox.Text = this.Entity.IDAlumno.ToString();
            this.idCursoTextBox.Text = this.Entity.IDCurso.ToString();
            this.notaTextBox.Text = this.Entity.Nota.ToString();
            this.condicionddl.Text = this.Entity.Condicion;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(AlumnoInscripciones aluIns)
        {

            aluIns.IDAlumno = Convert.ToInt32(this.idAlumnoTextBox.Text);
            aluIns.IDCurso = Convert.ToInt32(this.idCursoTextBox.Text);
            if (!string.IsNullOrEmpty(notaTextBox.Text)) aluIns.Nota = Convert.ToInt32(this.notaTextBox.Text);
            aluIns.Condicion = this.condicionddl.Text;
           
        }

        private void SaveEntity(AlumnoInscripciones aluIns)
        {
            this.Logic.Save(aluIns);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new AlumnoInscripciones();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new AlumnoInscripciones();
                    this.Entity.ID = (int)GridView1.SelectedValue;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        }

        private void EnableForm(bool enable)
        {
            this.idAlumnoTextBox.Enabled = enable;
            this.idCursoTextBox.Enabled = enable;
            this.notaTextBox.Enabled = enable;
            this.condicionddl.Visible = enable;
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
            this.idCursoTextBox.Text = string.Empty;
            this.notaTextBox.Text = string.Empty;
            //this.condicionTextBox.Text = string.Empty;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex >= 0)
            {
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm((int)GridView1.SelectedValue);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            if (GridView1.SelectedIndex >= 0)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(true);
                this.LoadForm((int)GridView1.SelectedValue);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
            
        }

    }
}