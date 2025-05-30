using System.ComponentModel.DataAnnotations;

namespace AutoService.Models
{
    public class ServiceRecord
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required, StringLength(100)]
        public string Description { get; set; } = string.Empty;

        [Range(0, double.MaxValue)]
        public decimal Cost { get; set; }

        // FKs
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public int MechanicId { get; set; }
        public Mechanic Mechanic { get; set; } = null!;
    }
}
