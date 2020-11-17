using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackAppPWC.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        [Required]

        public string titulo { get; set; }
        [Required]

        public string creador { get; set; }
        [Required]

        public string texto { get; set; }
        [Required]

        public DateTime fechaCreacion { get; set; }


    }
}
