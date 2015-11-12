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
    public partial class Usuarios : BasePage
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null) _logic = new UsuarioLogic();
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
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
   
        private Usuario _Entity;

        private Usuario Entity
        {
            get { return _Entity; }
            set { _Entity = value;}
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
            this.idPersonaTextBox.Text = this.Entity.IDPersona.ToString();
            this.habilitadoCheckBox.Text = this.Entity.Habilitado.ToString();
            this.usuarioTextBox.Text = this.Entity.NombreUsuario;
        }

        private void LoadEntity(Usuario usu)
        {

            usu.IDPersona = Convert.ToInt32(this.idPersonaTextBox.Text);
            usu.NombreUsuario = this.usuarioTextBox.Text;
            usu.Habilitado = this.habilitadoCheckBox.Checked;
            usu.Clave = this.claveTextBox.Text;
            //falta validar q las contraseñas sean iguales

        }

        private void SaveEntity(Usuario usu)
        {
            this.Logic.Save(usu);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.FormMode) //si repetir clave tiene algo, es porque en modificar quiere cambiar su clave
            {
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    DeleteEntity((int)GridView1.SelectedValue);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
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

        private void EnableForm (bool enable)
        {
            this.idPersonaTextBox.Enabled = enable;
            this.usuarioTextBox.Enabled = enable;
            this.habilitadoCheckBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            //this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            //this.repetirClaveLabel.Visible = enable;
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
            this.idPersonaTextBox.Text = string.Empty;
            this.usuarioTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.claveTextBox.Text = string.Empty;
            this.repetirClaveLabel.Text = string.Empty;
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
                this.LoadForm((int) GridView1.SelectedValue);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }  
        


    }
}