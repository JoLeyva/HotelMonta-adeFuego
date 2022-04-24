using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//importo
using waHotelMontaña.Dao;
using waHotelMontaña.Entidades;

namespace waHotelMontaña
{
    public partial class nuevoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            DaoCliente dao = new DaoCliente();

            cli.nombreCli=txtNombreCli.Text;
            cli.apellidoCli=txtApellidoCli.Text;
            cli.telefonoCli=txtTelefonoCli.Text;
            cli.correoCli=txtCorreoCli.Text;
            cli.dniCli=txtDniCli.Text;

            string rpta = dao.agregarCliente(cli);
            lblReporte.Text = rpta;
            Response.Redirect("ListadoCliente");
        }
    }
}