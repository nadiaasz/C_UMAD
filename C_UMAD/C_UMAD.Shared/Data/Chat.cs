using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C_UMAD.Shared.Data
{
    public class Chat: IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha creación")]
        public DateTime Date { get; set; }
        public ChatType? ChatType { get; set; }

        [JsonIgnore]
        public ICollection<ChatMember>? ChatMembers { get; set; }

        [JsonIgnore]
        public ICollection<Message>? Messages { get; set; }
    }
}
