using System;
using System.Collections.Generic;
using System.Text;

namespace InterfazGraficaWinForm
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
