using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//importo
using System.Data;
using waHotelMontaña.Dao;

namespace waHotelMontaña
{
    public partial class ListadoTarjeta : System.Web.UI.Page
    {
        private DaoTarjeta dao = new DaoTarjeta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar();
            }
        }

        public void Listar()
        {
            DataSet ds = new DataSet();
            ds = dao.listarTarjeta();
            gvTablaTarjeta.DataSource = ds;
            gvTablaTarjeta.DataBind();
        }


        protected void gvTablaTarjeta_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvTablaTarjeta.Rows[e.NewSelectedIndex];
            string texto = row.Cells[0].Text;
            string texto1 = row.Cells[1].Text;
            string texto2 = row.Cells[2].Text;

            if (row.Cells[0].Text == "Editar")
            {
                e.Cancel = true;
             
            }

            if (row.Cells[1].Text == "Eliminar")
            {
                e.Cancel = true;

            }

        }

        protected void gvTablaTarjeta_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            gvTablaTarjeta.SelectedIndex = Convert.ToInt32(e.CommandArgument);
            switch (e.CommandName.ToUpper())
            {
                case "ELIMINAR":
                    {
                        int code = int.Parse(gvTablaTarjeta.SelectedRow.Cells[2].Text);
                        int res = dao.eliminar(code);

                        if (res > 0)
                        {
                            Listar();
                        }
                        break;
                    }
                case "EDITAR":
                    {
                        int code = int.Parse(gvTablaTarjeta.SelectedRow.Cells[2].Text);
                        Session["codeTarjeta"] = code;
                        Response.Redirect("Vista/Tarjetas/Editar.aspx");
                        break;
                    }
            }
        }

        
protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DaoCliente dao = new DaoCliente();
            ds = dao.consultarxnom(txtConsulta.Text);
            ds = dao.consultarxape(txtConsulta.Text);
            gvTablaTarjeta.DataSource = ds;
            gvTablaTarjeta.DataBind();
        }

        protected void btnRestablecer_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DaoTarjeta dao = new DaoTarjeta();
            ds = dao.listarTarjeta();
            gvTablaTarjeta.DataSource = ds;
            gvTablaTarjeta.DataBind();
        }
        }
    }
