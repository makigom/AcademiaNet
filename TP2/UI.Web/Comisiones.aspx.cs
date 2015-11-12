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
    public partial class Comisiones : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        ComisionLogic _logic;
        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new ComisionLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            PlanLogic pl = new PlanLogic();
            this.descPlanddl.DataSource = pl.GetAll();
            this.descPlanddl.DataBind();
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

        private Comision _Entity;

        private Comision Entity
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
            this.descPlanddl.Text = this.Entity.IDPlan.ToString();
            this.anioEspecialidadTextBox.Text = this.Entity.AnioEspecialidad.ToString();
            this.descripcionTextBox.Text = this.Entity.Descripcion.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(Comision com)
        {

            com.AnioEspecialidad = Convert.ToInt32(this.anioEspecialidadTextBox.Text);
            com.Descripcion = this.descripcionTextBox.Text;
            com.IDPlan = Convert.ToInt32(this.descPlanddl.Text);

        }

        private void SaveEntity(Comision com)
        {
            this.Logic.Save(com);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Comision();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Comision();
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
            this.descPlanddl.Enabled = enable;
            this.descripcionTextBox.Enabled = enable;
            this.anioEspecialidadTextBox.Enabled = enable;
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
            this.anioEspecialidadTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;
            
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