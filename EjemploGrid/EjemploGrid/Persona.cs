using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploGrid
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Salario { get; set; }
    }
}