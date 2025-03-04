using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorPeliculas.MVVM.Models
{
    public partial class Film
    {
        public string Nombre { get; set; } = string.Empty;
        public Uri? Portada { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public long Id { get; set; }
        public long Year { get; set; }
    }
}
