using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//importo
using System.Data;
using System.Data.SqlClient;
using waHotelMontaña.Dao;
using waHotelMontaña.Entidades;


namespace waHotelMontaña
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            DaoUsuario dao = new DaoUsuario();

            usu.nombreUsu = txtNombreUsu.Text;
            usu.contraUsu = txtContraUsu.Text;

            DataTable dt = new DataTable();
            dt = dao.IniciarSesion(usu);

            if (dt.Rows.Count == 0)
            {
                lblRespuesta.Text = "Usuario o contraseña incorrecta.";
                txtNombreUsu.Text = "";
                txtContraUsu.Text = "";
                txtNombreUsu.Focus();
            }
            else
            {
                Session["sesionusuario"] = txtNombreUsu.Text.Trim();
                Response.Redirect("Default");
            }


        }
    }
}