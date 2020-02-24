using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiJugadores.Models
{
    public class Jugador
    {
        private string nombreJugador { get; set; }
        private int valoracion { get; set; }
        private string pais{get; set;}
        private int dorsal { get; set; }
    }
}