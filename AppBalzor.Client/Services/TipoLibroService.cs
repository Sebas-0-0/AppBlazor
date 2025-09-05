using AppBlazor.Entities;

namespace AppBalzor.Client.Services
{
    public class TipoLibroService
    {
        private List<TipoLibroCLS> lista;
        public TipoLibroService()
        {
            lista = new List<TipoLibroCLS>();
            lista.Add(new TipoLibroCLS { IdTipoLibro = 1, NombreTipoLibro = "Cuento" });
            lista.Add(new TipoLibroCLS { IdTipoLibro = 2, NombreTipoLibro = "Novela" });
        }
        public List<TipoLibroCLS> listarTipoLibros()
        {
            return lista;
        }
        public int obtenerIdTipoLibro(string nombretipolibro)
        {
            var obj = lista.Where(p => p.NombreTipoLibro == nombretipolibro).FirstOrDefault();
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.IdTipoLibro;
            }
        }
        public string obtenerNombreTipoLibro(int idtipolibro)
        {
            var obj = lista.Where(p => p.IdTipoLibro == idtipolibro).FirstOrDefault();
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.NombreTipoLibro;
            }
        }
    }
}
