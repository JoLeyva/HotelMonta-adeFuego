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
    public partial class Editar : System.Web.UI.Page
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

                CargarDatos();
            }
        }

        public void CargarDatos()
        {
            if (Session["codeTarjeta"] != null)
            {
                int code = (int)Session["codeTarjeta"];
                Tarjeta t = daoTarjeta.BuscarPorId(code);

                txtCodigoSeguridad.Text = t.codigoSeguridad;
                txtFechaVenc.Text = t.vencimientoTarjeta.ToString("yyyy-MM-dd");
                txtNumeroTarjeta.Text = t.nroTarjeta.ToString();
                cbCliente.SelectedValue = t.idCliente.ToString();
            }
            else
            {
                Response.Redirect("../../ListadoTarjeta.aspx");
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Tarjeta t = new Tarjeta();
            t.idTarjeta = (int)Session["codeTarjeta"]; ;
            t.nroTarjeta = txtNumeroTarjeta.Text;
            t.vencimientoTarjeta = DateTime.Parse(txtFechaVenc.Text);
            t.codigoSeguridad = txtCodigoSeguridad.Text;
            t.idCliente = int.Parse(cbCliente.SelectedValue.ToString());

            int rpta = daoTarjeta.editar(t);

            if (rpta > 0)
            {
                Response.Redirect("../../ListadoTarjeta.aspx");
            }
            else
            {
                lblReporte.Text = "Error al editar datos...";
            }
            
        }
    }
}