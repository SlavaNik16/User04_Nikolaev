using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User04_Nikolaev.Context.Models
{
    /// <summary>
    /// Сущность Статуса
    /// </summary>
    public class Status
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public ICollection<Request> Requests { get; set; }
    }
}
