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
    public partial class Index : System.Web.UI.Page
    {
        private Usuario _UsuarioActual;
        private Persona _PersonaActual;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Valido nombre de Usuario y Contrasenia
            if (this.validarUsuario())
            {
                Session["nombre_usuario"] = _UsuarioActual.NombreUsuario;
                Session["id_usuario"] = _UsuarioActual.ID;
                Session["rol_usuario"] = _PersonaActual.TiposPersona;
                Page.Response.Redirect("/Home.aspx");
            }
            else
            {
                Page.Response.Write("Usuario y/o contrasenia incorrecto");
            }
        }

        protected void lnkRecordarClave_Click(object sendeer, EventArgs e)
        {
            //Redirecciono a otra pagina que deberia existir y para mostrar el mensaje tener dicho elemento
            Response.Redirect("~/Default.aspx?msj=Es ud. un usuario muy descuidado");
        }

        private Boolean validarUsuario() 
        {
            UsuarioLogic user = new UsuarioLogic();
            try
            {
                _UsuarioActual = user.GetUsuarioForLogin(txtUsuario.Text, txtClave.Text);
                if (_UsuarioActual.ID != 0)
                {
                    PersonasLogic pl = new PersonasLogic();
                    _PersonaActual = pl.GetOne(_UsuarioActual.IDPersona);

                    return true;
          
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}