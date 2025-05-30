using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string LicensePlate { get; set; } = string.Empty;

        [Required, StringLength(17, MinimumLength = 11)]
        public string VIN { get; set; } = string.Empty;

        [Required]
        public string Make { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Range(1900, 2100)]
        public int Year { get; set; }

        // Navigation
        public List<ServiceRecord> ServiceRecords { get; set; } = new();
    }
}
