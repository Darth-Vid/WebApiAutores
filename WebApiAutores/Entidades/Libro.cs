using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [StringLength(maximumLength:250)]
        [Required]
        public string Nombre { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public List<Comentario> contenido { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
