using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.App.DTO
{
    public class Procurement
    {
        public int Id { get; set; }
        [MaxLength(256)]
        [MinLength(1)]
        [Required]
        public string Name { get; set; }
        public ICollection<ProcurementObject> ProcurementObjects { get; set; }
    }
}