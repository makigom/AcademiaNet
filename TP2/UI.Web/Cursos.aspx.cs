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
    public partial class Cursos : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        CursoLogic _logic;
        private CursoLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new CursoLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            MateriaLogic ml = new MateriaLogic();
            this.idMateriaddl.DataSource = ml.GetAll();
            this.idMateriaddl.DataBind();
            ComisionLogic cl = new ComisionLogic();
            this.idComisionddl.DataSource = cl.GetAll();
            this.idComisionddl.DataBind();
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

        private Curso _Entity;

        private Curso Entity
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
            this.anioCalendarioTextBox.Text = this.Entity.AnioCalendario.ToString();
            this.idMateriaddl.Text = this.Entity.IDMateria.ToString();
            this.cupoTextBox.Text = this.Entity.Cupo.ToString();
            this.idComisionddl.Text = this.Entity.IDComision.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(Curso cur)
        {
            cur.AnioCalendario = Convert.ToInt32(this.anioCalendarioTextBox.Text);
            cur.IDMateria = Convert.ToInt32(this.idMateriaddl.Text);
            cur.Cupo = Convert.ToInt32(this.cupoTextBox.Text);
            cur.IDComision = Convert.ToInt32(this.idComisionddl.Text);
        }

        private void SaveEntity(Curso cur)
        {
            this.Logic.Save(cur);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Curso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Curso();
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
            this.anioCalendarioTextBox.Enabled = enable;
            this.idMateriaddl.Enabled = enable;
            this.cupoTextBox.Enabled = enable;
            this.idComisionddl.Enabled = enable;
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
            this.anioCalendarioTextBox.Text = string.Empty;
           // this.idMateriaddl.Text = string.Empty;
            this.cupoTextBox.Text = string.Empty;
            //this.idComisionddl.Text = string.Empty;

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