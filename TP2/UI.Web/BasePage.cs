using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Web
{
    public class BasePage : System.Web.UI.Page
    {

         public enum FormModes { Alta, Baja, Modificacion }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        public void usuarioIngresado()
        {
            if (Session["rol_usuario"] == null) { Response.Redirect("/Index.aspx"); }
        }
 

        
    }
}