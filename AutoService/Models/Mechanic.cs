using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Mechanic
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Phone { get; set; }

        // Navigation
        public List<ServiceRecord> ServiceRecords { get; set; } = new();
    }
}
