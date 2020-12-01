using System;
using System.Collections.Generic;

namespace Libreria
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Escritor { get; set; }
        public string Editorial { get; set; }
        public string FechaCreacion { get; set; }
        public int IdSeccion { get; set; }

        public virtual Seccion IdSeccionNavigation { get; set; }
    }
}
