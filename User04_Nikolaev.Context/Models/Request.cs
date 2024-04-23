using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User04_Nikolaev.Context.Models
{

    /// <summary>
    /// Сущность Заявок
    /// </summary>
    public class Request
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? CompletionDate { get; set; } = null;

        [Required]
        public string ResentDefect { get; set; }

        public string Zapchasty { get; set; }


        public int EquipmentTypeId { get; set; } = 1;
        public EquipmentType EquipmentType { get; set; }

        [Required]
        public string ModelEquipment { get; set; }

        public int ClientId { get; set; }
        public User Client { get; set; }

        public int StatusId { get; set; } = 1;
        public Status Status { get; set; }

        public int? WorkerId { get; set; }
        public User Worker { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
