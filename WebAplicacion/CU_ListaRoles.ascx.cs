using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAplicacion.Servicios;
using WebAplicacion.Servicios.Models;

namespace WebAplicacion
{
    public partial class CU_ListaRoles : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CargarGrid();
            }
        }
        void CargarGrid()
        {
            ServicioRol oservicioRol = new ServicioRol();
            rgvListaRoles.DataSource =
        oservicioRol.GetList(((usuarioLogin)Session["ousuarioLogin"]).token);
            rgvListaRoles.DataBind();
        }
    }
}