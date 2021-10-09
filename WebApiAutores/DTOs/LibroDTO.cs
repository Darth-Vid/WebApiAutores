using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutores.DTOs
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        //public List<ComentarioDTO> contenido { get; set; }
    }
}
