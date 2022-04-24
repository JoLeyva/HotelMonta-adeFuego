using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//importo
using System.Data;
using System.Data.SqlClient;
using waHotelMontaña.Entidades;


namespace waHotelMontaña.Dao
{
    public class DaoCliente
    {
        public SqlConnection cone = Conexion.getConnection();
        DataSet ds =new DataSet();

        //Listar
        public DataSet ListarClientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("select idCliente as #,nombreCli as Nombres,apellidoCli as Apellidos,telefonoCli as Telefono,correoCli as 'e-mail',dniCli as DNI from Cliente;", cone);
            da.Fill(ds);
            return ds;
        }

        public DataTable ListarClientesOrd()
        {
            SqlDataAdapter da = new SqlDataAdapter("select idCliente , apellidoCli+' '+nombreCli as nomComp from Cliente order by apellidoCli asc, nombreCli asc", cone);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string agregarCliente(Cliente cli)
        {
            string rpta=null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into cliente values(@nomCli,@apeCli,@telCli,@correoCli,@dniCli)";
                cmd.Parameters.AddWithValue("@nomCli", cli.nombreCli);
                cmd.Parameters.AddWithValue("@apeCli", cli.apellidoCli);
                cmd.Parameters.AddWithValue("@telCli", cli.telefonoCli);
                cmd.Parameters.AddWithValue("@correoCli", cli.correoCli);
                cmd.Parameters.AddWithValue("@dniCli", cli.dniCli);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone;
                cone.Open();
                cmd.ExecuteNonQuery();
                cone.Close();
                cmd.Dispose();

                rpta = "Cliente guardado existosamente.";
            }
            catch(Exception ex)
            {
                rpta = "Error al guardar: "+ex.Message;
            }

            return rpta;
        }
        public DataSet consultarxnom(string nom)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cliente where nombreCli like '%' + RTRIM(@nom) + '%'", cone);
            da.SelectCommand.Parameters.AddWithValue("@nom", nom);
            da.Fill(ds);
            return ds;
        }
        public DataSet consultarxape(string ape)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Cliente where apellidoCli like '%' + RTRIM(@ape) + '%';", cone);
            da.SelectCommand.Parameters.AddWithValue("@ape", ape);
            da.Fill(ds);
            return ds;
        }
    }
}