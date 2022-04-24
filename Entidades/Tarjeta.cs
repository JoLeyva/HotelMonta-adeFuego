using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waHotelMontaña.Entidades
{
    public class Tarjeta
    {
        public int idTarjeta { get; set; }
        public int idCliente { get; set; }
        public string nroTarjeta { get; set; }
        public DateTime vencimientoTarjeta  { get; set; }
        public string codigoSeguridad { get; set; }

        public Tarjeta()
        {
        }

        public Tarjeta(int idTarjeta, int idCliente, string nroTarjeta, DateTime vencimientoTarjeta, string codigoSeguridad)
        {
            this.idTarjeta = idTarjeta;
            this.idCliente = idCliente;
            this.nroTarjeta = nroTarjeta;
            this.vencimientoTarjeta = vencimientoTarjeta;
            this.codigoSeguridad = codigoSeguridad;
        }
    }
}