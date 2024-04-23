using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User04_Nikolaev.Context.Models
{

    /// <summary>
    /// Класс тип оборудования
    /// </summary>
    public class EquipmentType
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<Request> Requests { get; set; }  
    }
}
