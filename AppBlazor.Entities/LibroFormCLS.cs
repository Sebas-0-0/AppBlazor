using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class LibroFormCLS
    {
        [Required(ErrorMessage = "El ID del libro es requerido")]
        [Range(0,int.MaxValue,ErrorMessage ="El id debe ser un numero positivo")]
        public int idLibro { get; set; }
        [Required (ErrorMessage = "El Titulo es Requerido")]
        [MaxLength (100, ErrorMessage ="La longitud maxima del titulo es de  100 caracteres")]
        public string titulo { get; set; } = null!;
        [Required (ErrorMessage = "El Resumen es Requerido")]
        [MinLength(20, ErrorMessage = "La longitud minima del resumen es de 20 caracteres")]
        public string resumen { get; set; } = null!;
        [Range(1, int.MaxValue, ErrorMessage = "Deve Seleccionar Un Tipo De Libro")]
        public int IdTipoLibro { get; set; }
    }
}
