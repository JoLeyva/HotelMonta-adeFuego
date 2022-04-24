using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waHotelMontaña.Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombreCli { get; set; }
        public string apellidoCli { get; set; }
        public string telefonoCli { get; set; }
        public string correoCli { get; set; }
        public string dniCli { get; set; }

        public Cliente()
        {
        }

        public Cliente(int idCliente, string nombreCli, string apellidoCli, string telefonoCli, string correoCli, string dniCli)
        {
            this.idCliente = idCliente;
            this.nombreCli = nombreCli;
            this.apellidoCli = apellidoCli;
            this.telefonoCli = telefonoCli;
            this.correoCli = correoCli;
            this.dniCli = dniCli;
        }
    }
}