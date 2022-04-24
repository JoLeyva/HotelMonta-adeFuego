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
    public class DaoUsuario
    {
        public SqlConnection cone = Conexion.getConnection();
        public DataTable IniciarSesion(Usuario usu)
        {
            SqlDataAdapter da = new SqlDataAdapter("select nombreUsu, contraUsu from usuario where nombreUsu=@nomusu and contraUsu=@conusu",cone);

            da.SelectCommand.Parameters.AddWithValue("@nomusu",usu.nombreUsu);
            da.SelectCommand.Parameters.AddWithValue("@conusu",usu.contraUsu);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}