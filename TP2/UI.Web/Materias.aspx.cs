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
    public partial class Materias : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new MateriaLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            PlanLogic pl = new PlanLogic();
            this.idPlanddl.DataSource = pl.GetAll();
            this.idPlanddl.DataBind();
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

        private Materia _Entity;

        private Materia Entity
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
            this.hsTotalesTextBox.Text = this.Entity.HsTotales.ToString();
            this.hsSemanalesTextBox.Text = this.Entity.HsSemanales.ToString();
            this.descripcionTextBox.Text = this.Entity.Descripcion.ToString();
            this.idPlanddl.Text = this.Entity.IDPlan.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(Materia mat)
        {
            mat.HsTotales = Convert.ToInt32(this.hsTotalesTextBox.Text);
            mat.HsSemanales = Convert.ToInt32(this.hsSemanalesTextBox.Text);
            mat.Descripcion = this.descripcionTextBox.Text;
            mat.IDPlan = Convert.ToInt32(this.idPlanddl.Text);
        }

        private void SaveEntity(Materia mat)
        {
            this.Logic.Save(mat);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Materia();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Materia();
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
            this.hsSemanalesTextBox.Enabled = enable;
            this.hsTotalesTextBox.Enabled = enable;
            this.idPlanddl.Enabled = enable;
            this.descripcionTextBox.Enabled = enable;
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
            this.hsSemanalesTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;
            this.hsTotalesTextBox.Text = string.Empty;

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