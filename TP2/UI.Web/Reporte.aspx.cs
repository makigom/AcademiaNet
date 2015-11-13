using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Reporte : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            this.usuarioIngresado();

            if (Session["rol_usuario"] == "Administrador" || Session["rol_usuario"] == "No Docente")
            {
                base.OnLoad(e);
            }
            else Response.Redirect("/Home.aspx");
        }
    }
}