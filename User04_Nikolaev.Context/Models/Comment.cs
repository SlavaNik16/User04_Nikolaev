using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User04_Nikolaev.Context.Models
{
    /// <summary>
    /// Класс комментарий
    /// </summary>
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public int WorkerId { get; set; }
        public User Worker { get; set; }

        public int RequestId { get; set; }
        public Request Request { get; set; }

    }
}
