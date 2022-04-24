using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using waHotelMontaña.Dao;
using waHotelMontaña.Entidades;

namespace waHotelMontaña.Vista.Tarjetas
{
    public partial class Nuevo : System.Web.UI.Page
    {
        private DaoCliente daoCli = new DaoCliente();
        private DaoTarjeta daoTarjeta = new DaoTarjeta();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cbCliente.DataSource = daoCli.ListarClientesOrd();
                cbCliente.DataTextField = "nomComp";
                cbCliente.DataValueField = "idCliente";
                cbCliente.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Tarjeta t = new Tarjeta();
            t.nroTarjeta = txtNumeroTarjeta.Text;
            t.vencimientoTarjeta = DateTime.Parse(txtFechaVenc.Text);
            t.codigoSeguridad = txtCodigoSeguridad.Text;
            t.idCliente = int.Parse(cbCliente.SelectedValue.ToString());

            string rpta = daoTarjeta.agregar(t);
            lblReporte.Text = rpta;
            Response.Redirect("../../ListadoTarjeta.aspx");
        }
    }
}