using AppBlazor.Entities;

namespace AppBalzor.Client.Services
{
    public class LibroService
    {
        private List<LibroListCLS> lista;
        private TipoLibroService tipoLibroService;
        public LibroService(TipoLibroService _tipoLibroService)
        {
            tipoLibroService = _tipoLibroService;
            lista = new List<LibroListCLS>();
            lista.Add(new LibroListCLS { idLibro = 1, titulo = "Caperucita Roja", NombreTipoLibro = "Cuento" });
            lista.Add(new LibroListCLS { idLibro = 2, titulo = "Libro 2", NombreTipoLibro = "Novela" });
        }
        public List<LibroListCLS> listarLibros()
        {
            return lista;
        }
        public void eliminarLibro(int idLibro)
        {
            var listaQueda = lista.Where(p => p.idLibro != idLibro).ToList();
            lista = listaQueda;
        }
        public LibroFormCLS RecuperarLibroPorId (int idLibro)
        {
            var obj = lista.Where(p => p.idLibro == idLibro).FirstOrDefault();
            if (obj != null)
            {
                return new LibroFormCLS { idLibro = obj.idLibro, titulo = obj.titulo, resumen = "Rsumen",
                    IdTipoLibro = tipoLibroService.obtenerIdTipoLibro(obj.NombreTipoLibro)};
            }
            else
            {
                return new LibroFormCLS();
            }
        }
        public void guardarLibro(LibroFormCLS oLibroFormCLS)
        {
            int idLibro = lista.Select(p => p.idLibro).Max() + 1;
            lista.Add(new LibroListCLS { idLibro = idLibro, titulo = oLibroFormCLS.titulo,
            NombreTipoLibro=tipoLibroService.obtenerNombreTipoLibro(oLibroFormCLS.IdTipoLibro) });
        }
    }
}
