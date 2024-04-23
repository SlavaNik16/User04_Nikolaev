using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace User04_Nikolaev.Context.Models
{
    /// <summary>
    /// Сущность Ролей
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public ICollection<User> Users { get; set; }    
    }
}