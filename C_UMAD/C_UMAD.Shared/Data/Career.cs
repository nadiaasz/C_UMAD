using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C_UMAD.Shared.Data
{
    public class Career
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Acrónimo")]
        public string? Acronym { get; set; }

        [JsonIgnore]
        public ICollection<Student>? Students { get; set; }
    }
}
