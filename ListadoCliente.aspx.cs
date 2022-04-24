using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//importar
using System.Data;
using waHotelMontaña.Dao;

namespace waHotelMontaña
{
    public partial class ListadoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = new DataSet();
                DaoCliente dao= new DaoCliente();
                ds= dao.ListarClientes();
                gvTablaCliente.DataSource=ds;
                gvTablaCliente.DataBind();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DaoCliente dao = new DaoCliente();
            ds = dao.consultarxnom(txtConsulta.Text);
            ds = dao.consultarxape(txtConsulta.Text);
            gvTablaCliente.DataSource = ds;
            gvTablaCliente.DataBind();
        }

        protected void btnRestablecer_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DaoCliente dao = new DaoCliente();
            ds = dao.ListarClientes();
            gvTablaCliente.DataSource = ds;
            gvTablaCliente.DataBind();
        }
    }
}