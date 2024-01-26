using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAplicacion.Servicios.Models;
using WebAplicacion.Servicios.Utiles;

namespace WebAplicacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAutenticar_Click(object sender, EventArgs e)
        {
            servicioAutenticar oservicioAutenticar = new sevicioAutenticar();
            usuarioLogin ousuarioLogin = oservicioAutenticar.RecuperaToken(txtUsuario.Text.ToString(), txtPassword.Text.ToString());
            lblToken.Text = ousuarioLogin.token;

            if (ousuarioLogin.token != null)
            {
                Session.Add("ousuarioLogin", ousuarioLogin);
                Response.Redirect("./wfRol.aspx");
            }
        }
    }
}