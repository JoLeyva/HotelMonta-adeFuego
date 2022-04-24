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
    public class DaoTarjeta
    {
        public SqlConnection cone = Conexion.getConnection();

        DataSet ds = new DataSet();

        public DataSet listarTarjeta()
        {
            SqlDataAdapter da = new SqlDataAdapter("select t.idTarjeta as #,CONCAT(c.nombreCli,' ',c.apellidoCli) as Cliente,t.nroTarjeta,t.vencimientoTarjeta from tarjeta t inner join cliente c  on t.idCliente = c.idCliente;",cone);
            da.Fill(ds);
            return ds;
        }

        public string agregar(Tarjeta t)
        {
            string rpta = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Tarjeta(idCliente,nroTarjeta,vencimientoTarjeta,codigoSeguridad)  values(@code,@nroTarj,@fechaVen,@codSeg)";
                cmd.Parameters.AddWithValue("@code", t.idCliente);
                cmd.Parameters.AddWithValue("@nroTarj",t.nroTarjeta);
                cmd.Parameters.AddWithValue("@fechaVen", t.vencimientoTarjeta);
                cmd.Parameters.AddWithValue("@codSeg", t.codigoSeguridad);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone;
                cone.Open();
                cmd.ExecuteNonQuery();
                cone.Close();
                cmd.Dispose();

                rpta = "Tarjeta guardado existosamente.";
            }
            catch (Exception ex)
            {
                rpta = "Error al guardar: " + ex.Message;
            }

            return rpta;
        }

        public int eliminar(int code)
        {
            int rpta = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Tarjeta where idTarjeta=@code";
                cmd.Parameters.AddWithValue("@code", code);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone;
                cone.Open();
                rpta= cmd.ExecuteNonQuery();
                cone.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                
            }
            return rpta;
        }


        public Tarjeta BuscarPorId(int id)
        {
            Tarjeta obj = null;
            string sql = "select idTarjeta,idCliente,nroTarjeta,vencimientoTarjeta,codigoSeguridad " +
                " from tarjeta where idTarjeta = @code";

            SqlCommand cmd = new SqlCommand(sql, cone);
            cmd.Parameters.AddWithValue("@code", id);
            cone.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                obj = new Tarjeta();
                obj.idTarjeta = dr.GetInt32(0);
                obj.idCliente = dr.GetInt32(1);
                obj.nroTarjeta = dr.GetString(2);
                obj.vencimientoTarjeta = dr.GetDateTime(3);
                obj.codigoSeguridad = dr.GetString(4);
            }
            cone.Close();

            return obj;
        }
        public int editar(Tarjeta t)
        {
            int rpta = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Tarjeta set idCliente=@code, nroTarjeta=@nroTarj," +
                    " vencimientoTarjeta=@fechaVen,codigoSeguridad=@codSeg" +
                    " where idTarjeta=@codTarj";
                cmd.Parameters.AddWithValue("@code", t.idCliente);
                cmd.Parameters.AddWithValue("@nroTarj", t.nroTarjeta);
                cmd.Parameters.AddWithValue("@fechaVen", t.vencimientoTarjeta);
                cmd.Parameters.AddWithValue("@codSeg", t.codigoSeguridad);
                cmd.Parameters.AddWithValue("@codTarj", t.idTarjeta);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cone;
                cone.Open();
                rpta = cmd.ExecuteNonQuery();
                cone.Close();
                cmd.Dispose();


            }
            catch (Exception ex)
            {
            }

            return rpta;
        }
        public DataSet consultarxnombre(string nom)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tarjeta t inner join Cliente c on t.idCliente=c.idCliente where c.nombreCli like '%' + RTRIM(@nom) + '%' ;", cone);
            da.SelectCommand.Parameters.AddWithValue("@nom", nom);
            da.Fill(ds);
            return ds;
        }
        public DataSet consultarxapellido(string ape)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tarjeta t inner join Cliente c on t.idCliente=c.idCliente where c.apellidoCli like '%' + RTRIM(@ape) + '%' ;", cone);
            da.SelectCommand.Parameters.AddWithValue("@ape", ape);
            da.Fill(ds);
            return ds;
        }
    }
}