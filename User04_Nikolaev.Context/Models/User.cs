
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User04_Nikolaev.Context.Models
{
    /// <summary>
    /// Сущность Пользователя
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<Request> RequestWorkers { get; set; }

        [ForeignKey("ClientId")]
        public ICollection<Request> RequestClients { get; set; }

        [ForeignKey("WorkerId")]
        public ICollection<Comment> Comments { get; set; }
    }
}
