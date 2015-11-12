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
    public partial class ModulosUsuarios : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        ModuloUsuarioLogic _logic;
        private ModuloUsuarioLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new ModuloUsuarioLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            UsuarioLogic ul = new UsuarioLogic();
            this.IDUsuarioddl.DataSource = ul.GetAll();
            this.IDUsuarioddl.DataBind();
            ModuloLogic cl = new ModuloLogic();
            this.IDModuloddl.DataSource = cl.GetAll();
            this.IDModuloddl.DataBind();
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

        private ModuloUsuario _Entity;

        private ModuloUsuario Entity
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
            this.IDModuloddl.Text = this.Entity.IDModulo.ToString();
            this.IDUsuarioddl.Text = this.Entity.IDUsuario.ToString();
            this.permiteAltaChkBox.Checked = Convert.ToBoolean(this.Entity.PermiteAlta.ToString());
            this.permiteBajaChkBox.Checked = Convert.ToBoolean(this.Entity.PermiteBaja.ToString());
            this.permiteModificacionChkBox.Checked = Convert.ToBoolean(this.Entity.PermiteModificacion.ToString());
            this.permiteConsultaChkBox.Checked = Convert.ToBoolean(this.Entity.PermiteConsulta.ToString());

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadEntity(ModuloUsuario modu)
        {
            modu.IDModulo = Convert.ToInt32(this.IDModuloddl.Text);
            modu.IDUsuario = Convert.ToInt32(this.IDUsuarioddl.Text);
            modu.PermiteAlta = this.permiteAltaChkBox.Checked;
            modu.PermiteBaja = this.permiteBajaChkBox.Checked;
            modu.PermiteConsulta = this.permiteConsultaChkBox.Checked;
            modu.PermiteModificacion = this.permiteModificacionChkBox.Checked;
        }

        private void SaveEntity(ModuloUsuario modu)
        {
            this.Logic.Save(modu);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new ModuloUsuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new ModuloUsuario();
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
            this.IDUsuarioddl.Enabled = enable;
            this.IDModuloddl.Enabled = enable;
            this.permiteConsultaChkBox.Enabled = enable;
            this.permiteBajaChkBox.Enabled = enable;
            this.permiteModificacionChkBox.Enabled = enable;
            this.permiteAltaChkBox.Enabled = enable;
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
            this.permiteAltaChkBox.Checked = false;
            this.permiteBajaChkBox.Checked = false;
            this.permiteModificacionChkBox.Checked = false;
            this.permiteConsultaChkBox.Checked = false;

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