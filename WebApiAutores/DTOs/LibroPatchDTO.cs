using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAutores.DTOs
{
    public class LibroPatchDTO
    {

        [StringLength(maximumLength: 250)]
        [Required]
        public string Nombre { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
