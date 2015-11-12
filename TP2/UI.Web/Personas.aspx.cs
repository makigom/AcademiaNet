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
    public partial class Personas : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        PersonasLogic _logic;
        private PersonasLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new PersonasLogic();
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

        private Persona _Entity;

        private Persona Entity
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
            this.nombreTextBox.Text = this.Entity.Nombre.ToString();
            this.apellidoTextBox.Text = this.Entity.Apellido.ToString();
            this.direccionTextBox.Text = this.Entity.Direccion.ToString();
            this.fechaNacTextBox.Text = this.Entity.FechaNacimiento.ToString(); // no mete bien la fecha
            this.emailTextBox.Text = this.Entity.Email.ToString();
            this.tipoPersonaddl.DataValueField = this.Entity.TiposPersona.ToString();
            this.legajoTextBox.Text = this.Entity.Legajo.ToString();
            this.telefonoTextBox.Text = this.Entity.Telefono.ToString();
            this.idPlanddl.Text = this.Entity.IDPlan.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(Persona per)
        {
            per.Nombre = this.nombreTextBox.Text;
            per.Apellido = this.apellidoTextBox.Text;
            per.Direccion = this.direccionTextBox.Text;
            per.FechaNacimiento = Convert.ToDateTime(this.fechaNacTextBox.Text);
            per.Email = this.emailTextBox.Text;
            per.Telefono = this.telefonoTextBox.Text;
            per.Legajo = Convert.ToInt32(this.legajoTextBox.Text);
            per.TiposPersona = this.tipoPersonaddl.Text;
            per.IDPlan = Convert.ToInt32(this.idPlanddl.Text);
        }

        private void SaveEntity(Persona per)
        {
            this.Logic.Save(per);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Persona();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Persona();
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
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.direccionTextBox.Enabled = enable;
            this.fechaNacTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.tipoPersonaddl.Enabled = enable;
            this.legajoTextBox.Enabled = enable;
            this.telefonoTextBox.Enabled = enable;
            this.idPlanddl.Enabled = enable;
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
            this.nombreTextBox.Text = string.Empty; ;
            this.apellidoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.fechaNacTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.legajoTextBox.Text = string.Empty;
            this.telefonoTextBox.Text = string.Empty;
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