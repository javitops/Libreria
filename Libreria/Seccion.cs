using System;
using System.Collections.Generic;

namespace Libreria
{
    public partial class Seccion
    {
        public Seccion()
        {
            Libro = new HashSet<Libro>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
