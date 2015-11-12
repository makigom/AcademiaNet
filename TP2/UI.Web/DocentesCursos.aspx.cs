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
    public partial class DocentesCursos : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new DocenteCursoLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            PersonasLogic pl = new PersonasLogic();
            this.idDocenteddl.DataSource = pl.GetDocentes();
            this.idDocenteddl.DataBind();
            CursoLogic cl = new CursoLogic();
            this.idCursoddl.DataSource = cl.GetAll();
            this.idCursoddl.DataBind();
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

        private DocenteCurso _Entity;

        private DocenteCurso Entity
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
            this.idDocenteddl.Text = this.Entity.IDDocente.ToString();
            this.idCursoddl.Text = this.Entity.IDCurso.ToString();
            this.tipoCargoddl.Text = this.Entity.TipoCargo.ToString();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(DocenteCurso dc)
        {
            dc.IDDocente = Convert.ToInt32(this.idDocenteddl.Text);
            dc.IDCurso = Convert.ToInt32(this.idCursoddl.Text);
            dc.TipoCargo = this.tipoCargoddl.Text;
        }

        private void SaveEntity(DocenteCurso dc)
        {
            this.Logic.Save(dc);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new DocenteCurso();
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
            this.idCursoddl.Enabled = enable;
            this.idDocenteddl.Enabled = enable;
            this.tipoCargoddl.Enabled = enable;
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