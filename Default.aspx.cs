using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waHotelMontaña
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string nomusuario = Session["sesionusuario"] as string;
                if (nomusuario != null)
                {
                    lblUsuario.Text = "Usuario: " + nomusuario.ToUpper();
                }
                else
                {
                    lblUsuario.Text = "Usuario no autenticado";
                }
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login");
        }
    }
}