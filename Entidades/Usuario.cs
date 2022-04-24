using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waHotelMontaña.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsu { get; set; }
        public string contraUsu { get; set; }
        public int idEmpleado { get; set; }

        public Usuario()
        {
        }

        public Usuario(int idUsuario, string nombreUsu, string contraUsu, int idEmpleado)
        {
            this.idUsuario = idUsuario;
            this.nombreUsu = nombreUsu;
            this.contraUsu = contraUsu;
            this.idEmpleado = idEmpleado;
        }



    }
}