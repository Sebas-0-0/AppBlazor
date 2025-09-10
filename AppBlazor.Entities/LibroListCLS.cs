using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazor.Entities
{
    public class LibroListCLS
    {

        public int idLibro { get; set; }
        public string titulo { get; set; }= null!;

        public string NombreTipoLibro { get; set; } = string.Empty;
        public string imagen { get; set; } = "/img/default.png";
    }
}
